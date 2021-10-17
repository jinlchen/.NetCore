using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement3.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
     
        private List<Employee> _EmployeeList;
        public MockEmployeeRepository()
        {
            _EmployeeList = new List<Employee>() {
                new Employee(){Id = 1, Name = "James", Email = "J@hotmail.com" },
                new Employee() { Id = 2, Name = "Deng", Email = "d@hotmail.com" }
           };
        }
        public Employee GetEmployee(int id)
        {
            return _EmployeeList.FirstOrDefault(e => e.Id == id);
        }
        public List<Employee> getList()
        {
            return _EmployeeList;
        }
        public Employee create(Employee e)
        {
            e.Id = _EmployeeList.Max(a => a.Id) + 1;
            _EmployeeList.Add(e);
            return e;
        }
    }
}
