using NestPayDotNet.NestPay.Models;
using NestPayDotNet.NestPay.Static;

namespace NestPayDotNet.NestPay.Utils
{
    public static class ErrorHelper
    {
        /// <summary>
        /// Returns the error message based on the error code and language.
        /// </summary>
        /// <param name="errorCode">The error code returned by the API.</param>
        /// <param name="lang">The language for the error message ("en" for English, "ar" for Arabic).</param>
        /// <returns>The translated error message, or a default message if the code is not found.</returns>
        public static ErrorMessage GetErrorMessage(string errorCode, string lang)
        {
            Dictionary<string, ErrorMessage> translations;

            switch (lang.ToLower())
            {
                case "ar":
                    translations = ErrorMessages.Arabic;
                    break;
                case "en":
                default:
                    translations = ErrorMessages.English;
                    break;
            }


            // Return the error message if found, otherwise a default message
            var result = translations.TryGetValue(errorCode, out var message)
                ? message
                : new ErrorMessage
                {
                    Error = lang == "ar" ? "خطأ غير معروف" : "Unknown error",
                };

            result.Code = errorCode;

            return result;
        }
    }
}
