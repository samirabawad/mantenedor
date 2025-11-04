using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mantenedor_oficial_salaventasOLD.Models
{
    [Table("USUARIO", Schema = "SVD_PROD")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        [MaxLength(50)]
        public string IdUsuario { get; set; }

        [Column("COD_UNIDAD")]
        public decimal CodUnidad { get; set; }

        [Column("PASSWORD")]
        [MaxLength(4000)]
        public string Password { get; set; }

        [Column("ID_PERFIL")]
        [MaxLength(10)]
        public string IdPerfil { get; set; }

        [Column("RUT_NUM")]
        public decimal RutNum { get; set; }

        [Column("RUT_DGV")]
        [MaxLength(1)]
        public string RutDgv { get; set; }

        [Column("NOMBRES")]
        [MaxLength(20)]
        public string Nombres { get; set; }

        [Column("APELLIDO1")]
        [MaxLength(20)]
        public string Apellido1 { get; set; }

        [Column("APELLIDO2")]
        [MaxLength(20)]
        public string Apellido2 { get; set; }

        [Column("ACTIVO")]
        public decimal Activo { get; set; }

        [Column("VIGENCIA")]
        public DateTime? Vigencia { get; set; }

        [Column("INTENTOS")]
        public decimal Intentos { get; set; }

        [Column("MAIL")]
        [MaxLength(50)]
        public string Mail { get; set; }

        [Column("ANEXO")]
        public decimal Anexo { get; set; }

        [Column("ISTEMP_PASS")]
        public decimal IsTempPass { get; set; }

        [Column("VIGENCIA_PASS")]  // ✅ Nombre correcto
        public DateTime? VigenciaPass { get; set; }

        [Column("FEC_ACCESO")]
        public DateTime? FecAcceso { get; set; }
    }
}