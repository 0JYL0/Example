using Example.BAL.Interface;
using Example.DL;
using Microsoft.AspNetCore.Mvc;

namespace Example.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBO employeeBo;
        public EmployeeController(IEmployeeBO employeeBo)
        {
            this.employeeBo = employeeBo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var employees = employeeBo.GetEmployees();
            return Ok(employees);
        }
        [HttpPost]
        public IActionResult Insert(Employee employee)
        {
            var employees = employeeBo.InsertEmployee(employee);
            return Ok(employees);
        }
        [HttpDelete]
        public IActionResult Delete(Employee employee)
        {
            var employees = employeeBo.DeleteEmployee(employee);
            return Ok(employees);
        }
    }
}
