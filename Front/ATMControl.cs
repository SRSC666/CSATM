using System.Text.Json;
using CSATM.Backend;

namespace CSATM.Front
{
    public partial class ATMControl : UserControl
    {
        public event Action ButtonExitClick;

        public ATMControl()
        {
            InitializeComponent();

            buttonExit.Click += (sender, e) =>
            {
                ButtonExitClick?.Invoke();
            };
            buttonSave.Click += ButtonSaveClick;
            buttonWithdraw.Click += ButtonWithdrawClick;
        }

        private void ButtonSaveClick(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                Result result = ATM.SaveMoney(amount);
                MessageBox.Show(result.Message);
            }
            else
            {
                MessageBox.Show("不是合法的金钱数值");
            }
        }

        private void ButtonWithdrawClick(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBoxAmount.Text, out decimal amount))
            {
                Result result = ATM.WithdrawMoney(amount);
                if (result.Data is BigMoneyArgs)
                {
                    string json = JsonSerializer.Serialize(result.Data, Data.SerializerOptions);
                    MessageBox.Show(json);
                }
                else
                {
                    MessageBox.Show(result.Message);
                }
            }
            else
            {
                MessageBox.Show("不是合法的金钱数值");
            }
        }
    }
}
