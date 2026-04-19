using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MACHINEBISS_Web.Models.Mikro;

[Table("ozel_mahsup_tanimlari")]
public class OzelMahsupTanimlari
{
    [Column("mh_Guid")]
    public Guid? MhGuid { get; set; }

    [Column("mh_DBCno")]
    public short? MhDBCno { get; set; }

    [Column("mh_SpecRECNo")]
    public int? MhSpecRECNo { get; set; }

    [Column("mh_iptal")]
    public bool? MhIptal { get; set; }

    [Column("mh_fileid")]
    public short? MhFileid { get; set; }

    [Column("mh_hidden")]
    public bool? MhHidden { get; set; }

    [Column("mh_kilitli")]
    public bool? MhKilitli { get; set; }

    [Column("mh_degisti")]
    public bool? MhDegisti { get; set; }

    [Column("mh_checksum")]
    public int? MhChecksum { get; set; }

    [Column("mh_create_user")]
    public short? MhCreateUser { get; set; }

    [Column("mh_create_date")]
    public DateTime? MhCreateDate { get; set; }

    [Column("mh_lastup_user")]
    public short? MhLastupUser { get; set; }

    [Column("mh_lastup_date")]
    public DateTime? MhLastupDate { get; set; }

    [Column("mh_special1")]
    [StringLength(4)]
    public string? MhSpecial1 { get; set; }

    [Column("mh_special2")]
    [StringLength(4)]
    public string? MhSpecial2 { get; set; }

    [Column("mh_special3")]
    [StringLength(4)]
    public string? MhSpecial3 { get; set; }

    [Column("mh_OzMahkodu")]
    [StringLength(25)]
    public string? MhOzMahkodu { get; set; }

    [Column("mh_OzMahAciklama")]
    [StringLength(40)]
    public string? MhOzMahAciklama { get; set; }

    [Column("mh_TakTarih")]
    public DateTime? MhTakTarih { get; set; }

    [Column("mh_Takvim_1")]
    public byte? MhTakvim1 { get; set; }

    [Column("mh_Takvim_2")]
    public byte? MhTakvim2 { get; set; }

    [Column("mh_Takvim_3")]
    public byte? MhTakvim3 { get; set; }

    [Column("mh_Takvim_4")]
    public byte? MhTakvim4 { get; set; }

    [Column("mh_Takvim_5")]
    public byte? MhTakvim5 { get; set; }

    [Column("mh_Takvim_6")]
    public byte? MhTakvim6 { get; set; }

    [Column("mh_Takvim_7")]
    public byte? MhTakvim7 { get; set; }

    [Column("mh_Takvim_8")]
    public byte? MhTakvim8 { get; set; }

    [Column("mh_Takvim_9")]
    public byte? MhTakvim9 { get; set; }

    [Column("mh_Takvim_10")]
    public byte? MhTakvim10 { get; set; }

    [Column("mh_Takvim_11")]
    public byte? MhTakvim11 { get; set; }

    [Column("mh_Takvim_12")]
    public byte? MhTakvim12 { get; set; }

    [Column("mh_Takvim_13")]
    public byte? MhTakvim13 { get; set; }

    [Column("mh_Takvim_14")]
    public byte? MhTakvim14 { get; set; }

    [Column("mh_Takvim_15")]
    public byte? MhTakvim15 { get; set; }

    [Column("mh_Takvim_16")]
    public byte? MhTakvim16 { get; set; }

    [Column("mh_Takvim_17")]
    public byte? MhTakvim17 { get; set; }

    [Column("mh_Takvim_18")]
    public byte? MhTakvim18 { get; set; }

    [Column("mh_Takvim_19")]
    public byte? MhTakvim19 { get; set; }

    [Column("mh_Takvim_20")]
    public byte? MhTakvim20 { get; set; }

    [Column("mh_Takvim_21")]
    public byte? MhTakvim21 { get; set; }

    [Column("mh_Takvim_22")]
    public byte? MhTakvim22 { get; set; }

    [Column("mh_Takvim_23")]
    public byte? MhTakvim23 { get; set; }

    [Column("mh_Takvim_24")]
    public byte? MhTakvim24 { get; set; }

    [Column("mh_Takvim_25")]
    public byte? MhTakvim25 { get; set; }

    [Column("mh_Takvim_26")]
    public byte? MhTakvim26 { get; set; }

    [Column("mh_Takvim_27")]
    public byte? MhTakvim27 { get; set; }

    [Column("mh_Takvim_28")]
    public byte? MhTakvim28 { get; set; }

    [Column("mh_Takvim_29")]
    public byte? MhTakvim29 { get; set; }

    [Column("mh_Takvim_30")]
    public byte? MhTakvim30 { get; set; }

    [Column("mh_Takvim_31")]
    public byte? MhTakvim31 { get; set; }

    [Column("mh_Takvim_32")]
    public byte? MhTakvim32 { get; set; }

    [Column("mh_Takvim_33")]
    public byte? MhTakvim33 { get; set; }

    [Column("mh_Takvim_34")]
    public byte? MhTakvim34 { get; set; }

    [Column("mh_Takvim_35")]
    public byte? MhTakvim35 { get; set; }

    [Column("mh_Takvim_36")]
    public byte? MhTakvim36 { get; set; }

    [Column("mh_Takvim_37")]
    public byte? MhTakvim37 { get; set; }

    [Column("mh_Takvim_38")]
    public byte? MhTakvim38 { get; set; }

    [Column("mh_Takvim_39")]
    public byte? MhTakvim39 { get; set; }

    [Column("mh_Takvim_40")]
    public byte? MhTakvim40 { get; set; }

    [Column("mh_Takvim_41")]
    public byte? MhTakvim41 { get; set; }

    [Column("mh_Takvim_42")]
    public byte? MhTakvim42 { get; set; }

