using Converter.MVVM.ViewModels;

namespace Converter.MVVM.Views;

public partial class ConverterView : ContentPage
{
	public ConverterView()
	{
		InitializeComponent();
		BindingContext = new ConverterViewModel();
	}
}