using Module1.Views;
using Prism.Modularity;
using Prism.Regions;
using System;

namespace Module1
{
    public class Module1Module : IModule
    {
        IRegionManager _regionManager;

        public Module1Module(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion("Navigation", typeof(Module1View));
        }
    }
}