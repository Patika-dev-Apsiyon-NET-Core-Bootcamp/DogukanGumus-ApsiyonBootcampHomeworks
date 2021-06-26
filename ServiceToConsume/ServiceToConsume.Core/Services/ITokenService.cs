using ServiceToConsume.Core.Configurations;
using ServiceToConsume.Core.DTOs;
using ServiceToConsume.Core.Models;

namespace ServiceToConsume.Core.Services
{
    public interface ITokenService
    {
        TokenDto CreateToken(UserApp userApp);
        ClientTokenDto CreateTokenByClient(Client client);
    }
}