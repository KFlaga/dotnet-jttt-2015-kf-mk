using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    interface IConditionWithResult // trochę kiepska nazwa, ale nie mam pomyslu jak nazwac
    {
        //ICondition Condition;
        void CheckCondition(string arg1, string arg2);
        object GetResult();
    }
}
