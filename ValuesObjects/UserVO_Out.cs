namespace LoginAPI.ValuesObjects
{
    public class UserVO_Out
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public UserVO_Out(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }
    }
}
