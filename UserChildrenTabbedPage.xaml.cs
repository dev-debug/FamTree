    using FamilyTreeApp.Models;
using FamilyTreeApp.ViewModels;
using System;
    using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
    using System.Threading.Tasks;

    using Xamarin.Forms;
    using Xamarin.Forms.Xaml;

    namespace FamilyTreeApp.Pages
    {
        [XamlCompilation(XamlCompilationOptions.Compile)]
        public partial class UserChildrenTabbedPage : ContentPage
        {
        private ObservableCollection<UserInfoTabbedPageViewModel> _viewmodel;
        private ObservableCollection<UserViewModel> _view1;

        private ObservableCollection<UserSpouseViewModel> _view2;
        private ObservableCollection<UserChildrenViewModel> _view3;

            public int countSons = 1;
            public int countDaughters = 1;
        //private object stepperSon;

        public UserChildrenTabbedPage()
            {
                InitializeComponent();
            }

            private void CreateEntryCells(int numCell, string textToBeCreated)
            {
                if (textToBeCreated.ToLower().Contains("son"))
                {
                    for (int i = countSons; i <= numCell; i++)
                    {
                        EntryCell entInput = new EntryCell
                        {
                            Placeholder = textToBeCreated + countSons
                            //Text = "{Binding Spouse' + 1 + 'FirstName}"
                            //HorizontalOptions = LayoutOptions.FillAndExpand
                        };

                        string txt = "{Binding" + textToBeCreated + countSons + "_FirstName}";
                        entInput.SetBinding(EntryCell.TextProperty, txt);

                        Sons.Add(entInput);
                        ++countSons;

                    }
          
                }
                else
                {
                    for (int i = countDaughters; i <= numCell; i++)
                    {
                        EntryCell entInput = new EntryCell
                        {
                            Placeholder = textToBeCreated + countDaughters
                            //Text = "{Binding Spouse' + 1 + 'FirstName}"
                            //HorizontalOptions = LayoutOptions.FillAndExpand
                        };

                        string txt = "{Binding" + textToBeCreated + countDaughters + "_FirstName}";
                        entInput.SetBinding(EntryCell.TextProperty, txt);

                        Daughters.Add(entInput);
                        ++countDaughters;

                    }

    
                }
            }

            private void OnstepperDaughterValueChanged(object sender, EventArgs e)
            {
                CreateEntryCells(int.Parse(stepperDaughter.Value.ToString()), "Daughter");

            }

            private void OnstepperSonValueChanged(object sender, EventArgs e)
            {

                CreateEntryCells(int.Parse(stepperSon.Value.ToString()), "Son");

            }

            private void OnSubmit(object sender, EventArgs e)
            {

            _view1 = new ObservableCollection<UserViewModel>
            {
                new UserViewModel{ 
                    Address1=UserInfoTabbedPageViewModel.Instance.UserViewTab.Address1,
                    Address2=UserInfoTabbedPageViewModel.Instance.UserViewTab.Address2,
                    Title=UserInfoTabbedPageViewModel.Instance.UserViewTab.Title,
                    Age=UserInfoTabbedPageViewModel.Instance.UserViewTab.Age,
                    City=UserInfoTabbedPageViewModel.Instance.UserViewTab.City,
                    Country=UserInfoTabbedPageViewModel.Instance.UserViewTab.Country,
                    FirstName=UserInfoTabbedPageViewModel.Instance.UserViewTab.Country,
                    LastName=UserInfoTabbedPageViewModel.Instance.UserViewTab.LastName,
                    Phone=UserInfoTabbedPageViewModel.Instance.UserViewTab.Phone,
                    Profession=UserInfoTabbedPageViewModel.Instance.UserViewTab.Profession,
                    State=UserInfoTabbedPageViewModel.Instance.UserViewTab.State,
                    Zip=UserInfoTabbedPageViewModel.Instance.UserViewTab.Zip
                }
            };

            _view2 = new ObservableCollection<UserSpouseViewModel>
            {
                new UserSpouseViewModel{
                    FatherFirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.FatherFirstName,
                    FatherLastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.FatherLastName,
                    MotherFirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.MotherFirstName,
                    Spouse1_FirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse1_FirstName,
                    Spouse1_LastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse1_LastName,
                    Spouse2_FirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse2_FirstName,
                    Spouse2_LastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse2_LastName,
                    Spouse3_FirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse3_FirstName,
                    Spouse3_LastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse3_LastName,
                    Spouse4_FirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse4_FirstName,
                    Spouse4_LastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse4_LastName,
                    Spouse5_FirstName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse5_FirstName,
                    Spouse5_LastName=UserInfoTabbedPageViewModel.Instance.UserSpouseViewTab.Spouse5_LastName
                }
            };

            _view3 = new ObservableCollection<UserChildrenViewModel>
            {
                new UserChildrenViewModel{
                    Daughter10_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter10_FirstName,
                    Daughter10_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter10_LastName,
                    Daughter1_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter1_FirstName,
                    Daughter1_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter1_LastName,
                    Daughter2_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter2_FirstName,
                    Daughter2_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter2_LastName,
                    Daughter3_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter3_FirstName,
                    Daughter3_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter3_LastName,
                    Daughter4_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter4_FirstName,
                    Daughter4_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter4_LastName,
                    Daughter5_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter5_FirstName,
                    Daughter5_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter5_LastName,

                     Daughter6_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter6_FirstName,
                    Daughter6_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter6_LastName,
                    Daughter7_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter7_FirstName,
                    Daughter7_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter7_LastName,
                    Daughter8_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter8_FirstName,
                    Daughter8_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter8_LastName,
                    Daughter9_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter9_FirstName,
                    Daughter9_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Daughter9_LastName,
                    Son10_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son10_FirstName,
                    Son10_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son10_LastName,
                    Son1_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son1_FirstName,
                    Son1_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son1_LastName,

                       Son2_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son2_FirstName,
                    Son2_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son2_LastName,
                    Son3_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son3_FirstName,
                    Son3_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son3_LastName,
                    Son4_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son4_FirstName,
                    Son4_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son4_LastName,
                    Son5_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son5_FirstName,
                    Son5_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son5_LastName,
                    Son6_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son6_FirstName,
                    Son6_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son6_LastName,
                    Son7_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son7_FirstName,
                    Son7_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son7_LastName,

                        Son8_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son8_FirstName,
                    Son8_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son8_LastName,
                    Son9_FirstName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son9_FirstName,
                    Son9_LastName=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.Son9_LastName,
                    MyParentPosition=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.MyParentPosition,
                    MyPosition=UserInfoTabbedPageViewModel.Instance.UserChildrenViewTab.MyPosition

                }
            };


            //var Form1 = UserInfoTabbedPageViewModel.Instance.UserViewTab;
            //// BindingContext context = new BindingContext();
            // DTOFamilyTreeMaster dtoOj = new DTOFamilyTreeMaster();
            // dtoOj.Title = Title;
            // dtoOj.FirstName=firs
            //Sample post to a restful api url, remember to use the namespace System.Net.Http for HttpClient()


            //var myHttpClient = new HttpClient();
            //var uri = new Uri("https://jsonplaceholder.typicode.com/posts");

            ////Since this sample restful api url accepts any json structure, we can structure the data like this
            //var formContent = new FormUrlEncodedContent(new Dictionary<string, string>
            //{
            //    { "jobNum", "000" },
            //    { "qty", "12" },
            //    { "barcode", "577" }
            //});

            //var response = myHttpClient.PostAsync(uri.ToString(), formContent).Result;

            //if (response.IsSuccessStatusCode)
            //    DisplayAlert("Success", "You posted data to a REST API URL.", "Ok");
            //else
            //    DisplayAlert("Error", "An error has occured and no data was posted.", "Ok");

        }

    }
    }