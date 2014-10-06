using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;


namespace MemberManage.Models
{
    public class LogOnModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
    public interface IFormsAuthenticationService
    {
        void SignIn(string userName);
        void SignOut();
    }

    public class FormsAuthenticationService : IFormsAuthenticationService
    {
        public void SignIn(string userName)
        {
            if (String.IsNullOrEmpty(userName)) throw new ArgumentException("值不可為 null 或空白。", "userName");

            FormsAuthentication.SetAuthCookie(userName, false);
        }

        public void SignOut()
        {
            FormsAuthentication.SignOut();
        }
    }
}