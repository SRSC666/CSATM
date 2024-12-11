namespace CSATM.Backend
{
    public class BigMoneyArgs(string accountNumber, decimal amount)
    {
        public string AccountNumber { get; set; } = accountNumber;
        public decimal Amount { get; set; } = amount;
    }
}
