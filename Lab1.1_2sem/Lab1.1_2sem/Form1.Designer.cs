namespace Lab1._1_2sem
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
            this.addButton = new System.Windows.Forms.Button();
            this.fullInfoButton = new System.Windows.Forms.Button();
            this.summaryInfoButton = new System.Windows.Forms.Button();
            this.ArtworkNameTextBox = new System.Windows.Forms.TextBox();
            this.YearCreatedTextBox = new System.Windows.Forms.TextBox();
            this.PlacementComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.PlaceTypeLabel = new System.Windows.Forms.Label();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.HeigthLabel = new System.Windows.Forms.Label();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addHallButton = new System.Windows.Forms.Button();
            this.ExhibitionHallNameTextBox = new System.Windows.Forms.TextBox();
            this.FundNameLabel = new System.Windows.Forms.Label();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.DepthTextBox = new System.Windows.Forms.TextBox();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.DepthLabel = new System.Windows.Forms.Label();
            this.FundsNameTextBox = new System.Windows.Forms.TextBox();
            this.FundAddressLabel = new System.Windows.Forms.Label();
            this.FundsAddressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExhibitionHallsListBox = new System.Windows.Forms.ListBox();
            this.overloadButton = new System.Windows.Forms.Button();
            this.overloadLabel = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.Location = new System.Drawing.Point(7, 255);
            this.addButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(101, 52);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Добавить экспонат";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // fullInfoButton
            // 
            this.fullInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fullInfoButton.Location = new System.Drawing.Point(118, 255);
            this.fullInfoButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.fullInfoButton.Name = "fullInfoButton";
            this.fullInfoButton.Size = new System.Drawing.Size(75, 30);
            this.fullInfoButton.TabIndex = 1;
            this.fullInfoButton.Text = "Инфа";
            this.fullInfoButton.UseVisualStyleBackColor = true;
            this.fullInfoButton.Click += new System.EventHandler(this.fullInfoButton_Click);
            // 
            // summaryInfoButton
            // 
            this.summaryInfoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summaryInfoButton.Location = new System.Drawing.Point(204, 255);
            this.summaryInfoButton.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.summaryInfoButton.Name = "summaryInfoButton";
            this.summaryInfoButton.Size = new System.Drawing.Size(132, 30);
            this.summaryInfoButton.TabIndex = 2;
            this.summaryInfoButton.Text = "Краткая инфа";
            this.summaryInfoButton.UseVisualStyleBackColor = true;
            this.summaryInfoButton.Click += new System.EventHandler(this.summaryInfoButton_Click);
            // 
            // ArtworkNameTextBox
            // 
            this.ArtworkNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArtworkNameTextBox.Location = new System.Drawing.Point(12, 49);
            this.ArtworkNameTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.ArtworkNameTextBox.Name = "ArtworkNameTextBox";
            this.ArtworkNameTextBox.Size = new System.Drawing.Size(175, 26);
            this.ArtworkNameTextBox.TabIndex = 3;
            // 
            // YearCreatedTextBox
            // 
            this.YearCreatedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearCreatedTextBox.Location = new System.Drawing.Point(197, 49);
            this.YearCreatedTextBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.YearCreatedTextBox.Name = "YearCreatedTextBox";
            this.YearCreatedTextBox.Size = new System.Drawing.Size(112, 26);
            this.YearCreatedTextBox.TabIndex = 4;
            // 
            // PlacementComboBox
            // 
            this.PlacementComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlacementComboBox.FormattingEnabled = true;
            this.PlacementComboBox.Items.AddRange(new object[] {
            "Стена",
            "Стол",
            "Пол"});
            this.PlacementComboBox.Location = new System.Drawing.Point(12, 215);
            this.PlacementComboBox.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.PlacementComboBox.Name = "PlacementComboBox";
            this.PlacementComboBox.Size = new System.Drawing.Size(183, 28);
            this.PlacementComboBox.TabIndex = 5;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(12, 22);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(123, 20);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Имя экспоната";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.YearLabel.Location = new System.Drawing.Point(193, 21);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(38, 20);
            this.YearLabel.TabIndex = 8;
            this.YearLabel.Text = "Год";
            // 
            // PlaceTypeLabel
            // 
            this.PlaceTypeLabel.AutoSize = true;
            this.PlaceTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlaceTypeLabel.Location = new System.Drawing.Point(12, 190);
            this.PlaceTypeLabel.Name = "PlaceTypeLabel";
            this.PlaceTypeLabel.Size = new System.Drawing.Size(105, 20);
            this.PlaceTypeLabel.TabIndex = 10;
            this.PlaceTypeLabel.Text = "Размещение";
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeightTextBox.Location = new System.Drawing.Point(12, 103);
            this.HeightTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(100, 26);
            this.HeightTextBox.TabIndex = 11;
            // 
            // HeigthLabel
            // 
            this.HeigthLabel.AutoSize = true;
            this.HeigthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HeigthLabel.Location = new System.Drawing.Point(12, 81);
            this.HeigthLabel.Name = "HeigthLabel";
            this.HeigthLabel.Size = new System.Drawing.Size(58, 20);
            this.HeigthLabel.TabIndex = 13;
            this.HeigthLabel.Text = "Длина";
            // 
            // outputTextBox
            // 
            this.outputTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.outputTextBox.Location = new System.Drawing.Point(499, 21);
            this.outputTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.outputTextBox.Size = new System.Drawing.Size(363, 336);
            this.outputTextBox.TabIndex = 14;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(755, 361);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(107, 44);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Очистить";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(236, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Выставочные залы";
            // 
            // addHallButton
            // 
            this.addHallButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addHallButton.Location = new System.Drawing.Point(12, 384);
            this.addHallButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addHallButton.Name = "addHallButton";
            this.addHallButton.Size = new System.Drawing.Size(190, 49);
            this.addHallButton.TabIndex = 22;
            this.addHallButton.Text = "Добавить Выставочный зал";
            this.addHallButton.UseVisualStyleBackColor = true;
            this.addHallButton.Click += new System.EventHandler(this.addHallButton_Click);
            // 
            // ExhibitionHallNameTextBox
            // 
            this.ExhibitionHallNameTextBox.Location = new System.Drawing.Point(12, 348);
            this.ExhibitionHallNameTextBox.Name = "ExhibitionHallNameTextBox";
            this.ExhibitionHallNameTextBox.Size = new System.Drawing.Size(190, 31);
            this.ExhibitionHallNameTextBox.TabIndex = 23;
            // 
            // FundNameLabel
            // 
            this.FundNameLabel.AutoSize = true;
            this.FundNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FundNameLabel.Location = new System.Drawing.Point(12, 140);
            this.FundNameLabel.Name = "FundNameLabel";
            this.FundNameLabel.Size = new System.Drawing.Size(97, 20);
            this.FundNameLabel.TabIndex = 25;
            this.FundNameLabel.Text = "Имя фонда";
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthTextBox.Location = new System.Drawing.Point(139, 103);
            this.WidthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 26);
            this.WidthTextBox.TabIndex = 26;
            // 
            // DepthTextBox
            // 
            this.DepthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthTextBox.Location = new System.Drawing.Point(271, 103);
            this.DepthTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepthTextBox.Name = "DepthTextBox";
            this.DepthTextBox.Size = new System.Drawing.Size(100, 26);
            this.DepthTextBox.TabIndex = 27;
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WidthLabel.Location = new System.Drawing.Point(135, 81);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(67, 20);
            this.WidthLabel.TabIndex = 28;
            this.WidthLabel.Text = "Ширина";
            // 
            // DepthLabel
            // 
            this.DepthLabel.AutoSize = true;
            this.DepthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DepthLabel.Location = new System.Drawing.Point(270, 81);
            this.DepthLabel.Name = "DepthLabel";
            this.DepthLabel.Size = new System.Drawing.Size(66, 20);
            this.DepthLabel.TabIndex = 29;
            this.DepthLabel.Text = "Высота";
            // 
            // FundsNameTextBox
            // 
            this.FundsNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FundsNameTextBox.Location = new System.Drawing.Point(12, 162);
            this.FundsNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FundsNameTextBox.Name = "FundsNameTextBox";
            this.FundsNameTextBox.Size = new System.Drawing.Size(175, 26);
            this.FundsNameTextBox.TabIndex = 30;
            // 
            // FundAddressLabel
            // 
            this.FundAddressLabel.AutoSize = true;
            this.FundAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FundAddressLabel.Location = new System.Drawing.Point(200, 140);
            this.FundAddressLabel.Name = "FundAddressLabel";
            this.FundAddressLabel.Size = new System.Drawing.Size(114, 20);
            this.FundAddressLabel.TabIndex = 31;
            this.FundAddressLabel.Text = "Адрес фонда";
            // 
            // FundsAddressTextBox
            // 
            this.FundsAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FundsAddressTextBox.Location = new System.Drawing.Point(204, 162);
            this.FundsAddressTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FundsAddressTextBox.Name = "FundsAddressTextBox";
            this.FundsAddressTextBox.Size = new System.Drawing.Size(175, 26);
            this.FundsAddressTextBox.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 325);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Имя выставочного зала";
            // 
            // ExhibitionHallsListBox
            // 
            this.ExhibitionHallsListBox.FormattingEnabled = true;
            this.ExhibitionHallsListBox.ItemHeight = 25;
            this.ExhibitionHallsListBox.Location = new System.Drawing.Point(240, 348);
            this.ExhibitionHallsListBox.Name = "ExhibitionHallsListBox";
            this.ExhibitionHallsListBox.Size = new System.Drawing.Size(224, 129);
            this.ExhibitionHallsListBox.TabIndex = 34;
            // 
            // overloadButton
            // 
            this.overloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overloadButton.Location = new System.Drawing.Point(12, 603);
            this.overloadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.overloadButton.Name = "overloadButton";
            this.overloadButton.Size = new System.Drawing.Size(119, 44);
            this.overloadButton.TabIndex = 35;
            this.overloadButton.Text = "Перегрузка";
            this.overloadButton.UseVisualStyleBackColor = true;
            this.overloadButton.Click += new System.EventHandler(this.overloadButton_Click);
            // 
            // overloadLabel
            // 
            this.overloadLabel.AutoSize = true;
            this.overloadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.overloadLabel.Location = new System.Drawing.Point(13, 484);
            this.overloadLabel.Name = "overloadLabel";
            this.overloadLabel.Size = new System.Drawing.Size(61, 16);
            this.overloadLabel.TabIndex = 36;
            this.overloadLabel.Text = "overload";
            // 
            // LoadButton
            // 
            this.LoadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoadButton.Location = new System.Drawing.Point(630, 361);
            this.LoadButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(119, 44);
            this.LoadButton.TabIndex = 37;
            this.LoadButton.Text = "Загрузить";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(505, 361);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(119, 44);
            this.SaveButton.TabIndex = 38;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 657);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.overloadLabel);
            this.Controls.Add(this.overloadButton);
            this.Controls.Add(this.ExhibitionHallsListBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FundsAddressTextBox);
            this.Controls.Add(this.FundAddressLabel);
            this.Controls.Add(this.FundsNameTextBox);
            this.Controls.Add(this.DepthLabel);
            this.Controls.Add(this.WidthLabel);
            this.Controls.Add(this.DepthTextBox);
            this.Controls.Add(this.WidthTextBox);
            this.Controls.Add(this.FundNameLabel);
            this.Controls.Add(this.ExhibitionHallNameTextBox);
            this.Controls.Add(this.addHallButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.HeigthLabel);
            this.Controls.Add(this.HeightTextBox);
            this.Controls.Add(this.PlaceTypeLabel);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.PlacementComboBox);
            this.Controls.Add(this.YearCreatedTextBox);
            this.Controls.Add(this.ArtworkNameTextBox);
            this.Controls.Add(this.summaryInfoButton);
            this.Controls.Add(this.fullInfoButton);
            this.Controls.Add(this.addButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button fullInfoButton;
        private System.Windows.Forms.Button summaryInfoButton;
        private System.Windows.Forms.TextBox ArtworkNameTextBox;
        private System.Windows.Forms.TextBox YearCreatedTextBox;
        private System.Windows.Forms.ComboBox PlacementComboBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label PlaceTypeLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.Label HeigthLabel;
        private System.Windows.Forms.TextBox outputTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addHallButton;
        private System.Windows.Forms.TextBox ExhibitionHallNameTextBox;
        private System.Windows.Forms.Label FundNameLabel;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox DepthTextBox;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label DepthLabel;
        private System.Windows.Forms.TextBox FundsNameTextBox;
        private System.Windows.Forms.Label FundAddressLabel;
        private System.Windows.Forms.TextBox FundsAddressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ExhibitionHallsListBox;
        private System.Windows.Forms.Button overloadButton;
        private System.Windows.Forms.Label overloadLabel;
        private System.Windows.Forms.Button LoadButton;
        private System.Windows.Forms.Button SaveButton;
    }
}


