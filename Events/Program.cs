using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        public delegate void MyDelegate();
        public event MyDelegate Event;
        // Либо
        public event Action EventAction;

        static void Main(string[] args)
        {             
        
        }
    }
}
