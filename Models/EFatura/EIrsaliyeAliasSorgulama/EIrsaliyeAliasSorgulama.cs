using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EIrsaliyeAliasSorgulama
{

    public class RootobjectGiden
    {
        public string? session_id { get; set; }
        public int BranchID { get; set; }
        public string? tax_number { get; set; }
        public bool is_test { get; set; }
    }


    public class RootobjectGelen
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
        public string? identityNumber { get; set; }
        public string? isExists { get; set; }
        public DateTime customerCreatedOn { get; set; }
        public Receiveraliass[] ReceiverAliasses { get; set; }
    }

    public class Receiveraliass
    {
        public string? name { get; set; }
        public string? alias { get; set; }
        public DateTime aliasCreatedOn { get; set; }
    }

}
