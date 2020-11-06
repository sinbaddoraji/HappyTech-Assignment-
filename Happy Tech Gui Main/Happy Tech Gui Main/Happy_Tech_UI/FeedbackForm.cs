using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
                textBox1.Text = "Congratulation your application was Successful ";
                textBox1.Refresh();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox1.Text = "Sorry your application was Unsuccessful ";
                textBox1.Refresh();
            }
        }

        private void Templates_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
