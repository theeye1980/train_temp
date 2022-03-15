namespace Train_03
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.завтракToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.асинхронныйЗавтракToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.синхронныйЗавтракToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завтракToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // завтракToolStripMenuItem
            // 
            this.завтракToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.асинхронныйЗавтракToolStripMenuItem,
            this.синхронныйЗавтракToolStripMenuItem});
            this.завтракToolStripMenuItem.Name = "завтракToolStripMenuItem";
            this.завтракToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.завтракToolStripMenuItem.Text = "Завтрак";
            this.завтракToolStripMenuItem.Click += new System.EventHandler(this.завтракToolStripMenuItem_Click);
            // 
            // асинхронныйЗавтракToolStripMenuItem
            // 
            this.асинхронныйЗавтракToolStripMenuItem.Name = "асинхронныйЗавтракToolStripMenuItem";
            this.асинхронныйЗавтракToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.асинхронныйЗавтракToolStripMenuItem.Text = "Асинхронный завтрак";
            this.асинхронныйЗавтракToolStripMenuItem.Click += new System.EventHandler(this.асинхронныйЗавтракToolStripMenuItem_Click);
            // 
            // синхронныйЗавтракToolStripMenuItem
            // 
            this.синхронныйЗавтракToolStripMenuItem.Name = "синхронныйЗавтракToolStripMenuItem";
            this.синхронныйЗавтракToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.синхронныйЗавтракToolStripMenuItem.Text = "Синхронный завтрак";
            this.синхронныйЗавтракToolStripMenuItem.Click += new System.EventHandler(this.синхронныйЗавтракToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem завтракToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem асинхронныйЗавтракToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem синхронныйЗавтракToolStripMenuItem;
    }
}

