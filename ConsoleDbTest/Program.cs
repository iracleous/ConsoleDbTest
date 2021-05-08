using ConsoleDbTest.Model;
using System;
using System.Collections.Generic;

namespace ConsoleDbTest
{
    public static class Program
    {
        public static void Main()
        {

            //Console.WriteLine("Hello World!");
            //try {
            //    var cat = new Cat { Age = 21 }; 
            //    Console.WriteLine(cat.Age);
            //}
            //catch(Exception exception)
            //{
            //    Console.WriteLine(exception.Message);
            //}

            //Employee employee = new();
            //Console.WriteLine(employee.ToString());



            //GenericStack<int> generic = new();
            //generic.Push(2);
            //generic.Push(1);
            //generic.Push(6);

            //Console.WriteLine(generic.Pop());
            //Console.WriteLine(generic.Pop());
            //Console.WriteLine(generic.Pop());




            int a = 3;
            int b = 6;
            int t;
            t = a; a = b; b = t;
            Console.WriteLine($"a={a} b={b}");


            Swap<int>.SwapNow(ref a, ref b);
            Console.WriteLine($"a={a} b={b}");



            List<Employee> employeeList = new();
             
            Employee[] employeeArray = new Employee[5] ;

            employeeArray[0] = new() { Id =1, Name = "Georgiou", Designation = "Jr" };


            Console.WriteLine(employeeList.Count);  //0
            Console.WriteLine(employeeArray.Length); //5

            Console.WriteLine("----------------------------");
            int[] ints = new int[10];
            Console.WriteLine(ints.Length);
        Console.WriteLine("----------------------------");
            foreach( var index in ints)
            {
                Console.WriteLine(index);
            }

        }
    }
}
