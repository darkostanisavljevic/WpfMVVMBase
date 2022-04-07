using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMBase.Models;

namespace WpfMVVMBase.ViewModels
{
    class GuestbookViewModel : ObservableObject
    {
        #region Public properties
        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        public ObservableCollection<Guest> Guests { get; }

        #endregion

        #region Constructor
        public GuestbookViewModel()
        {

            AddGuestCommand = new AsyncRelayCommand(OnAddGuestClicked_Execute, OnAddGuestClicked_CanExecute);
        }

        #endregion

        #region Commands
        public IAsyncRelayCommand AddGuestCommand { get; }
        #endregion


        #region Private methods
        private bool OnAddGuestClicked_CanExecute()
        {
            //TODO
            return true;
        }

        private async Task OnAddGuestClicked_Execute()
        {
            //TODO          
        }
        #endregion

    }
}