    [Column("mh_Takvim_43")]
    public byte? MhTakvim43 { get; set; }

    [Column("mh_Takvim_44")]
    public byte? MhTakvim44 { get; set; }

    [Column("mh_Takvim_45")]
    public byte? MhTakvim45 { get; set; }

    [Column("mh_Takvim_46")]
    public byte? MhTakvim46 { get; set; }

    [Column("mh_Takvim_47")]
    public byte? MhTakvim47 { get; set; }

    [Column("mh_Takvim_48")]
    public byte? MhTakvim48 { get; set; }

    [Column("mh_Takvim_49")]
    public byte? MhTakvim49 { get; set; }

    [Column("mh_Takvim_50")]
    public byte? MhTakvim50 { get; set; }

    [Column("mh_Takvim_51")]
    public byte? MhTakvim51 { get; set; }

    [Column("mh_Takvim_52")]
    public byte? MhTakvim52 { get; set; }

    [Column("mh_Takvim_53")]
    public byte? MhTakvim53 { get; set; }

    [Column("mh_Takvim_54")]
    public byte? MhTakvim54 { get; set; }

    [Column("mh_Takvim_55")]
    public byte? MhTakvim55 { get; set; }

    [Column("mh_Takvim_56")]
    public byte? MhTakvim56 { get; set; }

    [Column("mh_Takvim_57")]
    public byte? MhTakvim57 { get; set; }

    [Column("mh_Takvim_58")]
    public byte? MhTakvim58 { get; set; }

    [Column("mh_Takvim_59")]
    public byte? MhTakvim59 { get; set; }

    [Column("mh_Takvim_60")]
    public byte? MhTakvim60 { get; set; }

    [Column("mh_Takvim_61")]
    public byte? MhTakvim61 { get; set; }

    [Column("mh_Takvim_62")]
    public byte? MhTakvim62 { get; set; }

    [Column("mh_Takvim_63")]
    public byte? MhTakvim63 { get; set; }

    [Column("mh_Takvim_64")]
    public byte? MhTakvim64 { get; set; }

    [Column("mh_Takvim_65")]
    public byte? MhTakvim65 { get; set; }

    [Column("mh_Takvim_66")]
    public byte? MhTakvim66 { get; set; }

    [Column("mh_Takvim_67")]
    public byte? MhTakvim67 { get; set; }

    [Column("mh_Takvim_68")]
    public byte? MhTakvim68 { get; set; }

    [Column("mh_Takvim_69")]
    public byte? MhTakvim69 { get; set; }

    [Column("mh_Takvim_70")]
    public byte? MhTakvim70 { get; set; }

    [Column("mh_Takvim_71")]
    public byte? MhTakvim71 { get; set; }

    [Column("mh_Takvim_72")]
    public byte? MhTakvim72 { get; set; }

    [Column("mh_Takvim_73")]
    public byte? MhTakvim73 { get; set; }

    [Column("mh_Takvim_74")]
    public byte? MhTakvim74 { get; set; }

    [Column("mh_Takvim_75")]
    public byte? MhTakvim75 { get; set; }

    [Column("mh_Takvim_76")]
    public byte? MhTakvim76 { get; set; }

    [Column("mh_Takvim_77")]
    public byte? MhTakvim77 { get; set; }

    [Column("mh_Takvim_78")]
    public byte? MhTakvim78 { get; set; }

    [Column("mh_Takvim_79")]
    public byte? MhTakvim79 { get; set; }

    [Column("mh_Takvim_80")]
    public byte? MhTakvim80 { get; set; }

    [Column("mh_Takvim_81")]
    public byte? MhTakvim81 { get; set; }

    [Column("mh_Takvim_82")]
    public byte? MhTakvim82 { get; set; }

    [Column("mh_Takvim_83")]
    public byte? MhTakvim83 { get; set; }

    [Column("mh_Takvim_84")]
    public byte? MhTakvim84 { get; set; }

    [Column("mh_Takvim_85")]
    public byte? MhTakvim85 { get; set; }

    [Column("mh_Takvim_86")]
    public byte? MhTakvim86 { get; set; }

    [Column("mh_Takvim_87")]
    public byte? MhTakvim87 { get; set; }

    [Column("mh_Takvim_88")]
    public byte? MhTakvim88 { get; set; }

    [Column("mh_Takvim_89")]
    public byte? MhTakvim89 { get; set; }

    [Column("mh_Takvim_90")]
    public byte? MhTakvim90 { get; set; }

    [Column("mh_Takvim_91")]
    public byte? MhTakvim91 { get; set; }

    [Column("mh_Takvim_92")]
    public byte? MhTakvim92 { get; set; }

    [Column("mh_Takvim_93")]
    public byte? MhTakvim93 { get; set; }

    [Column("mh_Takvim_94")]
    public byte? MhTakvim94 { get; set; }

    [Column("mh_Takvim_95")]
    public byte? MhTakvim95 { get; set; }

    [Column("mh_Takvim_96")]
    public byte? MhTakvim96 { get; set; }

    [Column("mh_Takvim_97")]
    public byte? MhTakvim97 { get; set; }

    [Column("mh_Takvim_98")]
    public byte? MhTakvim98 { get; set; }

    [Column("mh_Takvim_99")]
    public byte? MhTakvim99 { get; set; }

    [Column("mh_Takvim_100")]
    public byte? MhTakvim100 { get; set; }

    [Column("mh_Takvim_101")]
    public byte? MhTakvim101 { get; set; }

    [Column("mh_Takvim_102")]
    public byte? MhTakvim102 { get; set; }

    [Column("mh_Takvim_103")]
    public byte? MhTakvim103 { get; set; }

    [Column("mh_Takvim_104")]
    public byte? MhTakvim104 { get; set; }

