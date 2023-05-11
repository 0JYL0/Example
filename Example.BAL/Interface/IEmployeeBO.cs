using Example.DL;

namespace Example.BAL.Interface
{
    public interface IEmployeeBO
    {
        List<Employee> GetEmployees();
        Employee GetEmployeeDetails(int id);
        int InsertEmployee(Employee employee);
        int UpdateEmployee(Employee employee);
        int DeleteEmployee(Employee employee);
    }
}
