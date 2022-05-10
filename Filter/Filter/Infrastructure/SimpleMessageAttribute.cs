using System;
using System.Web.Mvc;
namespace Filter.Infrastructure
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,
        AllowMultiple = true)]
    public class SimpleMessageAttribute : FilterAttribute, IActionFilter
    {
        public string Message { get; set; }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format("<div>[До действия: {0}]<div>", Message));
        }

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write(
                string.Format("<div>[После действия: {0}]<div>", Message));
        }
    }
}