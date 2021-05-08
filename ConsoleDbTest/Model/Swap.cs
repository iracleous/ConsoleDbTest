using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.Model
{
    public class Swap<T>
    {
        public static void SwapNow(ref T original, ref T target)
        {
            T holder = original;
            original = target;
            target = holder;
        }
    }
}
