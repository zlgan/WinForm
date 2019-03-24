namespace WindowsFormsApplication1
{
    partial class TestControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myListControl1 = new CustomerControl.MyListControl();
            this.firstControl1 = new CustomControlSample.FirstControl();
            this.SuspendLayout();
            // 
            // myListControl1
            // 
            this.myListControl1.Item.Add(1);
            this.myListControl1.Item.Add(2);
            this.myListControl1.Item.Add(3);
            this.myListControl1.Item.Add(4);
            this.myListControl1.Item.Add(5);
            this.myListControl1.Item.Add(6);
            this.myListControl1.Location = new System.Drawing.Point(127, 88);
            this.myListControl1.Name = "myListControl1";
            this.myListControl1.Scope = new CustomerControl.Scope(1, 5);
            this.myListControl1.Size = new System.Drawing.Size(74, 94);
            this.myListControl1.TabIndex = 1;
            this.myListControl1.Text = "myListControl1";
            // 
            // firstControl1
            // 
            this.firstControl1.Location = new System.Drawing.Point(12, 12);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(151, 45);
            this.firstControl1.TabIndex = 0;
            this.firstControl1.Text = "HelloWorld";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.myListControl1);
            this.Controls.Add(this.firstControl1);
            this.Name = "TestControl";
            this.Text = "TestControl";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlSample.FirstControl firstControl1;
        private CustomerControl.MyListControl myListControl1;
    }
}