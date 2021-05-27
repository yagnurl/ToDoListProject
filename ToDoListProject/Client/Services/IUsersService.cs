using System.Threading.Tasks;

using TodoListProject.Shared.Dto;

namespace TodoListProject.Client.Services
{
    public interface IUsersService
    {
        Task<UserDto> GetUser(int userId);

    }
}
