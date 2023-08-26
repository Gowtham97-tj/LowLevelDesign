using System;
using System.Collections.Generic;
using System.Text;

namespace CompositeDesignPattern
{
    public class CompanyDirectory : IEmployee
    {
        private List<IEmployee> employeeList = new List<IEmployee>();
        public void showEmployeeDetails()
        {
            foreach (IEmployee emp in employeeList)
            {   
                emp.showEmployeeDetails();
            }
        }

        public void addEmployee(IEmployee emp)
        {
            employeeList.Add(emp);
        }

        public void removeEmployee(IEmployee emp)
        {
            employeeList.Remove(emp);
        }
    }
}
