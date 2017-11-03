using Prism.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module1.ViewModels
{
    public class Module1ViewViewModel
    {
        public Module1ViewViewModel(IEventAggregator eventAggregator)
        {
            eventAggregator.GetEvent<MyEvent>().Subscribe((s) => {
                Console.WriteLine(s);
            });
        }
    }

    public class MyEvent : PubSubEvent<string>
    {

    }
}
