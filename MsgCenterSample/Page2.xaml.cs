using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class Page2 : ContentPage
	{
		public Page2()
		{
			InitializeComponent();
			MessagingCenter.Unsubscribe<Page6>(this, "SaveToastPage2");
			MessagingCenter.Subscribe<Page6>(this, "SaveToastPage2", (sender) =>
			{
				DisplayToastOnSuccessfulSubmission();

			});
			//MessagingCenter.Subscribe<Page6>(this, "SaveToastPage26666", (sender) =>
		 //   {
			//DisplayToastOnSuccessfulSubmission();

		 //   });
			NavigationPage.SetBackButtonTitle(new Page1(), "Page1");
		}

		async void Handle_Clicked(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PopAsync();
		}

		async void Handle_Next(object sender, System.EventArgs e)
		{
			await App.NavigationRef.PushAsync(new Page3(), true);
		}
		async void DisplayToastOnSuccessfulSubmission()
		{
			Debug.WriteLine("Saved successfully");


			var toastRectIn = new Rectangle
			{
				Height = 75,
				Width = App.ScreenSize.Width,
				X = 0,
			};
			toastRectIn.Y = 500 - (toastRectIn.Height + Device.OnPlatform(0, 20, 0)); //500-screen height

			var toastRectOut = new Rectangle
			{
				Height = 75,
				Width = App.ScreenSize.Width,
				X = 0,
				Y = 500 + (toastRectIn.Height + Device.OnPlatform(0, 20, 0))

			};

			await Task.Delay(1000); //REQUIRED
			lblSubmitToast.Text = "Saved successfully";
			viewSubmitToast.IsVisible = true;
			viewSubmitToast.LayoutTo(toastRectIn, 50, null);
			await Task.Delay(4000); //REQUIRED
			viewSubmitToast.LayoutTo(toastRectOut, 650, null);
			await Task.Delay(500); //REQUIRED
			viewSubmitToast.IsVisible = false;
		}

	}
}
