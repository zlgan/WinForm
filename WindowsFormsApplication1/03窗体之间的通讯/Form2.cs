using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1._03窗体之间的通讯
{
    public partial class Form2 : Form
    {
        Form fm;
        Action clickHander;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Form fm): this()
        {
            this.fm = fm;
        }

        public Form2(Action clickHander): this()
        {
            this.clickHander = clickHander;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ((Form1)fm).VisitByOther();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (clickHander != null)
            {
                clickHander();
            }
        }


    }
}
