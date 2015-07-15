using System.ServiceModel;

namespace MemberManage
{
    // 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的介面名稱 "ILoginService"。
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        bool ValidateLogOn(string Account, string Password);
    }
}
