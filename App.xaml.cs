using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using FamilyTreeApp;
using FamilyTreeApp.ViewModels;
using FamilyTreeApp.Pages;

namespace FamilyTreeApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new Login.Login();
            UserInfoTabbedPageViewModel viewModel = new UserInfoTabbedPageViewModel();
            UserInfoTabbedPage userInfoTabbedPage = new UserInfoTabbedPage();
            userInfoTabbedPage.BindingContext = viewModel;

            //MainPage= Navigation.PushAsync(userInfoTabbedPage);
            MainPage = new NavigationPage(userInfoTabbedPage);

            //MainPage = new Pages.UserInfoTabbedPage();

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
