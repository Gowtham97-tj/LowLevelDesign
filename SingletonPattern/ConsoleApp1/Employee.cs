using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public sealed class Employee
    {
        private static int counter = 0;
        private static readonly object obj = new object();
        //public static Employee instance = null;

        //public static Employee GetInstance
        //{
        //    get
        //    {
        //        if (instance == null)
        //        {
        //            lock (obj)
        //            {
        //                if (instance == null)
        //                    instance = new Employee();
        //            }
        //        }
        //        return instance;
        //    }

        //Eager loading
        //public static readonly Employee instance = new Employee();
        //public static Employee GetInstance
        //{
        //    get
        //    {
        //        return instance;
        //    }
        //}

        //Lazy loading
        public static readonly Lazy<Employee> instance = new Lazy<Employee>(()=>new Employee());
        public static Employee GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        private Employee()
        {
            counter++;
            Console.WriteLine("counter value " + counter.ToString());
        }


        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }

    }
}
