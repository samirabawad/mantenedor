namespace Mantenedor_oficial_salaventasOLD.Enums
{
    /// <summary>
    /// Perfiles de usuario disponibles en el sistema
    /// </summary>
    public enum PerfilUsuarioEnum
    {
        SUPERADMIN,
        SUPERVISOR,
        CAJERO
    }

    /// <summary>
    /// Estado de activación del usuario
    /// </summary>
    public enum EstadoActivoEnum
    {
        Inactivo = 0,
        Activo = 1
    }

    /// <summary>
    /// Indica si la contraseña es temporal
    /// </summary>
    public enum TipoPasswordEnum
    {
        Permanente = 0,
        Temporal = 1
    }
}