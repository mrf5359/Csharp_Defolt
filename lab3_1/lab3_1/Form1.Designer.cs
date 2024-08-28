namespace lab3_1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.add_toList = new System.Windows.Forms.Button();
            this.add_toTree = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.deleteList_btn = new System.Windows.Forms.Button();
            this.deleteTree_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(35, 55);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(128, 194);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icon.png");
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(288, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(127, 194);
            this.treeView1.TabIndex = 1;
            // 
            // add_toList
            // 
            this.add_toList.Location = new System.Drawing.Point(35, 332);
            this.add_toList.Name = "add_toList";
            this.add_toList.Size = new System.Drawing.Size(99, 41);
            this.add_toList.TabIndex = 2;
            this.add_toList.Text = "добавить в список";
            this.add_toList.UseVisualStyleBackColor = true;
            this.add_toList.Click += new System.EventHandler(this.add_toList_Click);
            // 
            // add_toTree
            // 
            this.add_toTree.Location = new System.Drawing.Point(316, 331);
            this.add_toTree.Name = "add_toTree";
            this.add_toTree.Size = new System.Drawing.Size(99, 42);
            this.add_toTree.TabIndex = 3;
            this.add_toTree.Text = "добавить в дерево";
            this.add_toTree.UseVisualStyleBackColor = true;
            this.add_toTree.Click += new System.EventHandler(this.add_toTree_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(158, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 31);
            this.textBox1.TabIndex = 4;
            // 
            // deleteList_btn
            // 
            this.deleteList_btn.Location = new System.Drawing.Point(35, 389);
            this.deleteList_btn.Name = "deleteList_btn";
            this.deleteList_btn.Size = new System.Drawing.Size(99, 36);
            this.deleteList_btn.TabIndex = 5;
            this.deleteList_btn.Text = "Удалить из списка";
            this.deleteList_btn.UseVisualStyleBackColor = true;
            this.deleteList_btn.Click += new System.EventHandler(this.deleteList_btn_Click);
            // 
            // deleteTree_btn
            // 
            this.deleteTree_btn.Location = new System.Drawing.Point(316, 389);
            this.deleteTree_btn.Name = "deleteTree_btn";
            this.deleteTree_btn.Size = new System.Drawing.Size(99, 36);
            this.deleteTree_btn.TabIndex = 6;
            this.deleteTree_btn.Text = "Удалить из дерева";
            this.deleteTree_btn.UseVisualStyleBackColor = true;
            this.deleteTree_btn.Click += new System.EventHandler(this.deleteTree_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.deleteTree_btn);
            this.Controls.Add(this.deleteList_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.add_toTree);
            this.Controls.Add(this.add_toList);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button add_toList;
        private System.Windows.Forms.Button add_toTree;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button deleteList_btn;
        private System.Windows.Forms.Button deleteTree_btn;
    }
}

