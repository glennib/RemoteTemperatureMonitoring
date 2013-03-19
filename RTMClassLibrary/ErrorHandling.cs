using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Text.RegularExpressions;

namespace RTMClassLibrary
{
    public class ErrorHandling
    {
        /* IsValidEmail function */
        private static bool invalid;
        /// <summary>
        /// Returns true if the input string is a valid email format.
        /// </summary>
        /// <param name="strIn">String to test if it's an email.</param>
        /// <returns>A boolean.</returns>
        public static bool IsValidEmail(string strIn)
        {
            invalid = false;
            if (String.IsNullOrEmpty(strIn))
                return false;

            // Use IdnMapping class to convert Unicode domain names. 
            try
            {
                strIn = Regex.Replace(strIn, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None);
            }
            catch (Exception)
            {
                return false;
            }

            if (invalid)
                return false;

            // Return true if strIn is in valid e-mail format. 
            try
            {
                return Regex.IsMatch(strIn, @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$",
                      RegexOptions.IgnoreCase);
            }
            catch (Exception)
            {
                return false;
            }
        }
        private static string DomainMapper(Match match)
        {
            // IdnMapping class with default property values.
            IdnMapping idn = new IdnMapping();

            string domainName = match.Groups[2].Value;
            try
            {
                domainName = idn.GetAscii(domainName);
            }
            catch (ArgumentException)
            {
                invalid = true;
            }
            return match.Groups[1].Value + domainName;
        }
        /* End IsValidEmail function */

        /* IsNumeric function */
        /// <summary>
        /// Returns true if the input string is a valid numeric format.
        /// </summary>
        /// <param name="String">String to test.</param>
        /// <returns>A boolean.</returns>
        public static bool IsNumeric(string String)
        {
            try
            {
                decimal N = Convert.ToDecimal(String);
                return true;
            }
            catch
            {
                return false;
            }
        }
        /* End IsNumeric function */
    }

}
