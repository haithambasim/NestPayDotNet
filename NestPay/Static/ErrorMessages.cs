using NestPayDotNet.NestPay.Models;

namespace NestPayDotNet.NestPay.Static
{
    /// <summary>
    /// Contains error codes and their English and Arabic translations.
    /// </summary>
    public static class ErrorMessages
    {
        // English translations
        public static readonly Dictionary<string, ErrorMessage> English = new()
        {
            #region CORE Errors: Core errors is caused by the Nestpay.
            {
                "CORE-1001",
                new ErrorMessage
                {
                    Error = "General initialization error",
                    Solution = "For detailed information please contact your administrator."
                }
            },
            {
                "CORE-1002",
                new ErrorMessage
                {
                    Error = "System error. First commit phase general exception",
                    Solution = "For detailed information please contact your administrator."
                }
            },
            {
                "CORE-1003",
                new ErrorMessage
                {
                    Error = "It is caused by Acquirer System",
                    Solution = "For detailed information please contact your administrator."
                }
            },
            {
                "CORE-1004",
                new ErrorMessage
                {
                    Error = "System error. Response parameters general exception.",
                    Solution = "For detailed information please contact your administrator."
                }
            },
            {
                "CORE-1005",
                new ErrorMessage
                {
                    Error = "System error. Last commit phase general exception",
                    Solution = "For detailed information please contact your administrator."
                }
            },
            {
                "CORE-1006",
                new ErrorMessage {
                    Error = "Invalid value for 'Mode' parameter. Please check API manuals."
                }
            },
            {
                "CORE-1007",
                new ErrorMessage {
                    Error = "Invalid value for 'OrderType' for 'PbOrder'. Please check API manuals."
                }
            },
            {
                "CORE-1010",
                new ErrorMessage {
                    Error = "'Currency' is unparsable value.",
                    Solution = "Please check the Currency field and try again."
                }
            },
            {
                "CORE-1011",
                new ErrorMessage {
                    Error = "'User Name' can not be null or empty.",
                    Solution = "Please check the username field and make sure that it is not null and try again."
                }
            },
            {
                "CORE-1012",
                new ErrorMessage {
                    Error = "'User Name' field size is out of limit.",
                    Solution = "Please check the username field and make sure that it has less than 255 characters."
                }
            },
            {
                "CORE-1013",
                new ErrorMessage {
                    Error = "'Merchant Id' can not be null or empty.",
                    Solution = "You should give your clientId. If you don't know your ID, Please call your administrator."
                }
            },
            {
                "CORE-1014",
                new ErrorMessage {
                    Error = "'Merchant Id' field size is out of limit.",
                    Solution = "Your merchantID can be maximum 15 characters. Please check and try again"
                }
            },
            {
                "CORE-1015",
                new ErrorMessage {
                    Error = "'Order Id' field size is out of limit.",
                    Solution = "OrderId is alphanumeric and it can be maximum 64 characters. Please check and try again."
                }
            },
            {
                "CORE-1016",
                new ErrorMessage {
                    Error = "'Criteria' field size is out of limit.",
                    Solution = "Criteria field can be maximum 64 characters. Please check and try again"
                }
            },
            {
                "CORE-1017",
                new ErrorMessage {
                    Error = "'Transaction Id' field size is out of limit.",
                    Solution = "TransactionId can be maximum 64 characters. Please check and try again"
                }
            },
            {
                "CORE-1018",
                new ErrorMessage {
                    Error = "Total Amount is out of length",
                    Solution = "Total amount should include less than 18 digits. Please check and try again."
                }
            },
            {
                "CORE-1019",
                new ErrorMessage {
                    Error = "Currency Code is wrong",
                    Solution = "Please check your currency code and try again. (eg. PLN = 985)"
                }
            },
            {
                "CORE-1020",
                new ErrorMessage {
                    Error = "'Api Version' field size is out of limit.",
                    Solution = "ApiVersion can be maximum 32 characters. Please check and try again"
                }
            },
            {
                "CORE-1021",
                new ErrorMessage {
                    Error = "'Description' field size is out of limit.",
                    Solution = "Description can be maximum 255 characters. Please check and try again."
                }
            },
            {
                "CORE-1022",
                new ErrorMessage {
                    Error = "'Consumer IP' field size is out of limit.",
                    Solution = "ConsumerIP can be maximum 39 characters. Please check and try again."
                }
            },
            {
                "CORE-1023",
                new ErrorMessage {
                    Error = "'Installments' field size is out of limit.",
                    Solution = "Installment can be maximum 3 characters. Please check and try again."
                }
            },
            {
                "CORE-1024",
                new ErrorMessage {
                    Error = "'Amount' can not be negative.",
                    Solution = "Please check that total amount is not less than 0."
                }
            },
            {
                "CORE-1025",
                new ErrorMessage {
                    Error = "'Points' can not be negative.",
                    Solution = "Please check that points field is not less than 0."
                }
            },
            {
                "CORE-1026",
                new ErrorMessage {
                    Error = "'Instalment' can not be negative.",
                    Solution = "Please check that installment is not less than 0."
                }
            },
            {
                "CORE-1027",
                new ErrorMessage {
                    Error = "'Amount' must be equal to or greater than 'Points'.",
                    Solution = "The amount must be more than points. Please check and try again."
                }
            },
            {
                "CORE-1028",
                new ErrorMessage {
                    Error = "'Transaction Id' must be used only for void request.",
                    Solution = "Do not transactionId except void transaction. For detailed information please call your administrator."
                }
            },
            {
                "CORE-1029",
                new ErrorMessage {
                    Error = "Instalment should be sent for this query.",
                    Solution = "You can not send installment field null. Please check and try again."
                }
            },
            {
                "CORE-2001",
                new ErrorMessage {
                    Error = "This is an invalid transaction type. Auth, PreAuth, PostAuth, Credit, Void are valid.",
                    Solution = "Check the transaction type and make sure you send the correct type."
                }
            },
            {
                "CORE-2008",
                new ErrorMessage {
                    Error = "There is no transaction available to cancel",
                    Solution = "Make sure that the transaction is convenient to cancel"
                }
            },
            {
                "CORE-2009",
                new ErrorMessage {
                    Error = "Zero (0) is not valid amount for sale and preauth transaction.",
                    Solution = "You should give more than 0 amount for sale or preauth transaction. Please check your amount."
                }
            },
            {
                "CORE-2010",
                new ErrorMessage {
                    Error = "Card Expiry Date is wrong",
                    Solution = "Check the expiry date and make sure that it is valid"
                }
            },
            {
                "CORE-2011",
                new ErrorMessage {
                    Error = "Card Expiry Date is not in valid format",
                    Solution = "Card expiry date should be in MM/YY format"
                }
            },
            {
                "CORE-2012",
                new ErrorMessage {
                    Error = "PAN Number is invalid.",
                    Solution = "1 - The card number should include at 50 | NestPay® | Merchant Integration API Manual least 13 digits 2 – It should be validated by bank. A randomly produced card number can not pass the validation even it has effective length."
                }
            },
            {
                "CORE-2013",
                new ErrorMessage {
                    Error = "Invalid settlement request detected.",
                    Solution = "Request xml is incorrect. Please, check the request xml and try again."
                }
            },
            {
                "CORE-2014",
                new ErrorMessage {
                    Error = "Invalid query request detected.",
                    Solution = "Request xml is incorrect. Please, check the request xml and try again."
                }
            },
            {
                "CORE-2015",
                new ErrorMessage {
                    Error = "The credit card number is missing or empty.",
                    Solution = "The credit card number is empty. Please enter your credit card number and try again."
                }
            },
            {
                "CORE-2020",
                new ErrorMessage {
                    Error = "The recurring period unit is missing or empty",
                    Solution = "Recurring period unit should be given. It can not be null. Please check and try again."
                }
            },
            {
                "CORE-2021",
                new ErrorMessage {
                    Error = "The recurring period unit is not valid.",
                    Solution = "Recurring period unit should be in correct format. Please check recurring period unit and try again."
                }
            },
            {
                "CORE-2022",
                new ErrorMessage {
                    Error = "The recurring period is not valid.",
                    Solution = "Recurring period can not be less than 0. Please check recurring period and try again."
                }
            },
            {
                "CORE-2023",
                new ErrorMessage {
                    Error = "The recurring duration is not valid.",
                    Solution = "Recurring duration can not be null and it must be a natural number. Please check and try again."
                }
            },
            {
                "CORE-2024",
                new ErrorMessage {
                    Error = "Only sale orders can have recurring.",
                    Solution = "Recurring transactions have to be sale. Please check that your transaction is sale and try again."
                }
            },
            {
                "CORE-2201",
                new ErrorMessage {
                    Error = "The user is not authenticated.",
                    Solution = "Check your user id and password and make sure that you are really authenticated"
                }
            },
            {
                "CORE-2202",
                new ErrorMessage {
                    Error = "User has not permission to do this operation",
                    Solution = "The operation you are trying to make need a permission. So please make sure that you have this permission."
                }
            },
            {
                "CORE-2254",
                new ErrorMessage {
                    Error = "IP restriction",
                    Solution = "Probably your IP settings are not 51 | NestPay® | Merchant Integration API Manual defined. Please contact your administrator."
                }
            },
            {
                "CORE-2506",
                new ErrorMessage {
                    Error = "Cannot post auth on zero net amount",
                    Solution = "The transaction amount is sent zero. Please give the amount more than 0"
                }
            },
            {
                "CORE-2507",
                new ErrorMessage {
                    Error = "The order-number is duplicated.",
                    Solution = "The order number you sent is already used before. Please give another one."
                }
            },
            #endregion

            #region BM Errors: Bank communication errors can occur if there is a problem on the communication between Nestpay and the bank.
            {
                "BM-1001",
                new ErrorMessage
                {
                    Error = "Invalid length TAG data in fields parsing."
                }
            },
            {
                "BM-1002",
                new ErrorMessage
                {
                    Error = "Invalid reversal message."
                }
            },
            {
                "BM-1006",
                new ErrorMessage
                {
                    Error = "Message parse error. Merchant id mismatch."
                }
            },
            {
                "BM-1007",
                new ErrorMessage
                {
                    Error = "Message parse error. Terminal id mismatch."
                }
            },
            {
                "BM-1008",
                new ErrorMessage
                {
                    Error = "Create acquirer request general error."
                }
            },
            {
                "BM-9100",
                new ErrorMessage
                {
                    Error = "Host name is unknown."
                }
            },
            {
                "BM-9101",
                new ErrorMessage
                {
                    Error = "Unable to connect to host, port closed"
                }
            },
            {
                "BM-9102",
                new ErrorMessage
                {
                    Error = "Host communications IO error."
                }
            },
            {
                "BM-9103",
                new ErrorMessage
                {
                    Error = "General connection failure to host"
                }
            },
            #endregion

            #region ISO8583 Errors: caused by bank.
            {
                "ISO8583-9999",
                new ErrorMessage()
                {
                    Error = "ISO8583 Non-Numeric Error.",
                    Solution = "Undefined error, contact your acquirer help desk"
                }
            },
            {
                "ISO8583-9998",
                new ErrorMessage()
                {
                    Error = "ISO8583 Unknown Error from Issuer.",
                    Solution = "Undefined error, contact your acquirer help desk"
                }
            },
            {
                "ISO8583-01",
                new ErrorMessage()
                {
                    Error = "Referral - call bank for manual approval.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-02",
                new ErrorMessage()
                {
                    Error = "Fake Approval, but should not be used in a VPOS system, check with your bank",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-03",
                new ErrorMessage()
                {
                    Error = "Invalid merchant or service provider.",
                    Solution = "Virtual POS might be deactivated. Contact your acquirer"
                }
            },
            {
                "ISO8583-04",
                new ErrorMessage()
                {
                    Error = "Pick-up card.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-05",
                new ErrorMessage()
                {
                    Error = "Do not honour",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-06",
                new ErrorMessage()
                {
                    Error = "Error (found only in file update responses).",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-07",
                new ErrorMessage()
                {
                    Error = "Pick up card, special condition.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-08",
                new ErrorMessage()
                {
                    Error = "Fake Approval, but should not be used in a VPOS system, check with your bank.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-11",
                new ErrorMessage()
                {
                    Error = "Fake Approved (VIP), but should not be used in a VPOS system, check with your bank.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-12",
                new ErrorMessage()
                {
                    Error = "Transaction is not valid.",
                    Solution = "Contact your acquirer about the transaction"
                }
            },
            {
                "ISO8583-13",
                new ErrorMessage()
                {
                    Error = "Invalid amount.",
                    Solution = "Amount is not in valid format"
                }
            },
            {
                "ISO8583-14",
                new ErrorMessage()
                {
                    Error = "Invalid account number.",
                    Solution = "Terminal number or merchant number is wrong. Contact your acquirer"
                }
            },
            {
                "ISO8583-15",
                new ErrorMessage()
                {
                    Error = "No such issuer.",
                    Solution = "Issuer is not defined"
                }
            },
            {
                "ISO8583-19",
                new ErrorMessage()
                {
                    Error = "Reenter, try again.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-20",
                new ErrorMessage()
                {
                    Error = "Invalid amount.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-21",
                new ErrorMessage()
                {
                    Error = "Unable to back out transaction.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-25",
                new ErrorMessage()
                {
                    Error = "Unable to locate record on file.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-28",
                new ErrorMessage()
                {
                    Error = "Original is denied.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-29",
                new ErrorMessage()
                {
                    Error = "Original not found.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-30",
                new ErrorMessage()
                {
                    Error = "Format error (switch generated).",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-32",
                new ErrorMessage()
                {
                    Error = "Referral (General).",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-33",
                new ErrorMessage()
                {
                    Error = "Expired card, pick-up.",
                    Solution = "Card is expired, acquirer reject the transaction"
                }
            },
            {
                "ISO8583-34",
                new ErrorMessage()
                {
                    Error = "Suspected fraud, pick-up.",
                    Solution = "Suspected fraud, acquirer reject the transaction"
                }
            },
            {
                "ISO8583-36",
                new ErrorMessage()
                {
                    Error = "Restricted card, pick-up.",
                    Solution = "Card owner can contact his/her issuer for detailed information"
                }
            },
            {
                "ISO8583-37",
                new ErrorMessage()
                {
                    Error = "Pick up card. Issuer wants card returned.",
                    Solution = "Card is stolen, card owner must return the card to his acquirer"
                }
            },
            {
                "ISO8583-38",
                new ErrorMessage()
                {
                    Error = "Allowable PIN tries exceeded, pick-up.",
                    Solution = "Contact your acquirer help desk.",
                }
            },
            {
                "ISO8583-41",
                new ErrorMessage()
                {
                    Error = "Lost card, Pick-up.",
                    Solution = "Card is reported as lost, card owner cannot use this card"
                }
            },
            {
                "ISO8583-43",
                new ErrorMessage()
                {
                    Error = "Stolen card, pick-up.",
                    Solution = "Card is reported as stolen, card owner cannot use this card"
                }
            },
            {
                "ISO8583-51",
                new ErrorMessage()
                {
                    Error = "Insufficient funds.",
                    Solution = "Card limit is not sufficient"
                }
            },
            {
                "ISO8583-52",
                new ErrorMessage()
                {
                    Error = "No checking account.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-53",
                new ErrorMessage()
                {
                    Error = "No savings account.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-54",
                new ErrorMessage()
                {
                    Error = "Expired card.",
                    Solution = "Card is expired, card owner cannot use this card"
                }
            },
            {
                "ISO8583-55",
                new ErrorMessage()
                {
                    Error = "Incorrect PIN.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-56",
                new ErrorMessage()
                {
                    Error = "No card record.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-57",
                new ErrorMessage()
                {
                    Error = "Transaction not permitted to cardholder.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-58",
                new ErrorMessage()
                {
                    Error = "Transaction not permitted to terminal.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-61",
                new ErrorMessage()
                {
                    Error = "Exceeds withdrawal amount limit.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-62",
                new ErrorMessage()
                {
                    Error = "Restricted card.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-63",
                new ErrorMessage()
                {
                    Error = "Security violation",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-65",
                new ErrorMessage()
                {
                    Error = "Activity limit exceeded.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-75",
                new ErrorMessage()
                {
                    Error = "Allowable number of PIN tries exceeded.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-76",
                new ErrorMessage()
                {
                    Error = "Key synchronization error.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-77",
                new ErrorMessage()
                {
                    Error = "Inconsistent data.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-80",
                new ErrorMessage()
                {
                    Error = "Date is not valid.",
                    Solution = "Card owner should check card details"
                }
            },
            {
                "ISO8583-81",
                new ErrorMessage()
                {
                    Error = "Encryption Error.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-82",
                new ErrorMessage()
                {
                    Error = "CVV Failure or CVV Value supplied is not valid.",
                    Solution = "Card owner should check card details"
                }
            },
            {
                "ISO8583-83",
                new ErrorMessage()
                {
                    Error = "Cannot verify PIN.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-85",
                new ErrorMessage()
                {
                    Error = "Declined (General).",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-91",
                new ErrorMessage()
                {
                    Error = "Issuer or switch is inoperative.",
                    Solution = "Cannot communicate with the host, Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-92",
                new ErrorMessage()
                {
                    Error = "Timeout, reversal is trying.",
                    Solution = "Cannot communicate with the host, Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-93",
                new ErrorMessage()
                {
                    Error = "Violation, cannot complete (installment, loyalty).",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-96",
                new ErrorMessage()
                {
                    Error = "System malfunction.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-98",
                new ErrorMessage()
                {
                    Error = "Duplicate Reversal.",
                    Solution = "Contact your acquirer help desk"
                }
            },
            {
                "ISO8583-YK",
                new ErrorMessage()
                {
                    Error = "Card in black list.",
                    Solution = "Contact your acquirer help desk"
                }
            }
            #endregion
        };

        // Arabic translations
        public static readonly Dictionary<string, ErrorMessage> Arabic = new()
        {
            #region CORE Errors: Core errors is caused by the Nestpay.
            {
                "CORE-1001",
                new ErrorMessage
                {
                    Error = "خطأ عام في التهيئة",
                    Solution = "لمزيد من المعلومات التفصيلية، يرجى التواصل مع المسؤول الخاص بك."
                }
            },
            {
                "CORE-1002",
                new ErrorMessage
                {
                    Error = "خطأ في النظام. استثناء عام في المرحلة الأولى من الالتزام",
                    Solution = "لمزيد من المعلومات التفصيلية، يرجى التواصل مع المسؤول الخاص بك."
                }
            },
            {
                "CORE-1003",
                new ErrorMessage
                {
                    Error = "سبب الخطأ هو نظام الجهة المستحوذة",
                    Solution = "لمزيد من المعلومات التفصيلية، يرجى التواصل مع المسؤول الخاص بك."
                }
            },
            {
                "CORE-1004",
                new ErrorMessage
                {
                    Error = "خطأ في النظام. استثناء عام في معلمات الاستجابة.",
                    Solution = "لمزيد من المعلومات التفصيلية، يرجى التواصل مع المسؤول الخاص بك."
                }
            },
            {
                "CORE-1005",
                new ErrorMessage
                {
                    Error = "خطأ في النظام. استثناء عام في المرحلة الأخيرة من الالتزام.",
                    Solution = "لمزيد من المعلومات التفصيلية، يرجى التواصل مع المسؤول الخاص بك."
                }
            },
            {
                "CORE-1006",
                new ErrorMessage
                {
                    Error = "قيمة غير صحيحة لمعلمة 'Mode'. يرجى مراجعة أدلة API.",
                    Solution = ""
                }
            },
            {
                "CORE-1007",
                new ErrorMessage
                {
                    Error = "قيمة غير صحيحة لـ 'OrderType' لـ 'PbOrder'. يرجى مراجعة أدلة API.",
                    Solution = ""
                }
            },
            {
                "CORE-1010",
                new ErrorMessage
                {
                    Error = "قيمة 'Currency' غير قابلة للتحليل.",
                    Solution = "يرجى التحقق من حقل العملة والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1011",
                new ErrorMessage
                {
                    Error = "لا يمكن أن يكون حقل 'اسم المستخدم' فارغًا أو غير موجود.",
                    Solution = "يرجى التحقق من حقل اسم المستخدم والتأكد من أنه ليس فارغًا والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1012",
                new ErrorMessage
                {
                    Error = "حجم حقل 'اسم المستخدم' يتجاوز الحد المسموح به.",
                    Solution = "يرجى التحقق من حقل اسم المستخدم والتأكد من أنه أقل من 255 حرفًا."
                }
            },
            {
                "CORE-1013",
                new ErrorMessage
                {
                    Error = "لا يمكن أن يكون حقل 'رقم التاجر' فارغًا أو غير موجود.",
                    Solution = "يجب عليك توفير معرف العميل الخاص بك. إذا كنت لا تعرف المعرف الخاص بك، يرجى الاتصال بالمسؤول."
                }
            },
            {
                "CORE-1014",
                new ErrorMessage
                {
                    Error = "حجم حقل 'رقم التاجر' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون معرف التاجر الخاص بك بحد أقصى 15 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1015",
                new ErrorMessage
                {
                    Error = "حجم حقل 'رقم الطلب' يتجاوز الحد المسموح به.",
                    Solution = "رقم الطلب أبجدي رقمي ويمكن أن يكون بحد أقصى 64 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1016",
                new ErrorMessage
                {
                    Error = "حجم حقل 'المعايير' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون حقل المعايير بحد أقصى 64 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1017",
                new ErrorMessage
                {
                    Error = "حجم حقل 'رقم المعاملة' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون رقم المعاملة بحد أقصى 64 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1018",
                new ErrorMessage
                {
                    Error = "المبلغ الإجمالي يتجاوز الطول المسموح به.",
                    Solution = "يجب أن يتضمن المبلغ الإجمالي أقل من 18 رقماً. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1019",
                new ErrorMessage
                {
                    Error = "رمز العملة غير صحيح.",
                    Solution = "يرجى التحقق من رمز العملة والمحاولة مرة أخرى. (مثال: PLN = 985)"
                }
            },
            {
                "CORE-1020",
                new ErrorMessage
                {
                    Error = "حجم حقل 'إصدار API' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون إصدار API بحد أقصى 32 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1021",
                new ErrorMessage
                {
                    Error = "حجم حقل 'الوصف' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون الوصف بحد أقصى 255 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1022",
                new ErrorMessage
                {
                    Error = "حجم حقل 'IP المستخدم' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون IP المستخدم بحد أقصى 39 حرفًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1023",
                new ErrorMessage
                {
                    Error = "حجم حقل 'التقسيط' يتجاوز الحد المسموح به.",
                    Solution = "يمكن أن يكون التقسيط بحد أقصى 3 أحرف. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1024",
                new ErrorMessage
                {
                    Error = "لا يمكن أن يكون المبلغ سالبًا.",
                    Solution = "يرجى التحقق من أن المبلغ الإجمالي ليس أقل من 0."
                }
            },
            {
                "CORE-1025",
                new ErrorMessage
                {
                    Error = "لا يمكن أن تكون النقاط سلبية.",
                    Solution = "يرجى التحقق من أن حقل النقاط ليس أقل من 0."
                }
            },
            {
                "CORE-1026",
                new ErrorMessage
                {
                    Error = "لا يمكن أن يكون التقسيط سالبًا.",
                    Solution = "يرجى التحقق من أن التقسيط ليس أقل من 0."
                }
            },
            {
                "CORE-1027",
                new ErrorMessage
                {
                    Error = "يجب أن يكون المبلغ أكبر من أو يساوي النقاط.",
                    Solution = "يجب أن يكون المبلغ أكثر من النقاط. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-1028",
                new ErrorMessage
                {
                    Error = "يجب استخدام 'رقم المعاملة' فقط في طلبات الإلغاء.",
                    Solution = "لا تستخدم رقم المعاملة إلا لعمليات الإلغاء. لمزيد من المعلومات التفصيلية، يرجى الاتصال بمسؤولك."
                }
            },
            {
                "CORE-1029",
                new ErrorMessage
                {
                    Error = "يجب إرسال حقل التقسيط لهذه العملية.",
                    Solution = "لا يمكن أن يكون حقل التقسيط فارغًا. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-2001",
                new ErrorMessage
                {
                    Error = "نوع المعاملة غير صالح. الخيارات الصالحة هي Auth، PreAuth، PostAuth، Credit، Void.",
                    Solution = "يرجى التحقق من نوع المعاملة والتأكد من أنك ترسل النوع الصحيح."
                }
            },
            {
                "CORE-2008",
                new ErrorMessage
                {
                    Error = "لا توجد معاملة يمكن إلغاؤها.",
                    Solution = "تأكد من أن المعاملة قابلة للإلغاء."
                }
            },
            {
                "CORE-2009",
                new ErrorMessage
                {
                    Error = "الصفر (0) ليس مبلغًا صالحًا لمعاملات البيع والتفويض المسبق.",
                    Solution = "يجب أن يكون المبلغ أكثر من 0 لمعاملات البيع أو التفويض المسبق. يرجى التحقق من المبلغ الخاص بك."
                }
            },
            {
                "CORE-2010",
                new ErrorMessage
                {
                    Error = "تاريخ انتهاء صلاحية البطاقة غير صحيح.",
                    Solution = "يرجى التحقق من تاريخ انتهاء الصلاحية والتأكد من أنه صالح."
                }
            },
            {
                "CORE-2011",
                new ErrorMessage
                {
                    Error = "تاريخ انتهاء صلاحية البطاقة ليس بالتنسيق الصحيح.",
                    Solution = "يجب أن يكون تاريخ انتهاء البطاقة بتنسيق MM/YY."
                }
            },
            {
                "CORE-2012",
                new ErrorMessage
                {
                    Error = "رقم بطاقة PAN غير صالح.",
                    Solution = "يجب أن يتضمن رقم البطاقة على الأقل 13 رقمًا وأن يتم التحقق منه من البنك."
                }
            },
            {
                "CORE-2013",
                new ErrorMessage
                {
                    Error = "طلب التسوية غير صالح.",
                    Solution = "طلب XML غير صحيح. يرجى التحقق من الطلب والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-2014",
                new ErrorMessage
                {
                    Error = "طلب الاستعلام غير صالح.",
                    Solution = "طلب XML غير صحيح. يرجى التحقق من الطلب والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-2015",
                new ErrorMessage
                {
                    Error = "رقم البطاقة مفقود أو فارغ.",
                    Solution = "رقم البطاقة فارغ. يرجى إدخال رقم البطاقة والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-2024",
                new ErrorMessage
                {
                    Error = "لا يمكن أن تكون المعاملات المتكررة إلا من نوع البيع.",
                    Solution = "يجب أن تكون المعاملات المتكررة من نوع البيع فقط. يرجى التحقق والمحاولة مرة أخرى."
                }
            },
            {
                "CORE-2201",
                new ErrorMessage
                {
                    Error = "المستخدم غير مصادق.",
                    Solution = "يرجى التحقق من معرف المستخدم وكلمة المرور والتأكد من المصادقة."
                }
            },
            {
                "CORE-2202",
                new ErrorMessage
                {
                    Error = "المستخدم لا يملك صلاحية للقيام بهذه العملية.",
                    Solution = "يرجى التأكد من أن لديك الصلاحية المطلوبة لإجراء هذه العملية."
                }
            },
            {
                "CORE-2506",
                new ErrorMessage
                {
                    Error = "لا يمكن تنفيذ عملية Post Auth بمبلغ صافي يساوي صفر.",
                    Solution = "يرجى التأكد من أن المبلغ أكثر من 0."
                }
            },
            {
                "CORE-2507",
                new ErrorMessage
                {
                    Error = "رقم الطلب مكرر.",
                    Solution = "رقم الطلب المستخدم موجود بالفعل. يرجى استخدام رقم آخر."
                }
            },
            #endregion

            #region BM Errors: Bank communication errors can occur if there is a problem on the communication between Nestpay and the bank.
            {
                "BM-1001",
                new ErrorMessage
                {
                    Error = "بيانات TAG غير صالحة في تحليل الحقول."
                }
            },
            {
                "BM-1002",
                new ErrorMessage
                {
                    Error = "رسالة عكسية غير صالحة."
                }
            },
            {
                "BM-1006",
                new ErrorMessage
                {
                    Error = "خطأ في تحليل الرسالة. عدم تطابق معرف التاجر."
                }
            },
            {
                "BM-1007",
                new ErrorMessage
                {
                    Error = "خطأ في تحليل الرسالة. عدم تطابق معرف المحطة."
                }
            },
            {
                "BM-1008",
                new ErrorMessage
                {
                    Error = "خطأ عام في طلب إنشاء الجهة المستحوذة."
                }
            },
            {
                "BM-9100",
                new ErrorMessage
                {
                    Error = "اسم المضيف غير معروف."
                }
            },
            {
                "BM-9101",
                new ErrorMessage
                {
                    Error = "تعذر الاتصال بالمضيف، تم إغلاق المنفذ."
                }
            },
            {
                "BM-9102",
                new ErrorMessage
                {
                    Error = "خطأ IO في اتصال المضيف."
                }
            },
            {
                "BM-9103",
                new ErrorMessage
                {
                    Error = "فشل الاتصال العام بالمضيف."
                }
            },
            #endregion

            #region ISO8583 Errors: caused by bank.
            {
                "ISO8583-9999",
                new ErrorMessage()
                {
                    Error = "خطأ غير رقمي في ISO8583.",
                    Solution = "خطأ غير محدد، يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-9998",
                new ErrorMessage()
                {
                    Error = "خطأ غير معروف في ISO8583 من جهة الإصدار.",
                    Solution = "خطأ غير محدد، يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-01",
                new ErrorMessage()
                {
                    Error = "إحالة - يرجى الاتصال بالبنك للحصول على الموافقة اليدوية.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-02",
                new ErrorMessage()
                {
                    Error = "موافقة وهمية، لكنها لا يجب أن تُستخدم في نظام VPOS، تحقق من البنك.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-03",
                new ErrorMessage()
                {
                    Error = "تاجر أو مزود خدمة غير صالح.",
                    Solution = "قد يكون نظام نقاط البيع الافتراضي معطلًا. تواصل مع الجهة المستحوذة."
                }
            },
            {
                "ISO8583-04",
                new ErrorMessage()
                {
                    Error = "يرجى استلام البطاقة.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-05",
                new ErrorMessage()
                {
                    Error = "لا تقبل العملية.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-06",
                new ErrorMessage()
                {
                    Error = "خطأ (يظهر فقط في ردود تحديث الملفات).",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-07",
                new ErrorMessage()
                {
                    Error = "يرجى استلام البطاقة - شرط خاص.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-08",
                new ErrorMessage()
                {
                    Error = "موافقة وهمية، لكنها لا يجب أن تُستخدم في نظام VPOS، تحقق من البنك.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-11",
                new ErrorMessage()
                {
                    Error = "موافقة وهمية (VIP)، لكنها لا يجب أن تُستخدم في نظام VPOS، تحقق من البنك.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على المزيد من المعلومات."
                }
            },
            {
                "ISO8583-12",
                new ErrorMessage()
                {
                    Error = "المعاملة غير صالحة.",
                    Solution = "تواصل مع الجهة المستحوذة حول هذه المعاملة."
                }
            },
            {
                "ISO8583-13",
                new ErrorMessage()
                {
                    Error = "المبلغ غير صالح.",
                    Solution = "المبلغ ليس بالتنسيق الصحيح."
                }
            },
            {
                "ISO8583-14",
                new ErrorMessage()
                {
                    Error = "رقم الحساب غير صالح.",
                    Solution = "رقم التاجر أو الرقم الطرفي غير صحيح. تواصل مع الجهة المستحوذة."
                }
            },
            {
                "ISO8583-15",
                new ErrorMessage()
                {
                    Error = "جهة الإصدار غير موجودة.",
                    Solution = "جهة الإصدار غير معرّفة."
                }
            },
            {
                "ISO8583-19",
                new ErrorMessage()
                {
                    Error = "أعد المحاولة مرة أخرى.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-20",
                new ErrorMessage()
                {
                    Error = "المبلغ غير صالح.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-21",
                new ErrorMessage()
                {
                    Error = "لا يمكن التراجع عن العملية.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-25",
                new ErrorMessage()
                {
                    Error = "تعذر العثور على السجل في الملف.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-28",
                new ErrorMessage()
                {
                    Error = "الأصل مرفوض.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-29",
                new ErrorMessage()
                {
                    Error = "الأصل غير موجود.",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-30",
                new ErrorMessage()
                {
                    Error = "خطأ في التنسيق (تم إنشاؤه بواسطة المحول).",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-32",
                new ErrorMessage()
                {
                    Error = "إحالة (عام).",
                    Solution = "تواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-33",
                new ErrorMessage()
                {
                    Error = "البطاقة منتهية الصلاحية، يرجى استلامها.",
                    Solution = "البطاقة منتهية الصلاحية، الجهة المستحوذة رفضت المعاملة."
                }
            },
            {
                "ISO8583-34",
                new ErrorMessage()
                {
                    Error = "يُشتبه في وجود احتيال، يرجى استلام البطاقة.",
                    Solution = "يُشتبه في وجود احتيال، الجهة المستحوذة رفضت المعاملة."
                }
            },
            {
                "ISO8583-36",
                new ErrorMessage()
                {
                    Error = "بطاقة مقيدة، يرجى استلام البطاقة.",
                    Solution = "يمكن لصاحب البطاقة التواصل مع جهة الإصدار للحصول على معلومات مفصلة."
                }
            },
            {
                "ISO8583-37",
                new ErrorMessage()
                {
                    Error = "يرجى استلام البطاقة. جهة الإصدار ترغب في استعادة البطاقة.",
                    Solution = "البطاقة مسروقة، يجب على صاحب البطاقة إرجاعها إلى الجهة المستحوذة."
                }
            },
            {
                "ISO8583-38",
                new ErrorMessage()
                {
                    Error = "تجاوز عدد المحاولات المسموح بها لإدخال الرقم السري، يرجى استلام البطاقة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-41",
                new ErrorMessage()
                {
                    Error = "بطاقة مفقودة، يرجى استلام البطاقة.",
                    Solution = "تم الإبلاغ عن فقدان البطاقة، لا يمكن لصاحب البطاقة استخدامها."
                }
            },
            {
                "ISO8583-43",
                new ErrorMessage()
                {
                    Error = "بطاقة مسروقة، يرجى استلام البطاقة.",
                    Solution = "تم الإبلاغ عن سرقة البطاقة، لا يمكن لصاحب البطاقة استخدامها."
                }
            },
            {
                "ISO8583-51",
                new ErrorMessage()
                {
                    Error = "الأموال غير كافية.",
                    Solution = "حد البطاقة غير كافٍ."
                }
            },
            {
                "ISO8583-52",
                new ErrorMessage()
                {
                    Error = "لا يوجد حساب جارٍ.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-53",
                new ErrorMessage()
                {
                    Error = "لا يوجد حساب توفير.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-54",
                new ErrorMessage()
                {
                    Error = "البطاقة منتهية الصلاحية.",
                    Solution = "البطاقة منتهية الصلاحية، لا يمكن لصاحب البطاقة استخدامها."
                }
            },
            {
                "ISO8583-55",
                new ErrorMessage()
                {
                    Error = "الرقم السري غير صحيح.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-56",
                new ErrorMessage()
                {
                    Error = "لا يوجد سجل للبطاقة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-57",
                new ErrorMessage()
                {
                    Error = "المعاملة غير مسموح بها لحامل البطاقة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-58",
                new ErrorMessage()
                {
                    Error = "المعاملة غير مسموح بها للطرفيّة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-61",
                new ErrorMessage()
                {
                    Error = "تجاوز حد المبلغ المسموح بالسحب.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-62",
                new ErrorMessage()
                {
                    Error = "بطاقة مقيدة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-63",
                new ErrorMessage()
                {
                    Error = "انتهاك أمني.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-65",
                new ErrorMessage()
                {
                    Error = "تم تجاوز الحد المسموح للنشاط.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-75",
                new ErrorMessage()
                {
                    Error = "تجاوز عدد المحاولات المسموح بها لإدخال الرقم السري.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-76",
                new ErrorMessage()
                {
                    Error = "خطأ في مزامنة المفتاح.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-77",
                new ErrorMessage()
                {
                    Error = "بيانات غير متسقة.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-80",
                new ErrorMessage()
                {
                    Error = "التاريخ غير صالح.",
                    Solution = "يجب على صاحب البطاقة التحقق من تفاصيل البطاقة."
                }
            },
            {
                "ISO8583-81",
                new ErrorMessage()
                {
                    Error = "خطأ في التشفير.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-82",
                new ErrorMessage()
                {
                    Error = "فشل CVV أو قيمة CVV غير صالحة.",
                    Solution = "يجب على صاحب البطاقة التحقق من تفاصيل البطاقة."
                }
            },
            {
                "ISO8583-83",
                new ErrorMessage()
                {
                    Error = "لا يمكن التحقق من الرقم السري.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-85",
                new ErrorMessage()
                {
                    Error = "مرفوض (عام).",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-91",
                new ErrorMessage()
                {
                    Error = "جهة الإصدار أو المحول غير مستجيب.",
                    Solution = "لا يمكن التواصل مع المضيف، يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-92",
                new ErrorMessage()
                {
                    Error = "انتهت المهلة، يتم محاولة العكس.",
                    Solution = "لا يمكن التواصل مع المضيف، يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-93",
                new ErrorMessage()
                {
                    Error = "انتهاك، لا يمكن الإكمال (التقسيط، الولاء).",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-96",
                new ErrorMessage()
                {
                    Error = "خلل في النظام.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-98",
                new ErrorMessage()
                {
                    Error = "عكس مكرر.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            },
            {
                "ISO8583-YK",
                new ErrorMessage()
                {
                    Error = "البطاقة موجودة في القائمة السوداء.",
                    Solution = "يرجى التواصل مع مكتب مساعدة الجهة المستحوذة."
                }
            }
            #endregion
        };
    }
}
