using AutoMapper;
using LoginAPI.Data;
using LoginAPI.Exceptions;
using LoginAPI.Models;
using LoginAPI.Services;
using LoginAPI.ValuesObjects;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace LoginAPI.Repository
{
    public class UserRepository : IUsersRepository
    {
        private readonly AplicationDbContextUser _dbUser;
        private readonly IMapper _mapper;

        public UserRepository(AplicationDbContextUser dbUser, IMapper mapper)
        {
            _dbUser = dbUser;
            _mapper = mapper;
        }

        public void AtualizarSenha(string email)
        {
            email = Criptografia.CripitografiaEmailEtc.Criptografar(email);
            UserModel User = _dbUser.User.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
            email = Criptografia.CripitografiaEmailEtc.Descriptografar(email);
            SendMail.SendGmail(
                "igorpaimdeoliveira@gmail.com", //testemanipulacaoemail@gmail.com
                email,
                "chegueiatrasadoemail",
                "Teste",
                "TESTANDO ENVIAR EMAIL POR CODIGO");
        }

        public UserVO_Out Create(UserVO_In userVO_In)
        {
            try
            {
                UserModel User = _mapper.Map<UserModel>(userVO_In);
                User.DataCadastro = DateTime.Now;
                User.Email = Criptografia.CripitografiaEmailEtc.Criptografar(User.Email);
                User.Phone = Criptografia.CripitografiaEmailEtc.Criptografar(User.Phone);
                _dbUser.User.Add(User);
                _dbUser.SaveChanges();
                return _mapper.Map<UserVO_Out>(userVO_In);
            }
            catch (Exception ex)
            {
                throw new GenericException($"Opa tivemos um erro erro ao cadastrar você: {ex}");
            }
        }

        public bool Delete(string email)
        {
            try
            {
                email = Criptografia.CripitografiaEmailEtc.Criptografar(email);
                UserModel User = _dbUser.User.FirstOrDefault(x => x.Email == email) ?? new UserModel(0, string.Empty, new byte[0], string.Empty, string.Empty, DateTime.Now, DateTime.Now);
                if (User.Id <= 0) { return false; }
                _dbUser.User.Remove(User);
                _dbUser.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw new GenericException($"Opa tivemos um erro: {ex}");
            }
        }

        public List<UserVO_Out> GetAll()
        {
            try
            {
                List<UserModel> User = _dbUser.User.ToList();
                if (User == null) throw new GenericException("opa, ninguem foi encontrado"); 
                return _mapper.Map<List<UserVO_Out>>(User);
            }
            catch (Exception ex)
            {
                throw new Exception($"Opa! Tivemos um erro: {ex}");
            }
        }

        public UserVO_Out GetByEmail(string email)
        {
            try
            {
                email = Criptografia.CripitografiaEmailEtc.Criptografar(email);
                UserModel User = _dbUser.User.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
                return _mapper.Map<UserVO_Out>(User);
            }
            catch (Exception ex)
            {
                throw new Exception($"Opa tivemos um erro: {ex}");
            }
        }

        public UserVO_Out Update(UserVO_In userVO, string email)
        {
            try
            {
                email = Criptografia.CripitografiaEmailEtc.Criptografar(email);
                UserModel UserUpdate = _dbUser.User.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
                var User = _mapper.Map<UserModel>(userVO);
                UserUpdate.Nome = User.Nome;
                UserUpdate.BytePassword = User.BytePassword;
                UserUpdate.Email = Criptografia.CripitografiaEmailEtc.Criptografar(User.Email);
                UserUpdate.Phone = Criptografia.CripitografiaEmailEtc.Criptografar(User.Phone);
                UserUpdate.DataAtualizacao = DateTime.Now;
                _dbUser.User.Update(UserUpdate);
                _dbUser.SaveChanges();
                return _mapper.Map<UserVO_Out>(UserUpdate);
            }
            catch(Exception ex) 
            {
                throw new Exception($"Opa Tivemos um Erro {ex}");
            }
        }
    }
}
