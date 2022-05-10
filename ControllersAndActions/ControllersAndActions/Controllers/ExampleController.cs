using System;
using System.Web.Mvc;
namespace ControllersAndActions.Controllers
{
    public class ExampleController : Controller
    {
        public ViewResult Index()
        {
            ViewBag.Message = TempData["Message"];
            ViewBag.Date = TempData["Date"];
            return View();
        }
        public RedirectResult Redirect()
        {
            return Redirect("/Basic/Index");
        }
        public RedirectToRouteResult RedirectRoute()
        {
            TempData["Message"] = "Привет";
            TempData["Date"] = DateTime.Now;
            return RedirectToAction("Index");
        }
        public HttpStatusCodeResult StatusCode()
        {
            return new HttpUnauthorizedResult();
        }
    }
}