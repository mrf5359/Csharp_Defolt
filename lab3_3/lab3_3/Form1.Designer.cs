namespace lab3_3
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.move_to_LIstBox = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.clear_listBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "один",
            "два",
            "три",
            "четыре",
            "пять",
            "шесть",
            "семь",
            "восемь",
            "девять",
            "десять"});
            this.checkedListBox1.Location = new System.Drawing.Point(38, 50);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(199, 342);
            this.checkedListBox1.TabIndex = 0;
            // 
            // move_to_LIstBox
            // 
            this.move_to_LIstBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.move_to_LIstBox.Location = new System.Drawing.Point(270, 170);
            this.move_to_LIstBox.Name = "move_to_LIstBox";
            this.move_to_LIstBox.Size = new System.Drawing.Size(158, 46);
            this.move_to_LIstBox.TabIndex = 1;
            this.move_to_LIstBox.Text = "Переместить";
            this.move_to_LIstBox.UseVisualStyleBackColor = true;
            this.move_to_LIstBox.Click += new System.EventHandler(this.move_to_LIstBox_Click);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(456, 50);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 329);
            this.listBox1.TabIndex = 2;
            // 
            // clear_listBox
            // 
            this.clear_listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clear_listBox.Location = new System.Drawing.Point(509, 412);
            this.clear_listBox.Name = "clear_listBox";
            this.clear_listBox.Size = new System.Drawing.Size(146, 44);
            this.clear_listBox.TabIndex = 3;
            this.clear_listBox.Text = "Отчистить";
            this.clear_listBox.UseVisualStyleBackColor = true;
            this.clear_listBox.Click += new System.EventHandler(this.clear_listBox_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 488);
            this.Controls.Add(this.clear_listBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.move_to_LIstBox);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button move_to_LIstBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button clear_listBox;
    }
}

