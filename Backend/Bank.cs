namespace CSATM.Backend
{
    public class Bank(string name)
    {
        public string Name { get; set; } = name;

        public List<Account> Accounts { get; } = [];
    }
}
