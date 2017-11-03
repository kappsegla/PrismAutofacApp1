using Module2.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Module2
{
    public class Module2Module : IModule
    {
        IRegionManager _regionManager;

        public Module2Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("Navigation", typeof(Module2View));
        }
    }
}