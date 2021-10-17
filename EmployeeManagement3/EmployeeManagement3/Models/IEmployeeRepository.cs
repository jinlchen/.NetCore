using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement3.Models
{
    public interface IEmployeeRepository
    {
        Employee GetEmployee(int id);
        List<Employee> getList();
        Employee create(Employee e);
    }
}
