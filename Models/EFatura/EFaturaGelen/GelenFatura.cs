// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

//namespace MACHINEBISS_Web.Models.EFatura.EFaturaGelen
//{
//    public class ABody
//    {
//        [JsonProperty("@xmlns:b")]
//        public string? xmlnsb { get; set; }

//        [JsonProperty("b:AccountingCost")]
//        public BAccountingCost bAccountingCost { get; set; }

//        [JsonProperty("b:AccountingCustomerParty")]
//        public BAccountingCustomerParty bAccountingCustomerParty { get; set; }

//        [JsonProperty("b:AccountingSupplierParty")]
//        public BAccountingSupplierParty bAccountingSupplierParty { get; set; }

//        [JsonProperty("b:AdditionalDocumentReference")]
//        public BAdditionalDocumentReference bAdditionalDocumentReference { get; set; }

//        [JsonProperty("b:AllowanceCharge")]
//        public BAllowanceCharge bAllowanceCharge { get; set; }

//        [JsonProperty("b:AllowanceCharges")]
//        public dynamic bAllowanceCharges { get; set; }

//        [JsonProperty("b:BillingReference")]
//        public object bBillingReference { get; set; }

//        [JsonProperty("b:BuyerCustomerParty")]
//        public BBuyerCustomerParty bBuyerCustomerParty { get; set; }

//        [JsonProperty("b:ContractDocumentReference")]
//        public object bContractDocumentReference { get; set; }

//        [JsonProperty("b:CopyIndicator")]
//        public string? bCopyIndicator { get; set; }

//        [JsonProperty("b:Delivery")]
//        public object bDelivery { get; set; }

//        [JsonProperty("b:DespatchDocumentReference")]
//        public object bDespatchDocumentReference { get; set; }

//        [JsonProperty("b:DocumentCurrencyCode")]
//        public string? bDocumentCurrencyCode { get; set; }

//        [JsonProperty("b:ID")]
//        public string? bID { get; set; }

//        [JsonProperty("b:InvoiceLine")]
//        public BInvoiceLine bInvoiceLine { get; set; }

//        [JsonProperty("b:InvoicePeriod")]
//        public BInvoicePeriod bInvoicePeriod { get; set; }

//        [JsonProperty("b:InvoiceTypeCode")]
//        public string? bInvoiceTypeCode { get; set; }

//        [JsonProperty("b:IssueDateTime")]
//        public DateTime bIssueDateTime { get; set; }

//        [JsonProperty("b:LegalMonetaryTotal")]
//        public BLegalMonetaryTotal bLegalMonetaryTotal { get; set; }

//        [JsonProperty("b:Notes")]
//        public BNotes bNotes { get; set; }

//        [JsonProperty("b:OrderReference")]
//        public BOrderReference bOrderReference { get; set; }

//        [JsonProperty("b:OriginatorDocumentReference")]
//        public object bOriginatorDocumentReference { get; set; }

//        [JsonProperty("b:PaymentAlternativeCurrencyCode")]
//        public BPaymentAlternativeCurrencyCode bPaymentAlternativeCurrencyCode { get; set; }

//        [JsonProperty("b:PaymentAlternativeExchangeRate")]
//        public BPaymentAlternativeExchangeRate bPaymentAlternativeExchangeRate { get; set; }

//        [JsonProperty("b:PaymentCurrencyCode")]
//        public BPaymentCurrencyCode bPaymentCurrencyCode { get; set; }

//        [JsonProperty("b:PaymentExchangeRate")]
//        public BPaymentExchangeRate bPaymentExchangeRate { get; set; }

//        [JsonProperty("b:PaymentMeans")]
//        public object bPaymentMeans { get; set; }

//        [JsonProperty("b:PaymentTerms")]
//        public BPaymentTerms bPaymentTerms { get; set; }

//        [JsonProperty("b:PricingCurrencyCode")]
//        public BPricingCurrencyCode bPricingCurrencyCode { get; set; }

//        [JsonProperty("b:PricingExchangeRate")]
//        public BPricingExchangeRate bPricingExchangeRate { get; set; }

//        [JsonProperty("b:ProfileID")]
//        public string? bProfileID { get; set; }

//        [JsonProperty("b:ReceiptDocumentReference")]
//        public object bReceiptDocumentReference { get; set; }

//        [JsonProperty("b:SellerSupplierParty")]
//        public BSellerSupplierParty bSellerSupplierParty { get; set; }

//        [JsonProperty("b:TaxCurrencyCode")]
//        public BTaxCurrencyCode bTaxCurrencyCode { get; set; }

//        [JsonProperty("b:TaxExchangeRate")]
//        public BTaxExchangeRate bTaxExchangeRate { get; set; }

//        [JsonProperty("b:TaxRepresentativeParty")]
//        public BTaxRepresentativeParty bTaxRepresentativeParty { get; set; }

//        [JsonProperty("b:TaxTotal")]
//        public BTaxTotal bTaxTotal { get; set; }

//        [JsonProperty("b:UUID")]
//        public string? bUUID { get; set; }

//        [JsonProperty("b:WithholdingTaxTotal")]
//        public object bWithholdingTaxTotal { get; set; }
//    }

//    public class AHeader
//    {
//        [JsonProperty("@xmlns:b")]
//        public string? xmlnsb { get; set; }

//        [JsonProperty("b:HashValue")]
//        public string? bHashValue { get; set; }

//        [JsonProperty("b:OperationDirectionType")]
//        public string? bOperationDirectionType { get; set; }

//        [JsonProperty("b:ReceiveDateTime")]
//        public DateTime bReceiveDateTime { get; set; }

//        [JsonProperty("b:ReceiverAlias")]
//        public string? bReceiverAlias { get; set; }

//        [JsonProperty("b:ReferenceNumber")]
//        public string? bReferenceNumber { get; set; }

//        [JsonProperty("b:SenderAlias")]
//        public string? bSenderAlias { get; set; }

//        [JsonProperty("b:SenderIdentityNumber")]
//        public string? bSenderIdentityNumber { get; set; }

//        [JsonProperty("b:ViewUrl")]
//        public string? bViewUrl { get; set; }
//    }

//    public class AIncomingInvoice
//    {
//        [JsonProperty("a:Body")]
//        public ABody aBody { get; set; }

//        [JsonProperty("a:Header")]
//        public AHeader aHeader { get; set; }

//        [JsonProperty("a:ViewContent")]
//        public AViewContent aViewContent { get; set; }
//    }

//    public class AInvoices
//    {
//        [JsonProperty("a:IncomingInvoice")]
//        public List<AIncomingInvoice> aIncomingInvoice { get; set; }
//    }

//    public class AViewContent
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BAccountingCost
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BAccountingCustomerParty
//    {
//        [JsonProperty("b:DespatchContact")]
//        public BDespatchContact bDespatchContact { get; set; }

