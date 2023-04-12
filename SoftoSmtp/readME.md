# SoftoSmtp

To use SoftoSmtp, it is necessary to configure it first.
Create a file named `SoftoSmtpConfig.json` in root directory of your startup project.
The file may look like
```` JSON
{
	"SmtpServer": "smtp.gmail.com",
	"SmtpPort": 587,
	"SmtpUser": "<username>"
	"SmtpPassword": "<password>",
	"SmtpUseSsl": true
}
````

Note: `SmtpUser` will be used as `From` address in emails.