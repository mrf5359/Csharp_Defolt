namespace lab3_4
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
            this.vScrollBar_red = new System.Windows.Forms.VScrollBar();
            this.vScrollBar_green = new System.Windows.Forms.VScrollBar();
            this.vScrollBar_blue = new System.Windows.Forms.VScrollBar();
            this.red_num = new System.Windows.Forms.Label();
            this.green_num = new System.Windows.Forms.Label();
            this.blue_num = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vScrollBar_red
            // 
            this.vScrollBar_red.LargeChange = 1;
            this.vScrollBar_red.Location = new System.Drawing.Point(126, 45);
            this.vScrollBar_red.Maximum = 255;
            this.vScrollBar_red.Name = "vScrollBar_red";
            this.vScrollBar_red.Size = new System.Drawing.Size(43, 353);
            this.vScrollBar_red.TabIndex = 0;
            this.vScrollBar_red.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_red_Scroll);
            // 
            // vScrollBar_green
            // 
            this.vScrollBar_green.LargeChange = 1;
            this.vScrollBar_green.Location = new System.Drawing.Point(359, 45);
            this.vScrollBar_green.Maximum = 255;
            this.vScrollBar_green.Name = "vScrollBar_green";
            this.vScrollBar_green.Size = new System.Drawing.Size(43, 353);
            this.vScrollBar_green.TabIndex = 1;
            this.vScrollBar_green.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_green_Scroll);
            // 
            // vScrollBar_blue
            // 
            this.vScrollBar_blue.LargeChange = 1;
            this.vScrollBar_blue.Location = new System.Drawing.Point(602, 45);
            this.vScrollBar_blue.Maximum = 255;
            this.vScrollBar_blue.Name = "vScrollBar_blue";
            this.vScrollBar_blue.Size = new System.Drawing.Size(43, 353);
            this.vScrollBar_blue.TabIndex = 2;
            this.vScrollBar_blue.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_blue_Scroll);
            // 
            // red_num
            // 
            this.red_num.AutoSize = true;
            this.red_num.BackColor = System.Drawing.Color.White;
            this.red_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.red_num.Location = new System.Drawing.Point(69, 209);
            this.red_num.Name = "red_num";
            this.red_num.Size = new System.Drawing.Size(24, 25);
            this.red_num.TabIndex = 3;
            this.red_num.Text = "0";
            // 
            // green_num
            // 
            this.green_num.AutoSize = true;
            this.green_num.BackColor = System.Drawing.Color.White;
            this.green_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.green_num.Location = new System.Drawing.Point(300, 209);
            this.green_num.Name = "green_num";
            this.green_num.Size = new System.Drawing.Size(24, 25);
            this.green_num.TabIndex = 4;
            this.green_num.Text = "0";
            // 
            // blue_num
            // 
            this.blue_num.AutoSize = true;
            this.blue_num.BackColor = System.Drawing.Color.White;
            this.blue_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.blue_num.Location = new System.Drawing.Point(545, 209);
            this.blue_num.Name = "blue_num";
            this.blue_num.Size = new System.Drawing.Size(24, 25);
            this.blue_num.TabIndex = 5;
            this.blue_num.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(81, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Красный";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(312, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Зеленый";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(585, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Синий";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(774, 513);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blue_num);
            this.Controls.Add(this.green_num);
            this.Controls.Add(this.red_num);
            this.Controls.Add(this.vScrollBar_blue);
            this.Controls.Add(this.vScrollBar_green);
            this.Controls.Add(this.vScrollBar_red);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vScrollBar_red;
        private System.Windows.Forms.VScrollBar vScrollBar_green;
        private System.Windows.Forms.VScrollBar vScrollBar_blue;
        private System.Windows.Forms.Label red_num;
        private System.Windows.Forms.Label green_num;
        private System.Windows.Forms.Label blue_num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