//        [JsonProperty("b:Party")]
//        public BParty bParty { get; set; }
//    }

//    public class BAccountingSupplierParty
//    {
//        [JsonProperty("b:DespatchContact")]
//        public BDespatchContact bDespatchContact { get; set; }

//        [JsonProperty("b:Party")]
//        public BParty bParty { get; set; }
//    }

//    public class BAdditionalDocumentReference
//    {
//        [JsonProperty("b:DocumentReference")]
//        public List<BDocumentReference> bDocumentReference { get; set; }
//    }

//    public class BAgentParty
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BAllowanceCharge
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }

//        [JsonProperty("b:AllowanceChargeReason")]
//        public string? bAllowanceChargeReason { get; set; }

//        [JsonProperty("b:Amount")]
//        public BAmount bAmount { get; set; }

//        [JsonProperty("b:BaseAmount")]
//        public BBaseAmount bBaseAmount { get; set; }

//        [JsonProperty("b:ChargeIndicator")]
//        public string? bChargeIndicator { get; set; }

//        [JsonProperty("b:MultiplierFactorNumeric")]
//        public string? bMultiplierFactorNumeric { get; set; }

//        [JsonProperty("b:PerUnitAmount")]
//        public BPerUnitAmount bPerUnitAmount { get; set; }

//        [JsonProperty("b:SequenceNumeric")]
//        public string? bSequenceNumeric { get; set; }
//    }

//    public class BAllowanceCharges
//    {
//        [JsonProperty("b:AllowanceCharge")]
//        public BAllowanceCharge bAllowanceCharge { get; set; }
//    }

//    public class BAllowanceTotalAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BAttachment
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }

//        [JsonProperty("b:EmbeddedDocumentBinaryObject")]
//        public BEmbeddedDocumentBinaryObject bEmbeddedDocumentBinaryObject { get; set; }

//        [JsonProperty("b:ExternalReference")]
//        public BExternalReference bExternalReference { get; set; }

//        [JsonProperty("b:FileName")]
//        public BFileName bFileName { get; set; }

//        [JsonProperty("b:MimeCode")]
//        public BMimeCode bMimeCode { get; set; }
//    }

//    public class BBaseAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BBaseUnitMeasure
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBaseUnitMeasureCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBlockName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBrandName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBuildingName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBuildingNumber
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBuyerCustomerParty
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BBuyersItemIdentification
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BChargeTotalAmount
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BCommodityClassificationCodes
//    {
//        [JsonProperty("@xmlns:c")]
//        public string? xmlnsc { get; set; }
//    }

//    public class BContact
//    {
//        [JsonProperty("b:ElectronicMail")]
//        public BElectronicMail bElectronicMail { get; set; }

//        [JsonProperty("b:Name")]
//        public BName bName { get; set; }

//        [JsonProperty("b:Note")]
//        public BNote bNote { get; set; }

//        [JsonProperty("b:OtherCommunication")]
//        public BOtherCommunication bOtherCommunication { get; set; }

//        [JsonProperty("b:Telefax")]
//        public BTelefax bTelefax { get; set; }

//        [JsonProperty("b:Telephone")]
//        public string? bTelephone { get; set; }
//    }

//    public class BCountry
//    {
//        [JsonProperty("b:IdentificationCode")]
//        public BIdentificationCode bIdentificationCode { get; set; }

//        [JsonProperty("b:Name")]
//        public string? bName { get; set; }
//    }

//    public class BDescription
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BDespatchContact
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BDistrict
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BDocumentDescription
//    {
//        [JsonProperty("@xmlns:c")]
//        public string? xmlnsc { get; set; }

//        [JsonProperty("c:string")]
//        public string? cstring { get; set; }
//    }

//    public class BDocumentReference
//    {
//        [JsonProperty("b:Attachment")]
//        public BAttachment bAttachment { get; set; }

//        [JsonProperty("b:DocumentDescription")]
//        public BDocumentDescription bDocumentDescription { get; set; }

//        [JsonProperty("b:DocumentType")]
//        public string? bDocumentType { get; set; }

//        [JsonProperty("b:DocumentTypeCode")]
//        public object bDocumentTypeCode { get; set; }

//        [JsonProperty("b:ID")]
//        public string? bID { get; set; }

//        [JsonProperty("b:IssueDate")]
//        public DateTime bIssueDate { get; set; }

//        [JsonProperty("b:IssuerParty")]
//        public BIssuerParty bIssuerParty { get; set; }

//        [JsonProperty("b:ValidityPeriod")]
//        public BValidityPeriod bValidityPeriod { get; set; }
//    }

//    public class BElectronicMail
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BEmbeddedDocumentBinaryObject
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BEndpointID
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BExternalReference
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BFileName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BFinancialAccount
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BID
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BIdentificationCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BIdentityDocumentReference
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BIndustryClassificationCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BInvoiceLine
//    {
//        [JsonProperty("b:InvoiceLine")]
//        public List<BInvoiceLine> bInvoiceLine { get; set; }

//        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
//        public BAllowanceCharge bAllowanceCharge { get; set; }

//        [JsonProperty("b:AllowanceCharges", NullValueHandling = NullValueHandling.Ignore)]
//        public BAllowanceCharges bAllowanceCharges { get; set; }

//        [JsonProperty("b:Delivery")]
//        public object bDelivery { get; set; }

//        [JsonProperty("b:DespatchLineReference")]
//        public object bDespatchLineReference { get; set; }

//        [JsonProperty("b:InvoicedQuantityUnitCode")]
//        public string? bInvoicedQuantityUnitCode { get; set; }

//        [JsonProperty("b:InvoicedQuantityValue")]
//        public string? bInvoicedQuantityValue { get; set; }

//        [JsonProperty("b:Item")]
//        public BItem bItem { get; set; }

//        [JsonProperty("b:LineExtensionAmount")]
//        public BLineExtensionAmount bLineExtensionAmount { get; set; }

//        [JsonProperty("b:Note")]
//        public object bNote { get; set; }

//        [JsonProperty("b:Notes")]
//        public BNotes bNotes { get; set; }

//        [JsonProperty("b:OrderLineReference")]
//        public object bOrderLineReference { get; set; }

//        [JsonProperty("b:Price")]
//        public BPrice bPrice { get; set; }

//        [JsonProperty("b:ReceiptLineReference")]
//        public object bReceiptLineReference { get; set; }

//        [JsonProperty("b:SubInvoiceLine")]
//        public object bSubInvoiceLine { get; set; }

//        [JsonProperty("b:TaxTotal")]
//        public BTaxTotal bTaxTotal { get; set; }

//        [JsonProperty("b:WithholdingTaxTotal")]
//        public object bWithholdingTaxTotal { get; set; }
//    }

