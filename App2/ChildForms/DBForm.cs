using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp.Example.Handlers;

namespace App2.ChildForms
{
    public partial class DBForm : Form
    {
        CefSettings setting;
        static public int limit = 0;
        int now;
        public DBForm()
        {
            InitializeComponent();
            if (limit++ == 0)
            {
                setting = new CefSettings();
                setting.CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\CEF";
                Cef.Initialize(setting);
            }
            //panel3.Hide();
            this.browser.DownloadHandler = new DownloadHandler();
            
        }
        

        private void browser_FrameLoadEnd(object sender, FrameLoadEndEventArgs e)
        {
            if (e.Url.Equals(@"https://courses.uet.vnu.edu.vn/"))
            {
                var wb = sender as ChromiumWebBrowser;
                wb.EvaluateScriptAsync
                    (@"document.querySelector('input#inputName.span2').value='20020389';");
                wb.EvaluateScriptAsync
                    (@"document.querySelector('input#inputPassword.span2').value='tuyet02';");
            }
           
        }

        private void DBForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
