using Autofac;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using System;
using PrismAutofacApp1.Views;

namespace PrismAutofacApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IContainer _container;
        IRegionManager _regionManager;

        private string _title = "Prism Autofac Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
            ButtonCommand = new DelegateCommand(OnButtonExecute, OnButtonCanExecute);
            
            //Discover
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        private void OnButtonExecute()
        {
            //Add view with code
                //var view = _container.Resolve<ViewA>();
                //IRegion region = _regionManager.Regions["ContentRegion"];
                //region.Add(view);
        
            _regionManager.RequestNavigate("ContentRegion", "ViewA");
        }

        private bool OnButtonCanExecute()
        {
            return true;
        }

        public ICommand ButtonCommand { get; }
    }
}
