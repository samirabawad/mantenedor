using DICREP.EcommerceSubastas.Application.DTOs.Responses;
using Mantenedor_oficial_salaventasOLD.Application;
using Mantenedor_oficial_salaventasOLD.Interfaces;
using Mantenedor_oficial_salaventasOLD.Models;
using Mantenedor_oficial_salaventasOLD.Services;
using Microsoft.Extensions.Logging;

namespace Mantenedor_oficial_salaventasOLD.Repositories
{
    public class RegistrarUsuarioRepository : IRegistrarUsuarioRepository
    {
        private readonly SvdDbContext _context;
        private readonly ILogger<RegistrarUsuarioRepository> _logger;
        private readonly IPasswordHasher _passwordHasher;

        public RegistrarUsuarioRepository(
            SvdDbContext context,
            ILogger<RegistrarUsuarioRepository> logger,
            IPasswordHasher passwordHasher)
        {
            _context = context;
            _logger = logger;
            _passwordHasher = passwordHasher;
        }

        public async Task<ResponseDTO<UsuarioDTO>> RegistrarUsuario(UsuarioDTO usuariodto)
        {
            _logger.LogInformation("Registrando al usuario de rut {RutNum}", usuariodto.RutNum);

            var response = new ResponseDTO<UsuarioDTO>();

            try
            {
                // Encriptar la contraseña
                string hashedPassword = _passwordHasher.HashPassword(usuariodto.Password);

                var usuario = new Usuario
                {
                    IdUsuario = usuariodto.NombreUsuario,
                    CodUnidad = usuariodto.CodUnidad,
                    Password = hashedPassword,
                    // ✅ Convertir enum a string
                    IdPerfil = usuariodto.IdPerfil.ToString(),
                    RutNum = usuariodto.RutNum,
                    RutDgv = usuariodto.RutDgv.ToString(),
                    Nombres = usuariodto.Nombres,
                    Apellido1 = usuariodto.Apellido1,
                    Apellido2 = usuariodto.Apellido2,
                    // ✅ Convertir enum a decimal (0 o 1)
                    Activo = (decimal)usuariodto.Activo,
                    Vigencia = usuariodto.Vigencia,
                    Intentos = usuariodto.Intentos,
                    Mail = usuariodto.Mail,
                    Anexo = usuariodto.Anexo,
                    // ✅ Convertir enum a decimal (0 o 1)
                    IsTempPass = (decimal)usuariodto.IsTempPass,
                    VigenciaPass = usuariodto.VigenciaPass,
                    FecAcceso = usuariodto.FecAcceso
                };

                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Usuario {IdUsuario} con RUT {RutNum} registrado exitosamente con perfil {Perfil}",
                    usuariodto.NombreUsuario, usuariodto.RutNum, usuariodto.IdPerfil);

                response.Success = true;
                response.Data = usuariodto;
                response.Message = "Usuario registrado exitosamente";

                return response;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al registrar usuario {RutNum}: {ErrorMessage}",
                    usuariodto.RutNum, ex.Message);

                response.Success = false;
                response.Error = new ErrorResponseDto
                {
                    ErrorCode = 500,
                    Message = $"Error al registrar usuario: {ex.Message}",
                    HttpStatusCode = 500
                };
                response.Message = "Error al registrar usuario";

                return response;
            }
        }
    }
}