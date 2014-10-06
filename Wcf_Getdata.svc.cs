using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.ServiceModel.Activation;
using MemberManage.Models;

namespace MemberManage
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼、svc 和組態檔中的類別名稱 "Wcf_Getdata"。
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Wcf_Getdata : IWcf_Getdata
    {
        public List<Member> GetAllMember()
        {
            // 建立一個 DataContext 物件。
            MemberManageEntities db = new MemberManageEntities();
            return db.Member.ToList();
        }

        public void CreateMember(Member member)
        {
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
        }
        public void Delete(int id)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.ID == id).First();
                db.DeleteObject(member);
                db.SaveChanges();
            }
        }
        public List<Member> Search(string SearchText)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                return db.Member.Where(p => p.Account.Contains(SearchText) || p.ChName.Contains(SearchText) || p.Email.Contains(SearchText) || p.NickName.Contains(SearchText)).ToList();
            }
        }
        public void Edit(Member UpdateMember)
        {
            using (MemberManageEntities db = new MemberManageEntities())
            {
                var member = db.Member.Where(p => p.Account == UpdateMember.Account).First();
                member.ChName = UpdateMember.ChName;
                member.NickName = UpdateMember.NickName;
                member.Email = UpdateMember.Email;
                db.SaveChanges();
            }
        }
    }
}
