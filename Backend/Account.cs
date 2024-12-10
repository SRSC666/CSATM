namespace CSATM.Backend
{
    public class Account(string bankName, string number, string username, string password)
    {
        public string BankName { get; } = bankName;
        public string Number { get; } = number;

        public string Username { get; set; } = username;
        public string Password { get; set; } = password;

        public decimal Balance { get; set; }
    }
}
