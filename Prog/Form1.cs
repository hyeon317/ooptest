using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (q3_b1.Checked)
            {
                if ((q1_b1.Checked == true || q1_b2.Checked == true || q1_b3.Checked == true || q1_b4.Checked == true)
                    && (q2_b1.Checked == true || q2_b2.Checked == true || q2_b3.Checked == true || q2_b4.Checked == true || q2_b5.Checked == true
                    || q2_b6.Checked == true || q2_b7.Checked == true))
                {
                    this.Visible = false;
                    Form4 showForm4 = new Form4();
                    showForm4.ShowDialog();
                }
                else
                {
                    MessageBox.Show("답하지 않은 문항이 있습니다. \n모든 문항에 응답해주세요.");
                }
            }
            else if (q4_b1.Checked)
            {
                if ((q1_b1.Checked == true || q1_b2.Checked == true || q1_b3.Checked == true || q1_b4.Checked == true)
                    && (q2_b1.Checked == true || q2_b2.Checked == true || q2_b3.Checked == true || q2_b4.Checked == true || q2_b5.Checked == true
                    || q2_b6.Checked == true || q2_b7.Checked == true)
                    && (q3_b2.Checked == true)
                    && (q4_b1.Checked == true))
                {
                    this.Visible = false;
                    Form2 showForm2 = new Form2();
                    showForm2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("답하지 않은 문항이 있습니다. \n모든 문항에 응답해주세요.");
                }
            }
            else
            {
                if ((q1_b1.Checked == true || q1_b2.Checked == true || q1_b3.Checked == true || q1_b4.Checked == true)
                    && (q2_b1.Checked == true || q2_b2.Checked == true || q2_b3.Checked == true || q2_b4.Checked == true || q2_b5.Checked == true
                    || q2_b6.Checked == true || q2_b7.Checked == true)
                    && (q3_b2.Checked == true)
                    && (q4_b2.Checked == true))
                {
                    this.Visible = false;
                    Form3 showForm3 = new Form3();
                    showForm3.ShowDialog();
                }
                else
                {
                    MessageBox.Show("답하지 않은 문항이 있습니다. \n모든 문항에 응답해주세요.");
                }
            };
        }

        private void q3_b2_CheckedChanged(object sender, EventArgs e)
        {
            panel8.Show();
            q4.Show();
            q4_b1.Show();
            q4_b2.Show();
        }

        private void q3_b1_CheckedChanged(object sender, EventArgs e)
        {
            panel8.Visible = false;
            q4.Visible = false;
            q4_b1.Visible = false;
            q4_b2.Visible = false;
        }
    }
}
