using NestPayDotNet.Models;

namespace NestPayDotNet.Exceptions
{
    public class NestPayGatewayException : Exception
    {
        public string ErrorCode { get; set; }
        public string Detail { get; set; }

        public NestPayGatewayException(ErrorMessage msg) : base(msg.Error)
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
