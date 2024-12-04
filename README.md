# NestPayDotNet SDK

A lightweight and easy-to-use .NET SDK for integrating with the **NestPay API**, enabling secure and efficient payment processing. This SDK supports various transaction types, including sales, refunds, preauthorization.

---

## Features

- **Transaction Processing**: Supports `Auth`, `PreAuth`, `PostAuth`, `Void`, and `Credit` operations.
- **Error Handling**: Built-in error codes and descriptive error messages for seamless debugging.
- **XML Serialization**: Automatically handles request and response conversions.
- **Extensible**: Designed for easy customization and scalability.


## Usage example

```c#
using NestPayDotNet.Exceptions;
using NestPayDotNet;
using NestPayDotNet.Enums;
using NestPayDotNet.Models;
using Newtonsoft.Json;


// NestPay merchant Information
const string NESTPAY_URL = "YOUR_MERCHANT_API_URL";
const string MERCHANT_ID = "YOUR_MERCHANT_ID";
const string MERCHANT_USERNAME = "YOUR_MERCHANT_USERNAME";
const string MERCHANT_PASSWORD = "YOUR_MERCHANT_PASSWORD";


// Test Card Information
const string CARD_NUMBER = "0000000000000000";
const string CARD_EXPIRY = "mm/yy";
const string CARD_CVV = "000";


// Initialize a new transaction request
var saleRequest = new TransactionRequest
{
    CardNumber = CARD_NUMBER,
    CardExpiry = CARD_EXPIRY,
    CardCvv = CARD_CVV,
    Currency = Currency.IQD,
    Lang = Language.English,
    Total = 1000,
    Type = TransactionType.Auth.ToString(),
    OrderId = Guid.NewGuid().ToString(),
};


// Initialize a new NestPayClient
var nestPayClient = new NestPayClient(NESTPAY_URL, MERCHANT_ID, MERCHANT_USERNAME, MERCHANT_PASSWORD);


// Process the transaction
try
{
    var saleResponse = await nestPayClient.ProcessTransactionAsync(saleRequest);

    Console.WriteLine(JsonConvert.SerializeObject(saleResponse));
}
catch (NestPayGatewayException ex)
{
    // Handle the gateway exception
    Console.WriteLine(ex.ToString());
}
catch (NestPayTransactionException ex)
{
    // Handle the transaction exception
    Console.WriteLine(ex.ToString());
}
catch (Exception ex)
{
    // Handle any other exception
    Console.WriteLine(ex.ToString());
}

```
