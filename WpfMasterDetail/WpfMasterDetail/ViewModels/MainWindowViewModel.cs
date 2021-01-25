using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMasterDetail.AppCodes;
using WpfMasterDetail.Models;

namespace WpfMasterDetail.ViewModels
{
    public class MainWindowViewModel
        : ViewModelBase
    {
        private UserManager _userManager;
        private RoleManager _roleManager;
        private LanguageManager _languageManager;

        public ObservableCollection<RoleModel> Roles { get; set; }
        public ObservableCollection<LanguageModel> Languages { get; set; }
        public ObservableCollection<UserModel> Users { get; set; }

        private UserModel _selectedUser;
        public UserModel SelectedUser
        {
            get { return _selectedUser; }
            set
            {
                _selectedUser = value;
                OnPropertyChanged();
            }
        }


        public MainWindowViewModel(UserManager userManager, RoleManager roleManager, LanguageManager languageManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _languageManager = languageManager;

            
            
            
            _selectedUser = new UserModel();
        }
    }
}
