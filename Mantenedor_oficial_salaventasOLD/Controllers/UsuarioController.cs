using Mantenedor_oficial_salaventasOLD.Application;
using Mantenedor_oficial_salaventasOLD.Enums;
using Mantenedor_oficial_salaventasOLD.Filters;
using Mantenedor_oficial_salaventasOLD.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Mantenedor_oficial_salaventasOLD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiKeyAuth]
    public class UsuarioController : ControllerBase
    {
        private readonly IRegistrarUsuarioRepository _repository;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(
            IRegistrarUsuarioRepository repository,
            ILogger<UsuarioController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

 

        /// <summary>
/// Registra un nuevo usuario usando formulario
/// Los campos con enum aparecerán como desplegables
/// </summary>
[HttpPost("registrar-formulario")]
[Consumes("application/x-www-form-urlencoded")]
[ProducesResponseType(StatusCodes.Status200OK)]
[ProducesResponseType(StatusCodes.Status400BadRequest)]
[ProducesResponseType(StatusCodes.Status401Unauthorized)]
public async Task<IActionResult> RegistrarUsuarioFormulario(
    [FromForm] string nombreUsuario,
    [FromForm] decimal codUnidad,
    [FromForm] string password,
    [FromForm] PerfilUsuarioEnum perfil,
    [FromForm] decimal rutNum,
    [FromForm] char rutDgv,
    [FromForm] string nombres,
    [FromForm] string apellido1,
    [FromForm] string? apellido2,
    [FromForm] EstadoActivoEnum activo,
    [FromForm] string? mail,
    [FromForm] decimal anexo,
    [FromForm] TipoPasswordEnum isTempPass)
{
    _logger.LogInformation("Registrando usuario desde formulario: {NombreUsuario}", nombreUsuario);

    // Validaciones
    if (string.IsNullOrWhiteSpace(nombreUsuario))
        return BadRequest(new { Error = "El nombre de usuario es obligatorio" });

    if (string.IsNullOrWhiteSpace(password) || password.Length < 6)
        return BadRequest(new { Error = "La contraseña debe tener al menos 6 caracteres" });

    // Crear el DTO
    var usuarioDto = new UsuarioDTO
    {
        NombreUsuario = nombreUsuario,
        CodUnidad = codUnidad,
        Password = password,
        IdPerfil = perfil,
        RutNum = rutNum,
        RutDgv = rutDgv,
        Nombres = nombres,
        Apellido1 = apellido1,
        Apellido2 = apellido2,
        Activo = activo,
        Vigencia = DateTime.Now.AddYears(1),
        Intentos = 0,
        Mail = mail,
        Anexo = anexo,
        IsTempPass = isTempPass,
        VigenciaPass = isTempPass == TipoPasswordEnum.Temporal 
            ? DateTime.Now.AddDays(30) 
            : (DateTime?)null,
        FecAcceso = null
    };

    // Llamar al repository
    var resultado = await _repository.RegistrarUsuario(usuarioDto);

    if (resultado.Success)
        return Ok(resultado);

    return StatusCode(500, resultado);
}

    }
}