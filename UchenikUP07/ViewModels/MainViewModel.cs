using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace UchenikUP07.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        public Account Account { get; private set; }
        public ObservableCollection<ViewModelBase> ViewModelsCollection { get; private set; }

        private Page _currentPage;
        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                if (_currentPage != value)
                {
                    _currentPage = value;
                    PropertyChange("CurrentPage");
                }
            }
        }
        public ViewModelBase SelectedViewModel;
        public MainViewModel()
        {
            Account = AuthorizationViewModel.Account;
            ViewModelsCollection = new ObservableCollection<ViewModelBase>();
            ViewModelsCollection.Add(new AuthViewModel());
            if (Account.IdAccountType != 2)
                ViewModelsCollection.Add(new AuthViewModel());
            SelectedViewModel = ViewModelsCollection[0];
        }

    }

}
