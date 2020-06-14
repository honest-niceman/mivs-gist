namespace MIVS_2_21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_N = new System.Windows.Forms.TextBox();
            this.textBox_Q = new System.Windows.Forms.TextBox();
            this.textBox_P1 = new System.Windows.Forms.TextBox();
            this.textBox_Del = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox_V = new System.Windows.Forms.ListBox();
            this.listBox_X = new System.Windows.Forms.ListBox();
            this.listBox_P = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_avg = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_N
            // 
            this.textBox_N.Location = new System.Drawing.Point(57, 41);
            this.textBox_N.Name = "textBox_N";
            this.textBox_N.Size = new System.Drawing.Size(231, 26);
            this.textBox_N.TabIndex = 0;
            this.textBox_N.Text = "1000";
            this.textBox_N.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Q
            // 
            this.textBox_Q.Location = new System.Drawing.Point(57, 104);
            this.textBox_Q.Name = "textBox_Q";
            this.textBox_Q.Size = new System.Drawing.Size(231, 26);
            this.textBox_Q.TabIndex = 1;
            this.textBox_Q.Text = "7,5";
            this.textBox_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_P1
            // 
            this.textBox_P1.Location = new System.Drawing.Point(57, 167);
            this.textBox_P1.Name = "textBox_P1";
            this.textBox_P1.Size = new System.Drawing.Size(231, 26);
            this.textBox_P1.TabIndex = 2;
            this.textBox_P1.Text = "0,22";
            this.textBox_P1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_Del
            // 
            this.textBox_Del.Location = new System.Drawing.Point(57, 233);
            this.textBox_Del.Name = "textBox_Del";
            this.textBox_Del.Size = new System.Drawing.Size(231, 26);
            this.textBox_Del.TabIndex = 3;
            this.textBox_Del.Text = "11";
            this.textBox_Del.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "N";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Q";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "P1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Del";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 62);
            this.button1.TabIndex = 8;
            this.button1.Text = " Поехали!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox_V
            // 
            this.listBox_V.FormattingEnabled = true;
            this.listBox_V.ItemHeight = 20;
            this.listBox_V.Location = new System.Drawing.Point(308, 40);
            this.listBox_V.Name = "listBox_V";
            this.listBox_V.Size = new System.Drawing.Size(164, 344);
            this.listBox_V.TabIndex = 9;
            // 
            // listBox_X
            // 
            this.listBox_X.FormattingEnabled = true;
            this.listBox_X.ItemHeight = 20;
            this.listBox_X.Location = new System.Drawing.Point(478, 40);
            this.listBox_X.Name = "listBox_X";
            this.listBox_X.Size = new System.Drawing.Size(164, 344);
            this.listBox_X.TabIndex = 10;
            // 
            // listBox_P
            // 
            this.listBox_P.FormattingEnabled = true;
            this.listBox_P.ItemHeight = 20;
            this.listBox_P.Location = new System.Drawing.Point(648, 40);
            this.listBox_P.Name = "listBox_P";
            this.listBox_P.Size = new System.Drawing.Size(164, 344);
            this.listBox_P.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Выборка";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(718, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "P";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Location = new System.Drawing.Point(92, 285);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(0, 20);
            this.label_avg.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(30, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 62);
            this.button2.TabIndex = 16;
            this.button2.Text = "Вариант №1";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(205, 403);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 62);
            this.button3.TabIndex = 17;
            this.button3.Text = "Вариант №2";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(389, 403);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 62);
            this.button4.TabIndex = 18;
            this.button4.Text = "Вариант №3";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(711, 403);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 62);
            this.button5.TabIndex = 19;
            this.button5.Text = "Вариант №5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(559, 403);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(96, 62);
            this.button6.TabIndex = 20;
            this.button6.Text = "Вариант №4";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(845, 491);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label_avg);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox_P);
            this.Controls.Add(this.listBox_X);
            this.Controls.Add(this.listBox_V);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Del);
            this.Controls.Add(this.textBox_P1);
            this.Controls.Add(this.textBox_Q);
            this.Controls.Add(this.textBox_N);
            this.Name = "Form1";
            this.Text = "2_21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_N;
        private System.Windows.Forms.TextBox textBox_Q;
        private System.Windows.Forms.TextBox textBox_P1;
        private System.Windows.Forms.TextBox textBox_Del;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox_V;
        private System.Windows.Forms.ListBox listBox_X;
        private System.Windows.Forms.ListBox listBox_P;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}

