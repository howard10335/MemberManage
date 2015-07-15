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

namespace MemberManageSilverlight
{
    public partial class SearchChild : ChildWindow
    {
        public SearchChild()
        {
            InitializeComponent();
        }

        private void SearchText_TextChanged(object sender, TextChangedEventArgs e)
        {
            Wcf_GetdataClient client = new Wcf_GetdataClient();
            client.SearchCompleted += new EventHandler<SearchCompletedEventArgs>(client_SearchCompleted);
            client.SearchAsync(SearchText.Text);
        }

        void client_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            dataGrid1.ItemsSource = e.Result;
        }
    }
}

