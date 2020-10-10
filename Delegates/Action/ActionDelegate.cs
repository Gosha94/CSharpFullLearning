using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Action
{
    class ActionDelegate
    {
        // Тип делегата void типа, без возвращаемого значения
        // имеет только входные параметры 17 шт
        public delegate int Action(string b);
        Action<string> action;
    }
}
