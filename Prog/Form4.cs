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
        public Form4()
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
            if (MessageBox.Show("설문의 마지막 문항입니다\n" + "설문을 마치시겠습니까?", "종료", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Visible = false;
                Form5 showForm5 = new Form5();
                showForm5.ShowDialog();
            }
        }

        private void q1_b6_CheckedChanged(object sender, EventArgs e)
        {
            q1_b6_text.Show();
        }
    }
}
