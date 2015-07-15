using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Browser;
using System.Windows.Controls;
using MemberManageSilverlight.wcfService;

namespace MemberManageSilverlight
{
    public partial class ShowMember : UserControl
    {
        public ShowMember()
        {
            InitializeComponent();
            loadMembers();
        }

        void loadMembers()
        {
            Wcf_GetdataClient client = new Wcf_GetdataClient();
            client.GetAllMemberCompleted += new EventHandler<GetAllMemberCompletedEventArgs>(client_GetAllMemberCompleted);
            client.GetAllMemberAsync();
        }

        void client_GetAllMemberCompleted(object sender, GetAllMemberCompletedEventArgs e)
        {
            this.dataGrid1.ItemsSource = e.Result;
        }

        private void CreateBtn_Click(object sender, RoutedEventArgs e)
        {
            HtmlPage.Window.Eval("window.location.href = './Register'");
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem == null)
            {
                MessageBox.Show("請選擇欲刪除的項目", "錯誤", MessageBoxButton.OK);
            }
            else
            {
                Member deleteMember = this.dataGrid1.SelectedItem as Member;
                MessageBoxResult result = MessageBox.Show("確定刪除" + deleteMember.ChName + "?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    Wcf_GetdataClient client = new Wcf_GetdataClient();
                    client.DeleteCompleted += new EventHandler<AsyncCompletedEventArgs>(client_DeleteCompleted);
                    client.DeleteAsync(deleteMember.ID);
                }
            }
        }

        void client_DeleteCompleted(object sender, AsyncCompletedEventArgs e)
        {
            loadMembers();
            MessageBox.Show("成功");
        }

        private void UpdateBtn_Click(object sender, RoutedEventArgs e)
        {
            if (dataGrid1.SelectedItem == null)
            {
                MessageBox.Show("請選擇欲修改的項目", "錯誤", MessageBoxButton.OK);
            }
            else
            {
                Member deleteMember = this.dataGrid1.SelectedItem as Member;
                MessageBoxResult result = MessageBox.Show("確定修改" + deleteMember.ChName + "?", "", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    UpdateChild window = new UpdateChild(deleteMember);
                    window.Show();
                    window.Closed += new EventHandler(window_Closed);
                }
            }
        }

        void window_Closed(object sender, EventArgs e)
        {
            loadMembers();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SearchChild window = new SearchChild();
            window.Show();
        }
    }
}
