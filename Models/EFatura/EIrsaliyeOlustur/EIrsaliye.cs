using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EIrsaliyeOlustur
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Alias
    {
        [JsonProperty("EArsiv", NullValueHandling = NullValueHandling.Ignore)]
        public string? EArsiv { get; set; }

        [JsonProperty("EFatura", NullValueHandling = NullValueHandling.Ignore)]
        public string? EFatura { get; set; }

        [JsonProperty("EIrsaliye", NullValueHandling = NullValueHandling.Ignore)]
        public string? EIrsaliye { get; set; }
    }

    public class Current
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? title { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string? city { get; set; }

        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("email", NullValueHandling = NullValueHandling.Ignore)]
        public string? email { get; set; }

        [JsonProperty("state", NullValueHandling = NullValueHandling.Ignore)]
        public bool? state { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string? name { get; set; }

        [JsonProperty("surname", NullValueHandling = NullValueHandling.Ignore)]
        public string? surname { get; set; }

        [JsonProperty("is_company", NullValueHandling = NullValueHandling.Ignore)]
        public bool? is_company { get; set; }

        [JsonProperty("ReceiverAlias", NullValueHandling = NullValueHandling.Ignore)]
        public string? ReceiverAlias { get; set; }
    }

    public class EDespatchDriver
    {
        [JsonProperty("FirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string? FirstName { get; set; }

        [JsonProperty("FamilyName", NullValueHandling = NullValueHandling.Ignore)]
        public string? FamilyName { get; set; }

        [JsonProperty("NationalityID", NullValueHandling = NullValueHandling.Ignore)]
        public string? NationalityID { get; set; }

        [JsonProperty("PlateID", NullValueHandling = NullValueHandling.Ignore)]
        public string? PlateID { get; set; }
    }

    public class Items
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        [JsonProperty("$values", NullValueHandling = NullValueHandling.Ignore)]
        public List<Value> values { get; set; }
    }

    public class ItemTransactionCarrierAddress
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("company_title", NullValueHandling = NullValueHandling.Ignore)]
        public string? company_title { get; set; }

        [JsonProperty("person_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_name { get; set; }

        [JsonProperty("person_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_surname { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_id { get; set; }

        [JsonProperty("block_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? block_name { get; set; }

        [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_name { get; set; }

        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_number { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_name { get; set; }

        [JsonProperty("city_subdivision_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_subdivision_name { get; set; }

        [JsonProperty("counrty_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? counrty_code { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? country_name { get; set; }

        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string? district { get; set; }

        [JsonProperty("definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? definition_id { get; set; }

        [JsonProperty("postbox", NullValueHandling = NullValueHandling.Ignore)]
        public string? postbox { get; set; }

        [JsonProperty("postal_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string? postal_zone { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string? region { get; set; }

        [JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string? room { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? street_name { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_number_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number_type { get; set; }
    }

    public class ItemTransactionDeliveryAddress
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("company_title", NullValueHandling = NullValueHandling.Ignore)]
        public string? company_title { get; set; }

        [JsonProperty("person_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_name { get; set; }

        [JsonProperty("person_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_surname { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_id { get; set; }

        [JsonProperty("block_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? block_name { get; set; }

        [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_name { get; set; }

        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_number { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_name { get; set; }

        [JsonProperty("city_subdivision_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_subdivision_name { get; set; }

        [JsonProperty("counrty_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? counrty_code { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? country_name { get; set; }

        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string? district { get; set; }

        [JsonProperty("definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? definition_id { get; set; }

        [JsonProperty("postbox", NullValueHandling = NullValueHandling.Ignore)]
        public string? postbox { get; set; }

        [JsonProperty("postal_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string? postal_zone { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string? region { get; set; }

        [JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string? room { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? street_name { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_number_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number_type { get; set; }
    }

    public class ItemTransactionDestinationWarehouseAddress
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("company_title", NullValueHandling = NullValueHandling.Ignore)]
        public string? company_title { get; set; }

        [JsonProperty("person_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_name { get; set; }

        [JsonProperty("person_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_surname { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_id { get; set; }

        [JsonProperty("block_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? block_name { get; set; }

        [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_name { get; set; }

        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_number { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_name { get; set; }

        [JsonProperty("city_subdivision_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_subdivision_name { get; set; }

        [JsonProperty("counrty_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? counrty_code { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? country_name { get; set; }

        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string? district { get; set; }

        [JsonProperty("definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? definition_id { get; set; }

        [JsonProperty("postbox", NullValueHandling = NullValueHandling.Ignore)]
        public string? postbox { get; set; }

        [JsonProperty("postal_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string? postal_zone { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string? region { get; set; }

        [JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string? room { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? street_name { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_number_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number_type { get; set; }
    }

    public class ItemTransactionSourceWarehouseAddress
    {
        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("company_title", NullValueHandling = NullValueHandling.Ignore)]
        public string? company_title { get; set; }

        [JsonProperty("person_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_name { get; set; }

        [JsonProperty("person_surname", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_surname { get; set; }

        [JsonProperty("person_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? person_id { get; set; }

        [JsonProperty("block_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? block_name { get; set; }

        [JsonProperty("building_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_name { get; set; }

        [JsonProperty("building_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? building_number { get; set; }

        [JsonProperty("city_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_name { get; set; }

        [JsonProperty("city_subdivision_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? city_subdivision_name { get; set; }

        [JsonProperty("counrty_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? counrty_code { get; set; }

        [JsonProperty("country_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? country_name { get; set; }

        [JsonProperty("district", NullValueHandling = NullValueHandling.Ignore)]
        public string? district { get; set; }

        [JsonProperty("definition_id", NullValueHandling = NullValueHandling.Ignore)]
        public string? definition_id { get; set; }

        [JsonProperty("postbox", NullValueHandling = NullValueHandling.Ignore)]
        public string? postbox { get; set; }

        [JsonProperty("postal_zone", NullValueHandling = NullValueHandling.Ignore)]
        public string? postal_zone { get; set; }

        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string? region { get; set; }

        [JsonProperty("room", NullValueHandling = NullValueHandling.Ignore)]
        public string? room { get; set; }

        [JsonProperty("street_name", NullValueHandling = NullValueHandling.Ignore)]
        public string? street_name { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_number_type", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number_type { get; set; }
    }

    public class LoginInfo
    {
        [JsonProperty("InstitutionId", NullValueHandling = NullValueHandling.Ignore)]
        public string? InstitutionId { get; set; }

        [JsonProperty("Username", NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; }

        [JsonProperty("Password", NullValueHandling = NullValueHandling.Ignore)]
        public string? Password { get; set; }

        [JsonProperty("Alias", NullValueHandling = NullValueHandling.Ignore)]
        public Alias Alias { get; set; }
    }

    public class Payments
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        //[JsonProperty("$values", NullValueHandling = NullValueHandling.Ignore)]
        //public List<object> values { get; set; }

        [JsonProperty("$values", NullValueHandling = NullValueHandling.Ignore)]
        public object[] values { get; set; }
    }

    public class Person
    {
        [JsonProperty("FirstName", NullValueHandling = NullValueHandling.Ignore)]
        public string? FirstName { get; set; }

        [JsonProperty("FamilyName", NullValueHandling = NullValueHandling.Ignore)]
        public string? FamilyName { get; set; }
    }

    public class Rootobject
    {
        [JsonProperty("IsTest", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTest { get; set; }

        [JsonProperty("LoginInfo", NullValueHandling = NullValueHandling.Ignore)]
        public LoginInfo LoginInfo { get; set; }

        [JsonProperty("SupplierCurrent", NullValueHandling = NullValueHandling.Ignore)]
        public SupplierCurrent SupplierCurrent { get; set; }

        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public Items items { get; set; }

        [JsonProperty("payments", NullValueHandling = NullValueHandling.Ignore)]
        public Payments payments { get; set; }

        [JsonProperty("current", NullValueHandling = NullValueHandling.Ignore)]
        public Current current { get; set; }

        [JsonProperty("branch_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? branch_id { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("branch_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? branch_code { get; set; }

        [JsonProperty("branch_description", NullValueHandling = NullValueHandling.Ignore)]
        public string? branch_description { get; set; }

        [JsonProperty("company_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? company_id { get; set; }

        [JsonProperty("firma", NullValueHandling = NullValueHandling.Ignore)]
        public string? firma { get; set; }

        [JsonProperty("invoice_date", NullValueHandling = NullValueHandling.Ignore)]
        public DateTime? invoice_date { get; set; }

        [JsonProperty("doc_no", NullValueHandling = NullValueHandling.Ignore)]
        public string? doc_no { get; set; }

        [JsonProperty("warehouse_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? warehouse_code { get; set; }

        [JsonProperty("invoice_type", NullValueHandling = NullValueHandling.Ignore)]
        public int? invoice_type { get; set; }

        [JsonProperty("TotalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public double? TotalAmount { get; set; }

        [JsonProperty("ToplamFaturaTutari", NullValueHandling = NullValueHandling.Ignore)]
        public double? ToplamFaturaTutari { get; set; }

        [JsonProperty("Prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string? Prefix { get; set; }

        [JsonProperty("invoice_guid", NullValueHandling = NullValueHandling.Ignore)]
        public string? invoice_guid { get; set; }

        [JsonProperty("eDespatchDriver", NullValueHandling = NullValueHandling.Ignore)]
        public EDespatchDriver eDespatchDriver { get; set; }

        [JsonProperty("item_transaction_carrier_address", NullValueHandling = NullValueHandling.Ignore)]
        public ItemTransactionCarrierAddress item_transaction_carrier_address { get; set; }

        [JsonProperty("item_transaction_delivery_address", NullValueHandling = NullValueHandling.Ignore)]
        public ItemTransactionDeliveryAddress item_transaction_delivery_address { get; set; }

        [JsonProperty("item_transaction_source_warehouse_address", NullValueHandling = NullValueHandling.Ignore)]
        public ItemTransactionSourceWarehouseAddress item_transaction_source_warehouse_address { get; set; }

        [JsonProperty("item_transaction_destination_warehouse_address", NullValueHandling = NullValueHandling.Ignore)]
        public ItemTransactionDestinationWarehouseAddress item_transaction_destination_warehouse_address { get; set; }
    }

    public class Section
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("vat_ratio", NullValueHandling = NullValueHandling.Ignore)]
        public int? vat_ratio { get; set; }

        [JsonProperty("no", NullValueHandling = NullValueHandling.Ignore)]
        public int? no { get; set; }
    }

    public class SupplierCurrent
    {
        [JsonProperty("tax_number", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_number { get; set; }

        [JsonProperty("tax_office", NullValueHandling = NullValueHandling.Ignore)]
        public string? tax_office { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string? title { get; set; }

        [JsonProperty("address", NullValueHandling = NullValueHandling.Ignore)]
        public string? address { get; set; }

        [JsonProperty("city", NullValueHandling = NullValueHandling.Ignore)]
        public string? city { get; set; }

        [JsonProperty("CurrentType", NullValueHandling = NullValueHandling.Ignore)]
        public int? CurrentType { get; set; }

        [JsonProperty("Person", NullValueHandling = NullValueHandling.Ignore)]
        public Person Person { get; set; }
    }

    public class Value
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore)]
        public string? type { get; set; }

        [JsonProperty("code", NullValueHandling = NullValueHandling.Ignore)]
        public string? code { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string? description { get; set; }

        [JsonProperty("quantity", NullValueHandling = NullValueHandling.Ignore)]
        public double? quantity { get; set; }

        [JsonProperty("unit_code", NullValueHandling = NullValueHandling.Ignore)]
        public string? unit_code { get; set; }

        [JsonProperty("unit_price", NullValueHandling = NullValueHandling.Ignore)]
        public double? unit_price { get; set; }

        [JsonProperty("barcode", NullValueHandling = NullValueHandling.Ignore)]
        public string? barcode { get; set; }

        [JsonProperty("section", NullValueHandling = NullValueHandling.Ignore)]
        public Section section { get; set; }

        [JsonProperty("reduction", NullValueHandling = NullValueHandling.Ignore)]
        public double? reduction { get; set; }
    }


}
