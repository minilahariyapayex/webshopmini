namespace MiniWebshopProject.Model
{

    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Aborted
    {
        public string id { get; set; }
    }

    public class Cancelled
    {
        public string id { get; set; }
    }

    public class Failed
    {
        public string id { get; set; }
    }

    public class FailedAttempts
    {
        public string id { get; set; }
    }

    public class FinancialTransactions
    {
        public string id { get; set; }
    }

    public class History
    {
        public string id { get; set; }
    }

    public class Metadata
    {
        public string id { get; set; }
    }

    public class Operation
    {
        public string href { get; set; }
        public string rel { get; set; }
        public string method { get; set; }
        public string contentType { get; set; }
    }

    public class OrderItems
    {
        public string id { get; set; }
    }

    public class Paid
    {
        public string id { get; set; }
    }

    public class Payer
    {
        public string id { get; set; }
    }

    public class Paymentorder
    {
        public string id { get; set; }
        public DateTime created { get; set; }
        public DateTime updated { get; set; }
        public string operation { get; set; }
        public string status { get; set; }
        public string currency { get; set; }
        public int amount { get; set; }
        public int vatAmount { get; set; }
        public string description { get; set; }
        public string initiatingSystemUserAgent { get; set; }
        public string language { get; set; }
        public List<string> availableInstruments { get; set; }
        public string implementation { get; set; }
        public bool instrumentMode { get; set; }
        public bool guestMode { get; set; }
        public Payer payer { get; set; }
        public OrderItems orderItems { get; set; }
        public History history { get; set; }
        public Failed failed { get; set; }
        public Aborted aborted { get; set; }
        public Paid paid { get; set; }
        public Cancelled cancelled { get; set; }
        public FinancialTransactions financialTransactions { get; set; }
        public FailedAttempts failedAttempts { get; set; }
        public Metadata metadata { get; set; }
    }

    public class PaymentOrderResponseModel
    {
        public Paymentorder paymentorder { get; set; }
        public List<Operation> operations { get; set; }
    }



}
