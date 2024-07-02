using ToDo_MauiApp.ViewModel;

namespace ToDo_MauiApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

       
    }

}
