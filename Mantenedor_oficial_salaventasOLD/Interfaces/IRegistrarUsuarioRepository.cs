using Mantenedor_oficial_salaventasOLD.Application;

namespace Mantenedor_oficial_salaventasOLD.Interfaces
{
    public interface IRegistrarUsuarioRepository
    {
        Task<ResponseDTO<UsuarioDTO>> RegistrarUsuario(UsuarioDTO usuariodto);
    }
}
