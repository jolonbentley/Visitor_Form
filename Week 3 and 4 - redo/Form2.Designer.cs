namespace Week_3_and_4___redo
{
    partial class Form2
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
            this.Meeting_RB = new System.Windows.Forms.RadioButton();
            this.SalesAppointment_RB = new System.Windows.Forms.RadioButton();
            this.SiteVisit_RB = new System.Windows.Forms.RadioButton();
            this.StudentInterview_RB = new System.Windows.Forms.RadioButton();
            this.Cancel_Btn = new System.Windows.Forms.Button();
            this.OK_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(5)));
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please specify the nature of the meeting";
            // 
            // Meeting_RB
            // 
            this.Meeting_RB.AutoSize = true;
            this.Meeting_RB.Location = new System.Drawing.Point(103, 127);
            this.Meeting_RB.Name = "Meeting_RB";
            this.Meeting_RB.Size = new System.Drawing.Size(63, 17);
            this.Meeting_RB.TabIndex = 1;
            this.Meeting_RB.TabStop = true;
            this.Meeting_RB.Text = "Meeting";
            this.Meeting_RB.UseVisualStyleBackColor = true;
            // 
            // SalesAppointment_RB
            // 
            this.SalesAppointment_RB.AutoSize = true;
            this.SalesAppointment_RB.Location = new System.Drawing.Point(376, 127);
            this.SalesAppointment_RB.Name = "SalesAppointment_RB";
            this.SalesAppointment_RB.Size = new System.Drawing.Size(113, 17);
            this.SalesAppointment_RB.TabIndex = 2;
            this.SalesAppointment_RB.TabStop = true;
            this.SalesAppointment_RB.Text = "Sales Appointment";
            this.SalesAppointment_RB.UseVisualStyleBackColor = true;
            // 
            // SiteVisit_RB
            // 
            this.SiteVisit_RB.AutoSize = true;
            this.SiteVisit_RB.Location = new System.Drawing.Point(103, 236);
            this.SiteVisit_RB.Name = "SiteVisit_RB";
            this.SiteVisit_RB.Size = new System.Drawing.Size(65, 17);
            this.SiteVisit_RB.TabIndex = 3;
            this.SiteVisit_RB.TabStop = true;
            this.SiteVisit_RB.Text = "Site Visit";
            this.SiteVisit_RB.UseVisualStyleBackColor = true;
            // 
            // StudentInterview_RB
            // 
            this.StudentInterview_RB.AutoSize = true;
            this.StudentInterview_RB.Location = new System.Drawing.Point(376, 236);
            this.StudentInterview_RB.Name = "StudentInterview_RB";
            this.StudentInterview_RB.Size = new System.Drawing.Size(108, 17);
            this.StudentInterview_RB.TabIndex = 4;
            this.StudentInterview_RB.TabStop = true;
            this.StudentInterview_RB.Text = "Student Interview";
            this.StudentInterview_RB.UseVisualStyleBackColor = true;
            // 
            // Cancel_Btn
            // 
            this.Cancel_Btn.Location = new System.Drawing.Point(203, 331);
            this.Cancel_Btn.Name = "Cancel_Btn";
            this.Cancel_Btn.Size = new System.Drawing.Size(162, 34);
            this.Cancel_Btn.TabIndex = 5;
            this.Cancel_Btn.Text = "Cancel";
            this.Cancel_Btn.UseVisualStyleBackColor = true;
            this.Cancel_Btn.Click += new System.EventHandler(this.Cancel_Btn_Click);
            // 
            // OK_Btn
            // 
            this.OK_Btn.Location = new System.Drawing.Point(415, 331);
            this.OK_Btn.Name = "OK_Btn";
            this.OK_Btn.Size = new System.Drawing.Size(162, 34);
            this.OK_Btn.TabIndex = 6;
            this.OK_Btn.Text = "OK";
            this.OK_Btn.UseVisualStyleBackColor = true;
            this.OK_Btn.Click += new System.EventHandler(this.OK_Btn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 406);
            this.Controls.Add(this.OK_Btn);
            this.Controls.Add(this.Cancel_Btn);
            this.Controls.Add(this.StudentInterview_RB);
            this.Controls.Add(this.SiteVisit_RB);
            this.Controls.Add(this.SalesAppointment_RB);
            this.Controls.Add(this.Meeting_RB);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Aim";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RadioButton Meeting_RB;
        public System.Windows.Forms.RadioButton SalesAppointment_RB;
        public System.Windows.Forms.RadioButton SiteVisit_RB;
        public System.Windows.Forms.RadioButton StudentInterview_RB;
        private System.Windows.Forms.Button Cancel_Btn;
        private System.Windows.Forms.Button OK_Btn;
    }
}