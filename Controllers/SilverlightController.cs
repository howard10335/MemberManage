using System.Web.Mvc;

namespace MemberManage.Controllers
{
    public class SilverlightController : Controller
    {
        //
        // GET: /Silverlight/

        public ActionResult LogOn()
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
