namespace TimeTable.Forms.Admin
{
    partial class frmTutor
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
            this.label1 = new System.Windows.Forms.Label();
            this.DataList = new System.Windows.Forms.ListBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._Created = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._Modified = new System.Windows.Forms.Label();
            this._LastName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this._FirstName = new System.Windows.Forms.TextBox();
            this._Active = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbWorkingPatternID = new System.Windows.Forms.ComboBox();
            this.dayHourPicker1 = new TimeTable.DayHourPicker();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tutors Management";
            // 
            // DataList
            // 
            this.DataList.FormattingEnabled = true;
            this.DataList.ItemHeight = 19;
            this.DataList.Location = new System.Drawing.Point(13, 73);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(213, 536);
            this.DataList.TabIndex = 1;
            this.DataList.SelectedIndexChanged += new System.EventHandler(this.DataList_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 615);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add New";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this._LastName);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this._FirstName);
            this.tabPage1.Controls.Add(this._Active);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(722, 504);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Details";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this._Created);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this._Modified);
            this.groupBox1.Location = new System.Drawing.Point(6, 414);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 84);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Timestamps";
            // 
            // _Created
            // 
            this._Created.AutoSize = true;
            this._Created.Location = new System.Drawing.Point(123, 23);
            this._Created.Name = "_Created";
            this._Created.Size = new System.Drawing.Size(49, 19);
            this._Created.TabIndex = 13;
            this._Created.Text = "label9";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Last Modified";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 19);
            this.label8.TabIndex = 12;
            this.label8.Text = "Created";
            // 
            // _Modified
            // 
            this._Modified.AutoSize = true;
            this._Modified.Location = new System.Drawing.Point(123, 52);
            this._Modified.Name = "_Modified";
            this._Modified.Size = new System.Drawing.Size(49, 19);
            this._Modified.TabIndex = 11;
            this._Modified.Text = "label7";
            // 
            // _LastName
            // 
            this._LastName.Location = new System.Drawing.Point(129, 56);
            this._LastName.Name = "_LastName";
            this._LastName.Size = new System.Drawing.Size(279, 27);
            this._LastName.TabIndex = 9;
            this._LastName.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Last Name";
            // 
            // _FirstName
            // 
            this._FirstName.Location = new System.Drawing.Point(129, 23);
            this._FirstName.Name = "_FirstName";
            this._FirstName.Size = new System.Drawing.Size(279, 27);
            this._FirstName.TabIndex = 7;
            this._FirstName.TextChanged += new System.EventHandler(this.DataChanged);
            // 
            // _Active
            // 
            this._Active.AutoSize = true;
            this._Active.Location = new System.Drawing.Point(129, 92);
            this._Active.Name = "_Active";
            this._Active.Size = new System.Drawing.Size(15, 14);
            this._Active.TabIndex = 3;
            this._Active.UseVisualStyleBackColor = true;
            this._Active.CheckStateChanged += new System.EventHandler(this.DataChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Active";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "First Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(464, 611);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 31);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(360, 611);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 31);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(256, 612);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 31);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(242, 73);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(730, 536);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dayHourPicker1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.cmbWorkingPatternID);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(722, 504);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Working Pattern";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Working Pattern";
            // 
            // cmbWorkingPatternID
            // 
            this.cmbWorkingPatternID.FormattingEnabled = true;
            this.cmbWorkingPatternID.Location = new System.Drawing.Point(126, 16);
            this.cmbWorkingPatternID.Name = "cmbWorkingPatternID";
            this.cmbWorkingPatternID.Size = new System.Drawing.Size(265, 27);
            this.cmbWorkingPatternID.TabIndex = 0;
            // 
            // dayHourPicker1
            // 
            this.dayHourPicker1.Location = new System.Drawing.Point(21, 60);
            this.dayHourPicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dayHourPicker1.Name = "dayHourPicker1";
            this.dayHourPicker1.Size = new System.Drawing.Size(694, 283);
            this.dayHourPicker1.TabIndex = 3;
            // 
            // frmTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 711);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDelete);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmTutor";
            this.Text = "Tutor";
            this.Load += new System.EventHandler(this.evtFormLoad);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox DataList;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox _Active;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbWorkingPatternID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox _FirstName;
        private System.Windows.Forms.TextBox _LastName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label _Modified;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _Created;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private DayHourPicker dayHourPicker1;
    }
}