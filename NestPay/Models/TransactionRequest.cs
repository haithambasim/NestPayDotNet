using NestPayDotNet.Enums;
using System.Xml.Serialization;

namespace NestPayDotNet.Models
{
    /// <summary>
    /// Represents a transaction request sent to the NestPay API.
    /// This request contains all the necessary details for initiating different types of payment transactions.
    /// </summary>
    [XmlRoot("CC5Request")]
    public class TransactionRequest
    {
        /// <summary>
        /// The username of the API user. This is provided by the merchant administrator
        /// and is mandatory for all transaction requests.
        /// </summary>
        [XmlElement("Name")]
        public string Name { get; set; }

        /// <summary>
        /// The password of the API user. This password is created during the API user setup
        /// and is mandatory for all transaction requests.
        /// </summary>
        [XmlElement("Password")]
        public string Password { get; set; }

        /// <summary>
        /// The merchant's unique identifier. This is provided by the payment gateway
        /// and is mandatory for all transaction requests.
        /// </summary>
        [XmlElement("ClientId")]
        public string ClientId { get; set; }

        /// <summary>
        /// Specifies the type of transaction to be performed.
        /// Possible values include:
        /// - Auth: Sale transaction
        /// - PreAuth: Pre-authorization
        /// - PostAuth: Post-authorization
        /// - Void: Transaction cancellation
        /// - Credit: Refund transaction
        /// </summary>
        [XmlElement("Type")]
        public string Type { get; set; }

        /// <summary>
        /// The total amount for the transaction.
        /// This value should be specified as a decimal, and it is mandatory for all transactions.
        /// </summary>
        [XmlElement("Total")]
        public decimal Total { get; set; }

        /// <summary>
        /// The ISO currency code for the transaction amount.
        /// For example, 949 represents Turkish Lira. This is mandatory for all transactions.
        /// </summary>
        [XmlElement("Currency")]
        public Currency Currency { get; set; }

        /// <summary>
        /// The unique order identifier. If not provided, the system will generate a unique order ID.
        /// This is optional but recommended for tracking transactions.
        /// </summary>
        [XmlElement("OrderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// The credit card number for the transaction.
        /// This is required for non-3D secure transactions.
        /// </summary>
        [XmlElement("Number")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The expiry date of the credit card in MM/YYYY format.
        /// This is required for non-3D secure transactions.
        /// </summary>
        [XmlElement("Expires")]
        public string CardExpiry { get; set; }

        /// <summary>
        /// The CVV2 security code of the credit card.
        /// This is required for non-3D secure transactions.
        /// </summary>
        [XmlElement("Cvv2Val")]
        public string CardCvv { get; set; }

        /// <summary>
        /// Languafe code for the error messages. ar for Arabic, en for English.
        /// </summary>
        [XmlIgnore]
        public Language Lang { get; set; } = Language.English;
    }
}
