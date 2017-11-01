using Autofac;
using Prism.Autofac;
using PrismAutofacApp1.Views;
using System.Windows;

namespace PrismAutofacApp1
{
    class Bootstrapper : AutofacBootstrapper
    {
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
