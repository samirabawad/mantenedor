using Mantenedor_oficial_salaventasOLD.Application;
using Mantenedor_oficial_salaventasOLD.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


using Mantenedor_oficial_salaventasOLD.Application;
using Mantenedor_oficial_salaventasOLD.Filters;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;



namespace Mantenedor_oficial_salaventasOLD.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [ApiKeyAuth] // Aplicar autenticación a todo el controller
    public class UsuarioController : ControllerBase
    {
        private readonly RegistrarUsuarioUseCase _registrarUsuarioUseCase;
        private readonly ILogger<UsuarioController> _logger;

        public UsuarioController(
            RegistrarUsuarioUseCase registrarUsuarioUseCase,
            ILogger<UsuarioController> logger)
        {
            _registrarUsuarioUseCase = registrarUsuarioUseCase;
            _logger = logger;
        }


        [HttpPost("registrar")]
        public async Task<IActionResult> RegistrarUsuario([FromBody] UsuarioDTO usuario)
        {
            try
            {
                _logger.LogInformation("Iniciando registro de usuario. Email: {Email}", usuario);

                if (usuario == null)
                {
                    _logger.LogWarning("Intento de registro con datos nulos");
                    return BadRequest(new { mensaje = "Los datos del usuario son requeridos" });
                }

                _logger.LogDebug("Validando datos del usuario: {UsuarioData}",
                    System.Text.Json.JsonSerializer.Serialize(new { usuario}));

                // Ejecutar el caso de uso
                var resultado = await _registrarUsuarioUseCase.ExecuteAsync(usuario);

                _logger.LogInformation("Usuario registrado exitosamente. Email: {Email}, ID: {Id}",
                    usuario, resultado);

                return Ok(new { mensaje = "Usuario registrado exitosamente", data = resultado });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error inesperado al registrar usuario. Email: {Email}", usuario);
                return StatusCode(500, new { mensaje = "Error interno del servidor" });
            }
        }
    }
}