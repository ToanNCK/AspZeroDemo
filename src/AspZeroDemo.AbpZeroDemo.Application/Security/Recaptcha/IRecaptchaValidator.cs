using System.Threading.Tasks;

namespace AspZeroDemo.AbpZeroDemo.Security.Recaptcha
{
    public interface IRecaptchaValidator
    {
        Task ValidateAsync(string captchaResponse);
    }
}