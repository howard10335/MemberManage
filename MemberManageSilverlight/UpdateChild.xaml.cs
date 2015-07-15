using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using MemberManageSilverlight.wcfService;
using System.ComponentModel;

namespace MemberManageSilverlight
{
    public partial class UpdateChild : ChildWindow
    {
        public UpdateChild()
        {
            InitializeComponent();
        }

        public UpdateChild(Member updateMember)
        {
            InitializeComponent();
            Account.Text = updateMember.Account;
            Password.Text = updateMember.Password;
            ChName.Text = updateMember.ChName;
            NickName.Text = updateMember.NickName;
            Email.Text = updateMember.Email;
        }

        private void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            Wcf_GetdataClient client = new Wcf_GetdataClient();
            client.EditCompleted+= new EventHandler<AsyncCompletedEventArgs>(client_EditCompleted);
            client.EditAsync(new Member()
            {
                Account = Account.Text,
                Password = Password.Text,
                ChName = ChName.Text,
                NickName = NickName.Text,
                Email = Email.Text,
            });
            this.DialogResult = true;
        }

        void client_EditCompleted(object sender, AsyncCompletedEventArgs e)
        {
            this.Close();
        }
    }
}

