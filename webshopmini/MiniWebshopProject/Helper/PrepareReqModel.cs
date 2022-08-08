namespace MiniWebshopProject.Helper
{
    public static class PrepareReqModel
    {
        public static PaymentOrderRequestModel GetPaymentOrderRequestModel()
        {
            return new PaymentOrderRequestModel()
            {
                paymentorder = new paymentorder()
                {
                    operation = "Purchase",
                    currency = "SEK",
                    amount = 1500,
                    vatAmount = 375,
                    description = "Test Purchase",
                    userAgent = "Mozilla /5.0...",
                    language = "sv-SE",
                    productName = "Checkout3",
                    urls = GetURLs(),
                    payeeInfo = GetPayeeInfo(),
                    payer = GetPayerInfo(),
                    orderItems = GetOrderItems()
                }

            };
        }
        static Urls GetURLs()
        {
            return new Urls()
            {
                hostUrls = new List<string>() { "https://example.com", "https://example.net" },
                completeUrl = "https://example.com/payment-completed",
                callbackUrl = "https://api.example.com/payment-callback",
                termsOfServiceUrl = "https://example.com/termsandconditions.pdf",
                cancelUrl = "https://example.com/payment-cancelled"
            };
        }
        static Payer GetPayerInfo()
        {
            return new Payer()
            {
                billingAddress = GetBillingAddress(),
                email = "olivia.nyhuus@payex.com",
                firstName = "olivia",
                lastName = "nyhuus",
                msisdn = "+4798765432"
                //  shippingAddress = new ShippingAddress(),

            };
        }
        static BillingAddress GetBillingAddress()
        {
            return new BillingAddress()
            {
                firstName = "olivia",
                lastName = "nyhuus",
                email = "olivia.nyhuus@payex.com",
                msisdn = "+4798765432",
                streetAddress = "test street",
                coAddress = "",
                city = "oslo",
                zipCode = "1642",
                countryCode = "NO",
            };
        }
        static ShippingAddress GetShippingAddress()
        {
            return new ShippingAddress()
            {
                firstName = "",
                lastName = "",
                email = "",
                msisdn = "",
                streetAddress = "",
                coAddress = "",
                city = "",
                zipCode = "",
                countryCode = "",
            };
        }
        static PayeeInfo GetPayeeInfo()
        {
            return new PayeeInfo()
            {
                payeeId = "ee8ecc78-edc0-489a-9590-6fbfc8274a70",
                payeeReference = "Ref" + GetRandomNumber(),
                payeeName = "Mini Webshop"

            };
        }

        static string GetRandomNumber()
        {
            Random random = new Random();
            return random.Next().ToString();
        }
        static List<OrderItem> GetOrderItems()
        {
            return new List<OrderItem>()
            {
                new OrderItem()
                {
                   reference= "P1",
                   name= "Product1",
                   type= "PRODUCT",
                   @class= "ProductGroup1",
                   quantityUnit = "grams",
                   quantity=1,
                   //restrictedToInstruments = new List<string>(){ "Invoice-PayExFinancingSe"},
                   amount = 1500,
                   vatAmount = 375
                }
            };

        }
    }
}
