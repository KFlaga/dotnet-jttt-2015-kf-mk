using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    // Interfejs dla klas wykonująch akcję gdy zadany warunek jest spełniony
    interface IAction
    {
        void DoAction(string arg1, object arg2);
    }
}
