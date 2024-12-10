namespace CSATM.Backend
{
    public static class ATM
    {
        public const string FileName = "data.json";

        public static List<Bank> Banks { get; } = [];

        public static Account CurrentAccount { get; set; }

        public static void LoadBankData()
        {
            
        }

        public static void SaveBankData()
        {

        }
    }
}
