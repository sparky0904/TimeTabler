namespace TimeTable.Forms.Admin
{
    partial class baseAdminForm
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
            this.DataList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // DataList
            // 
            this.DataList.FormattingEnabled = true;
            this.DataList.Location = new System.Drawing.Point(12, 51);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(213, 524);
            this.DataList.TabIndex = 2;
            // 
            // baseAdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 510);
            this.Controls.Add(this.DataList);
            this.Name = "baseAdminForm";
            this.Text = "baseAdminForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox DataList;
    }
}