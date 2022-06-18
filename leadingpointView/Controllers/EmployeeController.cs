using leadingPointBusinessLogic.SpecificRepository;
using leadingPointDataAccess.generic;
using leadingPointDataClass.Entity;
using leadingpointView.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace leadingpointView.Controllers
{
    public class EmployeeController : Controller
    {
        IEmployeeService EService;
        IProjectService PService;
        ICityService CService;
        ICountryService countryService;
        ILookUpService LService;
        public EmployeeController(IEmployeeService _EService,IProjectService _PService, ICityService _CService, ICountryService _countryService,ILookUpService _LService)
        {
            EService = _EService;
            PService = _PService;
            CService = _CService;
            countryService = _countryService;
            LService = _LService;
        }
        public IActionResult Index(int project_id)
        {
            vmEmployeeProject vm = new vmEmployeeProject();

            vm.project=PService.LoadById(project_id);
            vm.liemployees=EService.loadEmployee(project_id);

            return View("ShowEmployee",vm);
        }
        public IActionResult NewEmployee(int project_Id)
        {
            ViewData["emp"] = "1";
            VMEmployee vm = new VMEmployee();
            vm.licountries = countryService.LoadCountry();
            vm.project=PService.LoadById(project_Id);
            vm.gender = LService.LoadGender();
            vm.pisition = LService.LoadPosition();
            return View("NewEmployee" ,vm);
        }
        public IActionResult AddEmployee(Employee employee)
        {
            ViewData["emp"] = "1";
            string name = Guid.NewGuid().ToString() + "." + employee.Image.FileName.Split(".")[1];
            string p = Path.Combine(Directory.GetCurrentDirectory(), "Images", name);
            employee.Image.CopyTo(new FileStream(p, FileMode.Create));
            employee.ImagePath= "http://localhost/leadingpointView/staticPath/" + name;
            EService.insert(employee);
            VMEmployee vm = new VMEmployee();
            vm.licountries = countryService.LoadCountry();
            vm.project = PService.LoadById(employee.Project_Id);
            vm.gender = LService.LoadGender();
            vm.pisition = LService.LoadPosition();
            return View("NewEmployee", vm);
        }
        public IActionResult EmployeeDetails(int id)
        {
            ViewData["emp"] = "0";
            VMEmployee vm = new VMEmployee();
            vm.employee = EService.LoadById(id);
            vm.project = PService.LoadById(vm.employee.Project_Id);
            vm.licountries = countryService.LoadCountry();
            vm.gender = LService.LoadGender();
            vm.pisition = LService.LoadPosition();
            return View("NewEmployee", vm);
        }
        public IActionResult delete(int id)
        {

            Employee emp = new Employee();
            emp = EService.LoadById(id);

            vmEmployeeProject vm = new vmEmployeeProject();
            vm.project = PService.LoadById(emp.Project_Id);
            EService.Delete(id);
            vm.liemployees = EService.loadEmployee(emp.Project_Id);
            
            
            return View("ShowEmployee", vm);
        }
        
        public IActionResult Edit(int id)
        {
            ViewData["emp"] = "2";
            VMEmployee vm = new VMEmployee();
            vm.employee= EService.LoadById(id);
            vm.project= PService.LoadById(vm.employee.Project_Id);
            vm.licountries = countryService.LoadCountry();
            vm.gender = LService.LoadGender();
            vm.pisition = LService.LoadPosition();
            return View("NewEmployee", vm);
        }
        public IActionResult Update(Employee employee)
        {
            
            if (employee.Image != null)
            {
                string name = Guid.NewGuid().ToString() + "." + employee.Image.FileName.Split(".")[1];
                string p = Path.Combine(Directory.GetCurrentDirectory(), "Images", name);
                employee.Image.CopyTo(new FileStream(p, FileMode.Create));
                employee.ImagePath = "http://localhost/leadingpointView/staticPath/" + name;

            }
            
            EService.Edit(employee);
            vmEmployeeProject vm = new vmEmployeeProject();
            vm.project = PService.LoadById(employee.Project_Id);
            vm.liemployees = EService.loadEmployee(employee.Project_Id);


            return View("ShowEmployee", vm);

        }
        public IActionResult LoadCity()
        {
            List<City> licity = new List<City>();
            licity = CService.LoadALl();
            return Json(licity);
        }
        public IActionResult LoadCityById(int Country_Id)
        {
            List<City> licity = new List<City>();
            licity = CService.LoadByCountryId(Country_Id);
            return Json(licity);
        }
        
    }
}
