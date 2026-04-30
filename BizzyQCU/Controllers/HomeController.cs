using System.Web.Mvc;

namespace BizzyQCU.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult RegisterStudent()
        {
            return View();
        }

        public ActionResult RegisterEnterprise()
        {
            return View();
        }
    }
}