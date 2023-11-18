namespace CRUDHikerAppXamarin
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(AddHikeLog), typeof(AddHikeLog));
        }
    }
}