//    public class BInvoicePeriod
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BIssuerParty
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BItem
//    {
//        [JsonProperty("b:AdditionalItemIdentifications")]
//        public object bAdditionalItemIdentifications { get; set; }

//        [JsonProperty("b:BrandName")]
//        public BBrandName bBrandName { get; set; }

//        [JsonProperty("b:BuyersItemIdentification")]
//        public BBuyersItemIdentification bBuyersItemIdentification { get; set; }

//        [JsonProperty("b:CommodityClassification")]
//        public object bCommodityClassification { get; set; }

//        [JsonProperty("b:CommodityClassificationCodes")]
//        public BCommodityClassificationCodes bCommodityClassificationCodes { get; set; }

//        [JsonProperty("b:Description")]
//        public BDescription bDescription { get; set; }

//        [JsonProperty("b:ItemClassificationCode")]
//        public object bItemClassificationCode { get; set; }

//        [JsonProperty("b:ManufacturersItemIdentification")]
//        public BManufacturersItemIdentification bManufacturersItemIdentification { get; set; }

//        [JsonProperty("b:ModelName")]
//        public BModelName bModelName { get; set; }

//        [JsonProperty("b:Name")]
//        public string? bName { get; set; }

//        [JsonProperty("b:OriginCountry")]
//        public BOriginCountry bOriginCountry { get; set; }

//        [JsonProperty("b:ProductTraceID")]
//        public BProductTraceID bProductTraceID { get; set; }

//        [JsonProperty("b:SellersItemIdentification")]
//        public string? bSellersItemIdentification { get; set; }

//        [JsonProperty("b:SerialID")]
//        public BSerialID bSerialID { get; set; }
//    }

//    public class BLegalMonetaryTotal
//    {
//        [JsonProperty("b:AllowanceTotalAmount")]
//        public BAllowanceTotalAmount bAllowanceTotalAmount { get; set; }

//        [JsonProperty("b:ChargeTotalAmount")]
//        public BChargeTotalAmount bChargeTotalAmount { get; set; }

//        [JsonProperty("b:LineExtensionAmount")]
//        public BLineExtensionAmount bLineExtensionAmount { get; set; }

//        [JsonProperty("b:PayableAmount")]
//        public BPayableAmount bPayableAmount { get; set; }

//        [JsonProperty("b:PayableRoundingAmount")]
//        public BPayableRoundingAmount bPayableRoundingAmount { get; set; }

//        [JsonProperty("b:TaxExclusiveAmount")]
//        public BTaxExclusiveAmount bTaxExclusiveAmount { get; set; }

//        [JsonProperty("b:TaxInclusiveAmount")]
//        public BTaxInclusiveAmount bTaxInclusiveAmount { get; set; }
//    }

//    public class BLineExtensionAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BManufacturersItemIdentification
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BMiddleName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BMimeCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BModelName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BNameSuffix
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BNationalityID
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BNote
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BNotes
//    {
//        [JsonProperty("@xmlns:c")]
//        public string? xmlnsc { get; set; }

//        [JsonProperty("c:string")]
//        public CString cstring { get; set; }
//    }

//    public class BOrderReference
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BOriginCountry
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BOtherCommunication
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BParty
//    {
//        [JsonProperty("b:AgentParty")]
//        public BAgentParty bAgentParty { get; set; }

//        [JsonProperty("b:Contact")]
//        public BContact bContact { get; set; }

//        [JsonProperty("b:EndpointID")]
//        public BEndpointID bEndpointID { get; set; }

//        [JsonProperty("b:IndustryClassificationCode")]
//        public BIndustryClassificationCode bIndustryClassificationCode { get; set; }

//        [JsonProperty("b:PartyIdentifications")]
//        public BPartyIdentifications bPartyIdentifications { get; set; }

//        [JsonProperty("b:PartyLegalEntity")]
//        public object bPartyLegalEntity { get; set; }

//        [JsonProperty("b:PartyName")]
//        public string? bPartyName { get; set; }

//        [JsonProperty("b:PartyTax")]
//        public string? bPartyTax { get; set; }

//        [JsonProperty("b:Person")]
//        public BPerson bPerson { get; set; }

//        [JsonProperty("b:PhysicalLocation")]
//        public BPhysicalLocation bPhysicalLocation { get; set; }

//        [JsonProperty("b:PostalAddress")]
//        public BPostalAddress bPostalAddress { get; set; }

//        [JsonProperty("b:WebsiteURI")]
//        public BWebsiteURI bWebsiteURI { get; set; }
//    }

//    public class BPartyIdentification
//    {
//        [JsonProperty("b:SchemeID")]
//        public string? bSchemeID { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BPartyIdentifications
//    {
//        [JsonProperty("b:PartyIdentification")]
//        public List<BPartyIdentification> bPartyIdentification { get; set; }
//    }

//    public class BPartyName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPayableAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BPayableRoundingAmount
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPaymentAlternativeCurrencyCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPaymentAlternativeExchangeRate
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPaymentCurrencyCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPaymentExchangeRate
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPaymentTerms
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPerson
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }

//        [JsonProperty("b:FamilyName")]
//        public string? bFamilyName { get; set; }

//        [JsonProperty("b:FinancialAccount")]
//        public BFinancialAccount bFinancialAccount { get; set; }

//        [JsonProperty("b:FirstName")]
//        public string? bFirstName { get; set; }

//        [JsonProperty("b:IdentityDocumentReference")]
//        public BIdentityDocumentReference bIdentityDocumentReference { get; set; }

//        [JsonProperty("b:MiddleName")]
//        public BMiddleName bMiddleName { get; set; }

//        [JsonProperty("b:NameSuffix")]
//        public BNameSuffix bNameSuffix { get; set; }

//        [JsonProperty("b:NationalityID")]
//        public BNationalityID bNationalityID { get; set; }

//        [JsonProperty("b:Title")]
//        public BTitle bTitle { get; set; }
//    }

//    public class BPerUnitAmount
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPhysicalLocation
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPostalAddress
//    {
//        [JsonProperty("b:BlockName")]
//        public BBlockName bBlockName { get; set; }

//        [JsonProperty("b:BuildingName")]
//        public BBuildingName bBuildingName { get; set; }

//        [JsonProperty("b:BuildingNumber")]
//        public BBuildingNumber bBuildingNumber { get; set; }

//        [JsonProperty("b:CityName")]
//        public string? bCityName { get; set; }

//        [JsonProperty("b:CitySubdivisionName")]
//        public string? bCitySubdivisionName { get; set; }

//        [JsonProperty("b:Country")]
//        public BCountry bCountry { get; set; }

//        [JsonProperty("b:District")]
//        public BDistrict bDistrict { get; set; }

