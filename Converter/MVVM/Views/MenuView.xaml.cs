using Converter.MVVM.ViewModels;

namespace Converter.MVVM.Views;

public partial class MenuView : ContentPage
{
	public MenuView()
	{
		InitializeComponent();
		BindingContext = new MenuViewModel();
	}

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
		var element = (Grid)sender;
		var option = ((Label)element.Children.LastOrDefault()).Text;


        DisplayAlert("Alert", option, "OK");

    }
}