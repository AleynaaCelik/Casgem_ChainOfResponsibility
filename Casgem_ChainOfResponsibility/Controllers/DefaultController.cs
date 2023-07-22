using Casgem_ChainOfResponsibility.ChainResponsibilityPattern;
using Casgem_ChainOfResponsibility.Models;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_ChainOfResponsibility.Controllers
{
    public class DefaultController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(CustomerViewModel model)
        {
            Employee treasurer = new Treasurer();
            Employee managerAssistant = new ManagerAssistant();
            Employee manager = new Manager();
            Employee areaDirector=new AreaDirector();

            treasurer.SetNextApprover(managerAssistant);
            manager.SetNextApprover(manager);
            manager.SetNextApprover(areaDirector);

            treasurer.ProcessRequest(model);

            return View();
        }
    }
}
