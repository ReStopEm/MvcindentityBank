namespace MvcindentityBank
{
    public class Account
    {
        public int Id { get; set; }

        public string Number { get; set; }
        public decimal Qty { get; set; }
        public virtual CustomContext CustomUser { get; set; }
    }
}