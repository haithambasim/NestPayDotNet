using NestPayDotNet.NestPay.Models;

namespace NestPay.Exceptions
{
    public class NestPayTransactionException : Exception
    {
        public string ErrorCode { get; set; }
        public string Detail { get; set; }

        public NestPayTransactionException(ErrorMessage msg) : base(msg.Error)
        {
            ErrorCode = msg.Code;
            Detail = msg.Solution;
        }

        public override string ToString()
        {
            return $"Error: {Message}\nCode: {ErrorCode}\nDetail: {Detail}";
        }
    }
}
