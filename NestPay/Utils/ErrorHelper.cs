using NestPayDotNet.Enums;
using NestPayDotNet.Models;
using NestPayDotNet.Static;

namespace NestPayDotNet.Utils
{
    public static class ErrorHelper
    {
        /// <summary>
        /// Returns the error message based on the error code and language.
        /// </summary>
        /// <param name="errorCode">The error code returned by the API.</param>
        /// <param name="lang">The language for the error message ("en" for English, "ar" for Arabic).</param>
        /// <returns>The translated error message, or a default message if the code is not found.</returns>
        public static ErrorMessage GetErrorMessage(string errorCode, Language lang)
        {
            List<ErrorMessage> translations;

            switch (lang)
            {
                case Language.Arabic:
                    translations = ErrorMessages.Arabic;
                    break;
                case Language.English:
                default:
                    translations = ErrorMessages.English;
                    break;
            }

            // Return the error message if found, otherwise a default message
            var message =
                translations.FirstOrDefault(x => x.Code == errorCode)
                ?? translations.FirstOrDefault(x => x.Code is null);

            return message;
        }
    }
}
