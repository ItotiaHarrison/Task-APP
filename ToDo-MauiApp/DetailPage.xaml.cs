using ToDo_MauiApp.ViewModel;

namespace ToDo_MauiApp;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}