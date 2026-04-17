using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.eFat
{
    public partial class Temperatures
    {
        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? State { get; set; }

        [JsonProperty("PARAMS", NullValueHandling = NullValueHandling.Ignore)]
        public TemperaturesParams Params { get; set; }
    }

    public partial class TemperaturesParams
    {
        [JsonProperty("Params", NullValueHandling = NullValueHandling.Ignore)]
        public Params Params { get; set; }
    }

    public partial class Params
    {
        [JsonProperty("ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("CODE", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Code { get; set; }

        [JsonProperty("VAL_L_CLS25", NullValueHandling = NullValueHandling.Ignore)]
        public ValLCls25[] ValLCls25 { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TypeName { get; set; }
    }

    public partial class ValLCls25
    {
        [JsonProperty("FIELD_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic FieldName { get; set; }

        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? State { get; set; }

        [JsonProperty("PARAM", NullValueHandling = NullValueHandling.Ignore)]
        public Param Param { get; set; }
    }

    public partial class Param
    {
        [JsonProperty("VAL_CLS_RETURN", NullValueHandling = NullValueHandling.Ignore)]
        public ValClsReturn ValClsReturn { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TypeName { get; set; }
    }

    public partial class ValClsReturn
    {
        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public bool? State { get; set; }

        [JsonProperty("PARAMS", NullValueHandling = NullValueHandling.Ignore)]
        public ValClsReturnParams Params { get; set; }
    }

    public partial class ValClsReturnParams
    {
        [JsonProperty("Result", NullValueHandling = NullValueHandling.Ignore)]
        public Result Result { get; set; }
    }

    public partial class Result
    {
        [JsonProperty("ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public long? Order { get; set; }

        [JsonProperty("CODE", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Code { get; set; }

        [JsonProperty("VAL_JOBJECT", NullValueHandling = NullValueHandling.Ignore)]
        public ValJobject ValJobject { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic TypeName { get; set; }
    }

    public partial class ValJobject
    {
        [JsonProperty("s:Envelope", NullValueHandling = NullValueHandling.Ignore)]
        public SEnvelope SEnvelope { get; set; }
    }

    public partial class SEnvelope
    {
        [JsonProperty("@xmlns:s", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsS { get; set; }

        [JsonProperty("s:Body", NullValueHandling = NullValueHandling.Ignore)]
        public SBody SBody { get; set; }
    }

    public partial class SBody
    {
        [JsonProperty("GetInvoicesResponse", NullValueHandling = NullValueHandling.Ignore)]
        public GetInvoicesResponse GetInvoicesResponse { get; set; }
    }

    public partial class GetInvoicesResponse
    {
        [JsonProperty("@xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Xmlns { get; set; }

        [JsonProperty("GetInvoicesResult", NullValueHandling = NullValueHandling.Ignore)]
        public GetInvoicesResult GetInvoicesResult { get; set; }
    }

    public partial class GetInvoicesResult
    {
        [JsonProperty("@xmlns:a", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsA { get; set; }

        [JsonProperty("@xmlns:i", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsI { get; set; }

        [JsonProperty("Header", NullValueHandling = NullValueHandling.Ignore)]
        public Header Header { get; set; }

        [JsonProperty("a:Invoices", NullValueHandling = NullValueHandling.Ignore)]
        public AInvoices AInvoices { get; set; }

        [JsonProperty("a:RemainedInvoiceCount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ARemainedInvoiceCount { get; set; }
    }

    public partial class AInvoices
    {
        [JsonProperty("a:IncomingInvoice", NullValueHandling = NullValueHandling.Ignore)]
        public AIncomingInvoice[] AIncomingInvoice { get; set; }
    }

    public partial class AIncomingInvoice
    {
        [JsonProperty("a:Body", NullValueHandling = NullValueHandling.Ignore)]
        public ABody ABody { get; set; }

        [JsonProperty("a:Header", NullValueHandling = NullValueHandling.Ignore)]
        public AHeader AHeader { get; set; }

        [JsonProperty("a:ViewContent", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic dynamic { get; set; }
    }

    public partial class ABody
    {
        [JsonProperty("@xmlns:b", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsB { get; set; }

        [JsonProperty("b:AccountingCost", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAccountingCost { get; set; }

        [JsonProperty("b:AccountingCustomerParty", NullValueHandling = NullValueHandling.Ignore)]
        public BAccountingCustomerParty BAccountingCustomerParty { get; set; }

        [JsonProperty("b:AccountingSupplierParty", NullValueHandling = NullValueHandling.Ignore)]
        public BAccountingSupplierParty BAccountingSupplierParty { get; set; }

        [JsonProperty("b:AdditionalDocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        public BAdditionalDocumentReference BAdditionalDocumentReference { get; set; }

        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBAllowanceCharge BAllowanceCharge { get; set; }

        [JsonProperty("b:AllowanceCharges", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBAllowanceCharges BAllowanceCharges { get; set; }

        [JsonProperty("b:BillingReference")]
        public object BBillingReference { get; set; }

        [JsonProperty("b:BuyerCustomerParty", NullValueHandling = NullValueHandling.Ignore)]
        public BBuyerCustomerParty BBuyerCustomerParty { get; set; }

        [JsonProperty("b:ContractDocumentReference")]
        public object BContractDocumentReference { get; set; }

        [JsonProperty("b:CopyIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCopyIndicator { get; set; }

        [JsonProperty("b:Delivery")]
        public object BDelivery { get; set; }

        [JsonProperty("b:DespatchDocumentReference")]
        public object BDespatchDocumentReference { get; set; }

        [JsonProperty("b:DocumentCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDocumentCurrencyCode { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:InvoiceLine", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBInvoiceLine BInvoiceLine { get; set; }

        [JsonProperty("b:InvoicePeriod", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BInvoicePeriod { get; set; }

        [JsonProperty("b:InvoiceTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BInvoiceTypeCode { get; set; }

        [JsonProperty("b:IssueDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BIssueDateTime { get; set; }

        [JsonProperty("b:LegalMonetaryTotal", NullValueHandling = NullValueHandling.Ignore)]
        public BLegalMonetaryTotal BLegalMonetaryTotal { get; set; }

        [JsonProperty("b:Notes", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBNotes BNotes { get; set; }

        [JsonProperty("b:OrderReference", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOrderReference { get; set; }

        [JsonProperty("b:OriginatorDocumentReference")]
        public object BOriginatorDocumentReference { get; set; }

        [JsonProperty("b:PaymentAlternativeCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentAlternativeCurrencyCode { get; set; }

        [JsonProperty("b:PaymentAlternativeExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentAlternativeExchangeRate { get; set; }

        [JsonProperty("b:PaymentCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentCurrencyCode { get; set; }

        [JsonProperty("b:PaymentExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentExchangeRate { get; set; }

        [JsonProperty("b:PaymentMeans", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBPaymentMeans BPaymentMeans { get; set; }

        [JsonProperty("b:PaymentTerms", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentTerms { get; set; }

        [JsonProperty("b:PricingCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPricingCurrencyCode { get; set; }

        [JsonProperty("b:PricingExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPricingExchangeRate { get; set; }

        [JsonProperty("b:ProfileID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BProfileId { get; set; }

        [JsonProperty("b:ReceiptDocumentReference")]
        public object BReceiptDocumentReference { get; set; }

        [JsonProperty("b:SellerSupplierParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSellerSupplierParty { get; set; }

        [JsonProperty("b:TaxCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxCurrencyCode { get; set; }

        [JsonProperty("b:TaxExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxExchangeRate { get; set; }

        [JsonProperty("b:TaxRepresentativeParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxRepresentativeParty { get; set; }

        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBTaxTotal BTaxTotal { get; set; }

        [JsonProperty("b:UUID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BUuid { get; set; }

        [JsonProperty("b:WithholdingTaxTotal")]
        public object BWithholdingTaxTotal { get; set; }
    }

    //public partial class dynamic
    //{
    //    [JsonProperty("@i:nil", NullValueHandling = NullValueHandling.Ignore)]
    //    public dynamic INil { get; set; }
    //}

    public partial class BAccountingCustomerParty
    {
        [JsonProperty("b:DespatchContact", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDespatchContact { get; set; }

        [JsonProperty("b:Party", NullValueHandling = NullValueHandling.Ignore)]
        public BAccountingCustomerPartyBParty BParty { get; set; }
    }

    public partial class BAccountingCustomerPartyBParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public BPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleBPostalAddress BPostalAddress { get; set; }

        //[JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BWebsiteUri { get; set; }
    }

    public partial class PurpleBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelephone { get; set; }
    }

    public partial class BPartyBPartyIdentifications
    {
        [JsonProperty("b:PartyIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public BPartyIdentification[] BPartyIdentification { get; set; }
    }

    public partial class BPartyIdentification
    {
        [JsonProperty("b:SchemeID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSchemeId { get; set; }

        [JsonProperty("b:Value", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BValue { get; set; }
    }

    public partial class PurpleBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBuildingName { get; set; }

        //[JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCityName { get; set; }

        //[JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public BCountry BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPostBox { get; set; }

        //[JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BPostalZone { get; set; }

        //[JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BStreetName { get; set; }
    }

    public partial class BCountry
    {
        [JsonProperty("b:IdentificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BIdentificationCode { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BName { get; set; }
    }

    public partial class BAccountingSupplierParty
    {
        [JsonProperty("b:DespatchContact", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDespatchContact { get; set; }

        [JsonProperty("b:Party", NullValueHandling = NullValueHandling.Ignore)]
        public BAccountingSupplierPartyBParty BParty { get; set; }
    }

    public partial class BAccountingSupplierPartyBParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public BPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyBPostalAddress BPostalAddress { get; set; }

        //[JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BWebsiteUri { get; set; }
    }

    public partial class FluffyBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelephone { get; set; }
    }

    public partial class FluffyBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBuildingName { get; set; }

        //[JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCityName { get; set; }

        [JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public BCountry BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPostBox { get; set; }

        //[JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BPostalZone { get; set; }

        //[JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BStreetName { get; set; }
    }

    public partial class BAdditionalDocumentReference
    {
        //[JsonProperty("b:DocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        //public BDocumentReference BDocumentReference { get; set; }
    }

    public partial class BDocumentReference
    {
        [JsonProperty("b:Attachment", NullValueHandling = NullValueHandling.Ignore)]
        public BAttachment BAttachment { get; set; }

        [JsonProperty("b:DocumentDescription", NullValueHandling = NullValueHandling.Ignore)]
        public BDocumentDescription BDocumentDescription { get; set; }

        [JsonProperty("b:DocumentType", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDocumentType { get; set; }

        [JsonProperty("b:DocumentTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDocumentTypeCode { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:IssueDate", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BIssueDate { get; set; }

        [JsonProperty("b:IssuerParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BIssuerParty { get; set; }

        [JsonProperty("b:ValidityPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BValidityPeriod { get; set; }
    }

    public partial class BAttachment
    {
        [JsonProperty("b:EmbeddedDocumentBinaryObject", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BEmbeddedDocumentBinaryObject { get; set; }

        [JsonProperty("b:ExternalReference", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BExternalReference { get; set; }

        [JsonProperty("b:FileName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BFileName { get; set; }

        [JsonProperty("b:MimeCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BMimeCode { get; set; }
    }

    public partial class BDocumentDescription
    {
        [JsonProperty("@xmlns:c", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsC { get; set; }
    }

    public partial class ABodyBAllowanceCharge
    {
        [JsonProperty("b:AllowanceChargeReason", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAllowanceChargeReason { get; set; }

        [JsonProperty("b:Amount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BAmount { get; set; }

        [JsonProperty("b:BaseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBaseAmount { get; set; }

        [JsonProperty("b:ChargeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BChargeIndicator { get; set; }

        [JsonProperty("b:MultiplierFactorNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BMultiplierFactorNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:SequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSequenceNumeric { get; set; }
    }

    public partial class BAmount
    {
        [JsonProperty("b:CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCurrencyCode { get; set; }

        [JsonProperty("b:Value", NullValueHandling = NullValueHandling.Ignore)]
        public double BValue { get; set; }
    }

    public partial class ABodyBAllowanceCharges
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public ABodyBAllowanceCharge BAllowanceCharge { get; set; }
    }

    public partial class BBuyerCustomerParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public BBuyerCustomerPartyBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public BBuyerCustomerPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public BBuyerCustomerPartyBPostalAddress BPostalAddress { get; set; }

        //[JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BWebsiteUri { get; set; }
    }

    public partial class BBuyerCustomerPartyBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTelephone { get; set; }
    }

    public partial class BBuyerCustomerPartyBPartyIdentifications
    {
        [JsonProperty("b:PartyIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public BPartyIdentification BPartyIdentification { get; set; }
    }

    public partial class BBuyerCustomerPartyBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBuildingName { get; set; }

        //[JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCityName { get; set; }

        //[JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public BCountry BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPostBox { get; set; }

        //[JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BPostalZone { get; set; }

        //[JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BStreetName { get; set; }
    }

    public partial class ABodyBInvoiceLine
    {
        [JsonProperty("b:InvoiceLine", NullValueHandling = NullValueHandling.Ignore)]
        public BInvoiceLineElement[] BInvoiceLine { get; set; }
    }

    public partial class BInvoiceLineElement
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public BInvoiceLineBAllowanceCharge BAllowanceCharge { get; set; }

        [JsonProperty("b:AllowanceCharges")]
        public BInvoiceLineBAllowanceCharges BAllowanceCharges { get; set; }

        [JsonProperty("b:Delivery")]
        public object BDelivery { get; set; }

        [JsonProperty("b:DespatchLineReference")]
        public object BDespatchLineReference { get; set; }

        [JsonProperty("b:InvoicedQuantityUnitCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BInvoicedQuantityUnitCode { get; set; }

        [JsonProperty("b:InvoicedQuantityValue", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BInvoicedQuantityValue { get; set; }

        [JsonProperty("b:Item", NullValueHandling = NullValueHandling.Ignore)]
        public BItem BItem { get; set; }

        [JsonProperty("b:LineExtensionAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BLineExtensionAmount { get; set; }

        //[JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic BNote { get; set; }

        [JsonProperty("b:Notes", NullValueHandling = NullValueHandling.Ignore)]
        public BInvoiceLineBNotes BNotes { get; set; }

        [JsonProperty("b:OrderLineReference")]
        public object BOrderLineReference { get; set; }

        [JsonProperty("b:Price", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BPrice { get; set; }

        [JsonProperty("b:ReceiptLineReference")]
        public object BReceiptLineReference { get; set; }

        [JsonProperty("b:SubInvoiceLine")]
        public object BSubInvoiceLine { get; set; }

        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public BInvoiceLineBTaxTotal BTaxTotal { get; set; }

        [JsonProperty("b:WithholdingTaxTotal")]
        public object BWithholdingTaxTotal { get; set; }
    }

    public partial class BInvoiceLineBAllowanceCharge
    {
        [JsonProperty("@i:nil", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic INil { get; set; }

        [JsonProperty("b:AllowanceChargeReason", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAllowanceChargeReason { get; set; }

        [JsonProperty("b:Amount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BAmount { get; set; }

        [JsonProperty("b:BaseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BBaseAmount { get; set; }

        [JsonProperty("b:ChargeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BChargeIndicator { get; set; }

        [JsonProperty("b:MultiplierFactorNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BMultiplierFactorNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:SequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSequenceNumeric { get; set; }
    }

    public partial class BInvoiceLineBAllowanceCharges
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleBAllowanceCharge BAllowanceCharge { get; set; }
    }

    public partial class PurpleBAllowanceCharge
    {
        [JsonProperty("b:AllowanceChargeReason", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BAllowanceChargeReason { get; set; }

        [JsonProperty("b:Amount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BAmount { get; set; }

        [JsonProperty("b:BaseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BBaseAmount { get; set; }

        [JsonProperty("b:ChargeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BChargeIndicator { get; set; }

        [JsonProperty("b:MultiplierFactorNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BMultiplierFactorNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:SequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSequenceNumeric { get; set; }
    }

    public partial class BItem
    {
        [JsonProperty("b:AdditionalItemIdentifications")]
        public object BAdditionalItemIdentifications { get; set; }

        [JsonProperty("b:BrandName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBrandName { get; set; }

        [JsonProperty("b:BuyersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBuyersItemIdentification { get; set; }

        [JsonProperty("b:CommodityClassification")]
        public object BCommodityClassification { get; set; }

        [JsonProperty("b:CommodityClassificationCodes", NullValueHandling = NullValueHandling.Ignore)]
        public BDocumentDescription BCommodityClassificationCodes { get; set; }

        [JsonProperty("b:Description", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BDescription { get; set; }

        [JsonProperty("b:ItemClassificationCode")]
        public object BItemClassificationCode { get; set; }

        [JsonProperty("b:ManufacturersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BManufacturersItemIdentification { get; set; }

        [JsonProperty("b:ModelName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BModelName { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BName { get; set; }

        [JsonProperty("b:OriginCountry", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOriginCountry { get; set; }

        [JsonProperty("b:ProductTraceID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BProductTraceId { get; set; }

        [JsonProperty("b:SellersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSellersItemIdentification { get; set; }

        [JsonProperty("b:SerialID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSerialId { get; set; }
    }

    public partial class BInvoiceLineBNotes
    {
        [JsonProperty("@xmlns:c", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsC { get; set; }

        //[JsonProperty("c:string", NullValueHandling = NullValueHandling.Ignore)]
        //public dynamic[] CString { get; set; }
    }

    public partial class BInvoiceLineBTaxTotal
    {
        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleBTaxSubtotal BTaxSubtotal { get; set; }
    }

    public partial class PurpleBTaxSubtotal
    {
        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public BTaxSubtotalElement BTaxSubtotal { get; set; }
    }

    public partial class BTaxSubtotalElement
    {
        [JsonProperty("b:BaseUnitMeasure", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBaseUnitMeasure { get; set; }

        [JsonProperty("b:BaseUnitMeasureCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BBaseUnitMeasureCode { get; set; }

        [JsonProperty("b:CalculationSequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCalculationSequenceNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:Percent", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPercent { get; set; }

        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxCategoryExemptionReason", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxCategoryExemptionReason { get; set; }

        [JsonProperty("b:TaxCategoryExemptionReasonCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxCategoryExemptionReasonCode { get; set; }

        [JsonProperty("b:TaxCategorySchemeCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxCategorySchemeCode { get; set; }

        [JsonProperty("b:TaxCategorySchemeName", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTaxCategorySchemeName { get; set; }

        [JsonProperty("b:TaxableAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxableAmount { get; set; }

        [JsonProperty("b:TransactionCurrencyTaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BTransactionCurrencyTaxAmount { get; set; }
    }

    public partial class BLegalMonetaryTotal
    {
        [JsonProperty("b:AllowanceTotalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BAllowanceTotalAmount { get; set; }

        [JsonProperty("b:ChargeTotalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BChargeTotalAmount { get; set; }

        [JsonProperty("b:LineExtensionAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BLineExtensionAmount { get; set; }

        [JsonProperty("b:PayableAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BPayableAmount { get; set; }

        [JsonProperty("b:PayableRoundingAmount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPayableRoundingAmount { get; set; }

        [JsonProperty("b:TaxExclusiveAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxExclusiveAmount { get; set; }

        [JsonProperty("b:TaxInclusiveAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxInclusiveAmount { get; set; }
    }

    public partial class ABodyBNotes
    {
        [JsonProperty("@xmlns:c", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsC { get; set; }

        [JsonProperty("c:string", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic[] CString { get; set; }
    }

    public partial class ABodyBPaymentMeans
    {
        [JsonProperty("b:PaymentMeans", NullValueHandling = NullValueHandling.Ignore)]
        public BPaymentMeansBPaymentMeans BPaymentMeans { get; set; }
    }

    public partial class BPaymentMeansBPaymentMeans
    {
        [JsonProperty("b:InstructionNote", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BInstructionNote { get; set; }

        [JsonProperty("b:PayeeFinancialAccount", NullValueHandling = NullValueHandling.Ignore)]
        public BPayeeFinancialAccount BPayeeFinancialAccount { get; set; }

        [JsonProperty("b:PayerFinancialAccount", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPayerFinancialAccount { get; set; }

        [JsonProperty("b:PaymentChannelCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentChannelCode { get; set; }

        [JsonProperty("b:PaymentDueDate", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentDueDate { get; set; }

        [JsonProperty("b:PaymentMeansCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentMeansCode { get; set; }
    }

    public partial class BPayeeFinancialAccount
    {
        [JsonProperty("b:CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BCurrencyCode { get; set; }

        [JsonProperty("b:FinancialInstitutionBranch", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BFinancialInstitutionBranch { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BId { get; set; }

        [JsonProperty("b:PaymentNote", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BPaymentNote { get; set; }
    }

    public partial class ABodyBTaxTotal
    {
        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public BTaxTotalBTaxTotal BTaxTotal { get; set; }
    }

    public partial class BTaxTotalBTaxTotal
    {
        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyBTaxSubtotal BTaxSubtotal { get; set; }
    }

    public partial class FluffyBTaxSubtotal
    {
        //[JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        //public BTaxSubtotalElement[] BTaxSubtotal { get; set; }
    }

    public partial class AHeader
    {
        [JsonProperty("@xmlns:b", NullValueHandling = NullValueHandling.Ignore)]
        public Uri XmlnsB { get; set; }

        [JsonProperty("b:HashValue", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BHashValue { get; set; }

        [JsonProperty("b:OperationDirectionType", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BOperationDirectionType { get; set; }

        [JsonProperty("b:ReceiveDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BReceiveDateTime { get; set; }

        [JsonProperty("b:ReceiverAlias", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BReceiverAlias { get; set; }

        [JsonProperty("b:ReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BReferenceNumber { get; set; }

        [JsonProperty("b:SenderAlias", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSenderAlias { get; set; }

        [JsonProperty("b:SenderIdentityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic BSenderIdentityNumber { get; set; }

        [JsonProperty("b:ViewUrl", NullValueHandling = NullValueHandling.Ignore)]
        public Uri BViewUrl { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("@xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Xmlns { get; set; }

        [JsonProperty("Message")]
        public object Message { get; set; }

        [JsonProperty("ResponseCode", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic ResponseCode { get; set; }

        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Status { get; set; }
    }

    //public class Baslik
    //{
    //    public string? ReferenceNo { get; set; }
    //    public string? Tarih { get; set; }
    //    public string? FaturaNo { get; set; }
    //    public string? Tedarikci { get; set; }
    //    public string? VergiDairesi { get; set; }
    //    public string? VergiNo { get; set; }
    //    public string? PostaKutusu { get; set; }
    //    public string? Adres { get; set; }
    //    public string? Ilce { get; set; }
    //    public string? Sehir { get; set; }
    //    public string? Ulke { get; set; }
    //    public double KdvMatrahi { get; set; }
    //    public double KdvTutari { get; set; }
    //    public double ToplamTutar { get; set; }
    //    public string? ETTN { get; set; }
    //    public string? ReceiverAlias { get; set; }
    //    public string? SenderAlias { get; set; }
    //    public string? FatUrl { get; set; }
    //}

    public class Kalemler
    {
        public string? MalzemeKodu { get; set; }
        public string? MalzemeAdi { get; set; }
        public string? Miktar { get; set; }
        public string? BirimKodu { get; set; }
        public double Fiyat { get; set; }
        public string? KdvOrani { get; set; }
        public double KdvTutari { get; set; }
        public double MalHizmetTutari { get; set; }
        public string? ParaBirimi { get; set; }
    }
}
