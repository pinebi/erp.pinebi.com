using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("evrak_belge_resimleri")]
public class EvrakBelgeResimleri
{
    [Column("ei_Key")]
    public int? EiKey { get; set; }

    [Column("ei_dosyano")]
    public short? EiDosyano { get; set; }

    [Column("ei_hareket_tip")]
    public byte? EiHareketTip { get; set; }

    [Column("ei_evr_tip")]
    public byte? EiEvrTip { get; set; }

    [Column("ei_evr_seri")]
    [StringLength(50)]
    public string? EiEvrSeri { get; set; }

    [Column("ei_evr_sira")]
    public int? EiEvrSira { get; set; }

    [Column("ei_evr-ustkod")]
    [StringLength(25)]
    public string? EiEvrUstkod { get; set; }

    [Column("ei_classid")]
    public byte? EiClassid { get; set; }

    [Column("ei_image")]
    public byte[]? EiImage { get; set; }

    [Column("ei_aciklama")]
    [StringLength(127)]
    public string? EiAciklama { get; set; }
}