//        [JsonProperty("b:ID")]
//        public BID bID { get; set; }

//        [JsonProperty("b:PostBox")]
//        public BPostBox bPostBox { get; set; }

//        [JsonProperty("b:PostalZone")]
//        public BPostalZone bPostalZone { get; set; }

//        [JsonProperty("b:Region")]
//        public BRegion bRegion { get; set; }

//        [JsonProperty("b:Room")]
//        public BRoom bRoom { get; set; }

//        [JsonProperty("b:StreetName")]
//        public string? bStreetName { get; set; }
//    }

//    public class BPostalZone
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPostBox
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPrice
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BPricingCurrencyCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BPricingExchangeRate
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BProductTraceID
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BRegion
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BRoom
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BSellerSupplierParty
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BSerialID
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BStreetName
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTaxableAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BTaxAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BTaxCurrencyCode
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTaxExchangeRate
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTaxExclusiveAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BTaxInclusiveAmount
//    {
//        [JsonProperty("b:CurrencyCode")]
//        public string? bCurrencyCode { get; set; }

//        [JsonProperty("b:Value")]
//        public string? bValue { get; set; }
//    }

//    public class BTaxRepresentativeParty
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTaxSubtotal
//    {
//        [JsonProperty("b:TaxSubtotal")]
//        public BTaxSubtotal bTaxSubtotal { get; set; }

//        [JsonProperty("b:BaseUnitMeasure")]
//        public BBaseUnitMeasure bBaseUnitMeasure { get; set; }

//        [JsonProperty("b:BaseUnitMeasureCode")]
//        public BBaseUnitMeasureCode bBaseUnitMeasureCode { get; set; }

//        [JsonProperty("b:CalculationSequenceNumeric")]
//        public string? bCalculationSequenceNumeric { get; set; }

//        [JsonProperty("b:PerUnitAmount")]
//        public BPerUnitAmount bPerUnitAmount { get; set; }

//        [JsonProperty("b:Percent")]
//        public string? bPercent { get; set; }

//        [JsonProperty("b:TaxAmount")]
//        public BTaxAmount bTaxAmount { get; set; }

//        [JsonProperty("b:TaxCategoryExemptionReason")]
//        public string? bTaxCategoryExemptionReason { get; set; }

//        [JsonProperty("b:TaxCategoryExemptionReasonCode")]
//        public string? bTaxCategoryExemptionReasonCode { get; set; }

//        [JsonProperty("b:TaxCategorySchemeCode")]
//        public string? bTaxCategorySchemeCode { get; set; }

//        [JsonProperty("b:TaxCategorySchemeName")]
//        public string? bTaxCategorySchemeName { get; set; }

//        [JsonProperty("b:TaxableAmount")]
//        public BTaxableAmount bTaxableAmount { get; set; }

//        [JsonProperty("b:TransactionCurrencyTaxAmount")]
//        public BTransactionCurrencyTaxAmount bTransactionCurrencyTaxAmount { get; set; }
//    }

//    public class BTaxTotal
//    {
//        [JsonProperty("b:TaxAmount")]
//        public BTaxAmount bTaxAmount { get; set; }

//        [JsonProperty("b:TaxSubtotal")]
//        public BTaxSubtotal bTaxSubtotal { get; set; }

//        [JsonProperty("b:TaxTotal")]
//        public BTaxTotal bTaxTotal { get; set; }
//    }

//    public class BTelefax
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTitle
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BTransactionCurrencyTaxAmount
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BValidityPeriod
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class BWebsiteURI
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class CString
//    {
//        [JsonProperty("@i:nil")]
//        public string? inil { get; set; }
//    }

//    public class GetInvoicesResponse
//    {
//        [JsonProperty("@xmlns")]
//        public string? xmlns { get; set; }
//        public GetInvoicesResult GetInvoicesResult { get; set; }
//    }

//    public class GetInvoicesResult
//    {
//        [JsonProperty("@xmlns:a")]
//        public string? xmlnsa { get; set; }

//        [JsonProperty("@xmlns:i")]
//        public string? xmlnsi { get; set; }
//        public Header Header { get; set; }

//        [JsonProperty("a:Invoices")]
//        public AInvoices aInvoices { get; set; }

//        [JsonProperty("a:RemainedInvoiceCount")]
//        public string? aRemainedInvoiceCount { get; set; }
//    }

//    public class Header
//    {
//        [JsonProperty("@xmlns")]
//        public string? xmlns { get; set; }
//        public object Message { get; set; }
//        public string? ResponseCode { get; set; }
//        public string? Status { get; set; }
//    }

//    public class PARAM
//    {
//        public VALCLSRETURN VAL_CLS_RETURN { get; set; }
//        public string? TypeName { get; set; }
//    }

//    public class PARAMS
//    {
//        public Params Params { get; set; }
//        public Result Result { get; set; }
//    }

//    public class Params
//    {
//        public int ORDER { get; set; }
//        public string? CODE { get; set; }
//        public List<VALLCLS25> VAL_L_CLS25 { get; set; }
//        public string? TypeName { get; set; }
//    }

//    public class Result
//    {
//        public int ORDER { get; set; }
//        public string? CODE { get; set; }
//        public VALJOBJECT VAL_JOBJECT { get; set; }
//        public string? TypeName { get; set; }
//    }

//    public class Temperatures
//    {
//        public bool STATE { get; set; }
//        public PARAMS PARAMS { get; set; }
//    }

//    public class SBody
//    {
//        public GetInvoicesResponse GetInvoicesResponse { get; set; }
//    }

//    public class SEnvelope
//    {
//        [JsonProperty("@xmlns:s")]
//        public string? xmlnss { get; set; }

//        [JsonProperty("s:Body")]
//        public SBody sBody { get; set; }
//    }

//    public class VALCLSRETURN
//    {
//        public bool STATE { get; set; }
//        public PARAMS PARAMS { get; set; }
//    }

//    public class VALJOBJECT
//    {
//        [JsonProperty("s:Envelope")]
//        public SEnvelope sEnvelope { get; set; }
//    }

//    public class VALLCLS25
//    {
//        public string? FIELD_NAME { get; set; }
//        public bool STATE { get; set; }
//        public PARAM PARAM { get; set; }
//    }
//}




//// <auto-generated />
////
//// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
////
////    using MACHINEBISS_Web.Models.EFatura.EFaturaGelen;
////
////    var empty = Empty.FromJson(jsonString);

