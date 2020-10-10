using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Classes
{
    class Person
    {
        public event Action GoToAnywhere;

        public void TakeTime(DateTime now)
        {
            if(now.Hour <= 8)
            {
                GoToAnywhere?.Invoke();
            }
        }
    }
}
