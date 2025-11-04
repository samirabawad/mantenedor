namespace Mantenedor_oficial_salaventasOLD.Application
{
    public class UsuarioDTO
    {
        public string NombreUsuario { get; set; }
        public int CodUnidad { get; set; }
        public string Password { get; set; }
        public string IdPerfil { get; set; }
        public long RutNum { get; set; }
        public char RutDgv { get; set; }
        public string Nombres { get; set; }
        public string Apellido1 { get; set; }
        public string Apellido2 { get; set; }
        public int Activo { get; set; }
        public DateTime? Vigencia { get; set; }
        public int Intentos { get; set; }
        public string Mail { get; set; }
        public long Anexo { get; set; }
        public bool IsTempPass { get; set; }
        public DateTime? VigenciaPass { get; set; }
        public DateTime? FecAcceso { get; set; }

    }
}
