using System.Linq;
using GalaSoft.MvvmLight;
using WpfMasterDetail.Models;
using WpfMasterDetail.Services;

namespace WpfMasterDetail.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        public CommonService Cms { get; }

        private UserModel _selectedUser;
        private RoleModel _selectedRoleModel;
        private LanguageModel _selectedLanguageModel;

        public UserModel SelectedUser
        {
            get => _selectedUser;
            set
            {
                Set(ref _selectedUser, value);
                if (value != null)
                {
                    SelectedRoleModel = Cms.Roles.FirstOrDefault(x => x.Role == value.Role.Role);
                    SelectedLanguageModel = Cms.Languages.FirstOrDefault(x => x.Language == value.Language.Language);
                }
            }
        }

        public RoleModel SelectedRoleModel
        {
            get => _selectedRoleModel;
            set => Set(ref _selectedRoleModel, value);
        }

        public LanguageModel SelectedLanguageModel
        {
            get => _selectedLanguageModel;
            set => Set(ref _selectedLanguageModel, value);
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(CommonService cms)
        {
            Cms = cms;
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }
    }
}