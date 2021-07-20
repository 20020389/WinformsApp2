using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using App2.ChildForms;
using CefSharp;
using CefSharp.WinForms;
using System.Net;
using System.Net.NetworkInformation;

namespace App2
{
    //1607, 1001
    //1015, 734
    //base 1345, 830
    public partial class Form1 : Form
    {        
        int choose = 0;
        int speed = 0;
        Panel choosing;
        DBForm[] dbForm = new DBForm[6];
        bool[] created = new bool[6] { true, true, true, true, true, true };
        bool _Internet = true, Taskbar_Hided=false;
        public Form1()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            choosing = new Panel();
            choosing.Size = new Size(5, 178);
            choosing.Hide();
            Add_Browser();
            TimeRunning1.Start();
            _Internet = Check_Connect();
            if (_Internet)
                Error_Log.Text = "";
            else
                Error_Log.Text = "Connect Failed, Please check your connect then reset app!";
        }
        
        bool Check_Connect()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        
        private void Add_Browser()
        {
            for (int i = 0; i < 6; i++)
            {
                dbForm[i] = new DBForm();
                dbForm[i].FormBorderStyle = FormBorderStyle.None;
                dbForm[i].TopLevel = false;
                BaseForms.Controls.Add(dbForm[i]);
               // dbForm[i].browser.LoadError += Browser_LoadError;
            }
            #region add url
            dbForm[0].browser.Load("www.google.com");
            dbForm[1].browser.Load("www.youtube.com");
            dbForm[2].browser.Load("www.facebook.com");
            dbForm[3].browser.Load("courses.uet.vnu.edu.vn");
            dbForm[4].browser.Load("www.hackerrank.com");
            dbForm[5].browser.Load("chat.zalo.me");
            #endregion
            BackButton.Hide();
            FocusButton.Hide();
            CloseButton.Hide();
        }


        void Goto_Home()
        {
            switch (choose)
            {
                case 0:
                    break;
                case 1:
                    LEAVE_BUTTON(ref Choose1);
                    Choose1.ForeColor = SystemColors.Control;
                    Choose1.IconColor = SystemColors.Control;
                    break;
                case 2:
                    LEAVE_BUTTON(ref Choose2);
                    Choose2.ForeColor = SystemColors.Control;
                    Choose2.IconColor = SystemColors.Control;
                    break;
                case 3:
                    LEAVE_BUTTON(ref Choose3);
                    Choose3.ForeColor = SystemColors.Control;
                    Choose3.IconColor = SystemColors.Control;
                    break;
                case 4:
                    LEAVE_BUTTON(ref Choose4);
                    Choose4.ForeColor = SystemColors.Control;
                    Choose4.IconColor = SystemColors.Control;
                    break;
                case 5:
                    LEAVE_BUTTON(ref Choose5);
                    Choose5.ForeColor = SystemColors.Control;
                    Choose5.IconColor = SystemColors.Control;
                    break;
                case 6:
                    LEAVE_BUTTON(ref Choose6);
                    Choose6.ForeColor = SystemColors.Control;
                    Choose6.IconColor = SystemColors.Control;
                    break;
            }
            dbForm[choose - 1].Close();
            created[choose - 1] = false;
            choosing.Hide();
            choose = 0;
            Icon_Box1.IconColor = Color.MediumSlateBlue;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Home;
            NameChoosing.Text = "Home";
            Home_Panel.Show();
            BackButton.Hide();
            FocusButton.Hide();
            CloseButton.Hide();
        }
        /*
        private void Browser_LoadError(object sender, LoadErrorEventArgs e)
        {
            _Internet = false;
            Error_Log.Text = "Connect Failed, Please check your connect then reset app!";
            Error_Log.Show();
            
        }*/

        #region move window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        
        public static extern bool ReleaseCapture();
        #endregion

