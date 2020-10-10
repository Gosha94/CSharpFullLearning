using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Func
{
    class FuncDelegate
    {
        // Тип делегата, возвращающий значение,
        // и принимающий до 16 параметров
        // Виды создания переменных под делегат-функцию
        public delegate int Func(int value);
        // Аналогично
        private readonly Func<int, int> func;        
    }
}
