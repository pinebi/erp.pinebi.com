using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MACHINEBISS_Web.Models.EFatura.EFaturaGiden
{

    public class RootobjectBasarili
    {
        public bool STATE { get; set; }
        public PARAMSBasarili PARAMS { get; set; }
    }

    public class PARAMSBasarili
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
        public string? CODE { get; set; }
        public string? DESCRIPTION { get; set; }
        public PARAMS2 PARAMS { get; set; }
    }

    public class PARAMS2
    {
        public Result Result { get; set; }
    }

    public class ResultBasarili
    {
        public int ORDER { get; set; }
        public string? CODE { get; set; }
        public VAL_JOBJECTBAsarili VAL_JOBJECT { get; set; }
        public string? TypeName { get; set; }
    }

    public class VAL_JOBJECTBAsarili
    {
        public HeaderBasarili Header { get; set; }
        public ItemBasarili Item { get; set; }
    }

    public class HeaderBasarili
    {
        public string? Message { get; set; }
        public string? ResponseCode { get; set; }
        public string? Status { get; set; }
    }

    public class ItemBasarili
    {
        public string? DespatchAdviceNumber { get; set; }
        public string? InvoiceNumber { get; set; }
        public string? ReferenceNumber { get; set; }
        public string? ResponseCode { get; set; }
        public string? ResponseDescription { get; set; }
        public string? ResponseStatus { get; set; }
        public string? TrackNumber { get; set; }
        public string? UUID { get; set; }
        public string? ViewUrl { get; set; }
    }

}
