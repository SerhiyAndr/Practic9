using System.Diagnostics;
using System.Web.Mvc;
namespace Filter.Infrastructure
{
    public class ProfileActionAttribute : FilterAttribute, IActionFilter
    {
        private Stopwatch timer;

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            timer.Stop();
            if (filterContext.Exception == null)
            {
                filterContext.HttpContext.Response.Write(
                    string.Format("<div>Время работы метода действия: {0:F6}</div>",
                        timer.Elapsed.TotalSeconds));
            }
        }
    }
}