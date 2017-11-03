using Autofac;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Input;
using System;
using PrismAutofacApp1.Views;
using Prism.Events;
using PrismAutofacApp1.Events;

namespace PrismAutofacApp1.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        IController _controller;
        IContainer _container;
        IRegionManager _regionManager;
        private IEventAggregator _eventAggregator;
        private string _title = "Prism Autofac Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public MainWindowViewModel(IContainer container, IRegionManager regionManager, IEventAggregator eventAggregator, IController controller)
        {
            _container = container;
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
            _controller = controller;

            ButtonCommand = new DelegateCommand(OnButtonExecute, OnButtonCanExecute);
            
            //Discover
            //regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        private void OnButtonExecute()
        {
            _eventAggregator.GetEvent<ShowNewWindowEvent>().Publish("Payload string");
            
            //_regionManager.RequestNavigate("ContentRegion", "ViewA");
        }

        private bool OnButtonCanExecute()
        {
            return true;
        }

        public ICommand ButtonCommand { get; }
    }
}
