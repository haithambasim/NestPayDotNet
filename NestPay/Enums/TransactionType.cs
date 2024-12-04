namespace NestPayDotNet.Enums
{
    /// <summary>
    /// Defines the types of transactions supported by the NestPay API.
    /// </summary>
    public enum TransactionType
    {
        /// <summary>
        /// Sale transaction that authorizes and captures the payment in a single step.
        /// This type is used for immediate purchases where no additional action is required
        /// to settle the transaction.
        /// </summary>
        Auth,

        /// <summary>
        /// Pre-authorization transaction that places a hold on the customer's account for the
        /// purchase amount without capturing it. This type is used when the payment needs to
        /// be authorized first and captured later using a PostAuth transaction.
        /// </summary>
        PreAuth,

        /// <summary>
        /// Post-authorization transaction used to capture funds for a previously authorized
        /// PreAuth transaction. This confirms the purchase and initiates the settlement process.
        /// </summary>
        PostAuth,

        /// <summary>
        /// Void transaction used to cancel a previously completed transaction. Depending on
        /// the type of transaction being voided (e.g., Auth, PreAuth, PostAuth, or Credit),
        /// this operation reverses the effect of that transaction.
        /// </summary>
        Void,

        /// <summary>
        /// Refund transaction that transfers money back to the customer's account. This is
        /// used to return funds for a settled transaction. Multiple partial refunds can be
        /// performed up to the total value of the original transaction.
        /// </summary>
        Credit
    }
}