    [Column("mh_Takvim_105")]
    public byte? MhTakvim105 { get; set; }

    [Column("mh_Takvim_106")]
    public byte? MhTakvim106 { get; set; }

    [Column("mh_Takvim_107")]
    public byte? MhTakvim107 { get; set; }

    [Column("mh_Takvim_108")]
    public byte? MhTakvim108 { get; set; }

    [Column("mh_Takvim_109")]
    public byte? MhTakvim109 { get; set; }

    [Column("mh_Takvim_110")]
    public byte? MhTakvim110 { get; set; }

    [Column("mh_Takvim_111")]
    public byte? MhTakvim111 { get; set; }

    [Column("mh_Takvim_112")]
    public byte? MhTakvim112 { get; set; }

    [Column("mh_Takvim_113")]
    public byte? MhTakvim113 { get; set; }

    [Column("mh_Takvim_114")]
    public byte? MhTakvim114 { get; set; }

    [Column("mh_Takvim_115")]
    public byte? MhTakvim115 { get; set; }

    [Column("mh_Takvim_116")]
    public byte? MhTakvim116 { get; set; }

    [Column("mh_Takvim_117")]
    public byte? MhTakvim117 { get; set; }

    [Column("mh_Takvim_118")]
    public byte? MhTakvim118 { get; set; }

    [Column("mh_Takvim_119")]
    public byte? MhTakvim119 { get; set; }

    [Column("mh_Takvim_120")]
    public byte? MhTakvim120 { get; set; }

    [Column("mh_Takvim_121")]
    public byte? MhTakvim121 { get; set; }

    [Column("mh_Takvim_122")]
    public byte? MhTakvim122 { get; set; }

    [Column("mh_Takvim_123")]
    public byte? MhTakvim123 { get; set; }

    [Column("mh_Takvim_124")]
    public byte? MhTakvim124 { get; set; }

    [Column("mh_Takvim_125")]
    public byte? MhTakvim125 { get; set; }

    [Column("mh_Takvim_126")]
    public byte? MhTakvim126 { get; set; }

    [Column("mh_Takvim_127")]
    public byte? MhTakvim127 { get; set; }

    [Column("mh_Takvim_128")]
    public byte? MhTakvim128 { get; set; }

    [Column("mh_Takvim_129")]
    public byte? MhTakvim129 { get; set; }

    [Column("mh_Takvim_130")]
    public byte? MhTakvim130 { get; set; }

    [Column("mh_Takvim_131")]
    public byte? MhTakvim131 { get; set; }

    [Column("mh_Takvim_132")]
    public byte? MhTakvim132 { get; set; }

    [Column("mh_Takvim_133")]
    public byte? MhTakvim133 { get; set; }

    [Column("mh_Takvim_134")]
    public byte? MhTakvim134 { get; set; }

    [Column("mh_Takvim_135")]
    public byte? MhTakvim135 { get; set; }

    [Column("mh_Takvim_136")]
    public byte? MhTakvim136 { get; set; }

    [Column("mh_Takvim_137")]
    public byte? MhTakvim137 { get; set; }

    [Column("mh_Takvim_138")]
    public byte? MhTakvim138 { get; set; }

    [Column("mh_Takvim_139")]
    public byte? MhTakvim139 { get; set; }

    [Column("mh_Takvim_140")]
    public byte? MhTakvim140 { get; set; }

    [Column("mh_Takvim_141")]
    public byte? MhTakvim141 { get; set; }

    [Column("mh_Takvim_142")]
    public byte? MhTakvim142 { get; set; }

    [Column("mh_Takvim_143")]
    public byte? MhTakvim143 { get; set; }

    [Column("mh_Takvim_144")]
    public byte? MhTakvim144 { get; set; }

    [Column("mh_Takvim_145")]
    public byte? MhTakvim145 { get; set; }

    [Column("mh_Takvim_146")]
    public byte? MhTakvim146 { get; set; }

    [Column("mh_Takvim_147")]
    public byte? MhTakvim147 { get; set; }

    [Column("mh_Takvim_148")]
    public byte? MhTakvim148 { get; set; }

    [Column("mh_Takvim_149")]
    public byte? MhTakvim149 { get; set; }

    [Column("mh_Takvim_150")]
    public byte? MhTakvim150 { get; set; }

    [Column("mh_Takvim_151")]
    public byte? MhTakvim151 { get; set; }

    [Column("mh_Takvim_152")]
    public byte? MhTakvim152 { get; set; }

    [Column("mh_Takvim_153")]
    public byte? MhTakvim153 { get; set; }

    [Column("mh_Takvim_154")]
    public byte? MhTakvim154 { get; set; }

    [Column("mh_Takvim_155")]
    public byte? MhTakvim155 { get; set; }

    [Column("mh_Takvim_156")]
    public byte? MhTakvim156 { get; set; }

    [Column("mh_Takvim_157")]
    public byte? MhTakvim157 { get; set; }

    [Column("mh_Takvim_158")]
    public byte? MhTakvim158 { get; set; }

    [Column("mh_Takvim_159")]
    public byte? MhTakvim159 { get; set; }

    [Column("mh_Takvim_160")]
    public byte? MhTakvim160 { get; set; }

    [Column("mh_Takvim_161")]
    public byte? MhTakvim161 { get; set; }

    [Column("mh_Takvim_162")]
    public byte? MhTakvim162 { get; set; }

    [Column("mh_Takvim_163")]
    public byte? MhTakvim163 { get; set; }

    [Column("mh_Takvim_164")]
    public byte? MhTakvim164 { get; set; }

    [Column("mh_Takvim_165")]
    public byte? MhTakvim165 { get; set; }

    [Column("mh_Takvim_166")]
    public byte? MhTakvim166 { get; set; }

