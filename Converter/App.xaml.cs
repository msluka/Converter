﻿using Converter.MVVM.Views;

namespace Converter;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new ConverterView();
	}
}
