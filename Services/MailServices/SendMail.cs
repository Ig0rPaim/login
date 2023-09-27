using System.Net.Mail;
using System.Net;
using System.Drawing;
using System.Text;

namespace LoginAPI.Services.SendMail
{
    public static class SendMail
    {
        public static void SendGmail(string remetenteEmail, string destinatarioEmail, string senha, string titulo, string corpo)
        {
            try
            {
                SmtpClient clienteSmtp = new SmtpClient("smtp.gmail.com"); //"smtp.gmail.com"
                clienteSmtp.Port = 587; // Porta do servidor SMTP do Gmail
                clienteSmtp.Credentials = new NetworkCredential(remetenteEmail, senha);
                clienteSmtp.EnableSsl = true; // SSL para criptografar a conexão


                // Criar uma mensagem de email
                MailMessage mensagem = new MailMessage(remetenteEmail, destinatarioEmail);
                mensagem.Subject = titulo;
                mensagem.Body = corpo;

                // Enviar o email
                clienteSmtp.Send(mensagem);
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao enviar o email: " + ex.Message);
            }
        }

        //public static void EnviarErro(string[] erro, string usuario)
        //{
        //    try
        //    {
        //        MailAddress from = new MailAddress("sistemas@fapex.org.br", "SISTEMAS");

        //        MailMessage mensagem = new MailMessage();
        //        mensagem.From = from;
        //        mensagem.To.Add(from);

        //        StringBuilder body = new StringBuilder();
        //        body.Append("<html><body>");
        //        body.Append("<div style='width: 550px; margin: auto; padding: 3px; border: solid 1px #999;'>");
        //        body.Append("<div style='decimal:right; '>");
        //        body.Append("<img src='http://ferrari.fapex.org.br/portalcoordenador/imagens/logo_fapex_blue.png/' ");
        //        body.Append("width='151' height='58' /></div>");
        //        body.Append("<p><strong>Ops! </strong></p>");
        //        body.Append("<p>Ocorreu o seguinte erro: {0}</p>");
        //        body.Append("<p>Método: {1}</p>");
        //        body.Append("<p>Usuário: " + CurrentUser.getLoginUsuario() + "</p>");
        //        body.Append("<p>Data: {2}</p><br />");
        //        body.Append("<p style="font - size:12px; color:#999; text-align:center;">Email enviado automaticamente pelo SAPRO</p>");
        //        body.Append("</div></body></html>");

        //        mensagem.Body = string.Format(body.ToString(), erro);

        //        mensagem.Subject = "Erro no SAPRO";
        //        mensagem.IsBodyHtml = true;
        //        mensagem.BodyEncoding = System.Text.Encoding.UTF8;

        //        SmtpClient cliente = new SmtpClient();
        //        cliente.Credentials = new System.Net.NetworkCredential("mensagens@fapex.org.br", "#)&Shabl1c2041$");
        //        cliente.Host = "smtp.gmail.com";
        //        cliente.Port = 587;
        //        cliente.EnableSsl = true;

        //        cliente.Send(mensagem);
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //}
    }
}
