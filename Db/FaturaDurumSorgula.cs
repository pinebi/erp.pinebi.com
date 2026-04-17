using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Db
{
    public class FaturaDurumSorgula
    {
        private readonly SistemAyarlari _clas;
        private readonly FirmaContext _firmaDb;

        public FaturaDurumSorgula(SistemAyarlari clas, FirmaContext firmaDb)
        {
            _clas = clas;
            _firmaDb = firmaDb;
        }

        public async Task FaturalarAsync()
        {
            _clas.Ayarlar();
            var liste = _firmaDb.GidenFaturaKontrolView.ToList();
            if (liste != null)
            {
                foreach (var item in liste)
                {
                    string[] veri = DurumSorgula(item.itemReferenceNumber.ToString(), item.FaturaETTN);
                    if (veri[2] == "1" || veri[2] == "2")
                    {
                        string kime = "sezai.ucan@obrsbilet.com";
                        string konu = "Ulasmayan fatura bildirimi";
                        string aciklama = item.FaturaTarihi + " tarihli " + item.CariUnvani + " firmasina kesilen " + item.FaturaNo + " nolu fatura durumu:" + Environment.NewLine +
                            "Aciklama    :" + veri[3] + Environment.NewLine + veri[5];

                        _clas.MailGonder(kime, konu, aciklama, "", 0);
                    }
                }
            }
        }

        public string[] DurumSorgula(string referenceNumber, string ETTN)
        {
            // TODO: innovaTest WCF service reference is not available in Blazor Web project.
            // This method needs to be reimplemented using REST API or gRPC.
            /*
            innovaTest.InvoiceInquiryRequest invoicesRequest = new innovaTest.InvoiceInquiryRequest()
            {
                Header = new innovaTest.RequestHeader()
                {
                    InstitutionId = _clas.apiInstitutionId,
                    InstitutionIdSpecified = true,
                    Username = _clas.apiKullaniciAdi,
                    Password = _clas.apiKullaniciSifresi
                },

                ReferenceNumber = Convert.ToInt64(referenceNumber),
                ReferenceNumberSpecified = true,
                TrackNumber = ETTN
            };

            var servis = new innovaTest.ClientInterfaceService();
            servis.Timeout = -1;
            var response = servis.InvoiceInquiry(invoicesRequest);
            var msgStatus = response.Header.Status;
            var msgHeaderKod = response.Header.ResponseCode;

            var invoiceNumber = response.InvoiceNumber;
            var invoiceGuid = response.UUID;
            var InvoiceStatus = response.InvoiceStatus;
            var invoiceStatusDescription = response.InvoiceStatusDescription;

            var zarfDurumu = response.EnvelopeStatus;
            var zarfDurumAciklama = response.EnvelopeStatusDescription;

            return new[] { invoiceNumber, invoiceGuid, InvoiceStatus.ToString(), invoiceStatusDescription, zarfDurumu.ToString(), zarfDurumAciklama };
            */
            return new[] { "", "", "0", "", "0", "" };
        }
    }
}
