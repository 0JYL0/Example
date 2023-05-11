using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.BAL.Interface;
using Example.DAL;
using Example.DAL.Interface;
using Example.DL;

namespace Example.BAL.Implementation
{
    public class EmployeeBO : IEmployeeBO
    {
        private readonly IEmployee Iemployee;

        public EmployeeBO(IEmployee Iemployee)
        {
            this.Iemployee = Iemployee;
        }

        public int DeleteEmployee(Employee employee)
        {
            try
            {
               return Iemployee.DeleteEmployee(employee);
            }
            catch(Exception ex) 
            {
                throw ex;
            }
        }

        public Employee GetEmployeeDetails(int id)
        {
            try
            {
                return Iemployee.GetEmployeeDetails(id);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<Employee> GetEmployees()
        {
            try
            {
                return Iemployee.GetEmployees();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int InsertEmployee(Employee employee)
        {
            try
            {
                return Iemployee.InsertEmployee(employee);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public int UpdateEmployee(Employee employee)
        {
            try
            {
                return Iemployee.UpdateEmployee(employee);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