    [Column("mh_Takvim_167")]
    public byte? MhTakvim167 { get; set; }

    [Column("mh_Takvim_168")]
    public byte? MhTakvim168 { get; set; }

    [Column("mh_Takvim_169")]
    public byte? MhTakvim169 { get; set; }

    [Column("mh_Takvim_170")]
    public byte? MhTakvim170 { get; set; }

    [Column("mh_Takvim_171")]
    public byte? MhTakvim171 { get; set; }

    [Column("mh_Takvim_172")]
    public byte? MhTakvim172 { get; set; }

    [Column("mh_Takvim_173")]
    public byte? MhTakvim173 { get; set; }

    [Column("mh_Takvim_174")]
    public byte? MhTakvim174 { get; set; }

    [Column("mh_Takvim_175")]
    public byte? MhTakvim175 { get; set; }

    [Column("mh_Takvim_176")]
    public byte? MhTakvim176 { get; set; }

    [Column("mh_Takvim_177")]
    public byte? MhTakvim177 { get; set; }

    [Column("mh_Takvim_178")]
    public byte? MhTakvim178 { get; set; }

    [Column("mh_Takvim_179")]
    public byte? MhTakvim179 { get; set; }

    [Column("mh_Takvim_180")]
    public byte? MhTakvim180 { get; set; }

    [Column("mh_Takvim_181")]
    public byte? MhTakvim181 { get; set; }

    [Column("mh_Takvim_182")]
    public byte? MhTakvim182 { get; set; }

    [Column("mh_Takvim_183")]
    public byte? MhTakvim183 { get; set; }

    [Column("mh_Takvim_184")]
    public byte? MhTakvim184 { get; set; }

    [Column("mh_Takvim_185")]
    public byte? MhTakvim185 { get; set; }

    [Column("mh_Takvim_186")]
    public byte? MhTakvim186 { get; set; }

    [Column("mh_Takvim_187")]
    public byte? MhTakvim187 { get; set; }

    [Column("mh_Takvim_188")]
    public byte? MhTakvim188 { get; set; }

    [Column("mh_Takvim_189")]
    public byte? MhTakvim189 { get; set; }

    [Column("mh_Takvim_190")]
    public byte? MhTakvim190 { get; set; }

    [Column("mh_Takvim_191")]
    public byte? MhTakvim191 { get; set; }

    [Column("mh_Takvim_192")]
    public byte? MhTakvim192 { get; set; }

    [Column("mh_Takvim_193")]
    public byte? MhTakvim193 { get; set; }

    [Column("mh_Takvim_194")]
    public byte? MhTakvim194 { get; set; }

    [Column("mh_Takvim_195")]
    public byte? MhTakvim195 { get; set; }

    [Column("mh_Takvim_196")]
    public byte? MhTakvim196 { get; set; }

    [Column("mh_Takvim_197")]
    public byte? MhTakvim197 { get; set; }

    [Column("mh_Takvim_198")]
    public byte? MhTakvim198 { get; set; }

    [Column("mh_Takvim_199")]
    public byte? MhTakvim199 { get; set; }

    [Column("mh_Takvim_200")]
    public byte? MhTakvim200 { get; set; }

    [Column("mh_Takvim_201")]
    public byte? MhTakvim201 { get; set; }

    [Column("mh_Takvim_202")]
    public byte? MhTakvim202 { get; set; }

    [Column("mh_Takvim_203")]
    public byte? MhTakvim203 { get; set; }

    [Column("mh_Takvim_204")]
    public byte? MhTakvim204 { get; set; }

    [Column("mh_Takvim_205")]
    public byte? MhTakvim205 { get; set; }

    [Column("mh_Takvim_206")]
    public byte? MhTakvim206 { get; set; }

    [Column("mh_Takvim_207")]
    public byte? MhTakvim207 { get; set; }

    [Column("mh_Takvim_208")]
    public byte? MhTakvim208 { get; set; }

    [Column("mh_Takvim_209")]
    public byte? MhTakvim209 { get; set; }

    [Column("mh_Takvim_210")]
    public byte? MhTakvim210 { get; set; }

    [Column("mh_Takvim_211")]
    public byte? MhTakvim211 { get; set; }

    [Column("mh_Takvim_212")]
    public byte? MhTakvim212 { get; set; }

    [Column("mh_Takvim_213")]
    public byte? MhTakvim213 { get; set; }

    [Column("mh_Takvim_214")]
    public byte? MhTakvim214 { get; set; }

    [Column("mh_Takvim_215")]
    public byte? MhTakvim215 { get; set; }

    [Column("mh_Takvim_216")]
    public byte? MhTakvim216 { get; set; }

    [Column("mh_Takvim_217")]
    public byte? MhTakvim217 { get; set; }

    [Column("mh_Takvim_218")]
    public byte? MhTakvim218 { get; set; }

    [Column("mh_Takvim_219")]
    public byte? MhTakvim219 { get; set; }

    [Column("mh_Takvim_220")]
    public byte? MhTakvim220 { get; set; }

    [Column("mh_Takvim_221")]
    public byte? MhTakvim221 { get; set; }

    [Column("mh_Takvim_222")]
    public byte? MhTakvim222 { get; set; }

    [Column("mh_Takvim_223")]
    public byte? MhTakvim223 { get; set; }

    [Column("mh_Takvim_224")]
    public byte? MhTakvim224 { get; set; }

    [Column("mh_Takvim_225")]
    public byte? MhTakvim225 { get; set; }

    [Column("mh_Takvim_226")]
    public byte? MhTakvim226 { get; set; }

    [Column("mh_Takvim_227")]
    public byte? MhTakvim227 { get; set; }

    [Column("mh_Takvim_228")]
    public byte? MhTakvim228 { get; set; }

