
namespace SqlCustomersBLL
{
    public class CustomerAuditData
    {
        public int Id { get; set; }

        public int CustomerId { get; set; }

        public string AuditData { get; set; }

        public string Operation { get; set; }
    }
}
