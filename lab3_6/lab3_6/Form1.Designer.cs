namespace lab3_6
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
            this.font_bold_btn = new System.Windows.Forms.Button();
            this.font_underline_btn = new System.Windows.Forms.Button();
            this.font_inclined_btn = new System.Windows.Forms.Button();
            this.center_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.font_size_tbox = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.save_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // font_bold_btn
            // 
            this.font_bold_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font_bold_btn.Location = new System.Drawing.Point(133, 12);
            this.font_bold_btn.Name = "font_bold_btn";
            this.font_bold_btn.Size = new System.Drawing.Size(138, 33);
            this.font_bold_btn.TabIndex = 0;
            this.font_bold_btn.Text = "Полужирный";
            this.font_bold_btn.UseVisualStyleBackColor = true;
            this.font_bold_btn.Click += new System.EventHandler(this.font_bold_btn_Click);
            // 
            // font_underline_btn
            // 
            this.font_underline_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font_underline_btn.Location = new System.Drawing.Point(277, 12);
            this.font_underline_btn.Name = "font_underline_btn";
            this.font_underline_btn.Size = new System.Drawing.Size(156, 33);
            this.font_underline_btn.TabIndex = 1;
            this.font_underline_btn.Text = "Подчеркнутый";
            this.font_underline_btn.UseVisualStyleBackColor = true;
            this.font_underline_btn.Click += new System.EventHandler(this.font_underline_btn_Click);
            // 
            // font_inclined_btn
            // 
            this.font_inclined_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font_inclined_btn.Location = new System.Drawing.Point(439, 12);
            this.font_inclined_btn.Name = "font_inclined_btn";
            this.font_inclined_btn.Size = new System.Drawing.Size(118, 33);
            this.font_inclined_btn.TabIndex = 2;
            this.font_inclined_btn.Text = "Наклонный";
            this.font_inclined_btn.UseVisualStyleBackColor = true;
            this.font_inclined_btn.Click += new System.EventHandler(this.font_inclined_btn_Click);
            // 
            // center_btn
            // 
            this.center_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.center_btn.Location = new System.Drawing.Point(563, 12);
            this.center_btn.Name = "center_btn";
            this.center_btn.Size = new System.Drawing.Size(113, 33);
            this.center_btn.TabIndex = 3;
            this.center_btn.Text = "По центру";
            this.center_btn.UseVisualStyleBackColor = true;
            this.center_btn.Click += new System.EventHandler(this.center_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(273, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Размер";
            // 
            // font_size_tbox
            // 
            this.font_size_tbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.font_size_tbox.Location = new System.Drawing.Point(344, 51);
            this.font_size_tbox.Name = "font_size_tbox";
            this.font_size_tbox.Size = new System.Drawing.Size(121, 26);
            this.font_size_tbox.TabIndex = 5;
            this.font_size_tbox.TextChanged += new System.EventHandler(this.font_size_tbox_TextChanged);
            this.font_size_tbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.font_size_tbox_KeyPress);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 96);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(776, 311);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // open_btn
            // 
            this.open_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.open_btn.Location = new System.Drawing.Point(252, 424);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(138, 33);
            this.open_btn.TabIndex = 7;
            this.open_btn.Text = "Открыть";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // save_btn
            // 
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_btn.Location = new System.Drawing.Point(410, 424);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(138, 33);
            this.save_btn.TabIndex = 8;
            this.save_btn.Text = "Сохранить";
            this.save_btn.UseVisualStyleBackColor = true;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 469);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.font_size_tbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.center_btn);
            this.Controls.Add(this.font_inclined_btn);
            this.Controls.Add(this.font_underline_btn);
            this.Controls.Add(this.font_bold_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button font_bold_btn;
        private System.Windows.Forms.Button font_underline_btn;
        private System.Windows.Forms.Button font_inclined_btn;
        private System.Windows.Forms.Button center_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox font_size_tbox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Button save_btn;
    }
}

