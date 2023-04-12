namespace SoftoSmtp
{
  public class SmtpConfig
  {
    public string SmtpServer { get; set; }
    public int SmtpPort { get; set; }
    public string SmtpUsername { get; set; }
    public string SmtpPassword { get; set; }
    public bool SmtpUseSSL { get; set; }

  }
}
