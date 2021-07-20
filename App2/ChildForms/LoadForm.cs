using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2.ChildForms
{
    public partial class LoadForm : Form
    {
        public LoadForm()
        {
            InitializeComponent();
            this.chromiumWebBrowser1.Load("www.google.com");
        }
    }
}
