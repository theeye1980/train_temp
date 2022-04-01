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
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.иЕщеПримерСФайломАндреяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.урокХрустAsyncToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.бДToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.делегатыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fibonaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NetworkProgressBar = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.бекграундВыполнениеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.завтракToolStripMenuItem,
            this.урокХрустAsyncToolStripMenuItem,
            this.бДToolStripMenuItem,
            this.делегатыToolStripMenuItem,
            this.fibonaciToolStripMenuItem});
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
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem,
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem,
            this.иЕщеПримерСФайломАндреяToolStripMenuItem,
            this.бекграундВыполнениеЗадачиToolStripMenuItem});
            this.завтракToolStripMenuItem.Name = "завтракToolStripMenuItem";
            this.завтракToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.завтракToolStripMenuItem.Text = "Завтрак";
            this.завтракToolStripMenuItem.Click += new System.EventHandler(this.завтракToolStripMenuItem_Click);
            // 
            // асинхронныйЗавтракToolStripMenuItem
            // 
            this.асинхронныйЗавтракToolStripMenuItem.Name = "асинхронныйЗавтракToolStripMenuItem";
            this.асинхронныйЗавтракToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.асинхронныйЗавтракToolStripMenuItem.Text = "Асинхронный завтрак";
            this.асинхронныйЗавтракToolStripMenuItem.Click += new System.EventHandler(this.асинхронныйЗавтракToolStripMenuItem_Click);
            // 
            // синхронныйЗавтракToolStripMenuItem
            // 
            this.синхронныйЗавтракToolStripMenuItem.Name = "синхронныйЗавтракToolStripMenuItem";
            this.синхронныйЗавтракToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.синхронныйЗавтракToolStripMenuItem.Text = "Синхронный завтрак";
            this.синхронныйЗавтракToolStripMenuItem.Click += new System.EventHandler(this.синхронныйЗавтракToolStripMenuItem_Click);
            // 
            // выводНаФормуИзДругогоПотокаToolStripMenuItem
            // 
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Name = "выводНаФормуИзДругогоПотокаToolStripMenuItem";
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Text = "Вывод на форму из другого потока";
            this.выводНаФормуИзДругогоПотокаToolStripMenuItem.Click += new System.EventHandler(this.выводНаФормуИзДругогоПотокаToolStripMenuItem_Click);
            // 
            // примерПараллельногоВыполненияЗадачToolStripMenuItem
            // 
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem.Name = "примерПараллельногоВыполненияЗадачToolStripMenuItem";
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem.Text = "Пример параллельного выполнения задач";
            this.примерПараллельногоВыполненияЗадачToolStripMenuItem.Click += new System.EventHandler(this.примерПараллельногоВыполненияЗадачToolStripMenuItem_Click);
            // 
            // иЕщеПримерСФайломАндреяToolStripMenuItem
            // 
            this.иЕщеПримерСФайломАндреяToolStripMenuItem.Name = "иЕщеПримерСФайломАндреяToolStripMenuItem";
            this.иЕщеПримерСФайломАндреяToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.иЕщеПримерСФайломАндреяToolStripMenuItem.Text = "И еще пример с файлом Андрея";
            this.иЕщеПримерСФайломАндреяToolStripMenuItem.Click += new System.EventHandler(this.иЕщеПримерСФайломАндреяToolStripMenuItem_Click);
            // 
            // урокХрустAsyncToolStripMenuItem
            // 
            this.урокХрустAsyncToolStripMenuItem.Name = "урокХрустAsyncToolStripMenuItem";
            this.урокХрустAsyncToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.урокХрустAsyncToolStripMenuItem.Text = "Урок Хруст - Async";
            this.урокХрустAsyncToolStripMenuItem.Click += new System.EventHandler(this.урокХрустAsyncToolStripMenuItem_Click);
            // 
            // бДToolStripMenuItem
            // 
            this.бДToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem});
            this.бДToolStripMenuItem.Name = "бДToolStripMenuItem";
            this.бДToolStripMenuItem.Size = new System.Drawing.Size(34, 20);
            this.бДToolStripMenuItem.Text = "БД";
            // 
            // подключениеКУдаленнойБДНаTimewebToolStripMenuItem
            // 
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem.Name = "подключениеКУдаленнойБДНаTimewebToolStripMenuItem";
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem.Size = new System.Drawing.Size(306, 22);
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem.Text = "Подключение к удаленной БД на timeweb";
            this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem.Click += new System.EventHandler(this.подключениеКУдаленнойБДНаTimewebToolStripMenuItem_Click);
            // 
            // делегатыToolStripMenuItem
            // 
            this.делегатыToolStripMenuItem.Name = "делегатыToolStripMenuItem";
            this.делегатыToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.делегатыToolStripMenuItem.Text = "Делегаты";
            this.делегатыToolStripMenuItem.Click += new System.EventHandler(this.делегатыToolStripMenuItem_Click);
            // 
            // fibonaciToolStripMenuItem
            // 
            this.fibonaciToolStripMenuItem.Name = "fibonaciToolStripMenuItem";
            this.fibonaciToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.fibonaciToolStripMenuItem.Text = "Fibonaci";
            this.fibonaciToolStripMenuItem.Click += new System.EventHandler(this.fibonaciToolStripMenuItem_Click);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "пример параллелизма";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(529, 290);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(228, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Параллельный for";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // бекграундВыполнениеЗадачиToolStripMenuItem
            // 
            this.бекграундВыполнениеЗадачиToolStripMenuItem.Name = "бекграундВыполнениеЗадачиToolStripMenuItem";
            this.бекграундВыполнениеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(312, 22);
            this.бекграундВыполнениеЗадачиToolStripMenuItem.Text = "Бекграунд выполнение задачи";
            this.бекграундВыполнениеЗадачиToolStripMenuItem.Click += new System.EventHandler(this.бекграундВыполнениеЗадачиToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.ToolStripMenuItem примерПараллельногоВыполненияЗадачToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem иЕщеПримерСФайломАндреяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem урокХрустAsyncToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бДToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem подключениеКУдаленнойБДНаTimewebToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem делегатыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fibonaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem бекграундВыполнениеЗадачиToolStripMenuItem;
    }
}

