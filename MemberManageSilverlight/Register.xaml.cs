using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using MemberManageSilverlight.wcfService;

namespace MemberManageSilverlight
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            Wcf_GetdataClient client = new Wcf_GetdataClient();
            client.CreateMemberCompleted += new EventHandler<AsyncCompletedEventArgs>(client_CreateMemberCompleted);
            client.CreateMemberAsync(new Member()
            {
                Account = Account.Text,
                Password = Password.Text,
                ChName = ChName.Text,
                NickName = NickName.Text,
                Email = Email.Text,
                CreateTime = DateTime.Now
            });
        }
        void client_CreateMemberCompleted(object sender, AsyncCompletedEventArgs e)
        {
            HtmlPage.Window.Eval("window.location.href = './ShowMembers'");
        }
    }
}
