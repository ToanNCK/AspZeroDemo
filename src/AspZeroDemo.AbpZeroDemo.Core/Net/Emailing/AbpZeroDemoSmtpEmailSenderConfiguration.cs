using Abp.Configuration;
using Abp.Net.Mail;
using Abp.Net.Mail.Smtp;
using Abp.Runtime.Security;

namespace AspZeroDemo.AbpZeroDemo.Net.Emailing
{
    public class AbpZeroDemoSmtpEmailSenderConfiguration : SmtpEmailSenderConfiguration
    {
        public AbpZeroDemoSmtpEmailSenderConfiguration(ISettingManager settingManager) : base(settingManager)
        {

        }

        public override string Password => SimpleStringCipher.Instance.Decrypt(GetNotEmptySettingValue(EmailSettingNames.Smtp.Password));
    }
}