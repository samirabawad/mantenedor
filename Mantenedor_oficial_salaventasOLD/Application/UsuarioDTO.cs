using Mantenedor_oficial_salaventasOLD.Enums;
using System.ComponentModel.DataAnnotations;

namespace Mantenedor_oficial_salaventasOLD.Application
{
    public class UsuarioDTO
    {
        [Required(ErrorMessage = "El nombre de usuario es obligatorio")]
        [MaxLength(50)]
        public string NombreUsuario { get; set; }

        [Required(ErrorMessage = "El código de unidad es obligatorio")]
        public decimal CodUnidad { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        [MinLength(6, ErrorMessage = "La contraseña debe tener al menos 6 caracteres")]
        [MaxLength(100)]
        public string Password { get; set; }

        /// <summary>
        /// Perfil del usuario - selecciona del desplegable
        /// </summary>
        [Required(ErrorMessage = "El perfil es obligatorio")]
        public PerfilUsuarioEnum IdPerfil { get; set; }

        [Required(ErrorMessage = "El RUT es obligatorio")]
        public decimal RutNum { get; set; }

        [Required(ErrorMessage = "El dígito verificador es obligatorio")]
        [MaxLength(1)]
        public char RutDgv { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [MaxLength(20)]
        public string Nombres { get; set; }

        [Required(ErrorMessage = "El primer apellido es obligatorio")]
        [MaxLength(20)]
        public string Apellido1 { get; set; }

        [MaxLength(20)]
        public string? Apellido2 { get; set; }

        /// <summary>
        /// Estado del usuario - Activo o Inactivo
        /// </summary>
        public EstadoActivoEnum Activo { get; set; } = EstadoActivoEnum.Activo;

        public DateTime? Vigencia { get; set; }

        public decimal Intentos { get; set; } = 0;

        [EmailAddress(ErrorMessage = "El email no es válido")]
        [MaxLength(50)]
        public string? Mail { get; set; }

        public decimal Anexo { get; set; }

        /// <summary>
        /// Tipo de contraseña - Temporal o Permanente
        /// </summary>
        public TipoPasswordEnum IsTempPass { get; set; } = TipoPasswordEnum.Permanente;

        public DateTime? VigenciaPass { get; set; }

        public DateTime? FecAcceso { get; set; }
    }
}