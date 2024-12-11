using CSATM.Backend;

namespace CSATM.Front
{
    public partial class MainForm : Form
    {
        private MainMenuControl mainMenuControl;

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
            ChangeToPage(mainMenuControl);
        }

        private void ChangeToPage(UserControl control)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }
    }
}
