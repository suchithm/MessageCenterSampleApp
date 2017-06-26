using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class Page6 : ContentPage
	{
		public Page6()
		{
			InitializeComponent();
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			//MessagingCenter.Send(this, "SaveToastPage2");
			MessagingCenter.Send(Page2.GetPage2Instance(), "SaveToastPage2");


			int stackCount = App.NavigationRef.NavigationStack.Count;
			for (var counter = 2; counter < stackCount - 1; counter++)
			{
				App.NavigationRef.RemovePage(App.NavigationRef.NavigationStack[2]);
			}
			await App.NavigationRef.PopAsync();
		}


	}
}
