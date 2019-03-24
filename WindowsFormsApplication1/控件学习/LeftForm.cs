using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1.控件学习
{
    public partial class LeftForm : Form
    {

        Action ToogleCheck;

        public LeftForm()
        {
            InitializeComponent();

            //遍历所有属性
            var query = this.GetType().GetProperties().Select(p => string.Format("属性名:{0}--属性值{1}", p.Name, p.GetValue(this, null)));
            foreach (var s in query)
            {
                //输出窗口写信息
                System.Diagnostics.Debug.WriteLine(s);
            }
        }

        //构造函数相互调用
        public LeftForm(Action ac):this()
        {
            this.ToogleCheck = ac;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ToogleCheck != null)
            {
                ToogleCheck();
            }


            MDIParent1 fm = (MDIParent1)this.ParentForm;
            var aa = fm.checkBox1.Checked;
            fm.checkBox1.Checked = !aa;
        }
    }
}
