using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public interface IProjectService
    {
        List<Project> loadAll();
       void insert(Project project);
        Project LoadById(int id);
        void update(Project project);
    }
}
