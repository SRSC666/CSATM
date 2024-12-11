using CSATM.Backend;

namespace CSATM.Front
{
    public partial class UserLoginControl : UserControl
    {
        public event Action ButtonBackClick;
        public event Action ButtonForwardClick;

        public UserLoginControl()
        {
            InitializeComponent();

            buttonBack.Click += (sender, e) =>
            {
                ButtonBackClick.Invoke();
            };
            buttonSignup.Click += ButtonSignupClick;
            buttonLogin.Click += ButtonLoginClick;
        }

        private void ButtonSignupClick(object sender, EventArgs e)
        {
            string bankName = textBoxBankName.Text;
            string number = textBoxNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            Result result = ATM.CreateAccount(bankName, number, username, password);
            MessageBox.Show(result.Message);
        }

        private void ButtonLoginClick(object sender, EventArgs e)
        {
            string bankName = textBoxBankName.Text;
            string number = textBoxNumber.Text;
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            Result result = ATM.Login(bankName, number, username, password);
            if (result.Code == 0)
            {
                MessageBox.Show(result.Message);
            }
            else
            {
                ButtonForwardClick?.Invoke();
            }
        }
    }
}
