using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDbTest.Model
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }


        public override string  ToString() 
        {
             return base.ToString() + $"   Id = {Id} Name= {Name} Designation= {Designation}";
        }
    }
}
