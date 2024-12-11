using CSATM.Backend;

namespace CSATM.Front
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            FormClosing += (sender, e) =>
            {
                Data.SaveBankData();
            };
        }
    }
}
