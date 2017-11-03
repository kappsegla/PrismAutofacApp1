using Prism.Events;
using PrismAutofacApp1.Events;
using PrismAutofacApp1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrismAutofacApp1
{
    public class Controller : IController
    {
        public Controller(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<ShowNewWindowEvent>().Subscribe(ShowNewWindow);

        }

        public void ShowNewWindow(string payload)
        {
            new Window1().Show();
        }
    }
}
