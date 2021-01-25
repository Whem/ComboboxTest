using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using WpfMasterDetail.Models;

namespace WpfMasterDetail.Services
{
    public class CommonService : ObservableObject
    {
        private ObservableCollection<UserModel> _users;
        private ObservableCollection<RoleModel> _roles;
        private ObservableCollection<LanguageModel> _languages;

        public ObservableCollection<UserModel> Users
        {
            get => _users;
            set => Set(ref _users, value);
        }


        public ObservableCollection<RoleModel> Roles
        {
            get => _roles;
            set => Set(ref _roles, value);
        }

        public ObservableCollection<LanguageModel> Languages
        {
            get => _languages;
            set => Set(ref _languages, value);
        }

        public CommonService()
        {
            Users = new ObservableCollection<UserModel>();
            Users.Add(new UserModel()
            {
                Id = 1,
                Name = "User 1",
                Login = "USER1",
                EntryDate = new DateTime(2021, 1, 1),
                RoleId = 1,
                Role = new RoleModel() { Id = 1, Role = "Admin" },
                LanguageId = 1,
                Language = new LanguageModel() { Id = 1, Language = "Hungarian" }
            });
            Users.Add(new UserModel()
            {
                Id = 2,
                Name = "User 2",
                Login = "USER2",
                EntryDate = new DateTime(2020, 1, 1),
                RoleId = 1,
                Role = new RoleModel() { Id = 1, Role = "Admin" },
                LanguageId = 2,
                Language = new LanguageModel() { Id = 2, Language = "English" }
            });
            Users.Add(new UserModel()
            {
                Id = 3,
                Name = "User 3",
                Login = "USER3",
                EntryDate = new DateTime(2019, 1, 1),
                RoleId = 3,
                Role = new RoleModel() { Id = 3, Role = "User" },
                LanguageId = 2,
                Language = new LanguageModel() { Id = 1, Language = "Hungarian" }
            });

            Roles = new ObservableCollection<RoleModel>();
            Roles.Add(new RoleModel() { Id = 1, Role = "Admin" });
            Roles.Add(new RoleModel() { Id = 2, Role = "Key user" });
            Roles.Add(new RoleModel() { Id = 3, Role = "User" });


            Languages = new ObservableCollection<LanguageModel>();
            Languages.Add(new LanguageModel() { Id = 1, Language = "Hungarian" });
            Languages.Add(new LanguageModel() { Id = 2, Language = "English" });
        }

    }
}
