using System;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using System.Windows.Input;
using MemberManageSilverlight.LoginService;

namespace MemberManageSilverlight
{
    public partial class Login : UserControl
    {
        LoginServiceClient client = new LoginServiceClient();

        public Login()
        {
            client.ValidateLogOnCompleted += new EventHandler<ValidateLogOnCompletedEventArgs>(client_ValidateLogOnCompleted);
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, RoutedEventArgs e)
        {
            client.ValidateLogOnAsync(this.Account.Text, this.Password.Password);
        }
        void client_ValidateLogOnCompleted(object sender, ValidateLogOnCompletedEventArgs e)
        {
            if (e.Result)
            {
                HtmlPage.Window.Eval("window.location.href = './ShowMembers'");
            }
            else
            {
                AlarmText.Content = "帳號或密碼錯誤";
            }
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            HtmlPage.Window.Eval("window.location.href = './Register'");
        }

        private void UserControl_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                client.ValidateLogOnAsync(this.Account.Text, this.Password.Password);
            }
        }
    }
}
