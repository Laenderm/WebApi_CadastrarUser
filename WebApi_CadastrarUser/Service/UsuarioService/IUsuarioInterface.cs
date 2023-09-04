using WebApi_CadastrarUser.Models;

namespace WebApi_CadastrarUser.Service.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<ServiceResponse<List<UsuarioModel>>> GetUsuarios();
        Task<ServiceResponse<List<UsuarioModel>>> CreateUsuario(UsuarioModel novoUsuario);
        Task<ServiceResponse<UsuarioModel>> GetUsuariosByID(int ID);
        Task<ServiceResponse<List<UsuarioModel>>> UpdateUsuario(UsuarioModel editadoUsuario);

        Task<ServiceResponse<List<UsuarioModel>>> DeleteUsuarios(int id);


    }
}
