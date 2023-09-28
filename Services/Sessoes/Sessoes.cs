using LoginAPI.Models;
using LoginAPI.ValuesObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace LoginAPI.Services.Sessecoes
{
    public class Sessoes : ISessecoes
    {
        private readonly IHttpContextAccessor _httpContext;

        public Sessoes(IHttpContextAccessor httpContext)
        {
            _httpContext = httpContext;
        }
        public void Create(UserVO_In userVO_In, string token)
        {
            JObject jsonObject = JObject.FromObject(userVO_In);
            jsonObject.Add("Token", token);
            string jsonText = JsonConvert.SerializeObject(jsonObject);
            _httpContext.HttpContext.Session.SetString("userLogado", jsonText);
        }

        public UserModel GetUser()
        {
            string sessaoUser = _httpContext.HttpContext.Session.GetString("userLogado");
            if(string.IsNullOrEmpty(sessaoUser)) { return null; }
            return JsonConvert.DeserializeObject<UserModel>(sessaoUser);
        }

        public void Remove()
        {
            _httpContext.HttpContext.Session.Remove("userLogado");
        }
    }
}
