using LoginAPI.Exceptions;
using LoginAPI.Models;
using LoginAPI.Repository;
using LoginAPI.ValuesObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LoginAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUsersRepository _usersRepository;

        public UserController(IUsersRepository usersRepository)
        {
            _usersRepository = usersRepository ?? throw new ArgumentNullException(nameof(Repository));
        }
        [HttpGet("usuarios")]
        public ActionResult GetAll()
        {
            try
            {
                var User = _usersRepository.GetAll();
                return Ok(User);
            }
            catch(GenericException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("usuarios/{email}")]
        public ActionResult GetByEmail(string email)
        {
            try
            {
                var User = _usersRepository.GetByEmail(email);
                return Ok(User);
            }
            catch (GenericException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost("usuarios")]
        public ActionResult Create([FromBody] UserVO_In UserVO)
        {
            try
            {
                if (UserVO == null) { return BadRequest("Entidade Vazia"); }
                if (!UserVO.IsValid) { return BadRequest(UserVO.Notifications); }

                var User = _usersRepository.Create(UserVO);
                return Ok(User);
            }
            catch (GenericException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("usuarios/{email}")]
        public ActionResult Update([FromBody] UserVO_In UserVO, string email)
        {
            try
            {
                if (UserVO == null) { return BadRequest("Entidade Vazia"); }
                if (!UserVO.IsValid) { return BadRequest(UserVO.Notifications); }
                var User = _usersRepository.Update(UserVO, email);
                return Ok(User);
            }
            catch (GenericException ex)
            {
                return NotFound(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("usuarios/{email}")]
        public ActionResult Delete(string email)
        {
            try
            {
                var Status = _usersRepository.Delete(email);
                if(Status == false) return NotFound(Status);
                return Ok(Status);
            }
            catch (GenericException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPatch("usuarios/{email}")]
        public ActionResult AtualizarSenha(string email)
        {
            try
            {
                _usersRepository.AtualizarSenha(email);
                return Ok();
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
