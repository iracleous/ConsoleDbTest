using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.Model
{
    public class GenericStack<T>
    {
        private int index = 0;
        private readonly T[] stack = new T[10];

        //check it
        public void Push(T item) => stack[index++] = item; 
        public T Pop() => stack[--index];
    }

}
