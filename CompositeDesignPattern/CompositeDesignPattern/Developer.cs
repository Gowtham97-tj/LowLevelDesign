using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class Developer : IEmployee
    {
        private String name;
        private long empId;
        private String position;

        public Developer(long empId, String name, String position)
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
