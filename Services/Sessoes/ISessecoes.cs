using LoginAPI.Models;
using LoginAPI.ValuesObjects;

namespace LoginAPI.Services.Sessecoes
{
    public interface ISessecoes
    {
        void Create(UserVO_In userVO_In, string token);
        void Remove();
        UserModel GetUser();
    }
}
