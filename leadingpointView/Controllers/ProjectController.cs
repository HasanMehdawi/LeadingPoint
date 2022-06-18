using leadingPointBusinessLogic.SpecificRepository;
using leadingPointDataClass.Entity;
using leadingpointView.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leadingpointView.Controllers
{
    public class ProjectController : Controller
    {
        IProjectService PService;
        public ProjectController(IProjectService _PService)
        {
            PService = _PService;
        }
        public IActionResult Index()
        {
            Vmproject vm = new Vmproject();
            vm.Liproject = PService.loadAll();
            return View("project",vm);
        }
        public IActionResult save(Project project)
        {
            PService.insert(project);
            Vmproject vm = new Vmproject();
            vm.Liproject = PService.loadAll();
            return View("project", vm);

        }
        public IActionResult Edit(int id)
        {
            Project project = new Project();
            project= PService.LoadById(id);
            return Json(project);
           
        }
        public IActionResult update(Project project)
        {
            PService.update(project);
            Vmproject vm = new Vmproject();
            vm.Liproject = PService.loadAll();
            return View("project", vm);
        }
    }
}
