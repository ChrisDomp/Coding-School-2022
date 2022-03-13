namespace Session_07
{
    partial class SetGradeForm
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
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.Value = new DevExpress.XtraEditors.LabelControl();
            this.textValue = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValue.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Location = new System.Drawing.Point(30, 12);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(370, 378);
            this.listBoxControl1.TabIndex = 0;
            // 
            // Value
            // 
            this.Value.Location = new System.Drawing.Point(511, 80);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(46, 23);
            this.Value.TabIndex = 1;
            this.Value.Text = "Value";
            // 
            // textValue
            // 
            this.textValue.Location = new System.Drawing.Point(573, 73);
            this.textValue.Name = "textValue";
            this.textValue.Size = new System.Drawing.Size(103, 38);
            this.textValue.TabIndex = 2;
            // 
            // SetGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textValue);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.listBoxControl1);
            this.Name = "SetGrade";
            this.Text = "SetGrade";
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textValue.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.LabelControl Value;
        private DevExpress.XtraEditors.TextEdit textValue;
    }
}