using Example.DAL.Interface;
using Example.DL;

namespace Example.DAL.Implementation
{
    public class EmployeeRepo : IEmployee
    {
        private CompanyDbContext db;

        public EmployeeRepo(CompanyDbContext db)
        {
            this.db = db;
        }
        public int DeleteEmployee(Employee employee)
        {
            var employeeDetails = db.Employees.Find(employee.EmployeeId);
            db.Employees.Remove(employeeDetails);
            db.SaveChanges();
            return 1; 
        }

        public Employee GetEmployeeDetails(int id)
        {
            return db.Employees.Find(id);
        }

        public List<Employee> GetEmployees()
        {
            return db.Employees.ToList();
        }

        public int InsertEmployee(Employee employee)
        {
            db.Employees.Add(employee); 
            db.SaveChanges(); 
            return 1;
        }

        public int UpdateEmployee(Employee employee)
        {
            db.Employees.Attach(employee);
            db.SaveChanges();
            return 1;
        }
    }
}
