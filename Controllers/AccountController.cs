using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MemberManage.Models;
using System.Web.Routing;

namespace MemberManage.Controllers
{
    public class AccountController : Controller
    {

        public IFormsAuthenticationService FormsService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            base.Initialize(requestContext);
        }
        //
        // GET: /Account/

        #region 註冊

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateMember(MemberForm member)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Register","Account");
            }
            MemberManageEntities db = new MemberManageEntities();

            db.AddToMember(new Member()
            {
                Account = member.Account,
                Password = member.Password,
                ChName = member.ChName,
                NickName = member.NickName,
                Email = member.Email,
                CreateTime = DateTime.Now
            });

            db.SaveChanges();

            FormsService.SignIn(member.ChName);

            return RedirectToAction("Show", "Account");
        }
        #endregion

        #region 登入

        public ActionResult LogOn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogOn(LogOnModel member)
        {
            
            if(ValidateLogOn(member))
            {
                return RedirectToAction("Show", "Account");
            }
            ModelState.AddModelError("UserName", "您輸入的帳號密碼錯誤，請重新輸入!");
            return View();
        }

        private bool ValidateLogOn(LogOnModel LogOnMember)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                Member member = db.Member.Where(p => p.Account.Equals(LogOnMember.UserName) && p.Password.Equals(LogOnMember.Password)).FirstOrDefault();
                if (member != null)
                {
                    FormsService.SignIn(member.ChName);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            throw new NotImplementedException();
        }

        #endregion

        #region 顯示會員清單

        public ActionResult Show()
        {
            MemberManageEntities db = new MemberManageEntities();

            var data = db.Member;

            return View(data);
        }

        #endregion

        #region 登出

        public ActionResult LogOff()
        {
            FormsService.SignOut();
            return RedirectToAction("Index", "Home");
        }

        #endregion

        #region 刪除

        public ActionResult Delete(int id)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.ID == id).First();
                db.DeleteObject(member);
                db.SaveChanges();
            }
            return RedirectToAction("Show", "Account");
        }

        #endregion

        #region 修改

        public ActionResult Edit(int id)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.ID == id).First();
                return View("Edit", member);
            }
            
        }
        [HttpPost]
        public ActionResult Edit(MemberForm UpdateMember)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.Account == UpdateMember.Account).First();
                member.ChName = UpdateMember.ChName;
                member.NickName = UpdateMember.NickName;
                member.Email = UpdateMember.Email;
                db.SaveChanges();
            }
            return RedirectToAction("Show", "Account");
        }
        #endregion

        #region 查詢

        public ActionResult Search()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Search(string SearchText)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.Account.Contains(SearchText) || p.ChName.Contains(SearchText) || p.Email.Contains(SearchText) || p.NickName.Contains(SearchText)).ToList();
                return View("SearchList", member);
            }
        }
        #endregion
    }
}
