namespace lab3_5
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
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.ok_btn = new System.Windows.Forms.Button();
            this.help_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.work_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.men_radio = new System.Windows.Forms.RadioButton();
            this.women_radio = new System.Windows.Forms.RadioButton();
            this.age_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.result_text = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_textBox
            // 
            this.name_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_textBox.Location = new System.Drawing.Point(137, 12);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(330, 31);
            this.name_textBox.TabIndex = 0;
            this.name_textBox.TextChanged += new System.EventHandler(this.name_textBox_TextChanged);
            // 
            // adress_textBox
            // 
            this.adress_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adress_textBox.Location = new System.Drawing.Point(137, 49);
            this.adress_textBox.Multiline = true;
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(330, 158);
            this.adress_textBox.TabIndex = 1;
            this.adress_textBox.TextChanged += new System.EventHandler(this.adress_textBox_TextChanged);
            // 
            // ok_btn
            // 
            this.ok_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ok_btn.Location = new System.Drawing.Point(503, 12);
            this.ok_btn.Name = "ok_btn";
            this.ok_btn.Size = new System.Drawing.Size(100, 31);
            this.ok_btn.TabIndex = 2;
            this.ok_btn.Text = "OK";
            this.ok_btn.UseVisualStyleBackColor = true;
            this.ok_btn.Click += new System.EventHandler(this.ok_btn_Click);
            // 
            // help_btn
            // 
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.help_btn.Location = new System.Drawing.Point(503, 49);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(100, 31);
            this.help_btn.TabIndex = 3;
            this.help_btn.Text = "Help";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес";
            // 
            // work_checkBox
            // 
            this.work_checkBox.AutoSize = true;
            this.work_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.work_checkBox.Location = new System.Drawing.Point(16, 230);
            this.work_checkBox.Name = "work_checkBox";
            this.work_checkBox.Size = new System.Drawing.Size(151, 28);
            this.work_checkBox.TabIndex = 6;
            this.work_checkBox.Text = "Программист";
            this.work_checkBox.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.men_radio);
            this.groupBox1.Controls.Add(this.women_radio);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(16, 264);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 69);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Пол";
            // 
            // men_radio
            // 
            this.men_radio.AutoSize = true;
            this.men_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.men_radio.Location = new System.Drawing.Point(184, 28);
            this.men_radio.Name = "men_radio";
            this.men_radio.Size = new System.Drawing.Size(108, 28);
            this.men_radio.TabIndex = 1;
            this.men_radio.TabStop = true;
            this.men_radio.Text = "Мужской";
            this.men_radio.UseVisualStyleBackColor = true;
            this.men_radio.CheckedChanged += new System.EventHandler(this.men_radio_CheckedChanged);
            // 
            // women_radio
            // 
            this.women_radio.AutoSize = true;
            this.women_radio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.women_radio.Location = new System.Drawing.Point(21, 28);
            this.women_radio.Name = "women_radio";
            this.women_radio.Size = new System.Drawing.Size(107, 28);
            this.women_radio.TabIndex = 0;
            this.women_radio.TabStop = true;
            this.women_radio.Text = "Женский";
            this.women_radio.UseVisualStyleBackColor = true;
            this.women_radio.CheckedChanged += new System.EventHandler(this.women_radio_CheckedChanged);
            // 
            // age_textBox
            // 
            this.age_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.age_textBox.Location = new System.Drawing.Point(151, 358);
            this.age_textBox.Name = "age_textBox";
            this.age_textBox.Size = new System.Drawing.Size(182, 31);
            this.age_textBox.TabIndex = 8;
            this.age_textBox.TextChanged += new System.EventHandler(this.age_textBox_TextChanged);
            this.age_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_textBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 362);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Возраст";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Результат";
            // 
            // result_text
            // 
            this.result_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.result_text.Location = new System.Drawing.Point(16, 424);
            this.result_text.Multiline = true;
            this.result_text.Name = "result_text";
            this.result_text.ReadOnly = true;
            this.result_text.Size = new System.Drawing.Size(372, 196);
            this.result_text.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 632);
            this.Controls.Add(this.result_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.age_textBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.work_checkBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.help_btn);
            this.Controls.Add(this.ok_btn);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.name_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.Button ok_btn;
        private System.Windows.Forms.Button help_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox work_checkBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton men_radio;
        private System.Windows.Forms.RadioButton women_radio;
        private System.Windows.Forms.TextBox age_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox result_text;
    }
}

