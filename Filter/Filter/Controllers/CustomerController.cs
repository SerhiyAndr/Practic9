using System.Web.Mvc;
using Filter.Infrastructure;
namespace Filter.Controllers
{
    [SimpleMessage(Message = "A")]
    public class CustomerController : Controller
    {
    
        public string Index()
        {
            return "Это контроллер Customer";
        }
        [CustomOverrideActionFilters]
        [SimpleMessage(Message = "Б")]
        public string OtherMethod()
        {
            return "Это метод действия OtherMethod в контроллере Customer";
        }
    }
}