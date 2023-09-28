using LoginAPI.ValuesObjects;

namespace LoginAPI.Repository
{
    public interface IUsersRepository
    {
        string GetToken(string email);
        List<UserVO_Out> GetAll();
        UserVO_Out GetByEmail(string email);
        UserVO_Out Create(UserVO_In userVO);
        UserVO_Out Update(UserVO_In userVO, string email);
        bool Delete(string email);
        bool AtualizarSenha(string email);
    }
}
