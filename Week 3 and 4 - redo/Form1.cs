using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;

namespace Week_3_and_4___redo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Mobile_Label_Click(object sender, EventArgs e)
        {

        }

        private void MeetingWith_ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MeetingAim_Btn_Click(object sender, EventArgs e)
        {
            Form2 meetingAim = new Form2();
            meetingAim.ShowDialog();
            if (meetingAim.ShowDialog() == DialogResult.OK)
            {
                if (meetingAim.Meeting_RB.Checked == true)
                {
                    MeetingAim_Btn.Text = meetingAim.Meeting_RB.Text;
                }
                else if (meetingAim.SalesAppointment_RB.Checked == true)
                {
                    MeetingAim_Btn.Text = meetingAim.SalesAppointment_RB.Text;
                }
                else if (meetingAim.SiteVisit_RB.Checked == true)
                {
                    MeetingAim_Btn.Text = meetingAim.SiteVisit_RB.Text;
                }
                else if (meetingAim.StudentInterview_RB.Checked == true)
                {
                    MeetingAim_Btn.Text = meetingAim.StudentInterview_RB.Text;
                }
            }
            else if (meetingAim.DialogResult == DialogResult.Cancel)
            {
                MeetingAim_Btn.Text = ("");
            }
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            if (Name_TB.Text == "" || Surname_TB.Text == "" || Mobile_TB.Text == "" || Email_TB.Text == "" || Date_Box.Value == null || TimeHours_NumericUpDown.Text == "" || TimeMinutes_NumericUpDown.Text == "" || MeetingWith_ComboBox.SelectedItem == null || MeetingAim_Btn.Text == "")
            {
                MessageBox.Show("Please fill in all fields", "Error");
            }
            else if (!Regex.IsMatch(Mobile_TB.Text, @"^\d{9,11}$"))
            {
                MessageBox.Show("Please enter a valid mobile number", "Error");
            }
            else if (!Regex.IsMatch(Email_TB.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$"))
            {
                MessageBox.Show("Please enter a valid email address", "Error");
            }
            else
            {
                string fullName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Name_TB.Text + " " + Surname_TB.Text);
                Visitor_LB.Items.Add("Name: " + fullName);
                Visitor_LB.Items.Add("Mobile: " + Mobile_TB.Text);
                Visitor_LB.Items.Add("Email: " + Email_TB.Text);
                Visitor_LB.Items.Add("Meeting at: " + TimeHours_NumericUpDown.Value + ":" + TimeMinutes_NumericUpDown.Value);
                Visitor_LB.Items.Add("Meeting with: " + MeetingWith_ComboBox.Text);
                Visitor_LB.Items.Add("Meeting Aim: " + MeetingAim_Btn.Text);
                string line = new string('*', 40);
                Visitor_LB.Items.Add(line);

                ClearAllFields();
            }
        }

        private void ClearAllFields()
        {
            Name_TB.Text = "";
            Surname_TB.Text = "";
            Mobile_TB.Text = "";
            Email_TB.Text = "";
            Date_Box.Value = DateTime.Now;
            TimeHours_NumericUpDown.Value = 0;
            TimeMinutes_NumericUpDown.Value = 0;
            MeetingWith_ComboBox.Text = "- - - Please Choose - - -";
            MeetingAim_Btn.Text = "Meeting aim";
            Name_TB.Focus();
        }

        private void Visitor_LB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cancel_Btn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void RemoveVisitor_Btn_Click(object sender, EventArgs e)
        {
            if (Visitor_LB.SelectedItems.Count > 0)
            {
                Visitor_LB.Items.RemoveAt(Visitor_LB.SelectedIndex);
            }
            else
            {
                MessageBox.Show("There are no lines of information selected to delete", "Error");
            }
        }
    }
}