    [Column("mh_Takvim_229")]
    public byte? MhTakvim229 { get; set; }

    [Column("mh_Takvim_230")]
    public byte? MhTakvim230 { get; set; }

    [Column("mh_Takvim_231")]
    public byte? MhTakvim231 { get; set; }

    [Column("mh_Takvim_232")]
    public byte? MhTakvim232 { get; set; }

    [Column("mh_Takvim_233")]
    public byte? MhTakvim233 { get; set; }

    [Column("mh_Takvim_234")]
    public byte? MhTakvim234 { get; set; }

    [Column("mh_Takvim_235")]
    public byte? MhTakvim235 { get; set; }

    [Column("mh_Takvim_236")]
    public byte? MhTakvim236 { get; set; }

    [Column("mh_Takvim_237")]
    public byte? MhTakvim237 { get; set; }

    [Column("mh_Takvim_238")]
    public byte? MhTakvim238 { get; set; }

    [Column("mh_Takvim_239")]
    public byte? MhTakvim239 { get; set; }

    [Column("mh_Takvim_240")]
    public byte? MhTakvim240 { get; set; }

    [Column("mh_Takvim_241")]
    public byte? MhTakvim241 { get; set; }

    [Column("mh_Takvim_242")]
    public byte? MhTakvim242 { get; set; }

    [Column("mh_Takvim_243")]
    public byte? MhTakvim243 { get; set; }

    [Column("mh_Takvim_244")]
    public byte? MhTakvim244 { get; set; }

    [Column("mh_Takvim_245")]
    public byte? MhTakvim245 { get; set; }

    [Column("mh_Takvim_246")]
    public byte? MhTakvim246 { get; set; }

    [Column("mh_Takvim_247")]
    public byte? MhTakvim247 { get; set; }

    [Column("mh_Takvim_248")]
    public byte? MhTakvim248 { get; set; }

    [Column("mh_Takvim_249")]
    public byte? MhTakvim249 { get; set; }

    [Column("mh_Takvim_250")]
    public byte? MhTakvim250 { get; set; }

    [Column("mh_Takvim_251")]
    public byte? MhTakvim251 { get; set; }

    [Column("mh_Takvim_252")]
    public byte? MhTakvim252 { get; set; }

    [Column("mh_Takvim_253")]
    public byte? MhTakvim253 { get; set; }

    [Column("mh_Takvim_254")]
    public byte? MhTakvim254 { get; set; }

    [Column("mh_Takvim_255")]
    public byte? MhTakvim255 { get; set; }

    [Column("mh_Takvim_256")]
    public byte? MhTakvim256 { get; set; }

    [Column("mh_Takvim_257")]
    public byte? MhTakvim257 { get; set; }

    [Column("mh_Takvim_258")]
    public byte? MhTakvim258 { get; set; }

    [Column("mh_Takvim_259")]
    public byte? MhTakvim259 { get; set; }

    [Column("mh_Takvim_260")]
    public byte? MhTakvim260 { get; set; }

    [Column("mh_Takvim_261")]
    public byte? MhTakvim261 { get; set; }

    [Column("mh_Takvim_262")]
    public byte? MhTakvim262 { get; set; }

    [Column("mh_Takvim_263")]
    public byte? MhTakvim263 { get; set; }

    [Column("mh_Takvim_264")]
    public byte? MhTakvim264 { get; set; }

    [Column("mh_Takvim_265")]
    public byte? MhTakvim265 { get; set; }

    [Column("mh_Takvim_266")]
    public byte? MhTakvim266 { get; set; }

    [Column("mh_Takvim_267")]
    public byte? MhTakvim267 { get; set; }

    [Column("mh_Takvim_268")]
    public byte? MhTakvim268 { get; set; }

    [Column("mh_Takvim_269")]
    public byte? MhTakvim269 { get; set; }

    [Column("mh_Takvim_270")]
    public byte? MhTakvim270 { get; set; }

    [Column("mh_Takvim_271")]
    public byte? MhTakvim271 { get; set; }

    [Column("mh_Takvim_272")]
    public byte? MhTakvim272 { get; set; }

    [Column("mh_Takvim_273")]
    public byte? MhTakvim273 { get; set; }

    [Column("mh_Takvim_274")]
    public byte? MhTakvim274 { get; set; }

    [Column("mh_Takvim_275")]
    public byte? MhTakvim275 { get; set; }

    [Column("mh_Takvim_276")]
    public byte? MhTakvim276 { get; set; }

    [Column("mh_Takvim_277")]
    public byte? MhTakvim277 { get; set; }

    [Column("mh_Takvim_278")]
    public byte? MhTakvim278 { get; set; }

    [Column("mh_Takvim_279")]
    public byte? MhTakvim279 { get; set; }

    [Column("mh_Takvim_280")]
    public byte? MhTakvim280 { get; set; }

    [Column("mh_Takvim_281")]
    public byte? MhTakvim281 { get; set; }

    [Column("mh_Takvim_282")]
    public byte? MhTakvim282 { get; set; }

    [Column("mh_Takvim_283")]
    public byte? MhTakvim283 { get; set; }

    [Column("mh_Takvim_284")]
    public byte? MhTakvim284 { get; set; }

    [Column("mh_Takvim_285")]
    public byte? MhTakvim285 { get; set; }

    [Column("mh_Takvim_286")]
    public byte? MhTakvim286 { get; set; }

    [Column("mh_Takvim_287")]
    public byte? MhTakvim287 { get; set; }

    [Column("mh_Takvim_288")]
    public byte? MhTakvim288 { get; set; }

    [Column("mh_Takvim_289")]
    public byte? MhTakvim289 { get; set; }

    [Column("mh_Takvim_290")]
    public byte? MhTakvim290 { get; set; }

    [Column("mh_Takvim_291")]
    public byte? MhTakvim291 { get; set; }

