namespace CSATM.Backend
{
    public static class ATM
    {
        public static List<Bank> Banks { get; } = [];

        public static Account CurrentAccount { get; set; }
    }
}
