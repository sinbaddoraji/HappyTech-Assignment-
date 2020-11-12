using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Happy_Tech_UI
{
    public partial class FeedbackForm : Form
    {

        public FeedbackForm()
        {
            InitializeComponent();
        }

        private void EntrName_TextChanged(object sender, EventArgs e)
        {

        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                FeedbackText.Text = "Congratulation your application was Successful ";
                FeedbackText.Refresh();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                FeedbackText.Text = "Sorry your application was Unsuccessful ";
                FeedbackText.Refresh();
            }
        }

        private void Templates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FeedbackForm_Load(object sender, EventArgs e)
        {

        }

        private void SendFeedback_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=USER; Initial Catalog=admin; Integrated Security=True"); // making connection 
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into Feedback(Applicant_ID, User_ID, Feedback_Header, Comments) values ('" + RecipientOfFeedback.Text + "', '" + Interviewer.Text + "', '" + FeedbackTopic.Text + "', '" + FeedbackText.Text + "')", con); //inserting feedback-form values to the database

            //if some value is added (not equal to zero), then shows 'Email Send' and sends email
            int i = cmd.ExecuteNonQuery();
            if (i != 0)
            {
                MessageBox.Show("Email Sent");
            }
            else
            {
                MessageBox.Show("Please complete the form");
            }
        }

        private void FeedbackTopic_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FeedbackTopic_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
