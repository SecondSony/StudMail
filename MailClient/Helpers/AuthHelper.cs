﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailClient.Helpers
{
    public class AuthHelper
    {
        public static bool IsValidEmail(string email)
        {
            var pattern = "[.\\-_a-z0-9]+@([a-z0-9][\\-a-z0-9]+\\.)+[a-z]{2,6}";
            return Regex.IsMatch(email, pattern);
        }

        public static string GetDomain(string email)
        {
            if (IsValidEmail(email)) return email.Split('@')[1];
            throw new FormatException("Некорректный ввод email");
        }
    }

    public enum NetworkStatus
    {
        Connected,
        Disconnected
    }
}
