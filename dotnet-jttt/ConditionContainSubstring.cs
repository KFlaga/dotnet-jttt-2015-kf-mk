using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet_jttt
{
    class ConditionContainSubstring : ICondition
    {
        string textToCheck;
        string key;

        public ConditionContainSubstring(string key, string text)
        {
            textToCheck = text;
            this.key = key;
        }

        public bool Check()
        {
            if (textToCheck.Contains(key))
                return true;
            return false;
        }
    }
}
