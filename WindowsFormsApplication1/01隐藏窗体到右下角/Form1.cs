using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            notifyIcon1.Icon = new Icon("002.ICO");
            notifyIcon1.Visible = false;
            this.notifyIcon1_Click = (s, ev) =>
            {

                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Maximized;
                    this.Activate();
                    this.notifyIcon1.Visible = false;
                    this.ShowInTaskbar = true;
                }
            };

            notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);

          
        }


        public EventHandler notifyIcon1_Click { get; set; }
        
       

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.ShowInTaskbar = false;
                this.notifyIcon1.Visible = true;
            }
        }
    }
}
