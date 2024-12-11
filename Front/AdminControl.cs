using CSATM.Backend;

namespace CSATM.Front
{
    public partial class AdminControl : UserControl
    {
        public event Action ButtonBackClick;

        public AdminControl()
        {
            InitializeComponent();

            buttonBack.Click += (sender, e) =>
            {
                ButtonBackClick?.Invoke();
            };
            buttonAdd.Click += ButtonAddClick;
            buttonDelete.Click += ButtonDeleteClick;
        }

        private void ButtonAddClick(object sender, EventArgs e)
        {
            string bankName = textBoxBankName.Text;
            Result result = Admin.AddBank(bankName);
            MessageBox.Show(result.Message);
        }

        private void ButtonDeleteClick(object sender, EventArgs e)
        {
            string bankName = textBoxBankName.Text;
            Result result = Admin.DeleteBank(bankName);
            MessageBox.Show(result.Message);
        }
    }
}
