using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EFaturaGidenDurumSorgula 
{

    public class RootobjectGidenSorgula
    {
        public Logininfo LoginInfo { get; set; }
        public bool is_test { get; set; }
        public string? reference_number { get; set; }
        public int BranchID { get; set; }
        public string? TrackNumber { get; set; }
    }

    public class Logininfo 
    {
        public string? InstitutionId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }


    public class RootobjectGidenDurum 
    {
        public bool STATE { get; set; }
        public PARAMS PARAMS { get; set; }
    }

    public class PARAMS
    {
        public Params1 Params { get; set; }
    }

    public class Params1
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public VAL_L_CLS25[] VAL_L_CLS25 { get; set; }
        public string? TypeName { get; set; }
    }

    public class VAL_L_CLS25
    {
        public string? FIELD_NAME { get; set; }
        public bool STATE { get; set; }
        public PARAM PARAM { get; set; }
    }

    public class PARAM
    {
        public VAL_CLS_RETURN VAL_CLS_RETURN { get; set; }
        public string? TypeName { get; set; }
    }

    public class VAL_CLS_RETURN
    {
        public bool STATE { get; set; }
        public PARAMS2 PARAMS { get; set; }
    }

    public class PARAMS2
    {
        public Result Result { get; set; }
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
        public string? EmailAddress { get; set; }
        public string? EmailDescription { get; set; }
        public string? EmailStatus { get; set; }
        public string? EmailStatusDescription { get; set; }
        public string? EnvelopeStatus { get; set; }
        public string? EnvelopeStatusDescription { get; set; }
        public string? HashValue { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? InvoiceStatusDescription { get; set; }
        public string? IsCancelled { get; set; }
        public string? IsCompleted { get; set; }
        public string? Notes { get; set; }
        public string? SmsDescription { get; set; }
        public string? SmsStatus { get; set; }
        public string? SmsStatusDescription { get; set; }
        public string? UUID { get; set; }
        public string? ViewUrl { get; set; }
    }

    public class Header
    {
        public string? Message { get; set; }
        public string? ResponseCode { get; set; }
        public string? Status { get; set; }
    }


}
