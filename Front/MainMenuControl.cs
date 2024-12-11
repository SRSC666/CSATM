namespace CSATM.Front
{
    public partial class MainMenuControl : UserControl
    {
        public event Action ButtonAdminClick;

        public MainMenuControl()
        {
            InitializeComponent();

            buttonAdmin.Click += (sender, e) =>
            {
                ButtonAdminClick?.Invoke();
            };
        }
    }
}