    [Column("mh_Takvim_292")]
    public byte? MhTakvim292 { get; set; }

    [Column("mh_Takvim_293")]
    public byte? MhTakvim293 { get; set; }

    [Column("mh_Takvim_294")]
    public byte? MhTakvim294 { get; set; }

    [Column("mh_Takvim_295")]
    public byte? MhTakvim295 { get; set; }

    [Column("mh_Takvim_296")]
    public byte? MhTakvim296 { get; set; }

    [Column("mh_Takvim_297")]
    public byte? MhTakvim297 { get; set; }

    [Column("mh_Takvim_298")]
    public byte? MhTakvim298 { get; set; }

    [Column("mh_Takvim_299")]
    public byte? MhTakvim299 { get; set; }

    [Column("mh_Takvim_300")]
    public byte? MhTakvim300 { get; set; }

    [Column("mh_Takvim_301")]
    public byte? MhTakvim301 { get; set; }

    [Column("mh_Takvim_302")]
    public byte? MhTakvim302 { get; set; }

    [Column("mh_Takvim_303")]
    public byte? MhTakvim303 { get; set; }

    [Column("mh_Takvim_304")]
    public byte? MhTakvim304 { get; set; }

    [Column("mh_Takvim_305")]
    public byte? MhTakvim305 { get; set; }

    [Column("mh_Takvim_306")]
    public byte? MhTakvim306 { get; set; }

    [Column("mh_Takvim_307")]
    public byte? MhTakvim307 { get; set; }

    [Column("mh_Takvim_308")]
    public byte? MhTakvim308 { get; set; }

    [Column("mh_Takvim_309")]
    public byte? MhTakvim309 { get; set; }

    [Column("mh_Takvim_310")]
    public byte? MhTakvim310 { get; set; }

    [Column("mh_Takvim_311")]
    public byte? MhTakvim311 { get; set; }

    [Column("mh_Takvim_312")]
    public byte? MhTakvim312 { get; set; }

    [Column("mh_Takvim_313")]
    public byte? MhTakvim313 { get; set; }

    [Column("mh_Takvim_314")]
    public byte? MhTakvim314 { get; set; }

    [Column("mh_Takvim_315")]
    public byte? MhTakvim315 { get; set; }

    [Column("mh_Takvim_316")]
    public byte? MhTakvim316 { get; set; }

    [Column("mh_Takvim_317")]
    public byte? MhTakvim317 { get; set; }

    [Column("mh_Takvim_318")]
    public byte? MhTakvim318 { get; set; }

    [Column("mh_Takvim_319")]
    public byte? MhTakvim319 { get; set; }

    [Column("mh_Takvim_320")]
    public byte? MhTakvim320 { get; set; }

    [Column("mh_Takvim_321")]
    public byte? MhTakvim321 { get; set; }

    [Column("mh_Takvim_322")]
    public byte? MhTakvim322 { get; set; }

    [Column("mh_Takvim_323")]
    public byte? MhTakvim323 { get; set; }

    [Column("mh_Takvim_324")]
    public byte? MhTakvim324 { get; set; }

    [Column("mh_Takvim_325")]
    public byte? MhTakvim325 { get; set; }

    [Column("mh_Takvim_326")]
    public byte? MhTakvim326 { get; set; }

    [Column("mh_Takvim_327")]
    public byte? MhTakvim327 { get; set; }

    [Column("mh_Takvim_328")]
    public byte? MhTakvim328 { get; set; }

    [Column("mh_Takvim_329")]
    public byte? MhTakvim329 { get; set; }

    [Column("mh_Takvim_330")]
    public byte? MhTakvim330 { get; set; }

    [Column("mh_Takvim_331")]
    public byte? MhTakvim331 { get; set; }

    [Column("mh_Takvim_332")]
    public byte? MhTakvim332 { get; set; }

    [Column("mh_Takvim_333")]
    public byte? MhTakvim333 { get; set; }

    [Column("mh_Takvim_334")]
    public byte? MhTakvim334 { get; set; }

    [Column("mh_Takvim_335")]
    public byte? MhTakvim335 { get; set; }

    [Column("mh_Takvim_336")]
    public byte? MhTakvim336 { get; set; }

    [Column("mh_Takvim_337")]
    public byte? MhTakvim337 { get; set; }

    [Column("mh_Takvim_338")]
    public byte? MhTakvim338 { get; set; }

    [Column("mh_Takvim_339")]
    public byte? MhTakvim339 { get; set; }

    [Column("mh_Takvim_340")]
    public byte? MhTakvim340 { get; set; }

    [Column("mh_Takvim_341")]
    public byte? MhTakvim341 { get; set; }

    [Column("mh_Takvim_342")]
    public byte? MhTakvim342 { get; set; }

    [Column("mh_Takvim_343")]
    public byte? MhTakvim343 { get; set; }

    [Column("mh_Takvim_344")]
    public byte? MhTakvim344 { get; set; }

    [Column("mh_Takvim_345")]
    public byte? MhTakvim345 { get; set; }

    [Column("mh_Takvim_346")]
    public byte? MhTakvim346 { get; set; }

    [Column("mh_Takvim_347")]
    public byte? MhTakvim347 { get; set; }

    [Column("mh_Takvim_348")]
    public byte? MhTakvim348 { get; set; }

    [Column("mh_Takvim_349")]
    public byte? MhTakvim349 { get; set; }

    [Column("mh_Takvim_350")]
    public byte? MhTakvim350 { get; set; }

    [Column("mh_Takvim_351")]
    public byte? MhTakvim351 { get; set; }

    [Column("mh_Takvim_352")]
    public byte? MhTakvim352 { get; set; }

    [Column("mh_Takvim_353")]
    public byte? MhTakvim353 { get; set; }

