using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Misson_0526_Upgrade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 새로열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                DialogResult result = MessageBox.Show(this.Text + "파일의 내용이 변경되었습니다." + Environment.NewLine + Environment.NewLine +
                    "변경된 내용을 저장하시겠습니까?", "메모장", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                switch (result)
                {
                    case DialogResult.Yes:
                        저장ToolStripMenuItem_Click(sender, e);
                        break;
                    case DialogResult.No:
                        this.Text = "제목 없음 - 메모장";
                        break;
                }
            }
            this.Text = "제목없음 - 메모장";
            richTextBox1.Clear();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "텍스트 문서(*.txt) | *.txt | C# 파일(*.cs) | *.cs | All Files(*.*)|";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }
        private void 다른이름으로저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();

            //창 설정
            save.Title = "다른 이름으로 저장";
            save.Filter = "텍스트 문서(*.txt) | *.txt | C# 파일(*.cs) | *.cs | All Files(*.*)|";
            
            if (save.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(save.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine(richTextBox1.Text);

                int position = save.FileName.LastIndexOf("\\");
                string textBoxName = save.FileName.Substring(position + 1);

                this.Text = textBoxName + " -메모장";

                sw.Close();
            }
            else
            {
                //else
            }
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 잘라내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 복사ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 붙여넣기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 뒤로가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 앞으로가기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void 폰트변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = richTextBox1.SelectionFont;
            if (fd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fd.Font;
            }
        }

        private void 배경색변경ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cr = new ColorDialog();
            if (cr.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.BackColor = cr.Color;
            }
        }

        private void 정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Misson 메모장 만들기\n" + "2020875042 이수현", "메모장 정보");
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }
}
