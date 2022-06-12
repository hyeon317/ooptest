namespace Prog
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.title_base = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.q1_b4 = new System.Windows.Forms.RadioButton();
            this.q1_b3 = new System.Windows.Forms.RadioButton();
            this.q1_b2 = new System.Windows.Forms.RadioButton();
            this.q1_b1 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.line = new System.Windows.Forms.Panel();
            this.notice = new System.Windows.Forms.Panel();
            this.text_notice = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.q2_b1 = new System.Windows.Forms.RadioButton();
            this.q2_b2 = new System.Windows.Forms.RadioButton();
            this.q2_b3 = new System.Windows.Forms.RadioButton();
            this.q2_b4 = new System.Windows.Forms.RadioButton();
            this.q2_b5 = new System.Windows.Forms.RadioButton();
            this.q2_b6 = new System.Windows.Forms.RadioButton();
            this.q2_b7 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.q3_b1 = new System.Windows.Forms.RadioButton();
            this.q3_b2 = new System.Windows.Forms.RadioButton();
            this.next = new System.Windows.Forms.Button();
            this.title_base.SuspendLayout();
            this.panel1.SuspendLayout();
            this.notice.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_base
            // 
            this.title_base.BackColor = System.Drawing.Color.LightSteelBlue;
            this.title_base.Controls.Add(this.label1);
            this.title_base.Dock = System.Windows.Forms.DockStyle.Top;
            this.title_base.Location = new System.Drawing.Point(0, 0);
            this.title_base.Name = "title_base";
            this.title_base.Size = new System.Drawing.Size(424, 56);
            this.title_base.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼모음T", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(82, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "대학생들의 휴학과 학업만족도";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.next);
            this.panel1.Controls.Add(this.q3_b2);
            this.panel1.Controls.Add(this.q3_b1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.q2_b7);
            this.panel1.Controls.Add(this.q2_b6);
            this.panel1.Controls.Add(this.q2_b5);
            this.panel1.Controls.Add(this.q2_b4);
            this.panel1.Controls.Add(this.q2_b3);
            this.panel1.Controls.Add(this.q2_b2);
            this.panel1.Controls.Add(this.q2_b1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.q1_b4);
            this.panel1.Controls.Add(this.q1_b3);
            this.panel1.Controls.Add(this.q1_b2);
            this.panel1.Controls.Add(this.q1_b1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.line);
            this.panel1.Controls.Add(this.notice);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(424, 379);
            this.panel1.TabIndex = 1;
            // 
            // q1_b4
            // 
            this.q1_b4.AutoSize = true;
            this.q1_b4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q1_b4.Location = new System.Drawing.Point(198, 228);
            this.q1_b4.Name = "q1_b4";
            this.q1_b4.Size = new System.Drawing.Size(56, 19);
            this.q1_b4.TabIndex = 5;
            this.q1_b4.TabStop = true;
            this.q1_b4.Text = "4학년";
            this.q1_b4.UseVisualStyleBackColor = true;
            // 
            // q1_b3
            // 
            this.q1_b3.AutoSize = true;
            this.q1_b3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q1_b3.Location = new System.Drawing.Point(136, 228);
            this.q1_b3.Name = "q1_b3";
            this.q1_b3.Size = new System.Drawing.Size(56, 19);
            this.q1_b3.TabIndex = 4;
            this.q1_b3.TabStop = true;
            this.q1_b3.Text = "3학년";
            this.q1_b3.UseVisualStyleBackColor = true;
            // 
            // q1_b2
            // 
            this.q1_b2.AutoSize = true;
            this.q1_b2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q1_b2.Location = new System.Drawing.Point(74, 228);
            this.q1_b2.Name = "q1_b2";
            this.q1_b2.Size = new System.Drawing.Size(56, 19);
            this.q1_b2.TabIndex = 3;
            this.q1_b2.TabStop = true;
            this.q1_b2.Text = "2학년";
            this.q1_b2.UseVisualStyleBackColor = true;
            // 
            // q1_b1
            // 
            this.q1_b1.AutoSize = true;
            this.q1_b1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q1_b1.Location = new System.Drawing.Point(12, 228);
            this.q1_b1.Name = "q1_b1";
            this.q1_b1.Size = new System.Drawing.Size(56, 19);
            this.q1_b1.TabIndex = 2;
            this.q1_b1.TabStop = true;
            this.q1_b1.Text = "1학년";
            this.q1_b1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(9, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "귀하의 학년을 선택해주세요 ( 현재 재학중인 학년을 선택해주시면 됩니다 )";
            // 
            // line
            // 
            this.line.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line.Location = new System.Drawing.Point(12, 206);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(400, 1);
            this.line.TabIndex = 1;
            // 
            // notice
            // 
            this.notice.BackColor = System.Drawing.SystemColors.ControlDark;
            this.notice.Controls.Add(this.text_notice);
            this.notice.Dock = System.Windows.Forms.DockStyle.Top;
            this.notice.Location = new System.Drawing.Point(0, 0);
            this.notice.Name = "notice";
            this.notice.Size = new System.Drawing.Size(424, 200);
            this.notice.TabIndex = 0;
            // 
            // text_notice
            // 
            this.text_notice.AutoSize = true;
            this.text_notice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.text_notice.Font = new System.Drawing.Font("맑은 고딕", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.text_notice.Location = new System.Drawing.Point(0, 0);
            this.text_notice.Name = "text_notice";
            this.text_notice.Size = new System.Drawing.Size(425, 195);
            this.text_notice.TabIndex = 0;
            this.text_notice.Text = resources.GetString("text_notice.Text");
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(12, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 1);
            this.panel2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(9, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "귀하의 학번을 선택해주세요";
            // 
            // q2_b1
            // 
            this.q2_b1.AutoSize = true;
            this.q2_b1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b1.Location = new System.Drawing.Point(174, 257);
            this.q2_b1.Name = "q2_b1";
            this.q2_b1.Size = new System.Drawing.Size(63, 19);
            this.q2_b1.TabIndex = 7;
            this.q2_b1.TabStop = true;
            this.q2_b1.Text = "22학번";
            this.q2_b1.UseVisualStyleBackColor = true;
            // 
            // q2_b2
            // 
            this.q2_b2.AutoSize = true;
            this.q2_b2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b2.Location = new System.Drawing.Point(243, 257);
            this.q2_b2.Name = "q2_b2";
            this.q2_b2.Size = new System.Drawing.Size(63, 19);
            this.q2_b2.TabIndex = 8;
            this.q2_b2.TabStop = true;
            this.q2_b2.Text = "21학번";
            this.q2_b2.UseVisualStyleBackColor = true;
            // 
            // q2_b3
            // 
            this.q2_b3.AutoSize = true;
            this.q2_b3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b3.Location = new System.Drawing.Point(312, 255);
            this.q2_b3.Name = "q2_b3";
            this.q2_b3.Size = new System.Drawing.Size(63, 19);
            this.q2_b3.TabIndex = 9;
            this.q2_b3.TabStop = true;
            this.q2_b3.Text = "20학번";
            this.q2_b3.UseVisualStyleBackColor = true;
            // 
            // q2_b4
            // 
            this.q2_b4.AutoSize = true;
            this.q2_b4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b4.Location = new System.Drawing.Point(12, 275);
            this.q2_b4.Name = "q2_b4";
            this.q2_b4.Size = new System.Drawing.Size(63, 19);
            this.q2_b4.TabIndex = 10;
            this.q2_b4.TabStop = true;
            this.q2_b4.Text = "19학번";
            this.q2_b4.UseVisualStyleBackColor = true;
            // 
            // q2_b5
            // 
            this.q2_b5.AutoSize = true;
            this.q2_b5.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b5.Location = new System.Drawing.Point(81, 275);
            this.q2_b5.Name = "q2_b5";
            this.q2_b5.Size = new System.Drawing.Size(63, 19);
            this.q2_b5.TabIndex = 11;
            this.q2_b5.TabStop = true;
            this.q2_b5.Text = "18학번";
            this.q2_b5.UseVisualStyleBackColor = true;
            // 
            // q2_b6
            // 
            this.q2_b6.AutoSize = true;
            this.q2_b6.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b6.Location = new System.Drawing.Point(150, 275);
            this.q2_b6.Name = "q2_b6";
            this.q2_b6.Size = new System.Drawing.Size(63, 19);
            this.q2_b6.TabIndex = 12;
            this.q2_b6.TabStop = true;
            this.q2_b6.Text = "17학번";
            this.q2_b6.UseVisualStyleBackColor = true;
            // 
            // q2_b7
            // 
            this.q2_b7.AutoSize = true;
            this.q2_b7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q2_b7.Location = new System.Drawing.Point(219, 275);
            this.q2_b7.Name = "q2_b7";
            this.q2_b7.Size = new System.Drawing.Size(75, 19);
            this.q2_b7.TabIndex = 13;
            this.q2_b7.TabStop = true;
            this.q2_b7.Text = "16학번 ~";
            this.q2_b7.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Location = new System.Drawing.Point(12, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 1);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(9, 304);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "귀하는 현재 휴학한 경험이 있습니까?";
            // 
            // q3_b1
            // 
            this.q3_b1.AutoSize = true;
            this.q3_b1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q3_b1.Location = new System.Drawing.Point(12, 322);
            this.q3_b1.Name = "q3_b1";
            this.q3_b1.Size = new System.Drawing.Size(49, 19);
            this.q3_b1.TabIndex = 15;
            this.q3_b1.TabStop = true;
            this.q3_b1.Text = "있다";
            this.q3_b1.UseVisualStyleBackColor = true;
            // 
            // q3_b2
            // 
            this.q3_b2.AutoSize = true;
            this.q3_b2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.q3_b2.Location = new System.Drawing.Point(67, 322);
            this.q3_b2.Name = "q3_b2";
            this.q3_b2.Size = new System.Drawing.Size(49, 19);
            this.q3_b2.TabIndex = 16;
            this.q3_b2.TabStop = true;
            this.q3_b2.Text = "없다";
            this.q3_b2.UseVisualStyleBackColor = true;
            // 
            // next
            // 
            this.next.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.next.Location = new System.Drawing.Point(366, 353);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(54, 23);
            this.next.TabIndex = 17;
            this.next.Text = "다음▷";
            this.next.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 441);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.title_base);
            this.Name = "Form1";
            this.Text = "Form1";
            this.title_base.ResumeLayout(false);
            this.title_base.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.notice.ResumeLayout(false);
            this.notice.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel title_base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel line;
        private System.Windows.Forms.Panel notice;
        private System.Windows.Forms.Label text_notice;
        private System.Windows.Forms.RadioButton q1_b4;
        private System.Windows.Forms.RadioButton q1_b3;
        private System.Windows.Forms.RadioButton q1_b2;
        private System.Windows.Forms.RadioButton q1_b1;
        private System.Windows.Forms.RadioButton q3_b2;
        private System.Windows.Forms.RadioButton q3_b1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton q2_b7;
        private System.Windows.Forms.RadioButton q2_b6;
        private System.Windows.Forms.RadioButton q2_b5;
        private System.Windows.Forms.RadioButton q2_b4;
        private System.Windows.Forms.RadioButton q2_b3;
        private System.Windows.Forms.RadioButton q2_b2;
        private System.Windows.Forms.RadioButton q2_b1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button next;
    }
}

