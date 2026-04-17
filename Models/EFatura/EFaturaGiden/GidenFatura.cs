using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EFaturaGiden
{
    public class Rootobject
    {
        public bool STATE { get; set; }
        public string? CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public PARAMS PARAMS { get; set; }
    }

    public class PARAMS
    {
        public Flow Flow { get; set; }
        public Node Node { get; set; }
        public Result Result { get; set; }
    }

    public class Flow
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public string? VAL_STRING { get; set; }
        public string? TypeName { get; set; }
    }

    public class Node
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public string? VAL_STRING { get; set; }
        public string? TypeName { get; set; }
    }

    public class Result
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public VAL_JOBJECT VAL_JOBJECT { get; set; }
        public string? TypeName { get; set; }
    }

    public class VAL_JOBJECT
    {
        public Header Header { get; set; }
        public Item Item { get; set; }
    }

    public class Header
    {
        public string? Message { get; set; }
        public string? ResponseCode { get; set; }
        public string? Status { get; set; }
    }

    public class Item
    {
        
        public string? DespatchAdviceNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public int? ReferenceNumber { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public string? ResponseStatus { get; set; }
        public string? TrackNumber { get; set; }
        public string? UUID { get; set; }
        public string? ViewUrl { get; set; }
    }


    //Database
    public class GidenEFaturalar
    {
        public int Id { get; set; }

        public string? headerMessage { get; set; }

        public string? headerResponseCode { get; set; }

        public string? headerStatus { get; set; }

        public int? invoiceId { get; set; }

        public int? invoiceType { get; set; }

        public string? invoiceDescription { get; set; }

        public DateTime createdAt { get; set; }

        public DateTime invoiceDate { get; set; }

        public int? itemReferenceNumber { get; set; }

        public string? itemInvoiceNumber { get; set; }

        public string? itemResponseCode { get; set; }

        public string ItemResponseDescription { get; set; }

        public string? itemResponseStatus { get; set; }

        public string? OnayDurumu { get; set; }

        [Column("InvoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [Column("InvoiceStatusDescription")] 
        public string? InvoiceStatusDescription { get; set; }

        [Column("EnvelopeStatus")]
        public string? ZarfDurumu { get; set; }

        [Column("EnvelopeStatusDescription")]
        public string? ZarfDurumAciklama { get; set; }

        public string? itemTrackNumber { get; set; }

        public string? itemUUID { get; set; }

        public string? itemViewUrl { get; set; }
    }

    public class GidenEFaturalarView
    {
        public int Id { get; set; }

        [NotMapped]
        public bool Sec { get; set; }

        public string? headerMessage { get; set; }

        public string? headerResponseCode { get; set; }

        public string? headerStatus { get; set; }

        public DateTime createdAt { get; set; }

        [Column("invoiceId")]
        public int? FaturaId { get; set; }

        [Column("createdAtTime")]
        public DateTime OlusturmaTarihi { get; set; }

        [Column("invoiceType")]
        public int? FaturaTipi { get; set; }

        [Column("invoiceDescription")]
        public string? FaturaAciklama { get; set; }

        [Column("invoiceDate")]
        public DateTime FaturaTarihi { get; set; }

        public int? itemReferenceNumber { get; set; }

        [Column("itemInvoiceNumber")]
        public string? FaturaNo { get; set; }

        public string? CariKodu { get; set; }

        [Column("Unvani")]
        public string? CariUnvani { get; set; }

        public string? itemResponseCode { get; set; }

        [Column("itemResponseStatus")]
        public string? GonderiDurumu { get; set; }

        public string? itemTrackNumber { get; set; }

        [Column("itemUUID")]
        public string? FaturaETTN { get; set; }

        [Column("ItemResponseDescription")]
        public string? GonderiDurumAciklama { get; set; }

        public string? OnayDurumu { get; set; }

        [Column("InvoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [Column("InvoiceStatusDescription")]
        public string? OnayRedDurumu { get; set; }

        [Column("EnvelopeStatus")]
        public string? ZarfDurumu { get; set; }

        [Column("EnvelopeStatusDescription")]
        public string? ZarfDurumAciklama { get; set; }

        [Column("itemViewUrl")]
        public string? FaturaUrl { get; set; }
    }

    public class GidenEIrsaliyelerView
    {
        public int Id { get; set; }

        public string? headerMessage { get; set; }

        public string? headerResponseCode { get; set; }

        public string? headerStatus { get; set; }

        public DateTime createdAt { get; set; }

        [Column("invoiceId")]
        public int? FaturaId { get; set; }

        [Column("createdAtTime")]
        public DateTime OlusturmaTarihi { get; set; }

        [Column("invoiceType")]
        public int? FaturaTipi { get; set; }

        [Column("invoiceDescription")]
        public string? FaturaAciklama { get; set; }

        [Column("invoiceDate")]
        public DateTime FaturaTarihi { get; set; }

        public int? itemReferenceNumber { get; set; }

        [Column("itemInvoiceNumber")]
        public string? FaturaNo { get; set; }

        public string? CariKodu { get; set; }

        [Column("Unvani")]
        public string? CariUnvani { get; set; }

        public string? itemResponseCode { get; set; }

        [Column("itemResponseStatus")]
        public string? GonderiDurumu { get; set; }

        public string? itemTrackNumber { get; set; }

        [Column("itemUUID")]
        public string? FaturaETTN { get; set; }

        [Column("ItemResponseDescription")]
        public string? DurumAciklama { get; set; }

        [Column("itemViewUrl")]
        public string? FaturaUrl { get; set; }
    }

    public class GidenFaturaKontrolView
    {
        public int Id { get; set; }

        public DateTime createdAt { get; set; }

        [Column("createdAtTime")]
        public DateTime OlusturmaTarihi { get; set; }
        
        [Column("invoiceDate")]
        public DateTime FaturaTarihi { get; set; }

        public int? itemReferenceNumber { get; set; }

        [Column("itemInvoiceNumber")]
        public string? FaturaNo { get; set; }

        [Column("Unvani")]
        public string? CariUnvani { get; set; }

        public string? itemResponseCode { get; set; }

        [Column("itemResponseStatus")]
        public string? GonderiDurumu { get; set; }

        public string? itemTrackNumber { get; set; }

        [Column("itemUUID")]
        public string? FaturaETTN { get; set; }

        [Column("InvoiceStatus")]
        public string? InvoiceStatus { get; set; }

        [Column("InvoiceStatusDescription")]
        public string? OnayRedDurumu { get; set; }

        [Column("EnvelopeStatus")]
        public string? ZarfDurumu { get; set; }
    }
}
