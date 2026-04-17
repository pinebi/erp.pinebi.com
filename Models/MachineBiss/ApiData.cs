using MACHINEBISS_Web.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.MachineBiss
{
    public class Sonuc
    {
        public bool Basarili { get; set; }
        public Dictionary<string, object> Bilgi { get; set; } = new Dictionary<string, object>();
        public Sonuc(bool basarili)
        {
            Basarili = basarili;
        }

        public Sonuc()
        {
            Basarili = true;
        }

        public Sonuc Ekle(string bilgi, object aciklama)
        {
            this.Bilgi.Add(bilgi, aciklama);
            return this;
        }
    }

    public class ApiData
    {
        // TODO: SistemAyarlari now requires DI (FirmaContext, NetworkContext, IConfiguration).
        // ApiData needs to be refactored to accept SistemAyarlari through constructor injection.
        // SistemAyarlari clas = new SistemAyarlari();
        SistemAyarlari clas = null; // Placeholder until DI is wired up

        public Sonuc FaturaKaydet(Faturalar fatura, List<FatIrsSatirlar> satirlar, int seriNoDegisti)
        {

            // TODO: FirmaContext now requires DbContextOptions via DI. Refactor ApiData to accept FirmaContext through constructor injection.
            using (FirmaContext db = null) // new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    fatura.Tutar = satirlar.Sum(s => s.Tutar);
                    fatura.ToplamIndirim = satirlar.Sum(s => s.IskontoTutari);
                    fatura.KdvMatrahi = satirlar.Sum(s => s.KdvMatrahi);
                    fatura.KdvTutari = satirlar.Sum(s => s.KdvTutari);
                    fatura.ToplamTutar = satirlar.Sum(s => s.NetTutar);

                    decimal kur = fatura.DovizKuru ?? 1m;

                    fatura.TLTutar = (satirlar.Sum(s => s.Tutar)) * kur;
                    fatura.TLToplamIndirim = (satirlar.Sum(sa => sa.IskontoTutari)) * kur;
                    fatura.TLKdvMatrahi = (satirlar.Sum(s => s.KdvMatrahi)) * kur;
                    fatura.TLKdvTutari = (satirlar.Sum(s => s.KdvTutari)) * kur;
                    fatura.TLToplamTutar = (satirlar.Sum(s => s.NetTutar)) * kur;
                    fatura.TLOdenecekTutar = fatura.OdenecekTutar * kur;

                db.Faturalar.Add(fatura);
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = fatura.Id;
                        satir.Iptal = false;
                    }

                    db.FatIrsSatirlar.AddRange(satirlar);


                    string fatTipi = string.Empty;
                    if (fatura.TrCode != 1)
                    {
                        if (fatura.FaturaTipi == 0)
                            fatTipi = "KagitFatura";
                        else if (fatura.FaturaTipi == 1)
                            fatTipi = "EFatura";
                        else if (fatura.FaturaTipi == 2)
                            fatTipi = "EArsiv";
                        else if (fatura.FaturaTipi == 4)
                            fatTipi = "Fis";
                        else if (fatura.FaturaTipi == 10)
                            fatTipi = "ProformaFatura";
                        else if (fatura.FaturaTipi == 11)
                            fatTipi = "ProformaFatura";
                    }
                    else if(fatura.TrCode == 1)
                    {
                        fatTipi = "SatinalmaFaturasi";
                    }

                    if (seriNoDegisti == 0)
                    {
                        var eFat = db.Numarator.FirstOrDefault(s => s.Tip == fatTipi);
                        string fatNum = fatura.FisNo.Substring(7, 9);
                        int numara = Convert.ToInt32(fatNum) + 1;
                        eFat.Numara = numara;
                    }

                    if (!string.IsNullOrWhiteSpace(fatura.ProformaNo) && fatura.ProformaNo.Length > 3)
                    {
                        var proFat = db.Faturalar.FirstOrDefault(s => s.FisNo == fatura.ProformaNo);
                        proFat.ProformaNo = fatura.FisNo;
                    }

                db.SaveChanges();
                trans.Commit();
                return new Sonuc().Ekle("Id", fatura.Id).Ekle("FisNo", fatura.FisNo);
            }
                catch (Exception ex)
            {
                trans.Rollback();
                return new Sonuc(false).Ekle("Hata: " + Environment.NewLine, ex.Message);
            }
        }
        }

        public Sonuc FaturaGuncelle(Faturalar fatura, List<FatIrsSatirlar> satirlar)
        {
            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    var s = db.FatIrsSatirlar.Where(x => x.FaturaId == fatura.Id);
                    db.FatIrsSatirlar.RemoveRange(s);
                    db.SaveChanges();

                    var f = db.Faturalar.FirstOrDefault(fa => fa.Id == fatura.Id);
                    f.FisTipi = fatura.FisTipi;
                    f.TrCode = fatura.TrCode;
                    f.FaturaTipi = fatura.FaturaTipi;
                    f.Tarih = fatura.Tarih;
                    f.VadeTarihi = fatura.VadeTarihi;
                    f.TemlikTarihi = fatura.TemlikTarihi;
                    f.OpsiyonTarihi = fatura.OpsiyonTarihi;
                    f.SiparisNo = fatura.SiparisNo;
                    f.SiparisTarihi = fatura.SiparisTarihi;
                    f.FisNo = fatura.FisNo;
                    f.BelgeNo = fatura.BelgeNo;
                    f.OzelKod1 = fatura.OzelKod1;
                    f.Personel = fatura.Personel;
                    f.CariId = fatura.CariId;
                    f.IsyeriNo = fatura.IsyeriNo;
                    f.AmbarNo = fatura.AmbarNo;
                    f.DovizKodu = fatura.DovizKodu;
                    f.Aciklama1 = fatura.Aciklama1;
                    f.Aciklama2 = fatura.Aciklama2;
                    f.Aciklama3 = fatura.Aciklama3;
                    f.Aciklama4 = fatura.Aciklama4;
                    f.Aciklama5 = fatura.Aciklama5;
                    f.ProformaNo = fatura.ProformaNo;
                    f.SatinalmaSorumlusu = fatura.SatinalmaSorumlusu;
                    f.BolumSatinAlmaSorumlusu = fatura.BolumSatinAlmaSorumlusu;
                    f.IhracatTasimaKodu = fatura.IhracatTasimaKodu;
                    f.Tutar = satirlar.Sum(sa => sa.Tutar);
                    f.ToplamIndirim = satirlar.Sum(sa => sa.IskontoTutari);
                    f.KdvMatrahi = satirlar.Sum(sa => sa.KdvMatrahi);
                    f.KdvTutari = satirlar.Sum(sa => sa.KdvTutari);
                    f.TevkifatMuafiyeti = fatura.TevkifatMuafiyeti;
                    f.ToplamTutar = satirlar.Sum(sa => sa.NetTutar);
                    f.OdenecekTutar = fatura.OdenecekTutar;
                    f.DovizKuru = fatura.DovizKuru;

                    decimal kur = fatura.DovizKuru ?? 1m;
                    f.TLTutar = satirlar.Sum(sa => sa.Tutar) * kur;
                    f.TLToplamIndirim = satirlar.Sum(sa => sa.IskontoTutari) * kur;
                    f.TLKdvMatrahi = satirlar.Sum(sa => sa.KdvMatrahi) * kur;
                    f.TLKdvTutari = satirlar.Sum(sa => sa.KdvTutari) * kur;
                    f.TLToplamTutar = satirlar.Sum(sa => sa.NetTutar) * kur;
                    f.TLOdenecekTutar = fatura.OdenecekTutar * kur;
                    f.Iptal = false;
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = fatura.Id;
                        satir.Iptal = false;
                    }

                    db.FatIrsSatirlar.AddRange(satirlar);
                    db.SaveChanges();
                    trans.Commit();

                    return new Sonuc().Ekle("Id", fatura.Id).Ekle("FisNo", fatura.FisNo);

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new Sonuc(false).Ekle("Hata", ex.Message);
                }
            }
        }

        public Sonuc IrsaliyeKaydet(Irsaliyeler irsaliye, List<FatIrsSatirlar> satirlar)
        {

            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    Guid guid = Guid.NewGuid();
                    irsaliye.Guid = guid.ToString();
                    irsaliye.Tutar = (double?)satirlar.Sum(s => s.Tutar);
                    irsaliye.ToplamIndirim = (double?)satirlar.Sum(sa => sa.IskontoTutari);
                    irsaliye.KdvMatrahi = (double?)satirlar.Sum(s => s.KdvMatrahi);
                    irsaliye.KdvTutari = (double?)satirlar.Sum(s => s.KdvTutari);
                    irsaliye.ToplamTutar = (double?)satirlar.Sum(s => s.NetTutar);
                    db.Irsaliyeler.Add(irsaliye);
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = irsaliye.Id;
                        satir.Iptal = false;
                    }

                    db.FatIrsSatirlar.AddRange(satirlar);
                    db.SaveChanges();

                    string fatTipi = string.Empty;
                    if (irsaliye.TrCode != 1)
                    {
                        if (irsaliye.FaturaTipi == 0)
                            fatTipi = "KagitIrsaliye";
                        else if (irsaliye.FaturaTipi == 1)
                            fatTipi = "EIrsaliye";
                        else if (irsaliye.FaturaTipi == 2)
                            fatTipi = "EIrsaliye";
                    }
                    else
                    {
                        fatTipi = "KagitIrsaliye";
                    }

                    var eFat = db.Numarator.FirstOrDefault(s => s.Tip == fatTipi);
                    string fatNum = irsaliye.FisNo.Substring(7, 9);
                    int numara = Convert.ToInt32(fatNum) + 1;
                    eFat.Numara = numara;
                    db.SaveChanges();
                    trans.Commit();

                    return new Sonuc().Ekle("Id", irsaliye.Id).Ekle("FisNo", irsaliye.FisNo);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new Sonuc(false).Ekle("Hata", ex.Message);
                }
            }
        }

        public Sonuc IrsaliyeGuncelle(Irsaliyeler irsaliye, List<FatIrsSatirlar> satirlar)
        {
            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    var s = db.FatIrsSatirlar.Where(x => x.FaturaId == irsaliye.Id);
                    db.FatIrsSatirlar.RemoveRange(s);
                    db.SaveChanges();

                    var f = db.Irsaliyeler.FirstOrDefault(fa => fa.Id == irsaliye.Id);
                    f.FisTipi = "I";
                    f.TrCode = irsaliye.TrCode;
                    f.FaturaTipi = irsaliye.FaturaTipi;
                    f.Tarih = irsaliye.Tarih;
                    f.VadeTarihi = irsaliye.VadeTarihi;
                    f.TemlikTarihi = irsaliye.TemlikTarihi;
                    f.OpsiyonTarihi = irsaliye.OpsiyonTarihi;
                    f.FisNo = irsaliye.FisNo;
                    f.BelgeNo = irsaliye.BelgeNo;
                    f.OzelKod1 = irsaliye.OzelKod1;
                    f.Personel = irsaliye.Personel;
                    f.CariId = irsaliye.CariId;
                    f.IsyeriNo = irsaliye.IsyeriNo;
                    f.AmbarNo = irsaliye.AmbarNo;
                    f.DovizKodu = irsaliye.DovizKodu;
                    f.Aciklama1 = irsaliye.Aciklama1;
                    f.Aciklama2 = irsaliye.Aciklama2;
                    f.Aciklama3 = irsaliye.Aciklama3;
                    f.Aciklama4 = irsaliye.Aciklama4;
                    f.Aciklama5 = irsaliye.Aciklama5;
                    f.SevkAdresId = irsaliye.SevkAdresId;
                    f.TasiyiciFirmaKodu = irsaliye.TasiyiciFirmaKodu;
                    f.TasiyiciFirmaUnvani = irsaliye.TasiyiciFirmaUnvani;
                    f.TasiyiciSoforAdi = irsaliye.TasiyiciSoforAdi;
                    f.TasiyiciSoforSoyadi = irsaliye.TasiyiciSoforSoyadi;
                    f.TasiyiciSoforTckNo = irsaliye.TasiyiciSoforTckNo;
                    f.TasiyiciAracPlakaNo = irsaliye.TasiyiciAracPlakaNo;
                    f.FaturaTuruId = irsaliye.FaturaTuruId;
                    f.Tutar = (double?)satirlar.Sum(sa => sa.Tutar);
                    f.ToplamIndirim = (double?)satirlar.Sum(sa => sa.IskontoTutari);
                    f.KdvMatrahi = (double?)satirlar.Sum(sa => sa.KdvMatrahi);
                    f.KdvTutari = (double?)satirlar.Sum(sa => sa.KdvTutari);
                    f.TevkifatMuafiyeti = irsaliye.TevkifatMuafiyeti;
                    f.ToplamTutar = (double?)satirlar.Sum(sa => sa.NetTutar);
                    f.OdenecekTutar = irsaliye.OdenecekTutar;
                    f.DovizKuru = irsaliye.DovizKuru;
                    f.Iptal = false;
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = irsaliye.Id;
                        satir.Iptal = false;
                    }

                    db.FatIrsSatirlar.AddRange(satirlar);
                    db.SaveChanges();
                    trans.Commit();

                    return new Sonuc().Ekle("Id", irsaliye.Id).Ekle("FisNo", irsaliye.FisNo);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new Sonuc(false).Ekle("Hata : " + Environment.NewLine, ex.Message);
                }
            }
        }

        public Sonuc TeklifKaydet(Teklifler teklif, List<TeklifSatirlar> satirlar, int seriNoDegisti)
        {
            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    Guid guid = Guid.NewGuid();
                    teklif.Guid = guid.ToString();
                    teklif.Tutar = satirlar.Sum(s => s.Tutar);
                    teklif.ToplamIndirim = satirlar.Sum(s => s.IndirimTutari);
                    teklif.KdvMatrahi = satirlar.Sum(s => s.KdvMatrahi);
                    teklif.KdvTutari = satirlar.Sum(s => s.KdvTutari);
                    teklif.ToplamTutar = satirlar.Sum(s => s.NetTutar);

                    double kur = (double)teklif.DovizKuru;

                    teklif.TLTutar = (satirlar.Sum(s => s.Tutar)) * kur;
                    teklif.TLToplamIndirim = (satirlar.Sum(sa => sa.IndirimTutari)) * kur;
                    teklif.TLKdvMatrahi = (satirlar.Sum(s => s.KdvMatrahi)) * kur;
                    teklif.TLKdvTutari = (satirlar.Sum(s => s.KdvTutari)) * kur;
                    teklif.TLToplamTutar = (satirlar.Sum(s => s.NetTutar)) * kur;

                    db.Teklifler.Add(teklif);
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = teklif.Id;
                        satir.Tarih = teklif.Tarih;
                        satir.TrCode = (int)teklif.TrCode;
                        satir.FaturaTipi = teklif.FaturaTipi;
                        satir.CariId = teklif.CariId;
                        satir.IsyeriNo = teklif.IsyeriNo;
                        satir.AmbarNo = teklif.AmbarNo;
                        satir.DovizKodu = teklif.DovizKodu.ToString();
                        satir.OnaylananMiktar = 0;
                        satir.Iptal = false;
                    }

                    db.TeklifSatirlar.AddRange(satirlar);


                    string fatTipi = "Teklif";

                    if (seriNoDegisti == 0)
                    {
                        var eFat = db.Numarator.FirstOrDefault(s => s.Tip == fatTipi);
                        string fatNum = teklif.FisNo.Substring(7, 9);
                        int numara = Convert.ToInt32(fatNum) + 1;
                        eFat.Numara = numara;
                    }

                    if (!string.IsNullOrWhiteSpace(teklif.ProformaNo) && teklif.ProformaNo.Length > 3)
                    {
                        var proFat = db.Teklifler.FirstOrDefault(s => s.FisNo == teklif.ProformaNo);
                        proFat.ProformaNo = teklif.FisNo;
                    }

                    db.SaveChanges();
                    trans.Commit();
                    return new Sonuc().Ekle("Id", teklif.Id).Ekle("FisNo", teklif.FisNo);
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new Sonuc(false).Ekle("Hata: " + Environment.NewLine, ex.Message);
                }
            }
        }

        public Sonuc TeklifGuncelle(Teklifler teklif, List<TeklifSatirlar> satirlar)
        {
            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var trans = db.Database.BeginTransaction();
                try
                {
                    var s = db.TeklifSatirlar.Where(x => x.FaturaId == teklif.Id);
                    db.TeklifSatirlar.RemoveRange(s);
                    db.SaveChanges();

                    var f = db.Teklifler.FirstOrDefault(fa => fa.Id == teklif.Id);
                    f.FisTipi = teklif.FisTipi;
                    f.TrCode = teklif.TrCode;
                    f.FaturaTipi = teklif.FaturaTipi;
                    f.Tarih = teklif.Tarih;
                    f.VadeTarihi = teklif.VadeTarihi;
                    f.TemlikTarihi = teklif.TemlikTarihi;
                    f.OpsiyonTarihi = teklif.OpsiyonTarihi;
                    f.SiparisNo = teklif.SiparisNo;
                    f.SiparisTarihi = teklif.SiparisTarihi;
                    f.FisNo = teklif.FisNo;
                    f.BelgeNo = teklif.BelgeNo;
                    f.ProjeNo = teklif.ProjeNo;
                    f.OzelKod1 = teklif.OzelKod1;
                    f.Personel = teklif.Personel;
                    f.CariId = teklif.CariId;
                    f.IsyeriNo = teklif.IsyeriNo;
                    f.AmbarNo = teklif.AmbarNo;
                    f.DovizKodu = teklif.DovizKodu.ToString();
                    f.Aciklama1 = teklif.Aciklama1;
                    f.Aciklama2 = teklif.Aciklama2;
                    f.Aciklama3 = teklif.Aciklama3;
                    f.Aciklama4 = teklif.Aciklama4;
                    f.Aciklama5 = teklif.Aciklama5;
                    f.ProformaNo = teklif.ProformaNo;
                    f.SatinalmaSorumlusu = teklif.SatinalmaSorumlusu;
                    f.BolumSatinAlmaSorumlusu = teklif.BolumSatinAlmaSorumlusu;
                    f.FaturaTuruId = teklif.FaturaTuruId;
                    f.Tutar = satirlar.Sum(sa => sa.Tutar);
                    f.ToplamIndirim = satirlar.Sum(sa => sa.IndirimTutari);
                    f.KdvMatrahi = satirlar.Sum(sa => sa.KdvMatrahi);
                    f.KdvTutari = satirlar.Sum(sa => sa.KdvTutari);
                    f.TevkifatMuafiyeti = teklif.TevkifatMuafiyeti;
                    f.ToplamTutar = satirlar.Sum(sa => sa.NetTutar);
                    f.OdenecekTutar = teklif.OdenecekTutar;
                    f.DovizKuru = (double)teklif.DovizKuru;
                    f.TLTutar = (satirlar.Sum(sa => sa.Tutar)) * (double)teklif.DovizKuru;
                    f.TLToplamIndirim = (satirlar.Sum(sa => sa.IndirimTutari)) * (double)teklif.DovizKuru;
                    f.TLKdvMatrahi = (satirlar.Sum(sa => sa.KdvMatrahi)) * (double)teklif.DovizKuru;
                    f.TLKdvTutari = (satirlar.Sum(sa => sa.KdvTutari)) * (double)teklif.DovizKuru;
                    f.TLToplamTutar = (satirlar.Sum(sa => sa.NetTutar)) * (double)teklif.DovizKuru;
                    f.SevkAdresId = teklif.SevkAdresId;
                    f.Iptal = false;
                    db.SaveChanges();

                    foreach (var satir in satirlar)
                    {
                        satir.FaturaId = teklif.Id;
                        satir.Tarih = teklif.Tarih;
                        satir.TrCode = (int)teklif.TrCode;
                        satir.FaturaTipi = teklif.FaturaTipi;
                        satir.CariId = teklif.CariId;
                        satir.IsyeriNo = teklif.IsyeriNo;
                        satir.AmbarNo = teklif.AmbarNo;
                        satir.DovizKodu = teklif.DovizKodu.ToString();
                        satir.Iptal = false;
                    }

                    db.TeklifSatirlar.AddRange(satirlar);
                    db.SaveChanges();
                    trans.Commit();

                    return new Sonuc().Ekle("Id", teklif.Id).Ekle("FisNo", teklif.FisNo);

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    return new Sonuc(false).Ekle("Hata", ex.Message);
                }
            }
        }

        public void IzinBitisGunuYaz()
        {
            using (FirmaContext db = null) // TODO: new FirmaContext() - needs DI refactoring
            {
                var izin = db.IzinFormlari.Where(s => s.IseBaslamaTarihi <= DateTime.Now && s.OnayDurumu == "Onaylandi" && s.OnayAciklama != "Onaylandi-Kapali" && s.Iptal != true).ToList();
                if (izin == null) return;
                foreach (var item in izin)
                {
                    item.OnayAciklama = "Onaylandi-Kapali";
                    db.SaveChanges();
                }
            }
        }
    }
}
