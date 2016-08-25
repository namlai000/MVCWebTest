using MVCWebTest.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebTest.Models.Services
{
    //public partial interface IEmployeeService
    //{
    //    IEnumerable<Employee> GetAll();
    //    Employee GetById(int id);
    //    bool editEmployee(string FullName);
    //}

    public partial class EmployeeService
    {
        EmployeeDBEntities entity = new EmployeeDBEntities();

        public List<Employee> GetAll()
        {
            var employee = entity.Employees.ToList();
            return employee;
        }

        public Employee GetById(int id)
        {
            var employee = entity.Employees.FirstOrDefault(x => x.ID == id);
            return employee;
        }

        public bool editEmployee(int id, string name)
        {
            var employee = entity.Employees.FirstOrDefault(x => x.ID == id);
            employee.FullName = name;
            entity.SaveChanges();
            return true;
        }
    }
}