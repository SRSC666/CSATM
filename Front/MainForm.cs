using CSATM.Backend;

namespace CSATM.Front
{
    public partial class MainForm : Form
    {
        private MainMenuControl mainMenuControl;
        private AdminControl adminControl;

        public MainForm()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            FormClosing += (sender, e) =>
            {
                Data.SaveBankData();
            };

            mainMenuControl = new();
            adminControl = new();

            ChangeToPage(mainMenuControl);
        }

        private void ChangeToPage(UserControl control)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }
    }
}
