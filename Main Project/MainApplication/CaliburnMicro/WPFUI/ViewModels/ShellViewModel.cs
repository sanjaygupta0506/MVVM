using Caliburn.Micro;
using WPFUI.Models;

namespace WPFUI.ViewModels
{
    public class ShellViewModel : Conductor<object>
    {
        #region Private Member

        private string _firstName = "Sanjay";
        private string _lastName;
        private PersonModel personModel;
        private BindableCollection<PersonModel> _people = new BindableCollection<PersonModel>();

        #endregion

        #region Constructor

        public ShellViewModel()
        {
            People.Add(new PersonModel { FirstName = "Sanjay", LastName = "Gupta" });
            People.Add(new PersonModel { FirstName = "Shanker", LastName = "Das" });
            People.Add(new PersonModel { FirstName = "Anuj", LastName = "Jain" });
        }

        #endregion

        #region Property
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                NotifyOfPropertyChange(() => FirstName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearText);
            }
        }
        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                NotifyOfPropertyChange(() => LastName);
                NotifyOfPropertyChange(() => FullName);
                NotifyOfPropertyChange(() => CanClearText);

            }
        }
        public string FullName
        {
            get 
            { 
                return $"{ FirstName } { LastName }"; 
            }
        }
        public BindableCollection<PersonModel> People
        {
            get
            {
                return _people;
            }
            set
            {
                _people = value;
                NotifyOfPropertyChange(() => People);
            }
        }
        //public PersonModel SelectedPerson
        //{
        //    get
        //    {
        //        return personModel;
        //    }
        //    set
        //    {
        //        personModel = value;
        //        NotifyOfPropertyChange(() => SelectedPerson);
        //    }
        //}
        public bool CanClearText
        {
            get
            {
                if (string.IsNullOrWhiteSpace(FirstName) && string.IsNullOrWhiteSpace(LastName))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        #endregion

        #region Public Method
        public void ClearText()
        {
            FirstName = "";
            LastName = "";
        }
        public void LoadPageOne()
        {
            ActivateItemAsync(new FirstChildViewModel());
        }
        public void LoadPageTwo()
        {
            ActivateItemAsync(new SecondChildViewModel());
        }

        #endregion

    }
}
