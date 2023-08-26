using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class Manager : IEmployee
    {
        private string name;
        private long empId;
        private String position;

        public Manager(long empId, String name, String position)
        {
            this.empId = empId;
            this.name = name;
            this.position = position;
        }

        public void showEmployeeDetails()
        {
            Console.WriteLine(empId + " " + name);
        }
    }
}
