using Mantenedor_oficial_salaventasOLD.Controllers;
using Mantenedor_oficial_salaventasOLD.Exceptions;
using System;
using System.Text;
using Mantenedor_oficial_salaventasOLD.Interfaces;

namespace Mantenedor_oficial_salaventasOLD.Application
{
    public class RegistrarUsuarioUseCase
    {
        private readonly ILogger<RegistrarUsuarioUseCase> _logger;
        private readonly IRegistrarUsuarioRepository _iregistrarUsuarioRepository;


        public RegistrarUsuarioUseCase(ILogger<RegistrarUsuarioUseCase> logger, IRegistrarUsuarioRepository iregistrarUsuarioRepository)
        {
            _logger = logger;
            _iregistrarUsuarioRepository = iregistrarUsuarioRepository;
        }

        public async Task<ResponseDTO<UsuarioDTO>> ExecuteAsync(UsuarioDTO usuariodto)
        {
            if (usuariodto == null)
            {
                _logger.LogWarning("usuario nulo");
                throw new DatosFaltantesException(nameof(usuariodto));
            }
            _logger.LogInformation("Se recibe usuario de rut : ", usuariodto.RutNum);

            try
            {
                var response = await _iregistrarUsuarioRepository.RegistrarUsuario(usuariodto);
                /*
                if (response.Success)
                {
                    _logger.LogInformation("ReceiveFichaUseCase: ficha procesada correctamente para producto ID {ProductId}", ficha.detalle_bien.id_publicacion_bien);
                }
                else
                {
                    _logger.Error("ReceiveFichaUseCase: error al procesar ficha producto ID {ProductId} - {ErrorMessage}",
                        ficha.detalle_bien.id_publicacion_bien,
                        response.Error?.Message);
                }
                */
                if (response!=null)
                {
                    return response;

                }
                else
                {
                    return response;
                }
            }
            catch (Exception ex)
            {

                //_logger.LogError(ex, "ReceiveFichaUseCase: excepción inesperada al procesar producto ID {ProductId}", ficha.detalle_bien.id_publicacion_bien);
                throw;
            }
        }
    }
}
