using CSATM.Backend;
using CSATM.Front;

namespace CSATM
{
    public static class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Data.LoadBankData();

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}