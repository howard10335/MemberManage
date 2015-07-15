using System.Web.Mvc;

namespace MemberManage.Controllers
{
    public class SilverlightController : Controller
    {
        public ActionResult Login()
        {
            ViewData["Parameters"] = "PageName=" + "Login";
            return View();
        }

        public ActionResult ShowMembers()
        {
            ViewData["Parameters"] = "PageName=" + "ShowMember";
            return View();
        }

        public ActionResult Register()
        {
            ViewData["Parameters"] = "PageName=" + "Register";
            return View();
        }

    }
}
