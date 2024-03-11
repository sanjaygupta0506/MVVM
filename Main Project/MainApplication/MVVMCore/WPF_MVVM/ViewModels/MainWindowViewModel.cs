using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCore.DataGridSingleClickCheckbox.ViewModels
{
  public class MainWindowViewModel : BindableBase
  {
    private string _title = "DataGrid with single click checkbox";
    public string Title
    {
      get { return "Mr"; }
      //set { SetProperty(ref _title, value); }
    }

    private ObservableCollection<PersonModel> _myCollection;
    public ObservableCollection<PersonModel> MyCollection
    {
      get { return _myCollection ?? (_myCollection = new ObservableCollection<PersonModel>()); }
      //set { SetProperty(ref _myCollection, value); }
    }

    public MainWindowViewModel()
    {
      var person1 = new PersonModel { IsSelected = true, FirstName = "Elon", LastName = "Musk" };
      var person2 = new PersonModel { IsSelected = true, FirstName = "Jeff", LastName = "Bezo" };

      MyCollection.Add(person1);
      MyCollection.Add(person2);
    }
  }
}
