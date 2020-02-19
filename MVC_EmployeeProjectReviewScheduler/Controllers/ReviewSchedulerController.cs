using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EmployeeRepositary;
using EmployeeEntity;
using System.Web.Mvc;

namespace MVC_EmployeeProjectReviewScheduler.Controllers
{
    public class ReviewSchedulerController : Controller
    {
        Repositary repositary = new Repositary();
        // GET: ReviewSchedulerController
        public ActionResult Index()
        {
            IEnumerable<Employee> employees = Repositary.GetEmployee();
            ViewData["Employees"] = employees;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        { 
            repositary.Add(employee);
            Response.Write("Registered Successfully");
            return View();
        }
    }
}