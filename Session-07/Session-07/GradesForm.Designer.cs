namespace Session_07
{
    partial class GradesForm
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
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
            this.Value = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.Student = new System.Windows.Forms.Label();
            this.Course = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(512, 384);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(131, 40);
            this.simpleButton4.TabIndex = 11;
            this.simpleButton4.Text = "Delete";
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(164, 384);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(131, 40);
            this.simpleButton3.TabIndex = 10;
            this.simpleButton3.Text = "Save";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(11, 384);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(131, 40);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "New";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(659, 384);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(131, 40);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButtonCancel_Click);
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(33, 49);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(224, 250);
            this.listBoxControl1.TabIndex = 12;
            // 
            // listBoxControl2
            // 
            this.listBoxControl2.Location = new System.Drawing.Point(332, 49);
            this.listBoxControl2.Name = "listBoxControl2";
            this.listBoxControl2.Size = new System.Drawing.Size(224, 250);
            this.listBoxControl2.TabIndex = 13;
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(643, 77);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(63, 25);
            this.Value.TabIndex = 14;
            this.Value.Text = "Value";
           
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(648, 134);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(71, 38);
            this.textEdit1.TabIndex = 15;
            // 
            // Student
            // 
            this.Student.AutoSize = true;
            this.Student.Location = new System.Drawing.Point(104, 21);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(80, 25);
            this.Student.TabIndex = 16;
            this.Student.Text = "Student";
            // 
            // Course
            // 
            this.Course.AutoSize = true;
            this.Course.Location = new System.Drawing.Point(402, 21);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(76, 25);
            this.Course.TabIndex = 17;
            this.Course.Text = "Course";
            // 
            // GradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Course);
            this.Controls.Add(this.Student);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.listBoxControl2);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "GradesForm";
            this.Text = "Grades";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
        private System.Windows.Forms.Label Value;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private System.Windows.Forms.Label Student;
        private System.Windows.Forms.Label Course;
    }
}