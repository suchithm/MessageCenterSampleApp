using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class Page4 : ContentPage
	{
		public Page4()
		{
			InitializeComponent();
		}
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PopAsync();
		}

		async void Handle_Next(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PushAsync(new Page5(), true);
		}
	}
}
