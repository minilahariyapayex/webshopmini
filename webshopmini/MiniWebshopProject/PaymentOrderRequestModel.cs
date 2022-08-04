namespace MiniWebshopProject
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
  

    public class BillingAddress
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string msisdn { get; set; }
        public string streetAddress { get; set; }
        public string coAddress { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string countryCode { get; set; }
    }

    public class OrderItem
    {
        public string reference { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string @class { get; set; }
      
        public int quantity { get; set; }
        public string quantityUnit { get; set; }
        public int unitPrice { get; set; }
        public int vatPercent { get; set; }
        public int amount { get; set; }
        public int vatAmount { get; set; }
        public List<string> restrictedToInstruments { get; set; }
    }

    public class PayeeInfo
    {
        public string payeeId { get; set; }
        public string payeeReference { get; set; }
        public string payeeName { get; set; }
    }

    public class Payer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string msisdn { get; set; }
        public ShippingAddress shippingAddress { get; set; }
        public BillingAddress billingAddress { get; set; }
    }

    public class paymentorder
    {
        public string operation { get; set; }
        public string currency { get; set; }
        public int amount { get; set; }
        public int vatAmount { get; set; }
        public string description { get; set; }
        public string userAgent { get; set; }
        public string language { get; set; }
        public string productName { get; set; }
        public Urls urls { get; set; }
        public PayeeInfo payeeInfo { get; set; }
        public Payer payer { get; set; }
        public List<OrderItem> orderItems { get; set; }
    }


    public class PaymentOrderRequestModel
    {
        public paymentorder paymentorder { get; set; }
    }

    public class ShippingAddress
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string msisdn { get; set; }
        public string streetAddress { get; set; }
        public string coAddress { get; set; }
        public string city { get; set; }
        public string zipCode { get; set; }
        public string countryCode { get; set; }
    }

    public class Swish
    {
        public int paymentRestrictedToAgeLimit { get; set; }
        public string paymentRestrictedToSocialSecurityNumber { get; set; }
    }

    public class Urls
    {
        public List<string> hostUrls { get; set; }
        public string completeUrl { get; set; }
        public string callbackUrl { get; set; }
        public string termsOfServiceUrl { get; set; }
        public string cancelUrl { get; set; }
    }


}
