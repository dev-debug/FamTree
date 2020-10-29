using FamilyTreeApp.Models;
using FamilyTreeApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static FamilyTreeApp.ViewModels.UserInfoTabbedPageViewModel;

namespace FamilyTreeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UserTabbedPage : INotifyPropertyChanged
    {
        private ObservableCollection<UserViewModel> _users;
        public UserTabbedPage()
        {
            InitializeComponent();

            //var bc = BindingContext as UserViewModel;
            //_users = new ObservableCollection<UserViewModel>
            //{
            //    new UserViewModel{Title=bc.Title, FirstName =bc.FirstName, LastName = bc.LastName,  Address1 =bc.Address1 ,
            //        Address2 = bc.Address2, Age=bc.Age, City=bc.City, Country=bc.Country, Phone=bc.Phone,Profession=bc.Profession,
            //        State=bc.State, Zip=bc.Zip

            //    },
            //};

            //var tabbedPage = new UserTabbedPage();
            //tabbedPage.BindingContext = new UserViewModel();
            //Navigation.PushAsync(tabbedPage);
            //var bc = BindingContext as UserViewModel;

            //UserInfoTabbedPageViewModel.Instance.UserViewTab = bc;
            //DataManager.Instance.Forms1 = new Dictionary<string, string>();
            //var bc = BindingContext as DTOFamilyTreeMaster;
            //DataManager.Instance.Forms1.Add("FirstName",bc.FirstName);
            // DataManager.Instance.Forms1.Add("FirstName", bc.FirstName);

            //for (int i = countDaughters; i <= numCell; i++)
            //{
            //    DataManager.Instance.Forms1.Add("xxx", "xxx");
            //}
        }

        //async void OnAddUser(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        //{
        //    var page = new UserSpousePage(new UserViewModel());
        //    page.UserAdded += (source, user) =>
        //    {
        //        _users.Add(user);
        //    };
        //    await Navigation.PushAsync(page);

        //}

    }
}