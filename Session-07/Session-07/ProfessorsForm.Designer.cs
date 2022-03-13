namespace Session_07
{
    partial class ProfessorsForm
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textAge = new DevExpress.XtraEditors.TextEdit();
            this.textName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textRank = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.simpleButtonSetGrade = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(470, 143);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(32, 23);
            this.labelControl2.TabIndex = 14;
            this.labelControl2.Text = "Age";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(453, 73);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(9);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 23);
            this.labelControl1.TabIndex = 13;
            this.labelControl1.Text = "Name";
            // 
            // textAge
            // 
            this.textAge.Location = new System.Drawing.Point(537, 136);
            this.textAge.Margin = new System.Windows.Forms.Padding(9);
            this.textAge.Name = "textAge";
            this.textAge.Size = new System.Drawing.Size(55, 38);
            this.textAge.TabIndex = 12;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(537, 67);
            this.textName.Margin = new System.Windows.Forms.Padding(9);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(198, 38);
            this.textName.TabIndex = 11;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(459, 206);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(16);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 23);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "Rank";
            // 
            // textRank
            // 
            this.textRank.Location = new System.Drawing.Point(537, 199);
            this.textRank.Margin = new System.Windows.Forms.Padding(16);
            this.textRank.Name = "textRank";
            this.textRank.Size = new System.Drawing.Size(131, 38);
            this.textRank.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(437, 273);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(28);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(65, 23);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "Courses";
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(623, 429);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(96, 40);
            this.simpleButton4.TabIndex = 23;
            this.simpleButton4.Text = "Delete";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButtonDelete_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(502, 429);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(90, 40);
            this.simpleButton3.TabIndex = 22;
            this.simpleButton3.Text = "Save";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButtonSave_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(399, 429);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(95, 40);
            this.simpleButton2.TabIndex = 21;
            this.simpleButton2.Text = "New";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButtonNew_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(725, 429);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(101, 40);
            this.simpleButton1.TabIndex = 20;
            this.simpleButton1.Text = "Cancel";
            this.simpleButton1.Click += new System.EventHandler(this.simpleCancel_Click_1);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Location = new System.Drawing.Point(537, 264);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(131, 40);
            this.simpleButton5.TabIndex = 24;
            this.simpleButton5.Text = "Edit..";
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(31, 38);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(307, 351);
            this.listBoxControl1.TabIndex = 25;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // simpleButtonSetGrade
            // 
            this.simpleButtonSetGrade.Location = new System.Drawing.Point(56, 429);
            this.simpleButtonSetGrade.Name = "simpleButtonSetGrade";
            this.simpleButtonSetGrade.Size = new System.Drawing.Size(240, 40);
            this.simpleButtonSetGrade.TabIndex = 26;
            this.simpleButtonSetGrade.Text = "Set Grade..";
            this.simpleButtonSetGrade.Click += new System.EventHandler(this.simpleButtonSetGrade_Click);
            // 
            // ProfessorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 489);
            this.Controls.Add(this.simpleButtonSetGrade);
            this.Controls.Add(this.listBoxControl1);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.textRank);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textAge);
            this.Controls.Add(this.textName);
            this.Name = "ProfessorsForm";
            this.Text = "Professors";
            this.Load += new System.EventHandler(this.ProfessorsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.textAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textAge;
        private DevExpress.XtraEditors.TextEdit textName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textRank;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSetGrade;
    }
}