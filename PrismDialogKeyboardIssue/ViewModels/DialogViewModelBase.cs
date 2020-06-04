using System;
using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Services.Dialogs;

namespace PrismDialogKeyboardIssue.ViewModels
{
    public abstract class DialogViewModelBase : BindableBase, IDialogAware, IAutoInitialize
    {
        private bool _isBusy;

        protected DialogViewModelBase()
        {
            CloseCommand = new DelegateCommand(() => RequestClose?.Invoke(Parameters));
        }

        public event Action<IDialogParameters> RequestClose;

        public DelegateCommand CloseCommand { get; }

        public IDialogParameters Parameters { get; protected set; }

        public bool IsBusy
        {
            get => _isBusy;
            set => SetProperty(ref _isBusy, value);
        }

        public virtual bool CanCloseDialog()
        {
            return true;
        }

        public virtual void OnDialogClosed()
        {
        }

        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            Parameters = parameters;
        }
    }
}