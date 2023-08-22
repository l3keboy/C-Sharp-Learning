using MauiApp___Tasks.ViewModel;

namespace MauiApp___Tasks;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}