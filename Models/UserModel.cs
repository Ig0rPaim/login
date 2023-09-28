using Flunt.Notifications;
using Flunt.Validations;
//using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace LoginAPI.Models
{
    public class UserModel : Notifiable<Notification>
    {
        //[Key]
        public int Id { get; set; }
        //[Required(ErrorMessage = "Digite o Nome do Usuário")]
        public string Nome { get; set; }
        //[Required(ErrorMessage = "Digite a senha do Usuário")]
        public byte[] BytePassword { get; set; }
        //public byte[] BytePassword { get; set; }
        //[Required(ErrorMessage = "Digite o Email do Usuário")]
        //[EmailAddress(ErrorMessage = "O email não está em um formato válido")]
        public string Email { get; set; }
        //[Required(ErrorMessage = "Digite o telefone do Usuário")]
        //[Phone(ErrorMessage = "Formato de telefone invalido")]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:(##) ####-####}")]
        //[RegularExpression(@"^\d{11}$", ErrorMessage = "Formato de telefone inválido, Digite o DDD e os outros nove digitos, todos juntos")]

        public string Phone { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataAtualizacao { get; set; }
        public string Role { get; set; }
        public string Token { get; set; }

        public UserModel()
        {
        }

        //public UserModel(int id, string nome, string password, byte[] bytePassword, string email, string phone, DateTime dataCadastro, DateTime? dataAtualizacao)
        //{
        //    Id = id;
        //    Nome = nome ?? throw new ArgumentNullException(nameof(nome));
        //    Password = password ?? throw new ArgumentNullException(nameof(password));
        //    BytePassword = bytePassword ?? throw new ArgumentNullException(nameof(bytePassword));
        //    Email = email ?? throw new ArgumentNullException(nameof(email));
        //    Phone = phone ?? throw new ArgumentNullException(nameof(phone));
        //    DataCadastro = dataCadastro;
        //    DataAtualizacao = dataAtualizacao;
        //}

        public UserModel(int id, string nome, byte[] password, string email, string phone, DateTime dataCadastro, DateTime? dataAtualizacao, string role)
        {
            var contract = new Contract<UserModel>()
                .IsNotNull(id, "Id", "Campo Id vazio")
                .IsNotNullOrEmpty(nome, "Nome", "Campo nome vazio")
                .IsNotNull(password, "Password", "Campo senha vazio")
                .IsNotNullOrEmpty(phone, "Phone", "Campo telefone vazio")
                .IsNotNullOrEmpty(role, "Role", "Campo Cargo vazio")
                .IsEmailOrEmpty(email, "Email", "Campo email vazio ou invalido");
            AddNotifications(contract);

            Id = id;
            Nome = nome;
            BytePassword = password;
            Email = email;
            Phone = phone;
            DataCadastro = dataCadastro;
            DataAtualizacao = dataAtualizacao;
            Role = role;
        }
    }
}
