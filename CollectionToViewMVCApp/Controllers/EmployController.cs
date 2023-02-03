using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CollectionToViewMVCApp.Models;

namespace CollectionToViewMVCApp.Controllers
{
    public class EmployController : Controller
    {
        public IActionResult Index()
        {
            //Creating Objects for Employ Model Class
            Employ emp1 = new Employ();
            emp1.EmpId = 101;
            emp1.EName = "Rajashekar";
            emp1.Salary = 50213;

            Employ emp2 = new Employ();
            emp2.EmpId = 102;
            emp2.EName = "Maniii";
            emp2.Salary = 61798;

            Employ emp3 = new Employ();
            emp3.EmpId = 103;
            emp3.EName = "Ajay";
            emp3.Salary = 65000;

         /*   List<Employ> employees = new List<Employ>()
            {
                new Employ{EmpId=101,EName="Assaaam",Salary=2565 }
            };*/

            //Passing Objects to Collection

            List<Employ> employees = new List<Employ>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            return View(employees);
        }
    }
}
