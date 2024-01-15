using cri_MVVM_MCLG__.Vista;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace cri_MVVM_MCLG__
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new Page1();
		}

		protected override void OnStart()
		{
		}

		protected override void OnSleep()
		{
		}

		protected override void OnResume()
		{
		}
	}
}
