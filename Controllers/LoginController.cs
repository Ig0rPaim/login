using LoginAPI.Exceptions;
using LoginAPI.Repository;
using LoginAPI.Services.Sessecoes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ISessecoes _sessoes;

        public LoginController(IUsersRepository usersRepository, ISessecoes sessecoes)
        {
            _usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(Repository));
            _sessoes = sessecoes;
        }

        [HttpGet("usuarios/logon/{email}")]
        public ActionResult Logon(string email)
        {
            try
            {
                string token  = _usersRepository.GetToken(email);
                return Ok(token);

            }
            catch (GenericException ex)
            {
                return BadRequest($"{ex.Message}");
            }
            catch (Exception ex)
            {
                return BadRequest($"{ex.Message}");
            }
        }
    }
}
