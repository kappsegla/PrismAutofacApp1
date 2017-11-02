using Autofac;
using Prism.Autofac;
using PrismAutofacApp1.Views;
using System.Windows;
using Prism.Modularity;

namespace PrismAutofacApp1
{
    class Bootstrapper : AutofacBootstrapper
    {
        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new DirectoryModuleCatalog() { ModulePath = @".\Modules" };
        }
      

        protected override void ConfigureContainerBuilder(ContainerBuilder builder)
        {
            base.ConfigureContainerBuilder(builder);

            builder.RegisterTypeForNavigation<ViewA>("ViewA");
        }

        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
