namespace Week_3_and_4___redo
{
    partial class Form1
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
            this.Visitor_GB = new System.Windows.Forms.GroupBox();
            this.Email_TB = new System.Windows.Forms.TextBox();
            this.Email_Label = new System.Windows.Forms.Label();
            this.Mobile_TB = new System.Windows.Forms.TextBox();
            this.Mobile_Label = new System.Windows.Forms.Label();
            this.Surname_TB = new System.Windows.Forms.TextBox();
            this.Surname_Label = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Name_Label = new System.Windows.Forms.Label();
            this.Meeting_GB = new System.Windows.Forms.GroupBox();
            this.MeetingAim_Btn = new System.Windows.Forms.Button();
            this.MeetingAim_Label = new System.Windows.Forms.Label();
            this.MeetingWith_ComboBox = new System.Windows.Forms.ComboBox();
            this.MeetingWith_Label = new System.Windows.Forms.Label();
            this.TimeHours_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.TimeMinutes_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Time_Label = new System.Windows.Forms.Label();
            this.Date_Box = new System.Windows.Forms.DateTimePicker();
            this.Date_Label = new System.Windows.Forms.Label();
            this.Visitor_LB = new System.Windows.Forms.ListBox();
            this.VisitorOnSite_Label = new System.Windows.Forms.Label();
            this.SignIn_Btn = new System.Windows.Forms.Button();
            this.RemoveVisitor_Btn = new System.Windows.Forms.Button();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.Visitor_GB.SuspendLayout();
            this.Meeting_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHours_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinutes_NumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // Visitor_GB
            // 
            this.Visitor_GB.Controls.Add(this.Email_TB);
            this.Visitor_GB.Controls.Add(this.Email_Label);
            this.Visitor_GB.Controls.Add(this.Mobile_TB);
            this.Visitor_GB.Controls.Add(this.Mobile_Label);
            this.Visitor_GB.Controls.Add(this.Surname_TB);
            this.Visitor_GB.Controls.Add(this.Surname_Label);
            this.Visitor_GB.Controls.Add(this.Name_TB);
            this.Visitor_GB.Controls.Add(this.Name_Label);
            this.Visitor_GB.Location = new System.Drawing.Point(12, 38);
            this.Visitor_GB.Name = "Visitor_GB";
            this.Visitor_GB.Size = new System.Drawing.Size(318, 374);
            this.Visitor_GB.TabIndex = 0;
            this.Visitor_GB.TabStop = false;
            this.Visitor_GB.Text = "Visitor Details";
            // 
            // Email_TB
            // 
            this.Email_TB.Location = new System.Drawing.Point(6, 301);
            this.Email_TB.Name = "Email_TB";
            this.Email_TB.Size = new System.Drawing.Size(295, 20);
            this.Email_TB.TabIndex = 7;
            // 
            // Email_Label
            // 
            this.Email_Label.AutoSize = true;
            this.Email_Label.Location = new System.Drawing.Point(6, 285);
            this.Email_Label.Name = "Email_Label";
            this.Email_Label.Size = new System.Drawing.Size(32, 13);
            this.Email_Label.TabIndex = 6;
            this.Email_Label.Text = "Email";
            // 
            // Mobile_TB
            // 
            this.Mobile_TB.Location = new System.Drawing.Point(6, 217);
            this.Mobile_TB.Name = "Mobile_TB";
            this.Mobile_TB.Size = new System.Drawing.Size(295, 20);
            this.Mobile_TB.TabIndex = 5;
            // 
            // Mobile_Label
            // 
            this.Mobile_Label.AutoSize = true;
            this.Mobile_Label.Location = new System.Drawing.Point(7, 201);
            this.Mobile_Label.Name = "Mobile_Label";
            this.Mobile_Label.Size = new System.Drawing.Size(38, 13);
            this.Mobile_Label.TabIndex = 4;
            this.Mobile_Label.Text = "Mobile";
            this.Mobile_Label.Click += new System.EventHandler(this.Mobile_Label_Click);
            // 
            // Surname_TB
            // 
            this.Surname_TB.Location = new System.Drawing.Point(6, 135);
            this.Surname_TB.Name = "Surname_TB";
            this.Surname_TB.Size = new System.Drawing.Size(295, 20);
            this.Surname_TB.TabIndex = 3;
            // 
            // Surname_Label
            // 
            this.Surname_Label.AutoSize = true;
            this.Surname_Label.Location = new System.Drawing.Point(7, 119);
            this.Surname_Label.Name = "Surname_Label";
            this.Surname_Label.Size = new System.Drawing.Size(49, 13);
            this.Surname_Label.TabIndex = 2;
            this.Surname_Label.Text = "Surname";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(6, 55);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(295, 20);
            this.Name_TB.TabIndex = 1;
            // 
            // Name_Label
            // 
            this.Name_Label.AutoSize = true;
            this.Name_Label.Location = new System.Drawing.Point(7, 39);
            this.Name_Label.Name = "Name_Label";
            this.Name_Label.Size = new System.Drawing.Size(35, 13);
            this.Name_Label.TabIndex = 0;
            this.Name_Label.Text = "Name";
            // 
            // Meeting_GB
            // 
            this.Meeting_GB.Controls.Add(this.MeetingAim_Btn);
            this.Meeting_GB.Controls.Add(this.MeetingAim_Label);
            this.Meeting_GB.Controls.Add(this.MeetingWith_ComboBox);
            this.Meeting_GB.Controls.Add(this.MeetingWith_Label);
            this.Meeting_GB.Controls.Add(this.TimeHours_NumericUpDown);
            this.Meeting_GB.Controls.Add(this.TimeMinutes_NumericUpDown);
            this.Meeting_GB.Controls.Add(this.Time_Label);
            this.Meeting_GB.Controls.Add(this.Date_Box);
            this.Meeting_GB.Controls.Add(this.Date_Label);
            this.Meeting_GB.Location = new System.Drawing.Point(336, 38);
            this.Meeting_GB.Name = "Meeting_GB";
            this.Meeting_GB.Size = new System.Drawing.Size(318, 374);
            this.Meeting_GB.TabIndex = 1;
            this.Meeting_GB.TabStop = false;
            this.Meeting_GB.Text = "Meeting Details";
            // 
            // MeetingAim_Btn
            // 
            this.MeetingAim_Btn.Location = new System.Drawing.Point(7, 302);
            this.MeetingAim_Btn.Name = "MeetingAim_Btn";
            this.MeetingAim_Btn.Size = new System.Drawing.Size(294, 23);
            this.MeetingAim_Btn.TabIndex = 9;
            this.MeetingAim_Btn.Text = "Meeting aim";
            this.MeetingAim_Btn.UseVisualStyleBackColor = true;
            this.MeetingAim_Btn.Click += new System.EventHandler(this.MeetingAim_Btn_Click);
            // 
            // MeetingAim_Label
            // 
            this.MeetingAim_Label.AutoSize = true;
            this.MeetingAim_Label.Location = new System.Drawing.Point(10, 285);
            this.MeetingAim_Label.Name = "MeetingAim_Label";
            this.MeetingAim_Label.Size = new System.Drawing.Size(65, 13);
            this.MeetingAim_Label.TabIndex = 8;
            this.MeetingAim_Label.Text = "Meeting Aim";
            // 
            // MeetingWith_ComboBox
            // 
            this.MeetingWith_ComboBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MeetingWith_ComboBox.FormattingEnabled = true;
            this.MeetingWith_ComboBox.Items.AddRange(new object[] {
            "Conor McGregor",
            "Ronda Rousey",
            "Israel Adesanya",
            "Khabib Nurmagomedov",
            "Alex Pereira"});
            this.MeetingWith_ComboBox.Location = new System.Drawing.Point(7, 218);
            this.MeetingWith_ComboBox.Name = "MeetingWith_ComboBox";
            this.MeetingWith_ComboBox.Size = new System.Drawing.Size(294, 21);
            this.MeetingWith_ComboBox.TabIndex = 7;
            this.MeetingWith_ComboBox.Text = "- - - Please Choose - - -";
            this.MeetingWith_ComboBox.SelectedIndexChanged += new System.EventHandler(this.MeetingWith_ComboBox_SelectedIndexChanged);
            // 
            // MeetingWith_Label
            // 
            this.MeetingWith_Label.AutoSize = true;
            this.MeetingWith_Label.Location = new System.Drawing.Point(7, 201);
            this.MeetingWith_Label.Name = "MeetingWith_Label";
            this.MeetingWith_Label.Size = new System.Drawing.Size(70, 13);
            this.MeetingWith_Label.TabIndex = 6;
            this.MeetingWith_Label.Text = "Meeting With";
            // 
            // TimeHours_NumericUpDown
            // 
            this.TimeHours_NumericUpDown.Location = new System.Drawing.Point(6, 135);
            this.TimeHours_NumericUpDown.Name = "TimeHours_NumericUpDown";
            this.TimeHours_NumericUpDown.Size = new System.Drawing.Size(141, 20);
            this.TimeHours_NumericUpDown.TabIndex = 5;
            // 
            // TimeMinutes_NumericUpDown
            // 
            this.TimeMinutes_NumericUpDown.Location = new System.Drawing.Point(160, 136);
            this.TimeMinutes_NumericUpDown.Name = "TimeMinutes_NumericUpDown";
            this.TimeMinutes_NumericUpDown.Size = new System.Drawing.Size(141, 20);
            this.TimeMinutes_NumericUpDown.TabIndex = 4;
            // 
            // Time_Label
            // 
            this.Time_Label.AutoSize = true;
            this.Time_Label.Location = new System.Drawing.Point(7, 119);
            this.Time_Label.Name = "Time_Label";
            this.Time_Label.Size = new System.Drawing.Size(30, 13);
            this.Time_Label.TabIndex = 2;
            this.Time_Label.Text = "Time";
            // 
            // Date_Box
            // 
            this.Date_Box.Location = new System.Drawing.Point(6, 55);
            this.Date_Box.Name = "Date_Box";
            this.Date_Box.Size = new System.Drawing.Size(295, 20);
            this.Date_Box.TabIndex = 1;
            // 
            // Date_Label
            // 
            this.Date_Label.AutoSize = true;
            this.Date_Label.Location = new System.Drawing.Point(7, 39);
            this.Date_Label.Name = "Date_Label";
            this.Date_Label.Size = new System.Drawing.Size(30, 13);
            this.Date_Label.TabIndex = 0;
            this.Date_Label.Text = "Date";
            // 
            // Visitor_LB
            // 
            this.Visitor_LB.FormattingEnabled = true;
            this.Visitor_LB.Location = new System.Drawing.Point(661, 64);
            this.Visitor_LB.Name = "Visitor_LB";
            this.Visitor_LB.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Visitor_LB.Size = new System.Drawing.Size(261, 485);
            this.Visitor_LB.TabIndex = 2;
            this.Visitor_LB.SelectedIndexChanged += new System.EventHandler(this.Visitor_LB_SelectedIndexChanged);
            // 
            // VisitorOnSite_Label
            // 
            this.VisitorOnSite_Label.AutoSize = true;
            this.VisitorOnSite_Label.Location = new System.Drawing.Point(660, 38);
            this.VisitorOnSite_Label.Name = "VisitorOnSite_Label";
            this.VisitorOnSite_Label.Size = new System.Drawing.Size(69, 13);
            this.VisitorOnSite_Label.TabIndex = 3;
            this.VisitorOnSite_Label.Text = "Visitor on-site";
            // 
            // SignIn_Btn
            // 
            this.SignIn_Btn.Location = new System.Drawing.Point(12, 419);
            this.SignIn_Btn.Name = "SignIn_Btn";
            this.SignIn_Btn.Size = new System.Drawing.Size(318, 130);
            this.SignIn_Btn.TabIndex = 4;
            this.SignIn_Btn.Text = "Sign In";
            this.SignIn_Btn.UseVisualStyleBackColor = true;
            this.SignIn_Btn.Click += new System.EventHandler(this.SignIn_Btn_Click);
            // 
            // RemoveVisitor_Btn
            // 
            this.RemoveVisitor_Btn.Location = new System.Drawing.Point(672, 496);
            this.RemoveVisitor_Btn.Name = "RemoveVisitor_Btn";
            this.RemoveVisitor_Btn.Size = new System.Drawing.Size(237, 43);
            this.RemoveVisitor_Btn.TabIndex = 6;
            this.RemoveVisitor_Btn.Text = "Remove Visitor";
            this.RemoveVisitor_Btn.UseVisualStyleBackColor = true;
            this.RemoveVisitor_Btn.Click += new System.EventHandler(this.RemoveVisitor_Btn_Click);
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(336, 419);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(318, 130);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 569);
            this.Controls.Add(this.RemoveVisitor_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.SignIn_Btn);
            this.Controls.Add(this.VisitorOnSite_Label);
            this.Controls.Add(this.Visitor_LB);
            this.Controls.Add(this.Meeting_GB);
            this.Controls.Add(this.Visitor_GB);
            this.Name = "Form1";
            this.Text = "Visitor Registration";
            this.Visitor_GB.ResumeLayout(false);
            this.Visitor_GB.PerformLayout();
            this.Meeting_GB.ResumeLayout(false);
            this.Meeting_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeHours_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeMinutes_NumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Visitor_GB;
        private System.Windows.Forms.GroupBox Meeting_GB;
        private System.Windows.Forms.ListBox Visitor_LB;
        private System.Windows.Forms.Label VisitorOnSite_Label;
        private System.Windows.Forms.Label Email_Label;
        private System.Windows.Forms.Label Mobile_Label;
        private System.Windows.Forms.TextBox Surname_TB;
        private System.Windows.Forms.Label Surname_Label;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Name_Label;
        private System.Windows.Forms.Button SignIn_Btn;
        private System.Windows.Forms.Button RemoveVisitor_Btn;
        private System.Windows.Forms.TextBox Email_TB;
        private System.Windows.Forms.TextBox Mobile_TB;
        private System.Windows.Forms.Button MeetingAim_Btn;
        private System.Windows.Forms.Label MeetingAim_Label;
        private System.Windows.Forms.ComboBox MeetingWith_ComboBox;
        private System.Windows.Forms.Label MeetingWith_Label;
        private System.Windows.Forms.NumericUpDown TimeHours_NumericUpDown;
        private System.Windows.Forms.NumericUpDown TimeMinutes_NumericUpDown;
        private System.Windows.Forms.Label Time_Label;
        private System.Windows.Forms.DateTimePicker Date_Box;
        private System.Windows.Forms.Label Date_Label;
        private System.Windows.Forms.Button Cancel_Btn;
    }
}

