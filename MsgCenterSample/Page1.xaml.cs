
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class Page1 : ContentPage
	{
		
		public Page1()
		{
			InitializeComponent(); 


			//(this, false);
		}
		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PopAsync();
		}

		async void Handle_Next(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PushAsync( Page2.GetPage2Instance(), true);
		}
	}
}
