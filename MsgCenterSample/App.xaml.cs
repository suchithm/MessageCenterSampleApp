using Xamarin.Forms;

namespace MsgCenterSample
{
	public partial class App : Application
	{
		public static INavigation NavigationRef;
		public static Size ScreenSize;
		public App()
		{
			InitializeComponent();

			//MainPage = new Page1();
			MainPage = new NavigationPage(new Page1());
			NavigationRef = MainPage.Navigation;
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
