using System.Windows;
using System.Windows.Input;
using TestCommand.Command;
using TestCommand.Core;

namespace TestCommand.ViewModel
{
    public class DashboardViewModel : BaseViewModel
    {
        private string _num;
        private string _name;
        private string _city;

        public string Num { get => _num; set => SetProperty(ref _num, value); }
        public string Name { get => _name; set => SetProperty(ref _name, value); }
        public string City { get => _city; set => SetProperty(ref _city, value); }

        public ICommand AddNewDepartmentCommand { get; private set; }
        public ICommand ShowMessageCommand { get; private set; }

        public DashboardViewModel() => 
            (AddNewDepartmentCommand, ShowMessageCommand) = (new RelayCommand(AddNewDepartment), new RelayCommand(ShowMessage));

        private void AddNewDepartment(object obj) => DbManager.AddDepartment(_num, _name, _city);

        private void ShowMessage(object obj) => MessageBox.Show("message");
    }
}
