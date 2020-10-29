using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace FamilyTreeApp.ViewModels
{
    public class UserInfoTabbedPageViewModel 
    {
        private static UserInfoTabbedPageViewModel instance;
        //public ObservableCollection<UserInfoTabbedPageViewModel> Playlists { get; private set; } = new ObservableCollection<UserInfoTabbedPageViewModel>();
         
        public UserViewModel UserViewTab { set; get; }
        public UserSpouseViewModel UserSpouseViewTab { set; get; }
        public UserChildrenViewModel UserChildrenViewTab { set; get; }

        public UserInfoTabbedPageViewModel()
        {
            UserViewTab = new UserViewModel();
            UserSpouseViewTab = new UserSpouseViewModel();
            UserChildrenViewTab = new UserChildrenViewModel();
        }

        //public static ViewModels Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            instance = new ViewModels();


        //        }
        //        return instance;
        //    }

        //}


        public static UserInfoTabbedPageViewModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInfoTabbedPageViewModel();


                }
                return instance;
            }
        }
   

    }

    public class UserChildrenViewModel
    {
        public string Son1_FirstName { get; set; }
        public string Son1_LastName { get; set; }
        public string Son2_FirstName { get; set; }
        public string Son2_LastName { get; set; }
        public string Son3_FirstName { get; set; }
        public string Son3_LastName { get; set; }
        public string Son4_FirstName { get; set; }
        public string Son4_LastName { get; set; }
        public string Son5_FirstName { get; set; }
        public string Son5_LastName { get; set; }
        public string Son6_FirstName { get; set; }
        public string Son6_LastName { get; set; }
        public string Son7_FirstName { get; set; }
        public string Son7_LastName { get; set; }
        public string Son8_FirstName { get; set; }
        public string Son8_LastName { get; set; }
        public string Son9_FirstName { get; set; }
        public string Son9_LastName { get; set; }
        public string Son10_FirstName { get; set; }
        public string Son10_LastName { get; set; }
        public string Daughter1_FirstName { get; set; }
        public string Daughter1_LastName { get; set; }
        public string Daughter2_FirstName { get; set; }
        public string Daughter2_LastName { get; set; }
        public string Daughter3_FirstName { get; set; }
        public string Daughter3_LastName { get; set; }
        public string Daughter4_FirstName { get; set; }
        public string Daughter4_LastName { get; set; }
        public string Daughter5_FirstName { get; set; }
        public string Daughter5_LastName { get; set; }
        public string Daughter6_FirstName { get; set; }
        public string Daughter6_LastName { get; set; }
        public string Daughter7_FirstName { get; set; }
        public string Daughter7_LastName { get; set; }
        public string Daughter8_FirstName { get; set; }
        public string Daughter8_LastName { get; set; }
        public string Daughter9_FirstName { get; set; }
        public string Daughter9_LastName { get; set; }
        public string Daughter10_FirstName { get; set; }
        public string Daughter10_LastName { get; set; }
        public Nullable<int> MyPosition { get; set; }
        public Nullable<int> MyParentPosition { get; set; }

    }

    public class UserSpouseViewModel
    {
        public string FatherFirstName { get; set; }
        public string FatherLastName { get; set; }
        public string MotherFirstName { get; set; }
        public string MotherLastName { get; set; }
        public string Spouse1_FirstName { get; set; }
        public string Spouse1_LastName { get; set; }
        public string Spouse2_FirstName { get; set; }
        public string Spouse2_LastName { get; set; }
        public string Spouse3_FirstName { get; set; }
        public string Spouse3_LastName { get; set; }
        public string Spouse4_FirstName { get; set; }
        public string Spouse4_LastName { get; set; }
        public string Spouse5_FirstName { get; set; }
        public string Spouse5_LastName { get; set; }

    }

    public class UserViewModel 
    {
     
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Nullable<int> Age { get; set; }
        public string Profession { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }


    }

}

