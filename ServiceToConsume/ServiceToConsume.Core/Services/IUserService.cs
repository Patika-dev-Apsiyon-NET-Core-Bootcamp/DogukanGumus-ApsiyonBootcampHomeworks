using System.Threading.Tasks;
using ServiceToConsume.Core.DTOs;
using SharedLibrary.DTOs;

namespace ServiceToConsume.Core.Services
{
    public interface IUserService
    {
        Task<Response<UserAppDto>> CreateUserAsync(CreateUserDto createUserDto);

        Task<Response<UserAppDto>> GetUserByNameAsync(string userName);
    }
}