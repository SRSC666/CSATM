using CSATM.Backend;

namespace CSATM.Front
{
    public partial class MainForm : Form
    {
        private MainMenuControl mainMenuControl;
        private AdminControl adminControl;
        private UserLoginControl userLoginControl;
        private ATMControl atmControl;

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
            mainMenuControl.ButtonAdminClick += () =>
            {
                ChangeToPage(adminControl);
            };
            mainMenuControl.ButtonUserClick += () =>
            {
                ChangeToPage(userLoginControl);
            };

            adminControl = new();
            adminControl.ButtonBackClick += () =>
            {
                ChangeToPage(mainMenuControl);
            };

            userLoginControl = new();
            userLoginControl.ButtonBackClick += () =>
            {
                ChangeToPage(mainMenuControl);
            };

            atmControl = new();

            ChangeToPage(mainMenuControl);
        }

        private void ChangeToPage(UserControl control)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }
    }
}
