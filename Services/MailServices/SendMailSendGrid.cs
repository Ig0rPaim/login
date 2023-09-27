﻿using SendGrid.Helpers.Mail;
using SendGrid;



using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Threading.Tasks;

namespace LoginAPI.Services.SendMail
{
    public class SendMailSendGrid
    {
        public static async Task SendMail(string remetenteEmail, string nomeRemetente, string destinatarioEmail, string nomeDestinatario, string titulo, string? corpo, string? link)
        {
            var apiKey = "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";
            var client = new SendGridClient(apiKey);

            var from = new EmailAddress(remetenteEmail, nomeRemetente);
            var subject = titulo;
            var to = new EmailAddress(destinatarioEmail, nomeDestinatario);
            var plainTextContent = corpo;
            var htmlContent =
                @$"<html>
                    <head>
                        <meta charset=""UTF-8"">
                        <title>Email Formal</title>
                    </head>
                    <body>
                        <table align=""center"" border=""0"" cellpadding=""0"" cellspacing=""0"" width=""600"">
                            <tr>
                                <td align=""center"" bgcolor=""#0073e6"" style=""padding: 20px 0;"">
                                    <h1 style=""color: #ffffff;"">{titulo}</h1>
                                </td>
                            </tr>
                            <tr>
                                <td style=""padding: 20px;"">
                                    <h2>Prezado(a) {nomeDestinatario},</h2>
                                    <p>Não Responda!!</p>
                                    <p>Para recuperar a senha Clique no Link abaixo</p>
                                    <h3>{link}</h3>
                                    <h2>Atenciosamente,
                                    {nomeRemetente}</h2>
                                </td>
                            </tr>
                        </table>
                    </body>
                </html>";

            var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);

            var response = await client.SendEmailAsync(msg);

            if (response.StatusCode == System.Net.HttpStatusCode.Accepted)
            {
                Console.WriteLine("E-mail enviado com sucesso!");
            }
            else
            {
                Console.WriteLine($"Erro ao enviar o e-mail: {response.StatusCode}");
            }
        }
    }
}



