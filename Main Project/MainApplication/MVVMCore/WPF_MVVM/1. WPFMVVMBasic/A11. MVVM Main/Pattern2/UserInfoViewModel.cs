using MVVMCore.Model;
using MVVMCore.MVVMCommads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMCore.ViewModel
{
    public class UserInfoViewModel
    {
        private List<UserInfoModel> _UsersList;

        private ICommand mUpdater;

        public ICommand UpdateCommand
        {
            get
            {
                return mUpdater;
            }
            set { mUpdater = value; }
        }

        public UserInfoViewModel(UserInfoModel userInfoModel)
        {
            _UsersList = new List<UserInfoModel>
            {
                new UserInfoModel{UserId=1,FirstName="Raj",LastName="Beniwal",City="Delhi",State="DEL",Country="INDIA"},
                new UserInfoModel{UserId=2,FirstName="Mark",LastName="henry",City="New York", State="NY", Country="USA"},
                new UserInfoModel{UserId=3,FirstName="Mahesh",LastName="Chand",City="Philadelphia", State="PHL", Country="USA"},
                new UserInfoModel{UserId=4,FirstName="Vikash",LastName="Nanda",City="Noida", State="UP", Country="INDIA"},
                new UserInfoModel{UserId=5,FirstName="Harsh",LastName="Kumar",City="Ghaziabad", State="UP", Country="INDIA"},
                new UserInfoModel{UserId=6,FirstName="Reetesh",LastName="Tomar",City="Mumbai", State="MP", Country="INDIA"},
                new UserInfoModel{UserId=7,FirstName="Deven",LastName="Verma",City="Palwal", State="HP", Country="INDIA"},
                new UserInfoModel{UserId=8,FirstName="Ravi",LastName="Taneja",City="Delhi", State="DEL", Country="INDIA"}
            };
            
        }

        public List<UserInfoModel> Users
        {
            get { return _UsersList; }
            set { _UsersList = value; }
        }

        private bool canExecuteMethod(object parameter)
        {
            return true;
        }

        private void ExecuteMethod(object parameter)
        {
            UpdateCommand = new MVVMCommand(ExecuteMethod, canExecuteMethod);
        }
    }
}
