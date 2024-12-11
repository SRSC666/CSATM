namespace CSATM.Front
{
    public partial class UserLoginControl : UserControl
    {
        public event Action ButtonBackClick;

        public UserLoginControl()
        {
            InitializeComponent();

            buttonBack.Click += (sender, e) =>
            {
                ButtonBackClick.Invoke();
            };
        }
    }
}
