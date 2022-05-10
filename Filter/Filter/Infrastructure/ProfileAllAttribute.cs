using System.Diagnostics;
using System.Web.Mvc;
namespace Filter.Infrastructure
{
    public class ProfileAllAttribute : ActionFilterAttribute
    {
        private Stopwatch timer;

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            timer = Stopwatch.StartNew();
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            timer.Stop();
            filterContext.HttpContext.Response.Write(
                    string.Format("<div>Общее время: {0:F6}</div>",
                        timer.Elapsed.TotalSeconds));
        }
    }
}