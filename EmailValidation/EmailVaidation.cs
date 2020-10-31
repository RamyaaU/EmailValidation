using System;
using System.Text.RegularExpressions;

namespace EmailValidation
{
    class EmailValidation
    {
        //pattern for email
        public static string REGEX_EMAIL = "^[a-zA-Z0-9]+";
        /// <summary>
        /// Validates the email.
        /// </summary>
        /// <param name="email">The email.</param>
        /// <returns></returns>
        public bool validateEmail(string email)
        {
            return Regex.IsMatch(email, REGEX_EMAIL);
        }
    }
}