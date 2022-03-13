namespace Session_07
{
    partial class StudentsForm
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.textRegNum = new DevExpress.XtraEditors.TextEdit();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegNum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(640, 387);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(87, 36);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(338, 387);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(91, 36);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "New";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButtonNew_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(439, 387);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(80, 36);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "Save";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(543, 387);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(87, 36);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "Delete";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(489, 28);
            this.textName.Margin = new System.Windows.Forms.Padding(5);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(156, 38);
            this.textName.TabIndex = 5;
            // 
            // textRegNum
            // 
            this.textRegNum.Location = new System.Drawing.Point(489, 183);
            this.textRegNum.Margin = new System.Windows.Forms.Padding(5);
            this.textRegNum.Name = "textRegNum";
            this.textRegNum.Size = new System.Drawing.Size(68, 38);
            this.textRegNum.TabIndex = 7;
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(489, 113);
            this.textAge.Margin = new System.Windows.Forms.Padding(5);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(47, 38);
            this.textAge.TabIndex = 8;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(414, 35);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 23);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Name";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(431, 119);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 23);
            this.labelControl2.TabIndex = 10;
            this.labelControl2.Text = "Age";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(335, 198);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(128, 23);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Registration No";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(398, 266);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 23);
            this.labelControl4.TabIndex = 12;
            this.labelControl4.Text = "Courses";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(10, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(292, 411);
            this.listBoxControl1.TabIndex = 13;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(489, 259);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(5);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(91, 36);
            this.simpleButton5.TabIndex = 14;
            this.simpleButton5.Text = "Edit..";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButtonEditCourses_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 443);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textRegNum);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "StudentsForm";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.StudentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRegNum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.TextEdit textRegNum;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}