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
            this.button1 = new System.Windows.Forms.Button();
            this.firstControl1 = new CustomControlSample.FirstControl();
            this.myListControl1 = new CustomerControl.MyListControl();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(235, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            // myListControl1
            // 
            this.myListControl1.DisplayText = null;
            this.myListControl1.Location = new System.Drawing.Point(278, 179);
            this.myListControl1.Name = "myListControl1";
            this.myListControl1.Scope = null;
            this.myListControl1.Size = new System.Drawing.Size(75, 23);
            this.myListControl1.TabIndex = 3;
            this.myListControl1.Text = "myListControl1";
            // 
            // TestControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 455);
            this.Controls.Add(this.myListControl1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.firstControl1);
            this.Name = "TestControl";
            this.Text = "TestControl";
            this.ResumeLayout(false);

        }

        #endregion

        private CustomControlSample.FirstControl firstControl1;
        private System.Windows.Forms.Button button1;
        private CustomerControl.MyListControl myListControl1;
    }
}