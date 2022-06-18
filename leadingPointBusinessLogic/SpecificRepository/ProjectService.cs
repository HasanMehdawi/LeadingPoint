using leadingPointDataAccess.generic;
using leadingPointDataClass.Context;
using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leadingPointBusinessLogic.SpecificRepository
{
    public class ProjectService:IProjectService
    {
        Igeneric<Project> generic;
        public ProjectService(Igeneric<Project>_generic)
        {
            generic = _generic;
        }
        public List<Project> loadAll()
        {
           
           return generic.LoadAll().ToList();
        }
        public void insert(Project project)
        {
            
            generic.Insert(project);
        }
        public Project LoadById(int id)
        {
            return generic.Load(id);
        }
        public void update(Project project)
        {
            generic.update(project);
        }
    }
}
