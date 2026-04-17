using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.GelenFaturaRedOnay
{

    public class Rootobject
    {
        public Logininfo LoginInfo { get; set; }
        public bool is_test { get; set; }
        public int BranchID { get; set; }
        public string? reference_number { get; set; }
        public string? ReplyDescription { get; set; }
        public string? ReplyState { get; set; }
    }

    public class Logininfo
    {
        public string? InstitutionId { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
    }


    public class OnayRedDonenCevap
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
        public Items Items { get; set; }
    }

    public class Header
    {
        public string? Message { get; set; }
        public string? ResponseCode { get; set; }
        public string? Status { get; set; }
    }

    public class Items
    {
        public Processresultitem ProcessResultItem { get; set; }
    }

    public class Processresultitem
    {
        public string? ReferenceNumber { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public string? ResponseStatus { get; set; }
    }


}
