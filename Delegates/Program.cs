using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegates.Func;

namespace Delegates
{
    class Program
    {
        // Стандартные делегаты
        public delegate void MyDelegate();

        public delegate int ValueDelegate(int inputValue);

        static void Main(string[] args)
        {
            //var valueDelegate = new ValueDelegate(MethodReturnedIntValue);            
            //valueDelegate.Invoke(5);                      
            //valueDelegate.Invoke(10);           
            //valueDelegate.Invoke(15);       
            //valueDelegate.Invoke(20);

            Func<int, int> func = MethodReturnedIntValue;
            func?.Invoke(6);            
            /* Аналогична методу Invoke() запись ниже
             if (func != null)
                func(6);
             */
            Console.ReadLine();
        }

        static int MethodReturnedIntValue(int inpVal)
        {
            Console.WriteLine(inpVal);
            return inpVal;
        }        

    }
}
