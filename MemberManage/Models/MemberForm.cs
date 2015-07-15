using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MemberManage.Models
{
    public class MemberForm
    {
        [Required]
        public string Account {get; set;}

        [Required]
        public string Password {get; set;}

        [Required]
        public string ChName {get; set;}

        [Required]
        public string NickName {get; set;}

        [Required]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4})$",
                ErrorMessage = "請輸入正確的Email.")]
        public string Email { get; set; }
    }
}