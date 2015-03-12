using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    public interface ICondition
    {
        bool Check();
        void SetParams(object arg1, object arg2);
    }
}
