﻿using System;
using System.Windows;
using System.Windows.Controls;

namespace MemberManageSilverlight
{
    public partial class App : Application
    {
        Grid navigationUI = new Grid();

        public App()
        {
            this.Startup += this.Application_Startup;
            this.Exit += this.Application_Exit;
            this.UnhandledException += this.Application_UnhandledException;

            InitializeComponent();
        }

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            switch (e.InitParams["PageName"])
            {
                case "Login":
                    this.RootVisual = new Login();
                    break;
                case "ShowMember":
                    this.RootVisual = new ShowMember();
                    break;
                case "Register":
                    this.RootVisual = new Register();
                    break;
            }
        }

        private void Application_Exit(object sender, EventArgs e)
        {

        }

        private void Application_UnhandledException(object sender, ApplicationUnhandledExceptionEventArgs e)
        {
            // 如果應用程式是在偵錯工具外執行，則使用瀏覽器的例外機制
            // 報告例外狀況。在 IE 中，這會顯示為狀態列中的黃色提醒圖示，
            // 而 Firefox 則會顯示指令碼錯誤。
            if (!System.Diagnostics.Debugger.IsAttached)
            {

                // 注意: 這樣可以讓應用程式在有例外狀況擲回但未處理的情況下
                // 繼續執行。
                // 對於生產應用程式，這個錯誤處理方式應該置換成會向網站
                // 報告錯誤並停用應用程式的程序。
                e.Handled = true;
                Deployment.Current.Dispatcher.BeginInvoke(delegate { ReportErrorToDOM(e); });
            }
        }

        private void ReportErrorToDOM(ApplicationUnhandledExceptionEventArgs e)
        {
            try
            {
                string errorMsg = e.ExceptionObject.Message + e.ExceptionObject.StackTrace;
                errorMsg = errorMsg.Replace('"', '\'').Replace("\r\n", @"\n");

                System.Windows.Browser.HtmlPage.Window.Eval("throw new Error(\"Unhandled Error in Silverlight Application " + errorMsg + "\");");
            }
            catch (Exception)
            {
            }
        }
    }
}
