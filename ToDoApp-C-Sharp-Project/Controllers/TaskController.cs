
using System.Web.Mvc;
using ToDoApp_C_Sharp_Project.Models;



namespace ToDoApp_C_Sharp_Project.Controllers
{
    public class TaskController : Controller
    {
        [HttpPost]
        public ActionResult Create(Task task)
        {
            if (task == null)
            {
                return RedirectToAction("Index", "Home");
            }
            using (var db = new TaskDbContext())
            {
                db.Tasks.Add(task);
                db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            using (var db = new TaskDbContext())
                {
                    var task = db.Tasks.Find(id);
                if (task == null)
                {
                    return RedirectToAction("Index", "Home");
                }

                db.Tasks.Remove(task);
                    db.SaveChanges();
            }
            return RedirectToAction("Index", "Home");
        }
    }
}