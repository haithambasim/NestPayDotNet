namespace NestPay.Exceptions
{
    public class NestPayException : Exception
    {
        public NestPayException(string message) : base(message) { }
    }
}
