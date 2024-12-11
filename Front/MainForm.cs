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
            InitializeUserControl();

            FormClosing += (sender, e) =>
            {
                Data.SaveBankData();
            };
        }

        private void InitializeUserControl()
        {
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
            userLoginControl.ButtonForwardClick += () =>
            {
                ChangeToPage(atmControl);
            };

            atmControl = new();
            atmControl.ButtonExitClick += () =>
            {
                ATM.Logout();
                ChangeToPage(userLoginControl);
            };

            ChangeToPage(mainMenuControl);
        }

        private void ChangeToPage(UserControl control)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(control);
        }
    }
}