namespace MACHINEBISS_Web.Models.EFatura.EFaturaGelen
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class RootObject
    {
        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? State { get; set; }

        [JsonProperty("PARAMS", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Params Params { get; set; }
    }

    public partial class Params
    {
        [JsonProperty("Params", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ParamsClass ParamsParams { get; set; }
    }

    public partial class ValClsReturnParams
    {
        [JsonProperty("Result", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ParamsClass Result { get; set; }
    }

    public partial class ValClsReturn
    {
        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? State { get; set; }

        [JsonProperty("PARAMS", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ValClsReturnParams Params { get; set; }
    }

    public partial class Param
    {
        [JsonProperty("VAL_CLS_RETURN", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ValClsReturn ValClsReturn { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string TypeName { get; set; }
    }

    public partial class ValLCls25
    {
        [JsonProperty("FIELD_NAME", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string FieldName { get; set; }

        [JsonProperty("STATE", NullValueHandling = NullValueHandling.Ignore)]
        public virtual bool? State { get; set; }

        [JsonProperty("PARAM", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Param Param { get; set; }
    }

    public partial class ParamsClass
    {
        [JsonProperty("ORDER", NullValueHandling = NullValueHandling.Ignore)]
        public virtual long? Order { get; set; }

        [JsonProperty("CODE", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string Code { get; set; }

        [JsonProperty("VAL_L_CLS25", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<ValLCls25> ValLCls25 { get; set; }

        [JsonProperty("TypeName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string TypeName { get; set; }

        [JsonProperty("VAL_JOBJECT", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ValJobject ValJobject { get; set; }
    }

    public partial class ValJobject
    {
        [JsonProperty("s:Envelope", NullValueHandling = NullValueHandling.Ignore)]
        public virtual SEnvelope SEnvelope { get; set; }
    }

    public partial class SEnvelope
    {
        [JsonProperty("@xmlns:s", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsS { get; set; }

        [JsonProperty("s:Body", NullValueHandling = NullValueHandling.Ignore)]
        public virtual SBody SBody { get; set; }
    }

    public partial class SBody
    {
        [JsonProperty("GetInvoicesResponse", NullValueHandling = NullValueHandling.Ignore)]
        public virtual GetInvoicesResponse GetInvoicesResponse { get; set; }
    }

    public partial class GetInvoicesResponse
    {
        [JsonProperty("@xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri Xmlns { get; set; }

        [JsonProperty("GetInvoicesResult", NullValueHandling = NullValueHandling.Ignore)]
        public virtual GetInvoicesResult GetInvoicesResult { get; set; }
    }

    public partial class GetInvoicesResult
    {
        [JsonProperty("@xmlns:a", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsA { get; set; }

        [JsonProperty("@xmlns:i", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsI { get; set; }

        [JsonProperty("Header", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Header Header { get; set; }

        [JsonProperty("a:Invoices", NullValueHandling = NullValueHandling.Ignore)]
        public virtual AInvoices AInvoices { get; set; }

        [JsonProperty("a:RemainedInvoiceCount", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? ARemainedInvoiceCount { get; set; }
    }

    public partial class AInvoices
    {
        [JsonProperty("a:IncomingInvoice", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<AIncomingInvoice> AIncomingInvoice { get; set; }
    }

    public partial class AIncomingInvoice
    {
        [JsonProperty("a:Body", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABody ABody { get; set; }

        [JsonProperty("a:Header", NullValueHandling = NullValueHandling.Ignore)]
        public virtual AHeader AHeader { get; set; }

        [JsonProperty("a:ViewContent", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic AViewContent { get; set; }
    }

    public partial class ABody
    {
        [JsonProperty("@xmlns:b", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsB { get; set; }

        [JsonProperty("b:AccountingCost", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAccountingCost { get; set; }

        [JsonProperty("b:AccountingCustomerParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAccountingCustomerParty BAccountingCustomerParty { get; set; }

        [JsonProperty("b:AccountingSupplierParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAccountingSupplierParty BAccountingSupplierParty { get; set; }

        [JsonProperty("b:AdditionalDocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAdditionalDocumentReference BAdditionalDocumentReference { get; set; }

        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBAllowanceCharge BAllowanceCharge { get; set; }

        [JsonProperty("b:AllowanceCharges", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBAllowanceCharges BAllowanceCharges { get; set; }

        [JsonProperty("b:BillingReference")]
        public virtual object BBillingReference { get; set; }

        [JsonProperty("b:BuyerCustomerParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BBuyerCustomerParty BBuyerCustomerParty { get; set; }

        [JsonProperty("b:ContractDocumentReference")]
        public virtual object BContractDocumentReference { get; set; }

        [JsonProperty("b:CopyIndicator", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public virtual bool? BCopyIndicator { get; set; }

        [JsonProperty("b:Delivery")]
        public virtual object BDelivery { get; set; }

        [JsonProperty("b:DespatchDocumentReference")]
        public virtual object BDespatchDocumentReference { get; set; }

        [JsonProperty("b:DocumentCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CurrencyCode? BDocumentCurrencyCode { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BId { get; set; }

        [JsonProperty("b:InvoiceLine", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBInvoiceLine BInvoiceLine { get; set; }

        [JsonProperty("b:InvoicePeriod", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BInvoicePeriod { get; set; }

        [JsonProperty("b:InvoiceTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BInvoiceTypeCode { get; set; }

        [JsonProperty("b:IssueDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTimeOffset? BIssueDateTime { get; set; }

        [JsonProperty("b:LegalMonetaryTotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BLegalMonetaryTotal BLegalMonetaryTotal { get; set; }

        [JsonProperty("b:Notes", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BNotes BNotes { get; set; }

        [JsonProperty("b:OrderReference", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BOrderReference { get; set; }

        [JsonProperty("b:OriginatorDocumentReference")]
        public virtual object BOriginatorDocumentReference { get; set; }

        [JsonProperty("b:PaymentAlternativeCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentAlternativeCurrencyCode { get; set; }

        [JsonProperty("b:PaymentAlternativeExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentAlternativeExchangeRate { get; set; }

        [JsonProperty("b:PaymentCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentCurrencyCode { get; set; }

        [JsonProperty("b:PaymentExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentExchangeRate { get; set; }

        [JsonProperty("b:PaymentMeans", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBPaymentMeans BPaymentMeans { get; set; }

        [JsonProperty("b:PaymentTerms", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentTerms { get; set; }

        [JsonProperty("b:PricingCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPricingCurrencyCode { get; set; }

        [JsonProperty("b:PricingExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPricingExchangeRate { get; set; }

        [JsonProperty("b:ProfileID", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BProfileId { get; set; }

        [JsonProperty("b:ReceiptDocumentReference")]
        public virtual object BReceiptDocumentReference { get; set; }

        [JsonProperty("b:SellerSupplierParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BSellerSupplierParty { get; set; }

        [JsonProperty("b:TaxCurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTaxCurrencyCode { get; set; }

        [JsonProperty("b:TaxExchangeRate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTaxExchangeRate { get; set; }

        [JsonProperty("b:TaxRepresentativeParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTaxRepresentativeParty { get; set; }

        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBTaxTotal BTaxTotal { get; set; }

        [JsonProperty("b:UUID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Guid? BUuid { get; set; }

        [JsonProperty("b:WithholdingTaxTotal")]
        public virtual object BWithholdingTaxTotal { get; set; }
    }

    public partial class AViewContent
    {
        [JsonProperty("@i:nil", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public virtual dynamic INil { get; set; }
    }

    public partial class BAccountingCustomerParty
    {
        [JsonProperty("b:DespatchContact", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDespatchContact { get; set; }

        [JsonProperty("b:Party", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAccountingCustomerPartyBParty BParty { get; set; }
    }

    public partial class BAccountingCustomerPartyBParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public virtual PurpleBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public virtual object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public virtual PurpleBPostalAddress BPostalAddress { get; set; }

        [JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BWebsiteUri { get; set; }
    }

    public partial class PurpleBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTelephone { get; set; }
    }

    public partial class BPartyBPartyIdentifications
    {
        [JsonProperty("b:PartyIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<BPartyIdentification> BPartyIdentification { get; set; }
    }

    public partial class BPartyIdentification
    {
        [JsonProperty("b:SchemeID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BSchemeId { get; set; }

        [JsonProperty("b:Value", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BValue { get; set; }
    }

    public partial class PurpleBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingName { get; set; }

        [JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCityName { get; set; }

        [JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostBox { get; set; }

        [JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostalZone { get; set; }

        [JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BStreetName { get; set; }
    }

    public partial class BCountry
    {
        [JsonProperty("b:IdentificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BIdentificationCode { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BName { get; set; }
    }

    public partial class BAccountingSupplierParty
    {
        [JsonProperty("b:DespatchContact", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDespatchContact { get; set; }

        [JsonProperty("b:Party", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAccountingSupplierPartyBParty BParty { get; set; }
    }

    public partial class BAccountingSupplierPartyBParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public virtual FluffyBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public virtual object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public virtual FluffyBPostalAddress BPostalAddress { get; set; }

        [JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BWebsiteUri { get; set; }
    }

    public partial class FluffyBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BTelephone { get; set; }
    }

    public partial class FluffyBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingName { get; set; }

        [JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCityName { get; set; }

        [JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostBox { get; set; }

        [JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostalZone { get; set; }

        [JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BStreetName { get; set; }
    }

    public partial class BAdditionalDocumentReference
    {
        [JsonProperty("b:DocumentReference", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BDocumentReference BDocumentReference { get; set; }
    }

    public partial class BDocumentReference
    {
        [JsonProperty("b:Attachment", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAttachment BAttachment { get; set; }

        [JsonProperty("b:DocumentDescription", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BDocumentDescription BDocumentDescription { get; set; }

        [JsonProperty("b:DocumentType", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BDocumentType { get; set; }

        [JsonProperty("b:DocumentTypeCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDocumentTypeCode { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BId { get; set; }

        [JsonProperty("b:IssueDate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTimeOffset? BIssueDate { get; set; }

        [JsonProperty("b:IssuerParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BIssuerParty { get; set; }

        [JsonProperty("b:ValidityPeriod", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BValidityPeriod { get; set; }
    }

    public partial class BAttachment
    {
        [JsonProperty("b:EmbeddedDocumentBinaryObject", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BEmbeddedDocumentBinaryObject { get; set; }

        [JsonProperty("b:ExternalReference", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BExternalReference { get; set; }

        [JsonProperty("b:FileName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BFileName { get; set; }

        [JsonProperty("b:MimeCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BMimeCode { get; set; }
    }

    public partial class BDocumentDescription
    {
        [JsonProperty("@xmlns:c", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsC { get; set; }
    }

    public partial class ABodyBAllowanceCharge
    {
        [JsonProperty("b:AllowanceChargeReason", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAllowanceChargeReason { get; set; }

        [JsonProperty("b:Amount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BAmount { get; set; }

        [JsonProperty("b:BaseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBaseAmount { get; set; }

        [JsonProperty("b:ChargeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public virtual bool? BChargeIndicator { get; set; }

        [JsonProperty("b:MultiplierFactorNumeric", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BMultiplierFactorNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:SequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BSequenceNumeric { get; set; }
    }

    public partial class BAmount
    {
        [JsonProperty("b:CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CurrencyCode? BCurrencyCode { get; set; }

        [JsonProperty("b:Value", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BValue { get; set; }
    }

    public partial class ABodyBAllowanceCharges
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public virtual ABodyBAllowanceCharge BAllowanceCharge { get; set; }
    }

    public partial class BBuyerCustomerParty
    {
        [JsonProperty("b:AgentParty", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAgentParty { get; set; }

        [JsonProperty("b:Contact", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BBuyerCustomerPartyBContact BContact { get; set; }

        [JsonProperty("b:EndpointID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BEndpointId { get; set; }

        [JsonProperty("b:IndustryClassificationCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BIndustryClassificationCode { get; set; }

        [JsonProperty("b:PartyIdentifications", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BBuyerCustomerPartyBPartyIdentifications BPartyIdentifications { get; set; }

        [JsonProperty("b:PartyLegalEntity")]
        public virtual object BPartyLegalEntity { get; set; }

        [JsonProperty("b:PartyName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPartyName { get; set; }

        [JsonProperty("b:PartyTax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPartyTax { get; set; }

        [JsonProperty("b:Person", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerson { get; set; }

        [JsonProperty("b:PhysicalLocation", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPhysicalLocation { get; set; }

        [JsonProperty("b:PostalAddress", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BBuyerCustomerPartyBPostalAddress BPostalAddress { get; set; }

        [JsonProperty("b:WebsiteURI", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BWebsiteUri { get; set; }
    }

    public partial class BBuyerCustomerPartyBContact
    {
        [JsonProperty("b:ElectronicMail", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BElectronicMail { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BName { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BNote { get; set; }

        [JsonProperty("b:OtherCommunication", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BOtherCommunication { get; set; }

        [JsonProperty("b:Telefax", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTelefax { get; set; }

        [JsonProperty("b:Telephone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTelephone { get; set; }
    }

    public partial class BBuyerCustomerPartyBPartyIdentifications
    {
        [JsonProperty("b:PartyIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BPartyIdentification BPartyIdentification { get; set; }
    }

    public partial class BBuyerCustomerPartyBPostalAddress
    {
        [JsonProperty("b:BlockName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBlockName { get; set; }

        [JsonProperty("b:BuildingName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingName { get; set; }

        [JsonProperty("b:BuildingNumber", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuildingNumber { get; set; }

        [JsonProperty("b:CityName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCityName { get; set; }

        [JsonProperty("b:CitySubdivisionName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCitySubdivisionName { get; set; }

        [JsonProperty("b:Country", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BCountry { get; set; }

        [JsonProperty("b:District", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDistrict { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BId { get; set; }

        [JsonProperty("b:PostBox", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostBox { get; set; }

        [JsonProperty("b:PostalZone", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPostalZone { get; set; }

        [JsonProperty("b:Region", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRegion { get; set; }

        [JsonProperty("b:Room", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BRoom { get; set; }

        [JsonProperty("b:StreetName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BStreetName { get; set; }
    }

    public partial class ABodyBInvoiceLine
    {
        [JsonProperty("b:InvoiceLine", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<BInvoiceLineElement> BInvoiceLine { get; set; }
    }

    public partial class BInvoiceLineElement
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BInvoiceLineBAllowanceCharge BAllowanceCharge { get; set; }

        [JsonProperty("b:AllowanceCharges")]
        public virtual BInvoiceLineBAllowanceCharges BAllowanceCharges { get; set; }

        [JsonProperty("b:Delivery")]
        public virtual object BDelivery { get; set; }

        [JsonProperty("b:DespatchLineReference")]
        public virtual object BDespatchLineReference { get; set; }

        [JsonProperty("b:InvoicedQuantityUnitCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BInvoicedQuantityUnitCode? BInvoicedQuantityUnitCode { get; set; }

        [JsonProperty("b:InvoicedQuantityValue", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BInvoicedQuantityValue { get; set; }

        [JsonProperty("b:Item", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BItem BItem { get; set; }

        [JsonProperty("b:LineExtensionAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BLineExtensionAmount { get; set; }

        [JsonProperty("b:Note", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BNote { get; set; }

        [JsonProperty("b:Notes", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BNotes BNotes { get; set; }

        [JsonProperty("b:OrderLineReference")]
        public virtual object BOrderLineReference { get; set; }

        [JsonProperty("b:Price", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BPrice { get; set; }

        [JsonProperty("b:ReceiptLineReference")]
        public virtual object BReceiptLineReference { get; set; }

        [JsonProperty("b:SubInvoiceLine")]
        public virtual object BSubInvoiceLine { get; set; }

        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BInvoiceLineBTaxTotal BTaxTotal { get; set; }

        [JsonProperty("b:WithholdingTaxTotal")]
        public virtual object BWithholdingTaxTotal { get; set; }
    }

    public partial class BInvoiceLineBAllowanceCharge
    {
        [JsonProperty("@i:nil", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public virtual bool? INil { get; set; }

        [JsonProperty("b:AllowanceChargeReason", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BAllowanceChargeReason { get; set; }

        [JsonProperty("b:Amount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BAmount { get; set; }

        [JsonProperty("b:BaseAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BBaseAmount { get; set; }

        [JsonProperty("b:ChargeIndicator", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(FluffyParseStringConverter))]
        public virtual bool? BChargeIndicator { get; set; }

        [JsonProperty("b:MultiplierFactorNumeric", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BMultiplierFactorNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:SequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BSequenceNumeric { get; set; }
    }

    public partial class BInvoiceLineBAllowanceCharges
    {
        [JsonProperty("b:AllowanceCharge", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BInvoiceLineBAllowanceCharge BAllowanceCharge { get; set; }
    }

    public partial class BItem
    {
        [JsonProperty("b:AdditionalItemIdentifications")]
        public virtual object BAdditionalItemIdentifications { get; set; }

        [JsonProperty("b:BrandName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBrandName { get; set; }

        [JsonProperty("b:BuyersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBuyersItemIdentification { get; set; }

        [JsonProperty("b:CommodityClassification")]
        public virtual object BCommodityClassification { get; set; }

        [JsonProperty("b:CommodityClassificationCodes", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BDocumentDescription BCommodityClassificationCodes { get; set; }

        [JsonProperty("b:Description", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BDescription { get; set; }

        [JsonProperty("b:ItemClassificationCode")]
        public virtual object BItemClassificationCode { get; set; }

        [JsonProperty("b:ManufacturersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BManufacturersItemIdentification { get; set; }

        [JsonProperty("b:ModelName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BModelName { get; set; }

        [JsonProperty("b:Name", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BName { get; set; }

        [JsonProperty("b:OriginCountry", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BOriginCountry { get; set; }

        [JsonProperty("b:ProductTraceID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BProductTraceId { get; set; }

        [JsonProperty("b:SellersItemIdentification", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BSellersItemIdentification { get; set; }

        [JsonProperty("b:SerialID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BSerialId { get; set; }
    }

    public partial class BNotes
    {
        [JsonProperty("@xmlns:c", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsC { get; set; }

        [JsonProperty("c:string", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<string> CString { get; set; }
    }

    public partial class BInvoiceLineBTaxTotal
    {
        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual PurpleBTaxSubtotal BTaxSubtotal { get; set; }
    }

    public partial class PurpleBTaxSubtotal
    {
        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BTaxSubtotalElement BTaxSubtotal { get; set; }
    }

    public partial class BTaxSubtotalElement
    {
        [JsonProperty("b:BaseUnitMeasure", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBaseUnitMeasure { get; set; }

        [JsonProperty("b:BaseUnitMeasureCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BBaseUnitMeasureCode { get; set; }

        [JsonProperty("b:CalculationSequenceNumeric", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BCalculationSequenceNumeric { get; set; }

        [JsonProperty("b:PerUnitAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPerUnitAmount { get; set; }

        [JsonProperty("b:Percent", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BPercent { get; set; }

        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxCategoryExemptionReason", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTaxCategoryExemptionReason { get; set; }

        [JsonProperty("b:TaxCategoryExemptionReasonCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTaxCategoryExemptionReasonCode { get; set; }

        [JsonProperty("b:TaxCategorySchemeCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BTaxCategorySchemeCode { get; set; }

        [JsonProperty("b:TaxCategorySchemeName", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BTaxCategorySchemeName? BTaxCategorySchemeName { get; set; }

        [JsonProperty("b:TaxableAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxableAmount { get; set; }

        [JsonProperty("b:TransactionCurrencyTaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BTransactionCurrencyTaxAmount { get; set; }
    }

    public partial class BLegalMonetaryTotal
    {
        [JsonProperty("b:AllowanceTotalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BAllowanceTotalAmount { get; set; }

        [JsonProperty("b:ChargeTotalAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BChargeTotalAmount { get; set; }

        [JsonProperty("b:LineExtensionAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BLineExtensionAmount { get; set; }

        [JsonProperty("b:PayableAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BPayableAmount { get; set; }

        [JsonProperty("b:PayableRoundingAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPayableRoundingAmount { get; set; }

        [JsonProperty("b:TaxExclusiveAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxExclusiveAmount { get; set; }

        [JsonProperty("b:TaxInclusiveAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxInclusiveAmount { get; set; }
    }

    public partial class ABodyBPaymentMeans
    {
        [JsonProperty("b:PaymentMeans", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BPaymentMeansBPaymentMeans BPaymentMeans { get; set; }
    }

    public partial class BPaymentMeansBPaymentMeans
    {
        [JsonProperty("b:InstructionNote", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BInstructionNote { get; set; }

        [JsonProperty("b:PayeeFinancialAccount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BPayeeFinancialAccount BPayeeFinancialAccount { get; set; }

        [JsonProperty("b:PayerFinancialAccount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPayerFinancialAccount { get; set; }

        [JsonProperty("b:PaymentChannelCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentChannelCode { get; set; }

        [JsonProperty("b:PaymentDueDate", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTimeOffset? BPaymentDueDate { get; set; }

        [JsonProperty("b:PaymentMeansCode", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BPaymentMeansCode { get; set; }
    }

    public partial class BPayeeFinancialAccount
    {
        [JsonProperty("b:CurrencyCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual CurrencyCode? BCurrencyCode { get; set; }

        [JsonProperty("b:FinancialInstitutionBranch", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BFinancialInstitutionBranch { get; set; }

        [JsonProperty("b:ID", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BId { get; set; }

        [JsonProperty("b:PaymentNote", NullValueHandling = NullValueHandling.Ignore)]
        public virtual dynamic BPaymentNote { get; set; }
    }

    public partial class ABodyBTaxTotal
    {
        [JsonProperty("b:TaxTotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BTaxTotalBTaxTotal BTaxTotal { get; set; }
    }

    public partial class BTaxTotalBTaxTotal
    {
        [JsonProperty("b:TaxAmount", NullValueHandling = NullValueHandling.Ignore)]
        public virtual BAmount BTaxAmount { get; set; }

        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual FluffyBTaxSubtotal BTaxSubtotal { get; set; }
    }

    public partial class FluffyBTaxSubtotal
    {
        [JsonProperty("b:TaxSubtotal", NullValueHandling = NullValueHandling.Ignore)]
        public virtual List<BTaxSubtotalElement> BTaxSubtotal { get; set; }
    }

    public partial class AHeader
    {
        [JsonProperty("@xmlns:b", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri XmlnsB { get; set; }

        [JsonProperty("b:HashValue", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BHashValue { get; set; }

        [JsonProperty("b:OperationDirectionType", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BOperationDirectionType { get; set; }

        [JsonProperty("b:ReceiveDateTime", NullValueHandling = NullValueHandling.Ignore)]
        public virtual DateTimeOffset? BReceiveDateTime { get; set; }

        [JsonProperty("b:ReceiverAlias", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BReceiverAlias { get; set; }

        [JsonProperty("b:ReferenceNumber", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual long? BReferenceNumber { get; set; }

        [JsonProperty("b:SenderAlias", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BSenderAlias { get; set; }

        [JsonProperty("b:SenderIdentityNumber", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string BSenderIdentityNumber { get; set; }

        [JsonProperty("b:ViewUrl", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri BViewUrl { get; set; }
    }

    public partial class Header
    {
        [JsonProperty("@xmlns", NullValueHandling = NullValueHandling.Ignore)]
        public virtual Uri Xmlns { get; set; }

        [JsonProperty("Message")]
        public virtual object Message { get; set; }

        [JsonProperty("ResponseCode", NullValueHandling = NullValueHandling.Ignore)]
        public virtual string ResponseCode { get; set; }

        [JsonProperty("Status", NullValueHandling = NullValueHandling.Ignore)]
        [JsonConverter(typeof(PurpleParseStringConverter))]
        public virtual dynamic Status { get; set; }
    }

    public enum CurrencyCode { Try };

    public enum BInvoicedQuantityUnitCode { Niu };

    public enum BTaxCategorySchemeName { Kdv };

    public partial class RootObject
    {
        public static RootObject FromJson(string json) => JsonConvert.DeserializeObject<RootObject>(json, MACHINEBISS_Web.Models.EFatura.EFaturaGelen.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this RootObject self) => JsonConvert.SerializeObject(self, MACHINEBISS_Web.Models.EFatura.EFaturaGelen.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                CurrencyCodeConverter.Singleton,
                BInvoicedQuantityUnitCodeConverter.Singleton,
                BTaxCategorySchemeNameConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class PurpleParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(long) || t == typeof(long?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            long l;
            if (Int64.TryParse(value, out l))
            {
                return l;
            }
            throw new Exception("Cannot unmarshal type long");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (long)untypedValue;
            serializer.Serialize(writer, value.ToString());
            return;
        }

        public static readonly PurpleParseStringConverter Singleton = new PurpleParseStringConverter();
    }

    internal class FluffyParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly FluffyParseStringConverter Singleton = new FluffyParseStringConverter();
    }

    internal class CurrencyCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CurrencyCode) || t == typeof(CurrencyCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "TRY")
            {
                return CurrencyCode.Try;
            }
            throw new Exception("Cannot unmarshal type CurrencyCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CurrencyCode)untypedValue;
            if (value == CurrencyCode.Try)
            {
                serializer.Serialize(writer, "TRY");
                return;
            }
            throw new Exception("Cannot marshal type CurrencyCode");
        }

        public static readonly CurrencyCodeConverter Singleton = new CurrencyCodeConverter();
    }

    internal class BInvoicedQuantityUnitCodeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BInvoicedQuantityUnitCode) || t == typeof(BInvoicedQuantityUnitCode?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "NIU"|| value == "C62")
            {
                return BInvoicedQuantityUnitCode.Niu;
            }
            throw new Exception("Cannot unmarshal type BInvoicedQuantityUnitCode");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BInvoicedQuantityUnitCode)untypedValue;
            if (value == BInvoicedQuantityUnitCode.Niu)
            {
                serializer.Serialize(writer, "NIU");
                return;
            }
            throw new Exception("Cannot marshal type BInvoicedQuantityUnitCode");
        }

        public static readonly BInvoicedQuantityUnitCodeConverter Singleton = new BInvoicedQuantityUnitCodeConverter();
    }

    internal class BTaxCategorySchemeNameConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(BTaxCategorySchemeName) || t == typeof(BTaxCategorySchemeName?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "KDV")
            {
                return BTaxCategorySchemeName.Kdv;
            }
            throw new Exception("Cannot unmarshal type BTaxCategorySchemeName");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (BTaxCategorySchemeName)untypedValue;
            if (value == BTaxCategorySchemeName.Kdv)
            {
                serializer.Serialize(writer, "KDV");
                return;
            }
            throw new Exception("Cannot marshal type BTaxCategorySchemeName");
        }

        public static readonly BTaxCategorySchemeNameConverter Singleton = new BTaxCategorySchemeNameConverter();
    }
}
