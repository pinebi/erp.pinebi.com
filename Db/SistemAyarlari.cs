using MACHINEBISS_Web.Db;
using MACHINEBISS_Web.Models.BlockBiss;
using MACHINEBISS_Web.Models.BlockBiss.Envanter;
using MACHINEBISS_Web.Models.MachineBiss;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace MACHINEBISS_Web
{
    public class SistemAyarlari
    {
        private readonly FirmaContext _firmaDb;
        private readonly NetworkContext _networkDb;
        private readonly IConfiguration _configuration;

        public long apiInstitutionId;
        public string sistemKlasoru, apiKullaniciAdi, apiKullaniciSifresi;
        public string sirketAdi, sirketTel, sirketFaks, sirketEPosta, sirketVd, sirketVn, sirketAdres, sirketIlce, sirketSehir, sirketUlke,
            sirketPostaKodu, sirketWeb, salesmanCode, erpKullanici, erpKullaniciGorevi,
            EFaturaGelenUrnMail, EFaturaGidenUrnMail, EArsivUrnMail, EIrsaliyeUrnMail;
        public int sistemSirketNo, sirketNo, isyeriNo, ambarNo, erpKullaniciId;
        public bool eFatura, eIrsaliye;

        public string mailUser, mailSifre, mailServer, mailGonderen;
        bool mailSSL;
        public Int32 mailPort;
        public int sirNo;

        public SistemAyarlari(FirmaContext firmaDb, NetworkContext networkDb, IConfiguration configuration)
        {
            _firmaDb = firmaDb;
            _networkDb = networkDb;
            _configuration = configuration;
        }

        public void IsyeriBilgileri(string kullAdi, string sifre)
        {
            var login = _networkDb.LoginTablo.FirstOrDefault(s => s.KullaniciAdi == kullAdi && s.Sifre == sifre);
            if (login != null)
            {
                sirNo = login.SirketKodu;
            }
        }

        public void Ayarlar()
        {
            sistemKlasoru = Path.GetPathRoot(Environment.SystemDirectory);

            int sirNo = Convert.ToInt32(_configuration["SirketNo"]);
            var sir = _networkDb.SirketBilgileri.FirstOrDefault(s => s.SirketNo == sirNo);
            sistemSirketNo = 0;
            sirketNo = (int)sir.SirketNo;
            sirketAdi = sir.FirmaUnvani;
            sirketTel = sir.Telefon;
            sirketFaks = sir.Faks;
            sirketEPosta = sir.EPosta;
            sirketVd = sir.Vd;
            sirketVn = sir.Vn;
            sirketAdres = sir.Adres;
            sirketIlce = sir.Ilce;
            sirketSehir = sir.Sehir;
            sirketUlke = sir.Ulke;
            sirketPostaKodu = "";
            sirketWeb = sir.Web;
            EFaturaGelenUrnMail = sir.EFaturaGelenUrnMail;
            EFaturaGidenUrnMail = sir.EFaturaGidenUrnMail;
            EArsivUrnMail = sir.EArsivUrnMail;
            EIrsaliyeUrnMail = sir.EIrsaliyeUrnMail;
            eFatura = sir.EFaturaMukellefi;
            eIrsaliye = sir.EIrsaliyeMukellefi;

            isyeriNo = 1;
            ambarNo = 1;
            salesmanCode = "1";

            apiInstitutionId = Convert.ToInt64(sir.ApiInstitutionId);
            apiKullaniciAdi = sir.ApiKullaniciAdi.Trim() as string;
            apiKullaniciSifresi = sir.ApiKullaniciSifresi.Trim();

            erpKullaniciId = Convert.ToInt32(_configuration["ErpKullaniciId"]);
            erpKullanici = _configuration["ErpKullanici"] as string;
            erpKullaniciGorevi = _configuration["ErpKullaniciGorevi"] as string;
        }

        public LoginTablo Yetkiler()
        {
            int id = Convert.ToInt32(_configuration["Id"]);
            var veri = _networkDb.LoginTablo.FirstOrDefault(s => s.Id == id);
            return veri;
        }

        public string[] ImkbDovizKurlari()
        {
            try
            {
                string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(exchangeRate);
                string usd = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod ='USD']/BanknoteSelling").InnerXml.Replace(".", ",");
                string eur = xmlDoc.SelectSingleNode("Tarih_Date/Currency[@Kod ='EUR']/BanknoteSelling").InnerXml.Replace(".", ",");
                return new string[] { usd, eur };
            }
            catch
            {
                return new string[] { "0,0000", "0,0000" };
            }
        }

        public string ImkbDovizKuru(string dovizId)
        {
            try
            {
                string dovKod = _networkDb.Doviz.FirstOrDefault(s => s.DovizKodu == dovizId).DovizCinsi;
                string exchangeRate = "http://www.tcmb.gov.tr/kurlar/today.xml";
                var xmlDoc = new XmlDocument();
                xmlDoc.Load(exchangeRate);
                string dov = xmlDoc.SelectSingleNode($"Tarih_Date/Currency[@Kod ='{dovKod}']/BanknoteSelling").InnerXml.Replace(".", ",");
                return dov;
            }
            catch
            {
                return "0,0000";
            }
        }

        public string[] KayitliDovizKurlari()
        {
            try
            {
                string usd, euro;
                DateTime tar = DateTime.Today;
                var usdKur = _firmaDb.DovizKurlari.FirstOrDefault(s => s.Tarih == tar && s.DovizKodu == "1");
                if (usdKur != null)
                    usd = usdKur.DovizKuru.ToString();
                else
                    usd = "0,0000";

                var euroKur = _firmaDb.DovizKurlari.FirstOrDefault(s => s.Tarih == tar && s.DovizKodu == "20");
                if (euroKur != null)
                    euro = euroKur.DovizKuru.ToString();
                else
                    euro = "0,0000";

                return new string[] { usd, euro };
            }
            catch
            {
                return new string[] { "0,0000", "0,0000" };
            }
        }

        public string[] NumaratorArray(string Tip)
        {
            var eFat = _firmaDb.Numarator.FirstOrDefault(s => s.Tip == Tip);
            var fatNo = eFat.OnEk + eFat.Numara.ToString().PadLeft(9, '0');
            return new string[] { eFat.OnEk, eFat.Numara.ToString() };
        }

        public string Numarator(string Tip)
        {
            var eFat = _firmaDb.Numarator.FirstOrDefault(s => s.Tip == Tip);
            var fatNo = eFat.OnEk + eFat.Numara.ToString().PadLeft(9, '0');
            return fatNo;
        }

        public List<string> Unvanlar(int yetkiliId)
        {
            return _networkDb.Gorevler.Select(s => s.Gorev).ToList();
        }

        public List<IzinSebepleri> IzinTurleri()
        {
            return _networkDb.IzinSebepleri.ToList();
        }

        public List<TevkifatKodlari> TevkifatOranlari()
        {
            return _networkDb.TevkifatKodlari.ToList();
        }

        public List<ParaBirimleri> ParaBirimleriListesi()
        {
            return _networkDb.ParaBirimleri.ToList();
        }

        public List<Doviz> DovizKodlari()
        {
            return _networkDb.Doviz.ToList();
        }

        public List<TumBankalar> TumBankalarListesi()
        {
            return _networkDb.TumBankalar.ToList();
        }

        public List<FaturaSecenekleri> FaturaSecenekleriListesi()
        {
            List<FaturaSecenekleri> fatTip = new List<FaturaSecenekleri>();
            fatTip.Add(new FaturaSecenekleri { Id = 0, ACIKLAMA = "NORMAL" });
            fatTip.Add(new FaturaSecenekleri { Id = 1, ACIKLAMA = "KAMU" });
            fatTip.Add(new FaturaSecenekleri { Id = 4, ACIKLAMA = "ISTISNA" });
            fatTip.Add(new FaturaSecenekleri { Id = 2, ACIKLAMA = "TEVKIFATLI" });
            fatTip.Add(new FaturaSecenekleri { Id = 3, ACIKLAMA = "IHRACAT" });
            return fatTip;
        }

        public List<FaturaSecenekleri> TasimaSecenekleriListesi()
        {
            List<FaturaSecenekleri> fatTip = new List<FaturaSecenekleri>();
            fatTip.Add(new FaturaSecenekleri { Id = 0, ACIKLAMA = "Tasima modu belirtilmemis" });
            fatTip.Add(new FaturaSecenekleri { Id = 1, ACIKLAMA = "Deniz tasimaciligi" });
            fatTip.Add(new FaturaSecenekleri { Id = 2, ACIKLAMA = "Demiryolu tasimaciligi" });
            fatTip.Add(new FaturaSecenekleri { Id = 3, ACIKLAMA = "Karayolu tasimaciligi" });
            fatTip.Add(new FaturaSecenekleri { Id = 4, ACIKLAMA = "Hava tasimaciligi" });
            fatTip.Add(new FaturaSecenekleri { Id = 5, ACIKLAMA = "Posta" });
            fatTip.Add(new FaturaSecenekleri { Id = 6, ACIKLAMA = "Cok modlu tasima" });
            fatTip.Add(new FaturaSecenekleri { Id = 7, ACIKLAMA = "Sabit tasima tesisleri" });
            fatTip.Add(new FaturaSecenekleri { Id = 8, ACIKLAMA = "Ic su tasimaciligi" });
            fatTip.Add(new FaturaSecenekleri { Id = 9, ACIKLAMA = "Tasima modu uygulanamaz" });
            return fatTip;
        }

        public List<FaturaTipleri> FaturaTipleriFisListesi()
        {
            List<FaturaTipleri> fatTip = new List<FaturaTipleri>();
            fatTip.Add(new FaturaTipleri { NR = 0, NAME = "Kagit Fatura" });
            fatTip.Add(new FaturaTipleri { NR = 1, NAME = "E-Fatura" });
            fatTip.Add(new FaturaTipleri { NR = 2, NAME = "E-Arsiv" });
            fatTip.Add(new FaturaTipleri { NR = 4, NAME = "Fis" });
            return fatTip;
        }

        public List<FaturaTipleri> FaturaTipleriListesi(int trcode)
        {
            List<FaturaTipleri> fatTip = new List<FaturaTipleri>();
            fatTip.Add(new FaturaTipleri { NR = 0, NAME = "Kagit Fatura" });
            fatTip.Add(new FaturaTipleri { NR = 1, NAME = "E-Fatura" });
            fatTip.Add(new FaturaTipleri { NR = 2, NAME = "E-Arsiv" });
            if (trcode == 10) fatTip.Add(new FaturaTipleri { NR = 10, NAME = "Verilen Proforma Fatura" });
            if (trcode == 11) fatTip.Add(new FaturaTipleri { NR = 11, NAME = "Alinan Proforma Fatura" });
            return fatTip;
        }

        public List<IrsaliyeTipleri> IrsaliyeTipleriListesi()
        {
            List<IrsaliyeTipleri> fatTip = new List<IrsaliyeTipleri>();
            fatTip.Add(new IrsaliyeTipleri { NR = 0, NAME = "Kagit Irsaliye" });
            fatTip.Add(new IrsaliyeTipleri { NR = 1, NAME = "E-Irsaliye" });
            return fatTip;
        }

        public List<Isyerleri> IsyerleriListesi()
        {
            return _firmaDb.Isyerleri.ToList();
        }

        public List<object> SatisElemanlariListesi()
        {
            return _firmaDb.Personeller.Select(s => new { s.Id, s.AdSoyad }).ToList<object>();
        }

        public List<Ambarlar> AmbarlarListesi()
        {
            return _firmaDb.Ambarlar.ToList();
        }

        public List<SirketBankaBilgileri> BankalarListesi()
        {
            Ayarlar();
            return _networkDb.SirketBankaBilgileri.Where(s => s.SirketNo == sirketNo).ToList();
        }

        public List<OdemeTipleri> OdemeTipleriListesi()
        {
            return _networkDb.OdemeTipleri.ToList();
        }

        public List<GiderTipleri> GiderTipleriListesi()
        {
            return _firmaDb.GiderTipleri.ToList();
        }

        public List<Ulkeler> UlkelerListesi()
        {
            return _networkDb.Ulkeler.ToList();
        }

        public List<Sehirler> SehirlerListesi()
        {
            return _networkDb.Sehirler.ToList();
        }

        public List<Ilceler> IlcelerListesi()
        {
            return _networkDb.Ilceler.ToList();
        }

        public List<VergiDaireleri> VergiDaireleriListesi()
        {
            return _networkDb.VergiDaireleri.ToList();
        }

        public string IlkHarf(string Metin)
        {
            string girilenyazi = Metin;
            string[] kelimeler;
            kelimeler = girilenyazi.Split(' ');
            string sonuc = "";
            for (int i = 0; i <= kelimeler.Length - 1; i++)
            {
                string ilkharf = kelimeler[i].Substring(0, 1);
                string sonrakiharfler = kelimeler[i].Substring(1);
                string duzgun = ilkharf.ToUpper() + sonrakiharfler.ToLower();
                sonuc += duzgun + " ";
            }
            sonuc = sonuc.TrimEnd();
            return sonuc;
        }

        public string EFUBKod(string bKod)
        {
            var kod = _networkDb.EFaturaUluslararasiBirimKodlari.FirstOrDefault(k => k.DonusumKodu == bKod);
            if (kod != null)
            {
                return kod.BirimKodu;
            }
            else
            {
                return "";
            }
        }

        public string KodEFUB(string bKod)
        {
            var kod = _networkDb.EFaturaUluslararasiBirimKodlari.FirstOrDefault(k => k.BirimKodu == bKod);
            if (kod != null)
            {
                return kod.DonusumKodu;
            }
            else
            {
                return "";
            }
        }

        public string EFaturaOnEk()
        {
            var kod = _firmaDb.Numarator.FirstOrDefault(k => k.Tip == "EFatura");
            if (kod != null)
            {
                return kod.OnEk.Substring(0, 3);
            }
            else
            {
                return "";
            }
        }

        public string EArsivOnEk()
        {
            var kod = _firmaDb.Numarator.FirstOrDefault(k => k.Tip == "EArsiv");
            if (kod != null)
            {
                return kod.OnEk.Substring(0, 3);
            }
            else
            {
                return "";
            }
        }

        public void Sehirler_TurkishCharacterToEnglish()
        {
            var kod = _networkDb.Sehirler.ToList();
            foreach (var item in kod)
            {
                char[] turkishChars = { '\u0131', '\u011F', '\u0130', '\u011E', '\u00E7', '\u00C7', '\u015F', '\u015E', '\u00F6', '\u00D6', '\u00FC', '\u00DC' };
                char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };
                string duzenlenmis = item.SehirAdi;

                for (int i = 0; i < turkishChars.Length; i++)
                {
                    duzenlenmis = duzenlenmis.Replace(turkishChars[i], englishChars[i]);
                }
                item.Duzenle = duzenlenmis;
                _networkDb.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _networkDb.SaveChanges();
            }
        }

        public void Ilceler_TurkishCharacterToEnglish()
        {
            var kod = _networkDb.Ilceler.ToList();
            foreach (var item in kod)
            {
                char[] turkishChars = { '\u0131', '\u011F', '\u0130', '\u011E', '\u00E7', '\u00C7', '\u015F', '\u015E', '\u00F6', '\u00D6', '\u00FC', '\u00DC' };
                char[] englishChars = { 'i', 'g', 'I', 'G', 'c', 'C', 's', 'S', 'o', 'O', 'u', 'U' };
                string duzenlenmis = item.IlceAdi;

                for (int i = 0; i < turkishChars.Length; i++)
                {
                    duzenlenmis = duzenlenmis.Replace(turkishChars[i], englishChars[i]);
                }
                item.Duzenle = duzenlenmis;
                _networkDb.Entry(item).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _networkDb.SaveChanges();
            }
        }

        public int UlkeDuzenle(string ulke)
        {
            var kod = _networkDb.Ulkeler.FirstOrDefault(k => k.Ulke == ulke);
            if (kod != null)
            {
                return kod.Id;
            }
            else
            {
                return -1;
            }
        }

        public int SehirDuzenle(string sehir)
        {
            var kod = _networkDb.Sehirler.FirstOrDefault(k => k.SehirAdi == sehir);
            if (kod != null)
            {
                return kod.Id;
            }
            else
            {
                return -1;
            }
        }

        public int IlceDuzenle(string ilce)
        {
            var kod = _networkDb.Ilceler.FirstOrDefault(k => k.IlceAdi == ilce);
            if (kod != null)
            {
                return kod.Id;
            }
            else
            {
                return -1;
            }
        }

        public double TevkifatHesapla(double kdvMatrahi, double kdvOrani, double kdvTutari, double kdvDahilTutar, double carpan, double bolen)
        {
            double tutar = 0;
            if (kdvDahilTutar > 2000)
            {
                tutar = kdvTutari - ((kdvTutari * carpan) / bolen);
                tutar = (kdvTutari * carpan) / bolen;
                return tutar;
            }
            else
            {
                return tutar;
            }
        }

        public List<Envanterler> EnvanterlerListesi()
        {
            return _networkDb.Envanterler.ToList();
        }

        static bool EmailKontrol(string email)
        {
            const string strRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return new Regex(strRegex).IsMatch(email);
        }

        public string MailGonder(string kime, string konu, string aciklama, string dosyaAdi, int ekliDosyaVar)
        {
            try
            {
                var ePosta = _firmaDb.EMailAyarlari.FirstOrDefault();
                if (ePosta == null)
                {
                    return "false";
                }
                else
                {
                    mailServer = ePosta.EMailServer.Trim();
                    mailGonderen = ePosta.EMailUserName.Trim();
                    mailUser = ePosta.EMailUserName.Trim();
                    mailSifre = ePosta.EMailPassword.Trim();
                    mailPort = (int)ePosta.EMailPort;
                    mailSSL = (bool)ePosta.SSL;
                }

                if (!EmailKontrol(kime))
                {
                    return "false";
                }

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(mailGonderen);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.IsBodyHtml = false;
                    mail.Body = aciklama;
                    if (ekliDosyaVar == 1)
                    {
                        if (dosyaAdi != null)
                            mail.Attachments.Add(new Attachment(dosyaAdi));
                    }
                    SmtpClient smtp = new SmtpClient();
                    smtp.Port = mailPort;
                    smtp.Host = mailServer;
                    smtp.Credentials = new NetworkCredential(mailUser, mailSifre);
                    smtp.Send(mail);
                    return "true";
                }
            }
            catch (Exception ex)
            {
                return "false";
            }
        }

        public string yaziyaCevirTL(decimal tutar, string doviz, string krsDoviz)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "Bir", "Iki", "Uc", "Dort", "Bes", "Alti", "Yedi", "Sekiz", "Dokuz" };
            string[] onlar = { "", "On", "Yirmi", "Otuz", "Kirk", "Elli", "Altmis", "Yetmis", "Seksen", "Doksan" };
            string[] binler = { "Katrilyon", "Trilyon", "Milyar", "Milyon", "Bin", "" };

            int grupSayisi = 6;

            lira = lira.PadLeft(grupSayisi * 3, '0');

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3)
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "Yuz";

                if (grupDegeri == "BirYuz")
                    grupDegeri = "Yuz";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))];

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))];

                if (grupDegeri != "")
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BirBin")
                    grupDegeri = "Bin";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " " + doviz;

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0")
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0")
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " " + krsDoviz + ".";
            else
                yazi += " Sifir " + krsDoviz + ".";

            return yazi;
        }

        public string yaziyaCevirUSD(decimal tutar)
        {
            string sTutar = tutar.ToString("F2").Replace('.', ',');
            string lira = sTutar.Substring(0, sTutar.IndexOf(','));
            string kurus = sTutar.Substring(sTutar.IndexOf(',') + 1, 2);
            string yazi = "";

            string[] birler = { "", "BIR", "IKI", "UC", "DORT", "BES", "ALTI", "YEDI", "SEKIZ", "DOKUZ" };
            string[] onlar = { "", "ON", "YIRMI", "OTUZ", "KIRK", "ELLI", "ALTMIS", "YETMIS", "SEKSEN", "DOKSAN" };
            string[] binler = { "KATRILYON", "TRILYON", "MILYAR", "MILYON", "BIN", "" };

            int grupSayisi = 6;

            lira = lira.PadLeft(grupSayisi * 3, '0');

            string grupDegeri;

            for (int i = 0; i < grupSayisi * 3; i += 3)
            {
                grupDegeri = "";

                if (lira.Substring(i, 1) != "0")
                    grupDegeri += birler[Convert.ToInt32(lira.Substring(i, 1))] + "YUZ";

                if (grupDegeri == "BIRYUZ")
                    grupDegeri = "YUZ";

                grupDegeri += onlar[Convert.ToInt32(lira.Substring(i + 1, 1))];

                grupDegeri += birler[Convert.ToInt32(lira.Substring(i + 2, 1))];

                if (grupDegeri != "")
                    grupDegeri += binler[i / 3];

                if (grupDegeri == "BIRBIN")
                    grupDegeri = "BIN";

                yazi += grupDegeri;
            }

            if (yazi != "")
                yazi += " USD ";

            int yaziUzunlugu = yazi.Length;

            if (kurus.Substring(0, 1) != "0")
                yazi += onlar[Convert.ToInt32(kurus.Substring(0, 1))];

            if (kurus.Substring(1, 1) != "0")
                yazi += birler[Convert.ToInt32(kurus.Substring(1, 1))];

            if (yazi.Length > yaziUzunlugu)
                yazi += " Cent ";
            else
                yazi += "SIFIR Cent";

            return yazi;
        }
    }

    public static class JObjectExtension
    {
    }
}
