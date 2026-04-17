using MACHINEBISS_Web.Models.MachineBiss;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Db
{
    public class Functions
    {
        private readonly SistemAyarlari _clas;
        private readonly FirmaContext _firmaDb;
        private readonly NetworkContext _networkDb;

        public Functions(SistemAyarlari clas, FirmaContext firmaDb, NetworkContext networkDb)
        {
            _clas = clas;
            _firmaDb = firmaDb;
            _networkDb = networkDb;
        }

        public string[] EFaturaAlias(string vn)
        {
            _clas.Ayarlar();
            bool efat = false;
            string gelenPosta = string.Empty;

            // TODO: innovaTest WCF service reference is not available in Blazor Web project.
            // This method needs to be reimplemented using REST API or gRPC.
            /*
            innovaTest.CustomerInquiryRequest customerRequest = new innovaTest.CustomerInquiryRequest()
            {
                Header = new innovaTest.RequestHeader()
                {
                    InstitutionId = _clas.apiInstitutionId,
                    InstitutionIdSpecified = true,
                    Username = _clas.apiKullaniciAdi,
                    Password = _clas.apiKullaniciSifresi
                },

                IdentityNumbers = new string[]
                {
                    vn.Trim()
                },

            };

            var servis = new innovaTest.ClientInterfaceService();
            servis.Timeout = 15000;
            var response = servis.CustomerInquiry(customerRequest);
            if(response.Header.ResponseCode=="1004")
            {
                return new string[] { efat.ToString().Replace("F", "f").Replace("T", "t"), "", "","Kayitli kullanici degilsiniz!" };
            }

            string name = string.Empty;
            if (response.Customers[0].IsExists == true)
            {
                efat = true;
                gelenPosta = response.Customers[0].ReceiverAliasses[0].Alias;
                name = response.Customers[0].ReceiverAliasses[0].Name;
            }
            else
            {
                efat = false;
                name = "";
            }

            return new string[] { efat.ToString().Replace("F", "f").Replace("T", "t"), gelenPosta, name,"" };
            */
            return new string[] { efat.ToString().Replace("F", "f").Replace("T", "t"), gelenPosta, "", "" };
        }

        public string[] EfaturaSorgula(string vn)
        {
            string efat, eUnvan, eFatUrn;
            string responseUri = "http://api.pinebi.com:8190//WS.SQL.GET.TERMINAL.EFATURA.CUSTOMERS";
            var client = new RestClient(responseUri);

            Models.EFatura.EFaturaAliasSorgulama.RootobjectGiden sorgula = new Models.EFatura.EFaturaAliasSorgulama.RootobjectGiden
            {
                BranchID = _clas.sirketNo,
                is_test = false,
                session_id = "DAB565F7-A6D9-4348-BAD8-F7A8029CB5C5",
                tax_number = vn
            };

            string fatura = JsonConvert.SerializeObject(sorgula);
            var request = new RestRequest(responseUri, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.RequestFormat = DataFormat.Json;
            request.AddParameter("application/json", fatura, ParameterType.RequestBody);

            RestResponse response = client.Execute(request);
            Console.WriteLine(response.Content);
            Models.EFatura.EFaturaAliasSorgulama.RootobjectGelen gelenSonuc = JsonConvert.DeserializeObject<Models.EFatura.EFaturaAliasSorgulama.RootobjectGelen>(response.Content);

            var sonuc = gelenSonuc.PARAMS.Params.VAL_L_CLS25[0].PARAM.VAL_CLS_RETURN.PARAMS;
            if (sonuc != null)
            {
                efat = "true";
                eUnvan = gelenSonuc.PARAMS.Params.VAL_L_CLS25[0].PARAM.VAL_CLS_RETURN.PARAMS.Result.VAL_JOBJECT.ReceiverAliasses[0].name.ToString();
                eFatUrn = gelenSonuc.PARAMS.Params.VAL_L_CLS25[0].PARAM.VAL_CLS_RETURN.PARAMS.Result.VAL_JOBJECT.ReceiverAliasses[0].alias.ToString();
            }
            else
            {
                efat = "false";
                eUnvan = "";
                eFatUrn = "";
            }

            return new string[] { efat, eUnvan, eFatUrn };
        }

        public string StokKoduUret(string kod, string cins)
        {
            string k = string.Empty;
            if (string.IsNullOrWhiteSpace(kod))
            {
                var kont = _firmaDb.StokKartlariView.FirstOrDefault(s => s.StokCinsi == cins.Trim());
                if (kont == null)
                {
                    Random rastgele = new Random();
                    int sayi = rastgele.Next(5000000, 9999999);
                    k = sayi.ToString();
                }
                else
                {
                    k = kont.StokKodu;
                }
            }

            return k;
        }

        public int StokIdBul(string kod, string cins, string birim, string kdv, string dovizKodu)
        {
            var stok = _firmaDb.StokKartlariView.FirstOrDefault(s => s.StokKodu == kod || s.StokCinsi == cins);
            if (stok != null)
            {
                return stok.Id;
            }
            else
            {
                StokKart stk = new StokKart();
                stk.Barkod = "";
                stk.StokKodu = string.IsNullOrWhiteSpace(kod) ? StokKoduUret(kod, cins) : kod;
                stk.StokCinsi = cins.Trim();
                stk.Birim = birim.Trim();
                stk.Kdv = Convert.ToDecimal(kdv.Replace("%", "").Trim());
                stk.DovizKodu = dovizKodu;
                stk.Aciklama = "";
                stk.UrunGrubu = "";
                stk.OzelKod1 = "";
                stk.OzelKod2 = "";
                stk.OzelKod3 = "";
                stk.OzelKod4 = "";
                stk.OzelKod5 = "";
                stk.TevkifatId = 0;
                stk.TevkifatKodu = "";
                stk.TevkifatCarpan = 0;
                stk.TevkifatBolen = 0;
                stk.KdvHaricSatisFiyati = 0;
                stk.MinimumSeviye = 0;
                stk.KullanimDisi = false;
                _firmaDb.StokKart.Add(stk);
                _firmaDb.SaveChanges();
                return stk.Id;
            }
        }

        public bool StokTakibi()
        {
            var prm = _firmaDb.VarsayilanDegerler.FirstOrDefault();
            if (prm != null)
            {
                return (bool)prm.StokTakibi;
            }
            else
            {
                return false;
            }
        }

        public int CariId(string cariUnvan)
        {
            int id = 0;
            string cUnv = string.Empty;
            if (string.IsNullOrWhiteSpace(cariUnvan as string))
                cUnv = "";
            else
                cUnv = cariUnvan;

            var veri = _firmaDb.Cariler.FirstOrDefault(s => s.Unvani == cUnv.Trim());
            if (veri == null)
                id = 0;
            else
                id = veri.Id;

            return id;
        }

        public int SehirId(string sehirAdi)
        {
            int id = 0;
            string sAdi = string.Empty;
            if (string.IsNullOrWhiteSpace(sehirAdi as string)) sAdi = ""; else sAdi = sehirAdi;
            var veri = _networkDb.Sehirler.FirstOrDefault(s => s.SehirAdi == sAdi.Trim());
            if (veri == null)
                id = 0;
            else
                id = veri.Id;

            return id;
        }

        public string DovizKodu(string doviz)
        {
            string kod = string.Empty;
            string dAdi = string.Empty;
            if (doviz == "TRY")
                dAdi = "TL";
            else if (doviz == "TLR")
                dAdi = "TL";
            else if (doviz == "EUR")
                dAdi = "EUR";
            else
                dAdi = "TL";

            if (string.IsNullOrWhiteSpace(doviz as string)) dAdi = "TL"; else dAdi = doviz;
            var veri = _networkDb.Doviz.FirstOrDefault(s => s.DovizCinsi == dAdi.Trim());
            if (veri == null)
                kod = "160";
            else
                kod = veri.DovizKodu;

            return kod;
        }

        public int IlceId(string ilceAdi)
        {
            int id = 0;
            string iAdi = string.Empty;
            if (string.IsNullOrWhiteSpace(ilceAdi as string)) iAdi = ""; else iAdi = ilceAdi;
            var veri = _networkDb.Ilceler.FirstOrDefault(s => s.IlceAdi == iAdi.Trim());
            if (veri == null)
                id = 0;
            else
                id = veri.Id;

            return id;
        }

        public string PazarGunuBul(int yil, int ay, int gun)
        {
            string g = string.Empty;

            DateTime date = new DateTime(yil, ay, gun);
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                g = "Pazar";
            }

            return g;
        }

        public string GetHolidayName(DateTime date)
        {
            if (date.Month == 1 && date.Day == 1)
            {
                return "Yilbasi";
            }
            else if (date.Month == 4 && date.Day == 23)
            {
                return "Ulusal Egemenlik ve Cocuk Bayrami";
            }
            else if (date.Month == 5 && (date.Day == 1 || date.Day == 2 || date.Day == 3))
            {
                return "Emek ve Dayanisma Gunu";
            }
            else if (date.Month == 5 && date.Day == 19)
            {
                return "Ataturk'u Anma, Genclik ve Spor Bayrami";
            }
            else if (date.Month == 7 && date.Day == 15)
            {
                return "Demokrasi ve Milli Birlik Gunu";
            }
            else if (date.Month == 8 && (date.Day == 30 || date.Day == 31))
            {
                return "Zafer Bayrami";
            }
            else if (date.Month == 10 && date.Day == 29)
            {
                return "Cumhuriyet Bayrami";
            }
            else
            {
                return "";
            }
        }

        public void smsMP(string _telefonNo, string mesajmetni)
        {
            try
            {
                string orginator = "BlockBiss";
                string userName = "5415454434";
                string pass = "5415454434";
                string url = "https://www.mesajpaketi.com/api/mesaj_gonder";
                DateTime STar = DateTime.Now;
                DateTime SSat = DateTime.Now;
                string STarih = STar.ToString("dd-MM-yyyy");
                string SSaat = STar.ToString("HH:mm");

                string smstelefonno = _telefonNo;
                smstelefonno = smstelefonno.Replace("(", "");
                smstelefonno = smstelefonno.Replace(")", "");
                smstelefonno = smstelefonno.Replace("-", "");
                smstelefonno = smstelefonno.Replace("_", "");

                string testXml = "<SingleTextSMS><UserName>" + userName + "</UserName><PassWord>" + pass + "</PassWord><Action>1</Action><Mesgbody>" + mesajmetni + "</Mesgbody><Numbers>" + smstelefonno + "</Numbers><Originator>" + orginator + "</Originator><SDate></SDate></SingleTextSMS>";
                string xmldonen = this.XmlPost(url, "data=" + testXml);
            }
            catch (Exception h)
            {
                string hata = h.Message;
            }
        }

        private string XmlPost(string PostAddress, string xmlData)
        {
            try
            {
                using (WebClient wUpload = new WebClient())
                {
                    wUpload.Proxy = null;
                    ServicePointManager.Expect100Continue = true;
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
                    ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };

                    wUpload.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                    Byte[] bPostArray = Encoding.UTF8.GetBytes(xmlData);
                    Byte[] bResponse = wUpload.UploadData(PostAddress, "POST", bPostArray);
                    Char[] sReturnChars = Encoding.UTF8.GetChars(bResponse);
                    string sWebPage = new string(sReturnChars);
                    return sWebPage;
                }
            }
            catch (Exception h)
            {
                return "-1";
            }
        }
    }
}
