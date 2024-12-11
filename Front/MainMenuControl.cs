namespace CSATM.Front
{
    public partial class MainMenuControl : UserControl
    {
        public event Action ButtonAdminClick;
        public event Action ButtonUserClick;

        public MainMenuControl()
        {
            InitializeComponent();

            buttonAdmin.Click += (sender, e) =>
            {
                ButtonAdminClick?.Invoke();
            };
            buttonUser.Click += (sender, e) =>
            {
                ButtonUserClick?.Invoke();
            };
        }
    }
}
