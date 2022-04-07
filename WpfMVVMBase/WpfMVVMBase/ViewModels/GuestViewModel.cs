using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMBase.ViewModels
{
    public class GuestViewModel : ObservableObject
    {

        #region Constructor
        public GuestViewModel()
        {
            CancelCommand = new AsyncRelayCommand(OnCancelClicked_Execute, OnCancelClicked_CanExecute);
            SaveCommand = new AsyncRelayCommand(OnSaveClicked_Execute, OnSaveClicked_CanExecute);
        }
        #endregion

        #region Public properties

        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private string surname;

        public string Surname
        {
            get => surname;
            set => SetProperty(ref surname, value);
        }

        private string age;

        public string Age
        {
            get => age;
            set => SetProperty(ref age, value);
        }

        #endregion

        #region Commands

        public IAsyncRelayCommand CancelCommand { get; }

        public IAsyncRelayCommand SaveCommand { get; }

        #endregion

        #region Private methods

        private async Task OnCancelClicked_Execute()
        {
            // TODO...
        }

        private bool OnCancelClicked_CanExecute()
        {
            // TODO...
            return true;
        }

        private async Task OnSaveClicked_Execute()
        {
            // TODO...
        }

        private bool OnSaveClicked_CanExecute()
        {
            // TODO...
            return true;
        }

        #endregion
    }
}