        #region TimeClock
        /*
        Thread thread;
        String strtime;
        public void update()
        {
            while(true)
            {
                if (Bar1.Value >= 100)
                    Bar1.Value = 0;
                if (Bar1.Value + 5 <= 100)
                    Bar1.Value += 1;
                else
                {
                    Bar1.Value = 100;
                    thread.Abort();
                }
                Thread.Sleep(50);
            }
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            //thread = new Thread(() => update());
            //thread.Start();
            //this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            Hide_Form_bt.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }
        
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clock_Label1.Focus();
            Cef.Shutdown();
            //thread.Abort();
        }
        
        #endregion

        private void ControlBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Full_Form_bt_Click(object sender, EventArgs e)
        {
            Clock_Label1.Focus();
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            }
            else if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimeRunning1.Stop();
            this.Close();
        }

        private void Hide_Form_bt_Click(object sender, EventArgs e)
        {
            Clock_Label1.Focus();
            this.WindowState = FormWindowState.Minimized;
        }

        //
        /// animator

        //
        ///

        #region button setting

        private void CHOOSE_BUTTON(ref FontAwesome.Sharp.IconButton Choose_bt)
        {
            Choose_bt.Padding = new Padding(0, 0, 12, 0);
            Choose_bt.TextImageRelation = TextImageRelation.TextBeforeImage;
            Choose_bt.ImageAlign = ContentAlignment.MiddleRight;
            choosing.Location = new Point(0, 0);
            Choose_bt.Controls.Add(choosing);
            choosing.Show();
        }

        private void LEAVE_BUTTON(ref FontAwesome.Sharp.IconButton Choose_bt)
        {
            Choose_bt.Padding = new Padding(12, 0, 0, 0);
            Choose_bt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Choose_bt.ImageAlign = ContentAlignment.MiddleLeft;
        }


        #endregion

        void Clicking()
        {
            Clock_Label1.Focus();
            if (_Internet)
            {
                if (!created[choose - 1])
                {
                    dbForm[choose - 1] = new DBForm();
                    dbForm[choose - 1].FormBorderStyle = FormBorderStyle.None;
                    dbForm[choose - 1].TopLevel = false;
                    BaseForms.Controls.Add(dbForm[choose - 1]);
                    if(!Taskbar_Hided)
                        dbForm[choose - 1].Size = new Size(this.Width - 329, this.Height - 95);
                    else
                        dbForm[choose - 1].Size = new Size(this.Width - 96, this.Height - 95);
                    switch (choose)
                    {
                        case 1:
                            dbForm[0].browser.Load("www.google.com");
                            break;
                        case 2:
                            dbForm[1].browser.Load("www.youtube.com");
                            break;
                        case 3:
                            dbForm[2].browser.Load("www.facebook.com");
                            break;
                        case 4:
                            dbForm[3].browser.Load("courses.uet.vnu.edu.vn");
                            break;
                        case 5:
                            dbForm[4].browser.Load("www.hackerrank.com");
                            break;
                        case 6:
                            dbForm[5].browser.Load("chat.zalo.me");
                            break;

                    }
                    if (!Taskbar_Hided)
                        dbForm[choose - 1].Size = new Size(this.Width - 329, this.Height - 95);
                    else
                        dbForm[choose - 1].Size = new Size(this.Width - 96, this.Height - 95);
                    dbForm[choose - 1].Show();
                    BackButton.Show();
                    FocusButton.Show();
                    CloseButton.Show();
                    Home_Panel.Hide();
                    created[choose - 1] = true;
                    return;
                }
                dbForm[choose - 1].Show();
                Home_Panel.Hide();
                BackButton.Show();
                FocusButton.Show();
                CloseButton.Show();
            }
        }

        void Leaving()
        {
            switch (choose)
            {
                case 0:
                    break;
                case 1:                   
                    LEAVE_BUTTON(ref Choose1);
                    break;
                case 2:                    
                    LEAVE_BUTTON(ref Choose2);
                    break;
                case 3:
                    LEAVE_BUTTON(ref Choose3);
                    break;
                case 4:
                    LEAVE_BUTTON(ref Choose4);
                    break;
                case 5:
                    LEAVE_BUTTON(ref Choose5);
                    break;
                case 6:
                    LEAVE_BUTTON(ref Choose6);
                    break;
            }

            if (choose!=0 && _Internet)
                dbForm[choose - 1].Hide();
        }

        private void Choose1_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 1;
            CHOOSE_BUTTON(ref Choose1);
            choosing.BackColor = Color.MediumSlateBlue;
            Choose1.ForeColor = Color.MediumSlateBlue;
            Choose1.IconColor = Color.MediumSlateBlue;
            BackButton.IconColor = Color.MediumSlateBlue;
            FocusButton.IconColor = Color.MediumSlateBlue;
            Icon_Box1.IconColor = Color.MediumSlateBlue;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Google;
            NameChoosing.Text = "Google";
            Clicking();            
        }


        private void Choose2_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 2;
            CHOOSE_BUTTON(ref Choose2);
            choosing.BackColor = Color.Orange;
            Choose2.ForeColor = Color.Orange;
            Choose2.IconColor = Color.Orange;
            BackButton.IconColor = Color.Orange;
            FocusButton.IconColor = Color.Orange;
            Icon_Box1.IconColor = Color.Orange;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Youtube;
            NameChoosing.Text = "Youtube";
            Clicking();
            
        }


        private void Choose3_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 3;
            CHOOSE_BUTTON(ref Choose3);
            choosing.BackColor = Color.Aqua;
            Choose3.ForeColor = Color.Aqua;
            Choose3.IconColor = Color.Aqua;
            BackButton.IconColor = Color.Aqua;
            FocusButton.IconColor = Color.Aqua;
            Icon_Box1.IconColor = Color.Aqua;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Facebook;
            NameChoosing.Text = "Facebook";
            Clicking();
        }


        private void Choose4_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 4;
            CHOOSE_BUTTON(ref Choose4);
            choosing.BackColor = Color.Yellow;
            Choose4.ForeColor = Color.Yellow;
            Choose4.IconColor = Color.Yellow;
            BackButton.IconColor = Color.Yellow;
            FocusButton.IconColor = Color.Yellow;
            Icon_Box1.IconColor = Color.Yellow;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.AddressBook;
            NameChoosing.Text = "Courses";
            Clicking();
        }

        private void Choose5_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 5;
            CHOOSE_BUTTON(ref Choose5);
            choosing.BackColor = Color.DeepPink;
            Choose5.ForeColor = Color.DeepPink;
            Choose5.IconColor = Color.DeepPink;
            BackButton.IconColor = Color.DeepPink;
            FocusButton.IconColor = Color.DeepPink;
            Icon_Box1.IconColor = Color.DeepPink;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Code;
            NameChoosing.Text = "Hackerrank";
            Clicking();
        }

        private void Choose6_Click(object sender, EventArgs e)
        {
            Leaving();
            choose = 6;
            CHOOSE_BUTTON(ref Choose6);
            choosing.BackColor = Color.DarkSeaGreen;
            Choose6.ForeColor = Color.DarkSeaGreen;
            Choose6.IconColor = Color.DarkSeaGreen;
            BackButton.IconColor = Color.DarkSeaGreen;
            FocusButton.IconColor = Color.DarkSeaGreen;
            Icon_Box1.IconColor = Color.DarkSeaGreen; ;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Comments;
            NameChoosing.Text = "Zalo";
            Clicking();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Leaving();
            Icon_Box1.IconColor = Color.MediumSlateBlue;
            choose = 0;
            choosing.Hide();
            Icon_Box1.IconColor = Color.MediumSlateBlue;
            Icon_Box1.IconChar = FontAwesome.Sharp.IconChar.Home;
            NameChoosing.Text = "Home";
            BackButton.Hide();
            FocusButton.Hide();
            CloseButton.Hide();
            Home_Panel.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if(!Taskbar_Hided)
            {
                BaseForms.Size = new Size(this.Width - 329, this.Height - 95);
                for (int i = 0; i < 6; i++)
                    dbForm[i].Size = new Size(this.Width - 329, this.Height - 95);
                Control_Box.Size = new Size(this.Width - 329, Control_Box.Height);
                Task_Bar.Size = new Size(Task_Bar.Width, this.Height - 16);
                Home_Panel.Location = new Point((BaseForms.Width - 1015) / 2, (BaseForms.Height - 664) / 2);
            }
            else
            {
                BaseForms.Size = new Size(this.Width - 96, this.Height - 95);
                for (int i = 0; i < 6; i++)
                    dbForm[i].Size = new Size(this.Width - 96, this.Height - 95);
                Control_Box.Size = new Size(this.Width - 96, Control_Box.Height);
                Task_Bar.Size = new Size(Task_Bar.Width, this.Height - 16);
                Home_Panel.Location = new Point((BaseForms.Width - 1015) / 2, (BaseForms.Height - 664) / 2);
            }
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            if(choose!=0 && dbForm[choose - 1].browser.CanGoBack)
                dbForm[choose - 1].browser.Back();
        }

        private void FocusButton_Click(object sender, EventArgs e)
        {
            if (choose != 0 && dbForm[choose - 1].browser.CanGoForward)
                dbForm[choose - 1].browser.Forward();
        }

        private void RefeshButton_Click(object sender, EventArgs e)
        {
            Goto_Home();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CLock_Label.Text = DateTime.Now.ToString("HH:mm:ss");
            if (choose != 0)
                Clock_Label1.Text = DateTime.Now.ToString("HH:mm:ss");
            else
                Clock_Label1.Text = String.Empty;
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
        }

        private void HideTaskBar_Click(object sender, EventArgs e)
        {
            Taskbar_Resize();
        }

        private void Control_Box_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Clock_Label1.Focus();
                if (this.WindowState == FormWindowState.Normal)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
                }
                else if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Full_Form_bt.IconChar = FontAwesome.Sharp.IconChar.ExpandAlt;
                }
            }
        }


        #region Event Resize TaskBar
        //
        //
        private void Taskbar_Resize()
        {
            if(!Taskbar_Hided)
            {
                HideTaskBar.IconChar = FontAwesome.Sharp.IconChar.CaretSquareRight;
                Task_Bar.Size = new Size(80, Task_Bar.Height);
                Control_Box.Location = new Point(Task_Bar.Width, 0);
                Control_Box.Size = new Size(Control_Box.Width+233, Control_Box.Height);
                //
                //button and logo,label  in taskbar
                //
                LogoBox1.Location = new Point(-21,LogoBox1.Location.Y+15);
                Choose1.Size = new Size(Task_Bar.Width, Choose1.Height);
                Choose1.Text = String.Empty;
                Choose2.Size = new Size(Task_Bar.Width, Choose2.Height);
                Choose2.Text = String.Empty;
                Choose3.Size = new Size(Task_Bar.Width, Choose3.Height);
                Choose3.Text = String.Empty;
                Choose4.Size = new Size(Task_Bar.Width, Choose4.Height);
                Choose4.Text = String.Empty;
                Choose5.Size = new Size(Task_Bar.Width, Choose5.Height);
                Choose5.Text = String.Empty;
                Choose6.Size = new Size(Task_Bar.Width, Choose6.Height);
                Choose6.Text = String.Empty;
                IntroName1.Text = String.Empty;
                //
                //
                BaseForms.Location = new Point(Task_Bar.Width, Control_Box.Height);
                BaseForms.Size = new Size(BaseForms.Width + 233, BaseForms.Height);
                for (int i = 0; i < 6; i++)
                {
                    dbForm[i].Size = new Size(dbForm[i].Width + 233, dbForm[i].Height);
                }
                Home_Panel.Location = new Point((BaseForms.Width - 1015) / 2, (BaseForms.Height - 664) / 2);
                Taskbar_Hided = true;
            }
            else
            {
                HideTaskBar.IconChar = FontAwesome.Sharp.IconChar.CaretSquareLeft;
                Task_Bar.Size = new Size(313, Task_Bar.Height);
                Control_Box.Location = new Point(Task_Bar.Width, 0);
                Control_Box.Size = new Size(Control_Box.Width - 233, Control_Box.Height);
                //
                //button and logo,label  in taskbar
                //
                LogoBox1.Location = new Point(81, LogoBox1.Location.Y-15);
                Choose1.Size = new Size(Task_Bar.Width, Choose1.Height);
                Choose1.Text = "Google";
                Choose2.Size = new Size(Task_Bar.Width, Choose2.Height);
                Choose2.Text = "Youtube";
                Choose3.Size = new Size(Task_Bar.Width, Choose3.Height);
                Choose3.Text = "Facebook";
                Choose4.Size = new Size(Task_Bar.Width, Choose4.Height);
                Choose4.Text = "Courses";
                Choose5.Size = new Size(Task_Bar.Width, Choose5.Height);
                Choose5.Text = "Hackerrank";
                Choose6.Size = new Size(Task_Bar.Width, Choose6.Height);
                Choose6.Text = "Zalo";
                IntroName1.Text = "Learn  to  Better";
                //
                //
                BaseForms.Location = new Point(Task_Bar.Width, Control_Box.Height);
                BaseForms.Size = new Size(BaseForms.Width - 233, BaseForms.Height);
                for (int i = 0; i < 6; i++)
                {
                    dbForm[i].Size = new Size(dbForm[i].Width - 233, dbForm[i].Height);
                }
                Home_Panel.Location = new Point((BaseForms.Width - 1015) / 2, (BaseForms.Height - 664) / 2);
                Taskbar_Hided = false;
            }
        }
        //
        //
        #endregion

       
    }

    /*  event when wifi error
     void Leaving()
        {
            switch (choose)
            {
                case 0:
                    break;
                case 1:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose1.ForeColor = SystemColors.Control;
                        Choose1.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose1);
                    break;
                case 2:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose2.ForeColor = SystemColors.Control;
                        Choose2.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose2);
                    break;
                case 3:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose3.ForeColor = SystemColors.Control;
                        Choose3.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose3);
                    break;
                case 4:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose4.ForeColor = SystemColors.Control;
                        Choose4.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose4);
                    break;
                case 5:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose5.ForeColor = SystemColors.Control;
                        Choose5.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose5);
                    break;
                case 6:
                    if (!_Internet)
                    {
                        dbForm[choose - 1].Close();
                        Choose6.ForeColor = SystemColors.Control;
                        Choose6.IconColor = SystemColors.Control;
                    }
                    LEAVE_BUTTON(ref Choose6);
                    break;
            }

            if (choose!=0 && _Internet)
                dbForm[choose - 1].Hide();
        }
     */
}
