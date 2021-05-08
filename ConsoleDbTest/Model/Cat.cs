using ConsoleDbTest.CustomException;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.Model
{
    public class Cat
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value > 20)
                    throw new CatAgeException("Cat age cannot be larger than 20");
                else age = value;
            }
        }

    }
}
