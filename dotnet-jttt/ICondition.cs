using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    // Interfejs dla klasy sprawdzającej warunek ( na max 2 argumentach )
    public interface ICondition 
    {
        bool Check();
        void SetParams(object arg1, object arg2);
    }
}
