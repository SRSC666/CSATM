namespace CSATM.Backend
{
    public class Account(string number, string username, string password)
    {
        public string Number { get; set; } = number;

        public string Username { get; set; } = username;
        public string Password { get; set; } = password;

        public decimal Balance { get; set; }
    }
}
