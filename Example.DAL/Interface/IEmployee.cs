using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Example.DAL;
using Example.DL;

namespace Example.DAL.Interface
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeDetails(int id);
        int InsertEmployee(Employee employee);
        int UpdateEmployee(Employee employee);  
        int DeleteEmployee(Employee employee);
    }
}
