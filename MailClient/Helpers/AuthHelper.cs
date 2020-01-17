using System;

namespace MailClient.Helpers
{
    public class AuthHelper
    {
        public static string GetDomain(string email)
        {
            if (CheckHelper.IsValidEmail(email)) return email.Split('@')[1];
            throw new FormatException("Некорректный ввод email");
        }
    }

    public enum NetworkStatus
    {
        Connected,
        Disconnected
    }
}
