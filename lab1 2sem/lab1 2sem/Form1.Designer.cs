namespace lab1_2sem
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
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.educationLevelLabel = new System.Windows.Forms.Label();
            this.examsListBox = new System.Windows.Forms.ListBox();
            this.shortInfoLabel = new System.Windows.Forms.Label();
            this.PersonInfo = new System.Windows.Forms.Button();
            this.ExamInfo = new System.Windows.Forms.Button();
            this.FullInfo = new System.Windows.Forms.Button();
            this.SummaryInfo = new System.Windows.Forms.Button();
            this.ExamName = new System.Windows.Forms.TextBox();
            this.ExamMark = new System.Windows.Forms.TextBox();
            this.ExamDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.AddExam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullNameLabel.Location = new System.Drawing.Point(12, 9);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(51, 55);
            this.fullNameLabel.TabIndex = 0;
            this.fullNameLabel.Text = "1";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthDateLabel.Location = new System.Drawing.Point(12, 73);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(51, 55);
            this.birthDateLabel.TabIndex = 1;
            this.birthDateLabel.Text = "2";
            // 
            // educationLevelLabel
            // 
            this.educationLevelLabel.AutoSize = true;
            this.educationLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.educationLevelLabel.Location = new System.Drawing.Point(12, 137);
            this.educationLevelLabel.Name = "educationLevelLabel";
            this.educationLevelLabel.Size = new System.Drawing.Size(51, 55);
            this.educationLevelLabel.TabIndex = 2;
            this.educationLevelLabel.Text = "3";
            // 
            // examsListBox
            // 
            this.examsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.examsListBox.FormattingEnabled = true;
            this.examsListBox.ItemHeight = 31;
            this.examsListBox.Location = new System.Drawing.Point(627, 12);
            this.examsListBox.Name = "examsListBox";
            this.examsListBox.Size = new System.Drawing.Size(264, 190);
            this.examsListBox.TabIndex = 3;
            // 
            // shortInfoLabel
            // 
            this.shortInfoLabel.AutoSize = true;
            this.shortInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.shortInfoLabel.Location = new System.Drawing.Point(12, 209);
            this.shortInfoLabel.Name = "shortInfoLabel";
            this.shortInfoLabel.Size = new System.Drawing.Size(51, 55);
            this.shortInfoLabel.TabIndex = 4;
            this.shortInfoLabel.Text = "4";
            // 
            // PersonInfo
            // 
            this.PersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonInfo.Location = new System.Drawing.Point(716, 225);
            this.PersonInfo.Name = "PersonInfo";
            this.PersonInfo.Size = new System.Drawing.Size(175, 40);
            this.PersonInfo.TabIndex = 5;
            this.PersonInfo.Text = "Full Info Person";
            this.PersonInfo.UseVisualStyleBackColor = true;
            this.PersonInfo.Click += new System.EventHandler(this.PersonInfo_Click);
            // 
            // ExamInfo
            // 
            this.ExamInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamInfo.Location = new System.Drawing.Point(716, 294);
            this.ExamInfo.Name = "ExamInfo";
            this.ExamInfo.Size = new System.Drawing.Size(175, 40);
            this.ExamInfo.TabIndex = 6;
            this.ExamInfo.Text = "Exam Info";
            this.ExamInfo.UseVisualStyleBackColor = true;
            this.ExamInfo.Click += new System.EventHandler(this.ExamInfo_Click);
            // 
            // FullInfo
            // 
            this.FullInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FullInfo.Location = new System.Drawing.Point(716, 358);
            this.FullInfo.Name = "FullInfo";
            this.FullInfo.Size = new System.Drawing.Size(175, 40);
            this.FullInfo.TabIndex = 7;
            this.FullInfo.Text = "Full Info";
            this.FullInfo.UseVisualStyleBackColor = true;
            this.FullInfo.Click += new System.EventHandler(this.FullInfo_Click);
            // 
            // SummaryInfo
            // 
            this.SummaryInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SummaryInfo.Location = new System.Drawing.Point(716, 417);
            this.SummaryInfo.Name = "SummaryInfo";
            this.SummaryInfo.Size = new System.Drawing.Size(175, 40);
            this.SummaryInfo.TabIndex = 8;
            this.SummaryInfo.Text = "Summary Info";
            this.SummaryInfo.UseVisualStyleBackColor = true;
            this.SummaryInfo.Click += new System.EventHandler(this.SummaryInfo_Click);
            // 
            // ExamName
            // 
            this.ExamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamName.Location = new System.Drawing.Point(12, 477);
            this.ExamName.Name = "ExamName";
            this.ExamName.Size = new System.Drawing.Size(140, 31);
            this.ExamName.TabIndex = 9;
            this.ExamName.Text = "Exam Name";
            // 
            // ExamMark
            // 
            this.ExamMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamMark.Location = new System.Drawing.Point(205, 477);
            this.ExamMark.Name = "ExamMark";
            this.ExamMark.Size = new System.Drawing.Size(140, 31);
            this.ExamMark.TabIndex = 10;
            // 
            // ExamDate
            // 
            this.ExamDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExamDate.Location = new System.Drawing.Point(401, 477);
            this.ExamDate.Name = "ExamDate";
            this.ExamDate.Size = new System.Drawing.Size(200, 31);
            this.ExamDate.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(162, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 12;
            this.label1.Text = "Добавить экзамен";
            // 
            // AddExam
            // 
            this.AddExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddExam.Location = new System.Drawing.Point(716, 472);
            this.AddExam.Name = "AddExam";
            this.AddExam.Size = new System.Drawing.Size(175, 40);
            this.AddExam.TabIndex = 13;
            this.AddExam.Text = "Add Exam";
            this.AddExam.UseVisualStyleBackColor = true;
            this.AddExam.Click += new System.EventHandler(this.AddExam_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 520);
            this.Controls.Add(this.AddExam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExamDate);
            this.Controls.Add(this.ExamMark);
            this.Controls.Add(this.ExamName);
            this.Controls.Add(this.SummaryInfo);
            this.Controls.Add(this.FullInfo);
            this.Controls.Add(this.ExamInfo);
            this.Controls.Add(this.PersonInfo);
            this.Controls.Add(this.shortInfoLabel);
            this.Controls.Add(this.examsListBox);
            this.Controls.Add(this.educationLevelLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.fullNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.Label birthDateLabel;
        private System.Windows.Forms.Label educationLevelLabel;
        private System.Windows.Forms.ListBox examsListBox;
        private System.Windows.Forms.Label shortInfoLabel;
        private System.Windows.Forms.Button PersonInfo;
        private System.Windows.Forms.Button ExamInfo;
        private System.Windows.Forms.Button FullInfo;
        private System.Windows.Forms.Button SummaryInfo;
        private System.Windows.Forms.TextBox ExamName;
        private System.Windows.Forms.TextBox ExamMark;
        private System.Windows.Forms.DateTimePicker ExamDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddExam;
    }
}

