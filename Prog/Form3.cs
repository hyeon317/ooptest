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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form1 showForm1 = new Form1();
            showForm1.ShowDialog();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if ((q2_b1.Checked == true || q2_b2.Checked == true || q2_b3.Checked == true || q2_b4.Checked == true || q2_b5.Checked == true)
                && (q1_text.Text.Length != 0))
            {
                if (MessageBox.Show("설문의 마지막 문항입니다\n" + "설문을 마치시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Visible = false;
                    Form5 showForm5 = new Form5();
                    showForm5.ShowDialog();
                }
            }
            else
                MessageBox.Show("답하지 않은 문장이 있습니다.\n모든 문항에 응답해주세요.");
        }

    }
}
