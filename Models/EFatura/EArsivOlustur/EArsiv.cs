using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EArsivOlustur
{
    public class Rootobject
    {
        public bool IsTest { get; set; }
        public Logininfo LoginInfo { get; set; }
        public Suppliercurrent SupplierCurrent { get; set; }
        public string? session_id { get; set; }
        [JsonProperty("$type")]
        public string? type { get; set; }
        public Items items { get; set; }
        public Payments payments { get; set; }
        public Current current { get; set; }
        public Terminal terminal { get; set; }
        public string? Prefix { get; set; }
        public string? invoice_reference_number { get; set; }
        public int branch_id { get; set; }
        public string? branch_code { get; set; }
        public string? branch_description { get; set; }
        public string? description { get; set; }
        public int company_id { get; set; }
        public string? firma { get; set; }
        public string? erp_user_code { get; set; }
        public string? erp_rg_code { get; set; }
        public string? invoice_date { get; set; }
        public string? doc_no { get; set; }
        public string? invoice_guid { get; set; }
        public string? warehouse_code { get; set; }
        public int invoice_type { get; set; }
        public float TotalAmount { get; set; }
        public float ToplamFaturaTutari { get; set; }
        public float discount_on_total { get; set; }
        public string? description_2 { get; set; }
        public string? eInvoiceProfile { get; set; }
        public string? eInvoiceTypeCode { get; set; }
        public object[] InvoiceDispatchs { get; set; }
    }

    public class Logininfo
    {
        public string? InstitutionId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public Alias Alias { get; set; }
    }

    public class Alias
    {
        public string? EArsiv { get; set; }
        public string? EFatura { get; set; }
        public string? EIrsaliye { get; set; }
    }

    public class Suppliercurrent
    {
        public string? tax_number { get; set; }
        public string? tax_office { get; set; }
        public string? title { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public int CurrentType { get; set; }
        public Person Person { get; set; }
    }

    public class Person
    {
        public string? FirstName { get; set; }
        public string? FamilyName { get; set; }
    }

    public class Items
    {
        [JsonProperty("$type")]
        public string? type { get; set; }
        [JsonProperty("$values")]
        public Values[] values { get; set; }
    }

    public class Values
    {
        [JsonProperty("$type")]
        public string? type { get; set; }
        public string? code { get; set; }
        public string? description { get; set; }
        public float quantity { get; set; }
        public string? unit_code { get; set; }
        public float unit_price { get; set; }
        public string? barcode { get; set; }
        public Section section { get; set; }
        public float reduction { get; set; }
        public float total { get; set; }
        public float discount_1 { get; set; }
        public float discount_2 { get; set; }
        public float discount_3 { get; set; }
        public float discount_4 { get; set; }
        public float discount_5 { get; set; }
    }

    public class Section
    {
        [JsonProperty("$type")]
        public string? type { get; set; }
        public string? code { get; set; }
        public int vat_ratio { get; set; }
        public int no { get; set; }
    }

    public class Payments
    {
        [JsonProperty("$type")]
        public string? type { get; set; }
        [JsonProperty("$values")]
        public object[] values { get; set; }
    }

    public class Current
    {
        [JsonProperty("$type")]
        public string? type { get; set; }
        public string? code { get; set; }
        public string? description { get; set; }
        public string? title { get; set; }
        public string? address { get; set; }
        public string? city { get; set; }
        public string? tax_number { get; set; }
        public string? tax_office { get; set; }
        public string? email { get; set; }
        public bool state { get; set; }
        public string? name { get; set; }
        public string? surname { get; set; }
        public bool is_company { get; set; }
    }

    public class Terminal
    {
        public string? code { get; set; }
        public string? description { get; set; }
    }

    public class Result
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public VAL_JARRAY[] VAL_JARRAY { get; set; }
        public string? TypeName { get; set; }
    }

    public class VAL_JARRAY
    {
        public string? headerMessage { get; set; }
        public string? headerResponseCode { get; set; }
        public string? headerStatus { get; set; }
        public DateTime createdAt { get; set; }
        public int? itemReferenceNumber { get; set; }
        public string? itemInvoiceNumber { get; set; }
        public string? itemResponseCode { get; set; }
        public string ItemResponseDescription { get; set; }
        public string? itemResponseStatus { get; set; }
        public string? itemTrackNumber { get; set; }
        public string? itemUUID { get; set; }
        public string? itemViewUrl { get; set; }
    }

}
