﻿#pragma checksum "C:\Users\howardyang\documents\visual studio 2010\Projects\MemberManage\MemberManageSilverlight\ShowMember.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "4D5D15CDF5D9669E8AAE79E6F990184E"
//------------------------------------------------------------------------------
// <auto-generated>
//     這段程式碼是由工具產生的。
//     執行階段版本:4.0.30319.34209
//
//     對這個檔案所做的變更可能會造成錯誤的行為，而且如果重新產生程式碼，
//     變更將會遺失。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace MemberManageSilverlight {
    
    
    public partial class ShowMember : System.Windows.Controls.UserControl {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.DataGrid dataGrid1;
        
        internal System.Windows.Controls.Button CreateBtn;
        
        internal System.Windows.Controls.Button DeleteBtn;
        
        internal System.Windows.Controls.Button UpdateBtn;
        
        internal System.Windows.Controls.Button SearchBtn;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/MemberManageSilverlight;component/ShowMember.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.dataGrid1 = ((System.Windows.Controls.DataGrid)(this.FindName("dataGrid1")));
            this.CreateBtn = ((System.Windows.Controls.Button)(this.FindName("CreateBtn")));
            this.DeleteBtn = ((System.Windows.Controls.Button)(this.FindName("DeleteBtn")));
            this.UpdateBtn = ((System.Windows.Controls.Button)(this.FindName("UpdateBtn")));
            this.SearchBtn = ((System.Windows.Controls.Button)(this.FindName("SearchBtn")));
        }
    }
}

