using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.CustomException
{
    public class CatAgeException : Exception
    {
 
        public CatAgeException() :base(){ }
        public CatAgeException(string message) : base(message) { }
        public CatAgeException(string message, Exception inner) : base(message, inner) { }
    }

}
