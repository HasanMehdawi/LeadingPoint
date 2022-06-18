using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public interface IEmployeeService
    {
        List<Employee> loadEmployee(int project_Id);
        void insert(Employee employee);
        Employee LoadById(int id);
        void Delete(int id);
        void Edit(Employee employee);
    }
}
