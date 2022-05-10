using System.Web.Mvc;
using ControllerExtensibility.Models;
namespace ControllerExtensibility.Controllers
{
    [SessionState(System.Web.SessionState.SessionStateBehavior.Disabled)]
    public class FastController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "Fast ",
                ActionName = "Index"
            });
        }
    }
}