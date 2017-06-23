using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class Page3 : ContentPage
	{
		public Page3()
		{
			InitializeComponent(); 
		}
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PopAsync();
		}

		async void Handle_Next(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PushAsync(new Page4(), true);
		}
	}
}
