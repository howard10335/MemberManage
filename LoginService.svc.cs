using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using MemberManage.Models;
using System.ServiceModel.Activation;

namespace MemberManage
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "LoginService"。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class LoginService : ILoginService
    {
        public bool ValidateLogOn(string Account, string Password)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                Member member = db.Member.Where(p => p.Account.Equals(Account) && p.Password.Equals(Password)).FirstOrDefault();
                if (member != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            throw new NotImplementedException();
        }
    }
}