    [Column("mh_Takvim_354")]
    public byte? MhTakvim354 { get; set; }

    [Column("mh_Takvim_355")]
    public byte? MhTakvim355 { get; set; }

    [Column("mh_Takvim_356")]
    public byte? MhTakvim356 { get; set; }

    [Column("mh_Takvim_357")]
    public byte? MhTakvim357 { get; set; }

    [Column("mh_Takvim_358")]
    public byte? MhTakvim358 { get; set; }

    [Column("mh_Takvim_359")]
    public byte? MhTakvim359 { get; set; }

    [Column("mh_Takvim_360")]
    public byte? MhTakvim360 { get; set; }

    [Column("mh_Takvim_361")]
    public byte? MhTakvim361 { get; set; }

    [Column("mh_Takvim_362")]
    public byte? MhTakvim362 { get; set; }

    [Column("mh_Takvim_363")]
    public byte? MhTakvim363 { get; set; }

    [Column("mh_Takvim_364")]
    public byte? MhTakvim364 { get; set; }

    [Column("mh_Takvim_365")]
    public byte? MhTakvim365 { get; set; }

    [Column("mh_Takvim_366")]
    public byte? MhTakvim366 { get; set; }

    [Column("mh_ozsecimindex_1")]
    public byte? MhOzsecimindex1 { get; set; }

    [Column("mh_tatilgunidx_1")]
    public byte? MhTatilgunidx1 { get; set; }

    [Column("mh_listval_1")]
    [StringLength(25)]
    public string? MhListval1 { get; set; }

    [Column("mh_ozsecimindex_2")]
    public byte? MhOzsecimindex2 { get; set; }

    [Column("mh_tatilgunidx_2")]
    public byte? MhTatilgunidx2 { get; set; }

    [Column("mh_listval_2")]
    [StringLength(25)]
    public string? MhListval2 { get; set; }

    [Column("mh_ozsecimindex_3")]
    public byte? MhOzsecimindex3 { get; set; }

    [Column("mh_tatilgunidx_3")]
    public byte? MhTatilgunidx3 { get; set; }

    [Column("mh_listval_3")]
    [StringLength(25)]
    public string? MhListval3 { get; set; }

    [Column("mh_ozsecimindex_4")]
    public byte? MhOzsecimindex4 { get; set; }

    [Column("mh_tatilgunidx_4")]
    public byte? MhTatilgunidx4 { get; set; }

    [Column("mh_listval_4")]
    [StringLength(25)]
    public string? MhListval4 { get; set; }

    [Column("mh_ozsecimindex_5")]
    public byte? MhOzsecimindex5 { get; set; }

    [Column("mh_tatilgunidx_5")]
    public byte? MhTatilgunidx5 { get; set; }

    [Column("mh_listval_5")]
    [StringLength(25)]
    public string? MhListval5 { get; set; }

    [Column("mh_ozsecimindex_6")]
    public byte? MhOzsecimindex6 { get; set; }

    [Column("mh_tatilgunidx_6")]
    public byte? MhTatilgunidx6 { get; set; }

    [Column("mh_listval_6")]
    [StringLength(25)]
    public string? MhListval6 { get; set; }

    [Column("mh_ozsecimindex_7")]
    public byte? MhOzsecimindex7 { get; set; }

    [Column("mh_tatilgunidx_7")]
    public byte? MhTatilgunidx7 { get; set; }

    [Column("mh_listval_7")]
    [StringLength(25)]
    public string? MhListval7 { get; set; }

    [Column("mh_ozsecimindex_8")]
    public byte? MhOzsecimindex8 { get; set; }

    [Column("mh_tatilgunidx_8")]
    public byte? MhTatilgunidx8 { get; set; }

    [Column("mh_listval_8")]
    [StringLength(25)]
    public string? MhListval8 { get; set; }

    [Column("mh_ozsecimindex_9")]
    public byte? MhOzsecimindex9 { get; set; }

    [Column("mh_tatilgunidx_9")]
    public byte? MhTatilgunidx9 { get; set; }

    [Column("mh_listval_9")]
    [StringLength(25)]
    public string? MhListval9 { get; set; }

    [Column("mh_ozsecimindex_10")]
    public byte? MhOzsecimindex10 { get; set; }

    [Column("mh_tatilgunidx_10")]
    public byte? MhTatilgunidx10 { get; set; }

    [Column("mh_listval_10")]
    [StringLength(25)]
    public string? MhListval10 { get; set; }

    [Column("mh_ozsecimindex_11")]
    public byte? MhOzsecimindex11 { get; set; }

    [Column("mh_tatilgunidx_11")]
    public byte? MhTatilgunidx11 { get; set; }

    [Column("mh_listval_11")]
    [StringLength(25)]
    public string? MhListval11 { get; set; }

    [Column("mh_ozsecimindex_12")]
    public byte? MhOzsecimindex12 { get; set; }

    [Column("mh_tatilgunidx_12")]
    public byte? MhTatilgunidx12 { get; set; }

    [Column("mh_listval_12")]
    [StringLength(25)]
    public string? MhListval12 { get; set; }

    [Column("mh_ozsecimindex_13")]
    public byte? MhOzsecimindex13 { get; set; }

    [Column("mh_tatilgunidx_13")]
    public byte? MhTatilgunidx13 { get; set; }

    [Column("mh_listval_13")]
    [StringLength(25)]
    public string? MhListval13 { get; set; }

    [Column("mh_ozsecimindex_14")]
    public byte? MhOzsecimindex14 { get; set; }

    [Column("mh_tatilgunidx_14")]
    public byte? MhTatilgunidx14 { get; set; }

    [Column("mh_listval_14")]
    [StringLength(25)]
    public string? MhListval14 { get; set; }

