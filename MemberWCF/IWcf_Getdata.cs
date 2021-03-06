﻿using System.Collections.Generic;
using System.ServiceModel;
using MemberWCF;

namespace MemberManage
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "IWcf_Getdata"。
    [ServiceContract]
    public interface IWcf_Getdata
    {
        [OperationContract]
        List<Member> GetAllMember();

        [OperationContract]
        void CreateMember(Member member);

        [OperationContract]
        void Delete(int id);

        [OperationContract]
        List<Member> Search(string SearchText);

        [OperationContract]
        void Edit(Member UpdateMember);
    }
}
