namespace lab5_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuBackgroundColor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBlue = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemGreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemYellow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonRed = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBlue = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGreen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonYellow = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBackgroundColor});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuBackgroundColor
            // 
            this.menuBackgroundColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemRed,
            this.menuItemBlue,
            this.menuItemGreen,
            this.menuItemYellow});
            this.menuBackgroundColor.Name = "menuBackgroundColor";
            this.menuBackgroundColor.Size = new System.Drawing.Size(77, 20);
            this.menuBackgroundColor.Text = "Цвет фона";
            this.menuBackgroundColor.Click += new System.EventHandler(this.menuBackgroundColor_Click);
            // 
            // menuItemRed
            // 
            this.menuItemRed.Name = "menuItemRed";
            this.menuItemRed.Size = new System.Drawing.Size(180, 22);
            this.menuItemRed.Text = "Красный";
            this.menuItemRed.Click += new System.EventHandler(this.menuBackgroundColor_Click);
            // 
            // menuItemBlue
            // 
            this.menuItemBlue.Name = "menuItemBlue";
            this.menuItemBlue.Size = new System.Drawing.Size(180, 22);
            this.menuItemBlue.Text = "Синий";
            this.menuItemBlue.Click += new System.EventHandler(this.menuBackgroundColor_Click);
            // 
            // menuItemGreen
            // 
            this.menuItemGreen.Name = "menuItemGreen";
            this.menuItemGreen.Size = new System.Drawing.Size(180, 22);
            this.menuItemGreen.Text = "Зеленый";
            this.menuItemGreen.Click += new System.EventHandler(this.menuBackgroundColor_Click);
            // 
            // menuItemYellow
            // 
            this.menuItemYellow.Name = "menuItemYellow";
            this.menuItemYellow.Size = new System.Drawing.Size(180, 22);
            this.menuItemYellow.Text = "Жёлтый";
            this.menuItemYellow.Click += new System.EventHandler(this.menuBackgroundColor_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonRed,
            this.toolStripButtonBlue,
            this.toolStripButtonGreen,
            this.toolStripButtonYellow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked_1);
            // 
            // toolStripButtonRed
            // 
            this.toolStripButtonRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRed.Image")));
            this.toolStripButtonRed.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRed.Name = "toolStripButtonRed";
            this.toolStripButtonRed.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonRed.Text = "toolStripButton1";
            // 
            // toolStripButtonBlue
            // 
            this.toolStripButtonBlue.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBlue.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBlue.Image")));
            this.toolStripButtonBlue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBlue.Name = "toolStripButtonBlue";
            this.toolStripButtonBlue.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBlue.Text = "toolStripButton2";
            // 
            // toolStripButtonGreen
            // 
            this.toolStripButtonGreen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonGreen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGreen.Image")));
            this.toolStripButtonGreen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGreen.Name = "toolStripButtonGreen";
            this.toolStripButtonGreen.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonGreen.Text = "toolStripButton3";
            // 
            // toolStripButtonYellow
            // 
            this.toolStripButtonYellow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonYellow.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonYellow.Image")));
            this.toolStripButtonYellow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonYellow.Name = "toolStripButtonYellow";
            this.toolStripButtonYellow.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonYellow.Text = "toolStripButton1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel1.Text = "Не выбран цвет фона";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuBackgroundColor;
        private System.Windows.Forms.ToolStripMenuItem menuItemRed;
        private System.Windows.Forms.ToolStripMenuItem menuItemBlue;
        private System.Windows.Forms.ToolStripMenuItem menuItemGreen;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonRed;
        private System.Windows.Forms.ToolStripButton toolStripButtonBlue;
        private System.Windows.Forms.ToolStripButton toolStripButtonGreen;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButtonYellow;
        private System.Windows.Forms.ToolStripMenuItem menuItemYellow;
    }
}

