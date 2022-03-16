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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkProgressBar = new System.Windows.Forms.ProgressBar();
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.синхронныйЗавтракToolStripMenuItem,
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem});
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(257, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Пример загрузки без блокировки";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // NetworkProgressBar
            // 
            this.NetworkProgressBar.Location = new System.Drawing.Point(147, 78);
            this.NetworkProgressBar.Name = "NetworkProgressBar";
            this.NetworkProgressBar.Size = new System.Drawing.Size(379, 23);
            this.NetworkProgressBar.TabIndex = 3;
            // 
            // выводНаФормуИзДругогоПотокаToolStripMenuItem
            // 
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Name = "выводНаФормуИзДругогоПотокаToolStripMenuItem";
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Size = new System.Drawing.Size(268, 22);
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Text = "Вывод на форму из другого потока";
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Click += new System.EventHandler(this.выводНаФормуИзДругогоПотокаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NetworkProgressBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar NetworkProgressBar;
        private System.Windows.Forms.ToolStripMenuItem выводНаФормуИзДругогоПотокаToolStripMenuItem;
    }
}

