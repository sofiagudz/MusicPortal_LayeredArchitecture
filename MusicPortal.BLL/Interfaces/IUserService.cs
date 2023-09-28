using MusicPortal.BLL.DTO;

namespace MusicPortal.BLL.Interfaces
{
    public interface IUserService
    {
        Task AddUser(UserDTO userDTO);
        Task<IEnumerable<UserDTO>> GetUsers();
    }
}
