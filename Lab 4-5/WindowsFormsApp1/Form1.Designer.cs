namespace WindowsFormsApp1
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxFileReadTime = new System.Windows.Forms.TextBox();
            this.textBoxFileReadCount = new System.Windows.Forms.TextBox();
            this.textBoxFind = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxExactTime = new System.Windows.Forms.TextBox();
            this.textBoxMaxDist = new System.Windows.Forms.TextBox();
            this.textBoxThreadCount = new System.Windows.Forms.TextBox();
            this.textBoxThreadCountAll = new System.Windows.Forms.TextBox();
            this.textBoxApproxTime = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "*.txt)|*.txt";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 55);
            this.button1.TabIndex = 0;
            this.button1.Text = "Чтение файла";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFileReadTime
            // 
            this.textBoxFileReadTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadTime.Location = new System.Drawing.Point(427, 12);
            this.textBoxFileReadTime.Name = "textBoxFileReadTime";
            this.textBoxFileReadTime.Size = new System.Drawing.Size(207, 38);
            this.textBoxFileReadTime.TabIndex = 1;
            // 
            // textBoxFileReadCount
            // 
            this.textBoxFileReadCount.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxFileReadCount.Location = new System.Drawing.Point(427, 74);
            this.textBoxFileReadCount.Name = "textBoxFileReadCount";
            this.textBoxFileReadCount.Size = new System.Drawing.Size(207, 38);
            this.textBoxFileReadCount.TabIndex = 2;
            // 
            // textBoxFind
            // 
            this.textBoxFind.Location = new System.Drawing.Point(427, 176);
            this.textBoxFind.Name = "textBoxFind";
            this.textBoxFind.Size = new System.Drawing.Size(207, 38);
            this.textBoxFind.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(676, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 4;
            this.label1.Text = "время чтения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(682, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "уникальные слова";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "слово для поиска";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(25, 329);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(289, 51);
            this.button2.TabIndex = 7;
            this.button2.Text = "Поиск (четкий)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // textBoxExactTime
            // 
            this.textBoxExactTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxExactTime.Location = new System.Drawing.Point(427, 336);
            this.textBoxExactTime.Name = "textBoxExactTime";
            this.textBoxExactTime.Size = new System.Drawing.Size(207, 38);
            this.textBoxExactTime.TabIndex = 8;
            // 
            // textBoxMaxDist
            // 
            this.textBoxMaxDist.Location = new System.Drawing.Point(427, 512);
            this.textBoxMaxDist.Name = "textBoxMaxDist";
            this.textBoxMaxDist.Size = new System.Drawing.Size(207, 38);
            this.textBoxMaxDist.TabIndex = 9;
            // 
            // textBoxThreadCount
            // 
            this.textBoxThreadCount.Location = new System.Drawing.Point(427, 618);
            this.textBoxThreadCount.Name = "textBoxThreadCount";
            this.textBoxThreadCount.Size = new System.Drawing.Size(207, 38);
            this.textBoxThreadCount.TabIndex = 10;
            // 
            // textBoxThreadCountAll
            // 
            this.textBoxThreadCountAll.Location = new System.Drawing.Point(427, 713);
            this.textBoxThreadCountAll.Name = "textBoxThreadCountAll";
            this.textBoxThreadCountAll.Size = new System.Drawing.Size(207, 38);
            this.textBoxThreadCountAll.TabIndex = 11;
            // 
            // textBoxApproxTime
            // 
            this.textBoxApproxTime.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxApproxTime.Location = new System.Drawing.Point(427, 815);
            this.textBoxApproxTime.Name = "textBoxApproxTime";
            this.textBoxApproxTime.Size = new System.Drawing.Size(207, 38);
            this.textBoxApproxTime.TabIndex = 12;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(25, 512);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(289, 114);
            this.button3.TabIndex = 13;
            this.button3.Text = "Поиск (паралельный нечеткий)";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 31;
            this.listBoxResult.Location = new System.Drawing.Point(1072, 12);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(437, 841);
            this.listBoxResult.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(640, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(304, 32);
            this.label5.TabIndex = 16;
            this.label5.Text = "время четкого поиска";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(714, 713);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 32);
            this.label6.TabIndex = 17;
            this.label6.Text = "Макс расстояние";
            //this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(725, 618);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "Кол-во потоков";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(665, 512);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(401, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Вычесленное кол-во потоков";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(791, 815);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "время";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 901);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxApproxTime);
            this.Controls.Add(this.textBoxThreadCountAll);
            this.Controls.Add(this.textBoxThreadCount);
            this.Controls.Add(this.textBoxMaxDist);
            this.Controls.Add(this.textBoxExactTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFind);
            this.Controls.Add(this.textBoxFileReadCount);
            this.Controls.Add(this.textBoxFileReadTime);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxFileReadTime;
        private System.Windows.Forms.TextBox textBoxFileReadCount;
        private System.Windows.Forms.TextBox textBoxFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxExactTime;
        private System.Windows.Forms.TextBox textBoxMaxDist;
        private System.Windows.Forms.TextBox textBoxThreadCount;
        private System.Windows.Forms.TextBox textBoxThreadCountAll;
        private System.Windows.Forms.TextBox textBoxApproxTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

