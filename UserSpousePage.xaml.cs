
using FamilyTreeApp.ViewModels;
using System;
using Xamarin.Forms;
    using Xamarin.Forms.Xaml;
using static FamilyTreeApp.ViewModels.UserInfoTabbedPageViewModel;

namespace FamilyTreeApp.Pages
    {
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class UserSpousePage : ContentPage
        {
            public int countSpouses = 1;
          public event EventHandler<UserViewModel> UserAdded;

        //public UserSpousePage(UserViewModel userViewModel)
        //    {
        //    if (userViewModel == null)
        //        throw new ArgumentNullException(nameof(userViewModel));
        //    InitializeComponent();
        //        //CreateEntryCells(10);

        //    }

        public UserSpousePage()
        {
            InitializeComponent();
        }


        private void CreateEntryCells(int numCell, string textToBeCreated)
            {
                for (int i = countSpouses; i <= numCell; i++)
                {
                    EntryCell entInput = new EntryCell
                    {
                        Placeholder = textToBeCreated + countSpouses
                    };

                    string txt = "{Binding" + textToBeCreated + countSpouses + "_FirstName}";
                    //string txtLastName = "{Binding" + textToBeCreated + countSpouses + "_LastName}";

                    entInput.SetBinding(EntryCell.TextProperty, txt);

                    Spouses.Add(entInput);
                    ++countSpouses;

                }

                      }

       
            private void OnStepperValueChanged(object sender, System.EventArgs e)
            {
                CreateEntryCells(int.Parse(stepper.Value.ToString()),"Spouse Full Name");

            }
        }
    }