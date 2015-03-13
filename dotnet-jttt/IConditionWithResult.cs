using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    // Interfejs dla klasy, która zwraca jakiś obiekt gdy warunek jest spełniony
    // Oprócz sprawdzenia warunku klasa ta będzie musiała wykonać inne czynności
    interface IConditionWithResult // trochę kiepska nazwa, ale nie mam pomyslu jak nazwac
    {
        void CheckCondition(string arg1, string arg2);
        object GetResult();
    }
}
