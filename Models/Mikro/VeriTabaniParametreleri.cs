using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("veri_tabani_parametreleri")]
public class VeriTabaniParametreleri
{
    [Column("Param_recno")]
    [StringLength(50)]
    public string? ParamRecno { get; set; }

    [Column("Param_id")]
    public short? ParamId { get; set; }

    [Column("Param_item")]
    public short? ParamItem { get; set; }

    [Column("Param_size")]
    public int? ParamSize { get; set; }

    [Column("Param_buf")]
    [StringLength(50)]
    public string? ParamBuf { get; set; }
}
