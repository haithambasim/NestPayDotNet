using System.Text;
using System.Xml.Serialization;
using NestPay.Exceptions;
using NestPay.Models;

namespace NestPay
{
    public class NestPayClient
    {
        private readonly HttpClient _httpClient;
        private readonly string _merchantId;
        private readonly string _username;
        private readonly string _password;

        public NestPayClient(string baseUrl, string merchantId, string username, string password)
        {
            _httpClient = new HttpClient { BaseAddress = new Uri(baseUrl) };
            _merchantId = merchantId;
            _username = username;
            _password = password;
        }

        public async Task<TransactionResponse> ProcessTransactionAsync(TransactionRequest request)
        {
            request.ClientId = _merchantId;
            request.Name = _username;
            request.Password = _password;

            var xmlRequest = SerializeToXml(request);

            var response = await _httpClient.PostAsync(
                "fim/api",
                new StringContent(xmlRequest, Encoding.UTF8, "application/xml")
            );

            if (!response.IsSuccessStatusCode)
            {
                throw new NestPayException($"Error: {response.StatusCode}");
            }

            var xmlResponse = await response.Content.ReadAsStringAsync();
            return DeserializeFromXml<TransactionResponse>(xmlResponse);
        }

        private static string SerializeToXml<T>(T obj)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stringWriter = new System.IO.StringWriter();
            serializer.Serialize(stringWriter, obj);
            return stringWriter.ToString();
        }

        private static T DeserializeFromXml<T>(string xml)
        {
            var serializer = new XmlSerializer(typeof(T));
            using var stringReader = new System.IO.StringReader(xml);
            return (T)serializer.Deserialize(stringReader);
        }
    }
}
