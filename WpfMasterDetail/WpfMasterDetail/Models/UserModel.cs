using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace WpfMasterDetail.Models
{
    public class UserModel : ObservableObject
    {
        private int _id;
        private string _login;
        private string _name;
        private DateTime _entryDate;
        private int _roleId;
        private int _languageId;
        private RoleModel _role;
        private LanguageModel _language;

        public int Id
        {
            get => _id;
            set => Set(ref _id, value);
        }

        public string Login
        {
            get => _login;
            set => Set(ref _login, value);
        }

        public string Name
        {
            get => _name;
            set => Set(ref _name, value);
        }

        public DateTime EntryDate
        {
            get => _entryDate;
            set => Set(ref _entryDate, value);
        }

        public int RoleId
        {
            get => _roleId;
            set => Set(ref _roleId, value);
        }

        public int LanguageId
        {
            get => _languageId;
            set => Set(ref _languageId, value);
        }

        public RoleModel Role
        {
            get => _role;
            set => Set(ref _role, value);
        }

        public LanguageModel Language
        {
            get => _language;
            set => Set(ref _language, value);
        }

        public UserModel()
        {
            EntryDate = DateTime.Now.Date;
        }
    }
}
