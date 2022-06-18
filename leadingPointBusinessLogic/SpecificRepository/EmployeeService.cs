using leadingPointDataAccess.generic;
using leadingPointDataClass.Context;
using leadingPointDataClass.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public class EmployeeService : IEmployeeService
    {
        Igeneric<Employee> generic;
        LeadingPointContext context;
        public EmployeeService(Igeneric<Employee> _generic, LeadingPointContext _context)
        {
            generic = _generic;
            context = _context;
        }

        public List<Employee> loadEmployee(int project_Id)
        {
            return context.employees.Include("Position").Where(e => e.Project_Id == project_Id).ToList();
        }
        public void insert(Employee employee)
        {
            generic.Insert(employee);
        }
        public Employee LoadById(int id)
        {
            return generic.Load(id);
        }
        public void Delete(int id)
        {
            generic.delete(id);
        }
        public void Edit(Employee employee)
        {
            generic.update(employee);
        }
       

            
        }
    

}