    [Column("mh_ozsecimindex_15")]
    public byte? MhOzsecimindex15 { get; set; }

    [Column("mh_tatilgunidx_15")]
    public byte? MhTatilgunidx15 { get; set; }

    [Column("mh_listval_15")]
    [StringLength(25)]
    public string? MhListval15 { get; set; }

    [Column("mh_ozsecimindex_16")]
    public byte? MhOzsecimindex16 { get; set; }

    [Column("mh_tatilgunidx_16")]
    public byte? MhTatilgunidx16 { get; set; }

    [Column("mh_listval_16")]
    [StringLength(25)]
    public string? MhListval16 { get; set; }

    [Column("mh_ozsecimindex_17")]
    public byte? MhOzsecimindex17 { get; set; }

    [Column("mh_tatilgunidx_17")]
    public byte? MhTatilgunidx17 { get; set; }

    [Column("mh_listval_17")]
    [StringLength(25)]
    public string? MhListval17 { get; set; }

    [Column("mh_ozsecimindex_18")]
    public byte? MhOzsecimindex18 { get; set; }

    [Column("mh_tatilgunidx_18")]
    public byte? MhTatilgunidx18 { get; set; }

    [Column("mh_listval_18")]
    [StringLength(25)]
    public string? MhListval18 { get; set; }

    [Column("mh_ozsecimindex_19")]
    public byte? MhOzsecimindex19 { get; set; }

    [Column("mh_tatilgunidx_19")]
    public byte? MhTatilgunidx19 { get; set; }

    [Column("mh_listval_19")]
    [StringLength(25)]
    public string? MhListval19 { get; set; }

    [Column("mh_ozsecimindex_20")]
    public byte? MhOzsecimindex20 { get; set; }

    [Column("mh_tatilgunidx_20")]
    public byte? MhTatilgunidx20 { get; set; }

    [Column("mh_listval_20")]
    [StringLength(25)]
    public string? MhListval20 { get; set; }

    [Column("mh_ozsecimindex_21")]
    public byte? MhOzsecimindex21 { get; set; }

    [Column("mh_tatilgunidx_21")]
    public byte? MhTatilgunidx21 { get; set; }

    [Column("mh_listval_21")]
    [StringLength(25)]
    public string? MhListval21 { get; set; }

    [Column("mh_ozsecimindex_22")]
    public byte? MhOzsecimindex22 { get; set; }

    [Column("mh_tatilgunidx_22")]
    public byte? MhTatilgunidx22 { get; set; }

    [Column("mh_listval_22")]
    [StringLength(25)]
    public string? MhListval22 { get; set; }

    [Column("mh_ozsecimindex_23")]
    public byte? MhOzsecimindex23 { get; set; }

    [Column("mh_tatilgunidx_23")]
    public byte? MhTatilgunidx23 { get; set; }

    [Column("mh_listval_23")]
    [StringLength(25)]
    public string? MhListval23 { get; set; }

    [Column("mh_ozsecimindex_24")]
    public byte? MhOzsecimindex24 { get; set; }

    [Column("mh_tatilgunidx_24")]
    public byte? MhTatilgunidx24 { get; set; }

    [Column("mh_listval_24")]
    [StringLength(25)]
    public string? MhListval24 { get; set; }

    [Column("mh_ozsecimindex_25")]
    public byte? MhOzsecimindex25 { get; set; }

    [Column("mh_tatilgunidx_25")]
    public byte? MhTatilgunidx25 { get; set; }

    [Column("mh_listval_25")]
    [StringLength(25)]
    public string? MhListval25 { get; set; }

    [Column("mh_ozsecimindex_26")]
    public byte? MhOzsecimindex26 { get; set; }

    [Column("mh_tatilgunidx_26")]
    public byte? MhTatilgunidx26 { get; set; }

    [Column("mh_listval_26")]
    [StringLength(25)]
    public string? MhListval26 { get; set; }

    [Column("mh_ozsecimindex_27")]
    public byte? MhOzsecimindex27 { get; set; }

    [Column("mh_tatilgunidx_27")]
    public byte? MhTatilgunidx27 { get; set; }

    [Column("mh_listval_27")]
    [StringLength(25)]
    public string? MhListval27 { get; set; }

    [Column("mh_ozsecimindex_28")]
    public byte? MhOzsecimindex28 { get; set; }

    [Column("mh_tatilgunidx_28")]
    public byte? MhTatilgunidx28 { get; set; }

    [Column("mh_listval_28")]
    [StringLength(25)]
    public string? MhListval28 { get; set; }

    [Column("mh_ozsecimindex_29")]
    public byte? MhOzsecimindex29 { get; set; }

    [Column("mh_tatilgunidx_29")]
    public byte? MhTatilgunidx29 { get; set; }

    [Column("mh_listval_29")]
    [StringLength(25)]
    public string? MhListval29 { get; set; }

    [Column("mh_ozsecimindex_30")]
    public byte? MhOzsecimindex30 { get; set; }

    [Column("mh_tatilgunidx_30")]
    public byte? MhTatilgunidx30 { get; set; }

    [Column("mh_listval_30")]
    [StringLength(25)]
    public string? MhListval30 { get; set; }

    [Column("mh_ozsecimindex_31")]
    public byte? MhOzsecimindex31 { get; set; }

    [Column("mh_tatilgunidx_31")]
    public byte? MhTatilgunidx31 { get; set; }

    [Column("mh_listval_31")]
    [StringLength(25)]
    public string? MhListval31 { get; set; }

    [Column("mh_ozmhuyar")]
    public bool? MhOzmhuyar { get; set; }

    [Column("mh_OzMahFisIslTarS")]
    public byte? MhOzMahFisIslTarS { get; set; }

    [Column("mh_ozmahbeymah")]
    public bool? MhOzmahbeymah { get; set; }
}
