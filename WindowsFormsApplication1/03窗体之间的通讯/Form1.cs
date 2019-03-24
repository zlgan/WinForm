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
    /// <summary>
    /// 方式一：
    /// 将form1的句柄传递给form2，在后者访问前者的所有公开的属性和方法
    /// 
    /// 方式二:
    ///  上述方式访问条件太宽松，可以通过委托方式
    ///
    /// </summary>
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        public void VisitByOther()
        {
            this.checkBox1.Checked = !this.checkBox1.Checked;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            (new Form2(this)).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Form2(VisitByOther)).Show();
        }
    }
}
