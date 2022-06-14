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
    public partial class Form4 : Form
    {
        bool close_by_button = false;
        public Form4()
        {
            InitializeComponent();
            FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close_by_button == false)
                Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            close_by_button = true;
            this.Close();
        }

        private void next_Click(object sender, EventArgs e)
        {
            var etc_checked = q1_b6.Checked == true && q1_b6_text.Text.Length != 0;
            if (etc_checked && (q1_b1.Checked == true || q1_b2.Checked == true || q1_b3.Checked == true || q1_b4.Checked == true || q1_b5.Checked == true || etc_checked)
                && (q2_b1.Checked == true || q2_b2.Checked == true || q2_b3.Checked == true || q2_b4.Checked == true || q2_b5.Checked == true)
                && (q3_b1.Checked == true || q3_b2.Checked == true || q3_b3.Checked == true || q3_b4.Checked == true || q3_b5.Checked == true)
                && (q4_text.Text.Length != 0))
            {
                if (MessageBox.Show("설문의 마지막 문항입니다\n" + "설문을 마치시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Visible = false;
                    Form5 showForm5 = new Form5();
                    showForm5.ShowDialog();
                }

            }
            else
                MessageBox.Show("답하지 않은 문항이 있습니다. \n모든 문항에 응답해주세요.");
        }

            private void q1_b6_CheckedChanged(object sender, EventArgs e)
        {
            if ((q1_b6.Checked) == true)
                q1_b6_text.Show();
            else
                q1_b6_text.Visible = false;
        }
    }
}
