﻿namespace lab4
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemCommand = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDel = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMove = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.menuItemTrackBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemNone = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTopLeft = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBottomRight = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemBoth = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переместитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пустоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сверхуслеваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.снизусправаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сОбеихСторонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOrientation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.manuItemVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.горизонтальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вертикальнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemCommand,
            this.menuItemTrackBar,
            this.menuItemOrientation,
            this.menuItemAbout});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemCommand
            // 
            this.menuItemCommand.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAdd,
            this.menuItemDel,
            this.menuItemMove});
            this.menuItemCommand.Name = "menuItemCommand";
            this.menuItemCommand.Size = new System.Drawing.Size(102, 20);
            this.menuItemCommand.Text = "Команда меню";
            // 
            // menuItemAdd
            // 
            this.menuItemAdd.Name = "menuItemAdd";
            this.menuItemAdd.Size = new System.Drawing.Size(180, 22);
            this.menuItemAdd.Text = "Добавить";
            this.menuItemAdd.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // menuItemDel
            // 
            this.menuItemDel.Name = "menuItemDel";
            this.menuItemDel.Size = new System.Drawing.Size(180, 22);
            this.menuItemDel.Text = "Удалить";
            this.menuItemDel.Click += new System.EventHandler(this.menuItemDel_Click);
            // 
            // menuItemMove
            // 
            this.menuItemMove.Name = "menuItemMove";
            this.menuItemMove.Size = new System.Drawing.Size(180, 22);
            this.menuItemMove.Text = "Переместить";
            this.menuItemMove.Click += new System.EventHandler(this.menuItemMove_Click);
            // 
            // menuItemAbout
            // 
            this.menuItemAbout.Name = "menuItemAbout";
            this.menuItemAbout.Size = new System.Drawing.Size(94, 20);
            this.menuItemAbout.Text = "О программе";
            // 
            // trackBar1
            // 
            this.trackBar1.ContextMenuStrip = this.contextMenuStrip2;
            this.trackBar1.Location = new System.Drawing.Point(40, 68);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(246, 45);
            this.trackBar1.TabIndex = 1;
            // 
            // menuItemTrackBar
            // 
            this.menuItemTrackBar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNone,
            this.menuItemTopLeft,
            this.menuItemBottomRight,
            this.menuItemBoth});
            this.menuItemTrackBar.Name = "menuItemTrackBar";
            this.menuItemTrackBar.Size = new System.Drawing.Size(98, 20);
            this.menuItemTrackBar.Text = "Стиль бегунка";
            this.menuItemTrackBar.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // menuItemNone
            // 
            this.menuItemNone.Name = "menuItemNone";
            this.menuItemNone.Size = new System.Drawing.Size(180, 22);
            this.menuItemNone.Text = "Пусто";
            this.menuItemNone.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // menuItemTopLeft
            // 
            this.menuItemTopLeft.Name = "menuItemTopLeft";
            this.menuItemTopLeft.Size = new System.Drawing.Size(180, 22);
            this.menuItemTopLeft.Text = "Сверху-слева";
            this.menuItemTopLeft.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // menuItemBottomRight
            // 
            this.menuItemBottomRight.Checked = true;
            this.menuItemBottomRight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemBottomRight.Name = "menuItemBottomRight";
            this.menuItemBottomRight.Size = new System.Drawing.Size(180, 22);
            this.menuItemBottomRight.Text = "Снизу-справа";
            this.menuItemBottomRight.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // menuItemBoth
            // 
            this.menuItemBoth.Name = "menuItemBoth";
            this.menuItemBoth.Size = new System.Drawing.Size(180, 22);
            this.menuItemBoth.Text = "С обеих сторон";
            this.menuItemBoth.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.переместитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пустоToolStripMenuItem,
            this.сверхуслеваToolStripMenuItem,
            this.снизусправаToolStripMenuItem,
            this.сОбеихСторонToolStripMenuItem,
            this.горизонтальнаяToolStripMenuItem,
            this.вертикальнаяToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(181, 158);
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemAdd_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemDel_Click);
            // 
            // переместитьToolStripMenuItem
            // 
            this.переместитьToolStripMenuItem.Name = "переместитьToolStripMenuItem";
            this.переместитьToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.переместитьToolStripMenuItem.Text = "Переместить";
            this.переместитьToolStripMenuItem.Click += new System.EventHandler(this.menuItemMove_Click);
            // 
            // пустоToolStripMenuItem
            // 
            this.пустоToolStripMenuItem.Name = "пустоToolStripMenuItem";
            this.пустоToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.пустоToolStripMenuItem.Text = "Пусто";
            this.пустоToolStripMenuItem.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // сверхуслеваToolStripMenuItem
            // 
            this.сверхуслеваToolStripMenuItem.Name = "сверхуслеваToolStripMenuItem";
            this.сверхуслеваToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сверхуслеваToolStripMenuItem.Text = "Сверху-слева";
            this.сверхуслеваToolStripMenuItem.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // снизусправаToolStripMenuItem
            // 
            this.снизусправаToolStripMenuItem.Name = "снизусправаToolStripMenuItem";
            this.снизусправаToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.снизусправаToolStripMenuItem.Text = "Снизу-справа";
            this.снизусправаToolStripMenuItem.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // сОбеихСторонToolStripMenuItem
            // 
            this.сОбеихСторонToolStripMenuItem.Name = "сОбеихСторонToolStripMenuItem";
            this.сОбеихСторонToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.сОбеихСторонToolStripMenuItem.Text = "С обеих сторон";
            this.сОбеихСторонToolStripMenuItem.Click += new System.EventHandler(this.menuItemTrackBar_Click);
            // 
            // menuItemOrientation
            // 
            this.menuItemOrientation.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemHorizontal,
            this.manuItemVertical});
            this.menuItemOrientation.Name = "menuItemOrientation";
            this.menuItemOrientation.Size = new System.Drawing.Size(86, 20);
            this.menuItemOrientation.Text = "Ориентация";
            this.menuItemOrientation.Click += new System.EventHandler(this.menuItemOrientation_Click);
            // 
            // menuItemHorizontal
            // 
            this.menuItemHorizontal.Checked = true;
            this.menuItemHorizontal.CheckState = System.Windows.Forms.CheckState.Checked;
            this.menuItemHorizontal.Name = "menuItemHorizontal";
            this.menuItemHorizontal.Size = new System.Drawing.Size(180, 22);
            this.menuItemHorizontal.Text = "Горизонтальная";
            this.menuItemHorizontal.Click += new System.EventHandler(this.menuItemOrientation_Click);
            // 
            // manuItemVertical
            // 
            this.manuItemVertical.Name = "manuItemVertical";
            this.manuItemVertical.Size = new System.Drawing.Size(180, 22);
            this.manuItemVertical.Text = "Вертикальная";
            this.manuItemVertical.Click += new System.EventHandler(this.menuItemOrientation_Click);
            // 
            // горизонтальнаяToolStripMenuItem
            // 
            this.горизонтальнаяToolStripMenuItem.Name = "горизонтальнаяToolStripMenuItem";
            this.горизонтальнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.горизонтальнаяToolStripMenuItem.Text = "Горизонтальная";
            this.горизонтальнаяToolStripMenuItem.Click += new System.EventHandler(this.menuItemOrientation_Click);
            // 
            // вертикальнаяToolStripMenuItem
            // 
            this.вертикальнаяToolStripMenuItem.Name = "вертикальнаяToolStripMenuItem";
            this.вертикальнаяToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.вертикальнаяToolStripMenuItem.Text = "Вертикальная";
            this.вертикальнаяToolStripMenuItem.Click += new System.EventHandler(this.menuItemOrientation_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 376);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemCommand;
        private System.Windows.Forms.ToolStripMenuItem menuItemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuItemDel;
        private System.Windows.Forms.ToolStripMenuItem menuItemMove;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuItemTrackBar;
        private System.Windows.Forms.ToolStripMenuItem menuItemNone;
        private System.Windows.Forms.ToolStripMenuItem menuItemTopLeft;
        private System.Windows.Forms.ToolStripMenuItem menuItemBottomRight;
        private System.Windows.Forms.ToolStripMenuItem menuItemBoth;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem переместитьToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem пустоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сверхуслеваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem снизусправаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сОбеихСторонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItemOrientation;
        private System.Windows.Forms.ToolStripMenuItem menuItemHorizontal;
        private System.Windows.Forms.ToolStripMenuItem manuItemVertical;
        private System.Windows.Forms.ToolStripMenuItem горизонтальнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вертикальнаяToolStripMenuItem;
    }
}

