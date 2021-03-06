﻿using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace OfficeLocator
{
	public class App : Application
	{
		public App ()
		{
			// The root page of your application

			//Step 1: Add Navigation
			MainPage = new NavigationPage(new LocationsPage())
			{
				BarTextColor = Color.White
			};
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

