using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ToDoApp_C_Sharp_Project.Models;

namespace ToDoApp_C_Sharp_Project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
           
            using (var db = new TaskDbContext())
            {
                var tasks = db.Tasks.ToList();
                return View(tasks);
            }
        }
    }
}