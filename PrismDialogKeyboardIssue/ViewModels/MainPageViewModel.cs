using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Prism.Services.Dialogs;
using PrismDialogKeyboardIssue.Views;

namespace PrismDialogKeyboardIssue.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private readonly IDialogService _dialogService;

        public MainPageViewModel(INavigationService navigationService, IDialogService dialogService)
            : base(navigationService)
        {
            Title = "Main Page";
            _dialogService = dialogService;
        }

        public ICommand ShowDialogCommand => new DelegateCommand(ShowDialog);

        private void ShowDialog()
        {
            _dialogService.ShowDialog(nameof(DialogView), new DialogParameters(), DialogCallback);
        }

        private void DialogCallback(IDialogResult dialogResult)
        {

        }
    }
}
