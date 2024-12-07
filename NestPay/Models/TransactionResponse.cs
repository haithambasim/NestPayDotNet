using System.Xml.Serialization;

namespace NestPayDotNet.Models
{
    /// <summary>
    /// Represents the response received from the NestPay API after processing a transaction.
    /// This contains information about the transaction's status and result.
    /// </summary>
    [XmlRoot("CC5Response")]
    public class TransactionResponse
    {
        /// <summary>
        /// The overall status of the transaction.
        /// Possible values:
        /// - "Approved": The transaction was successfully processed.
        /// - "Declined": The transaction was not approved.
        /// - "Error": An error occurred during the transaction process.
        /// </summary>
        [XmlElement("Response")]
        public string Response { get; set; }

        /// <summary>
        /// The unique identifier of the order associated with the transaction.
        /// This corresponds to the OrderId from the transaction request.
        /// </summary>
        [XmlElement("OrderId")]
        public string OrderId { get; set; }

        /// <summary>
        /// The unique identifier of the group associated with the transaction.
        /// </summary>
        [XmlElement("GroupId")]
        public string GroupId { get; set; }

        /// <summary>
        /// Host reference number
        /// </summary>
        [XmlElement("HostRefNum")]
        public string HostRefNum { get; set; }

        /// <summary>
        /// Host preauthorization code
        /// </summary>
        [XmlElement("AuthCode")]
        public string AuthCode { get; set; }

        /// <summary>
        /// Transaction Id: This is the unique identifier of the transaction.
        /// </summary>
        [XmlElement("TransId")]
        public string TransId { get; set; }

        /// <summary>
        /// The transaction status code returned by the system.
        /// Common values include:
        /// - "00": Transaction authorized successfully.
        /// - "99": General gateway error.
        /// Other codes represent ISO8583 error codes for specific issues.
        /// </summary>
        [XmlElement("ProcReturnCode")]
        public string ProcReturnCode { get; set; }

        /// <summary>
        /// A message providing details about any error encountered during the transaction.
        /// This will be empty if the transaction was successful.
        /// </summary>
        [XmlElement("ErrMsg")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Represents the extra information returned in the response from the NestPay API after processing a transaction.
        /// </summary>
        [XmlElement("Extra")]
        public TransactionResponseExtra Extra { get; set; }

        /// <summary>
        /// Indicates whether the transaction was successful.
        /// </summary>
        [XmlIgnore]
        public bool IsSuccess => Response == "Approved";

        /// <summary>
        /// Indicates whether an error occurred during the transaction process.
        /// </summary>
        [XmlIgnore]
        public bool IsGatewayError => Response == "Error";

        /// <summary>
        /// Indicates whether the transaction was declined.
        /// </summary>
        [XmlIgnore]
        public bool IsDeclined => Response == "Declined";
    }
}
