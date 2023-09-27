using AutoMapper;
using LoginAPI.Config.Mapping;
using LoginAPI.Data;
using LoginAPI.Exceptions;
using LoginAPI.Models;
using LoginAPI.Services.SendMail;
using LoginAPI.ValuesObjects;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace LoginAPI.Repository
{
    public class UserRepository : IUsersRepository
    {
        private readonly AplicationDbContextUser _dbUser;
        private readonly IMapper _mapper;
        //private readonly MappingConfig.Retorno_Out() _mapperConfig;

        public UserRepository(AplicationDbContextUser dbUser, IMapper mapper)
        {
            _dbUser = dbUser;
            _mapper = mapper;
            //_mapperConfig = mapperConfig;

        }

        public bool AtualizarSenha(string email)
        {
            try
            {
                email = Criptografia.CripitografiaEmailEtc.Criptografar(email);
                UserModel User = _dbUser.User1.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
                email = Criptografia.CripitografiaEmailEtc.Descriptografar(email);
                _ = SendMailSendGrid.SendMail(
                    "igorpaimdeoliveira@gmail.com", //testemanipulacaoemail@gmail.com
                    "Igor",
                    email,
                    "Qualquer um",
                    "Recuperação de Senha",
                    string.Empty,
                    "google.com");
                return true;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public UserVO_Out Create(UserVO_In userVO_In)
        {
            try
            {
                UserModel User = _mapper.Map<UserModel>(userVO_In);
                User.DataCadastro = DateTime.Now;
                User.Email = Criptografia.CripitografiaEmailEtc.Criptografar(User.Email);
                User.Phone = Criptografia.CripitografiaEmailEtc.Criptografar(User.Phone);
                _dbUser.User1.Add(User);
                _dbUser.SaveChanges();
                return _mapper.Map<UserVO_Out>(userVO_In);
                //return _mapper.Map<UserVO_Out>(userVO_In);
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
                UserModel User = _dbUser.User1.FirstOrDefault(x => x.Email == email) ?? new UserModel(0, string.Empty, new byte[0], string.Empty, string.Empty, DateTime.Now, DateTime.Now, "defalt");
                if (User.Id <= 0) { return false; }
                _dbUser.User1.Remove(User);
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
                List<UserModel> User = _dbUser.User1.ToList();
                if (User == null) throw new GenericException("opa, ninguem foi encontrado");
                List<UserVO_Out> userOut = new List<UserVO_Out>(); 
                foreach (UserModel user1 in User)
                {
                     userOut.Add(MappingConfig.Retorno_Out(user1));
                }
                return userOut;
                //return _mapper.Map <List<UserVO_Out>>(User);
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
                UserModel User = _dbUser.User1.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
                return MappingConfig.Retorno_Out(User);
                //return _mapper.Map<UserVO_Out>(User);
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
                UserModel UserUpdate = _dbUser.User1.FirstOrDefault(x => x.Email == email) ?? throw new GenericException("Nenhum resultado encontrado");
                var User = _mapper.Map<UserModel>(userVO);
                UserUpdate.Nome = User.Nome;
                UserUpdate.BytePassword = User.BytePassword;
                UserUpdate.Email = Criptografia.CripitografiaEmailEtc.Criptografar(User.Email);
                UserUpdate.Phone = Criptografia.CripitografiaEmailEtc.Criptografar(User.Phone);
                UserUpdate.DataAtualizacao = DateTime.Now;
                _dbUser.User1.Update(UserUpdate);
                _dbUser.SaveChanges();
                return MappingConfig.Retorno_Out(UserUpdate);
                //return _mapper.Map<UserVO_Out>(UserUpdate);
            }
            catch(Exception ex) 
            {
                throw new Exception($"Opa Tivemos um Erro {ex}");
            }
        }
    }
}
