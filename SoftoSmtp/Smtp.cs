using System.Net.Mail;

namespace SoftoSmtp
{
  public class Smtp
  {
    SmtpClient SmtpServer;
    MailMessage mail;
    public Smtp(SmtpConfig config)
    {

      SmtpServer = new SmtpClient(config.SmtpServer);
      SmtpServer.Port = 587;
      SmtpServer.Credentials = new System.Net.NetworkCredential(config.SmtpUsername, config.SmtpPassword);
      mail = new MailMessage();
      mail.From = new MailAddress(config.SmtpUsername);
    }

    public void Send(string toAddress, string subject, string body)
    {
      mail.To.Add(toAddress);
      mail.Subject = subject;
      mail.Body = body;
      SmtpServer.Send(mail);
    }

  }
}
