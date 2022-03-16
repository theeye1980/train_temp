using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_03.Forms
{
    public partial class AndreyFileDwld : Form
    {
        public AndreyFileDwld()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Task m = GetSiteInfo();
        }


        static async Task<bool> GetSiteInfo()
        {

            await Task.Run(() =>
            {
                Thread currentThread = Thread.CurrentThread;
                Console.WriteLine($"Id потока, который занимается получением данных от сайта: {currentThread.ManagedThreadId}");
                string source = @"https://fandeco.ru/rest/1c/exportbuyall";
                get_web_page_to_json_file(source, "Site_Price_cache_path.json");
                //actions.Showmsg("Файл с данными по ценам сайта обновлен");

            });
            return true;
        }

        public static async Task get_web_page_to_json_file(string source, string filename)
        {
            try
            {
                WebClient client = new WebClient();
                using (Stream stream = client.OpenRead(source))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        string line = "";
                        while ((line = reader.ReadLine()) != null)
                        {
                            //записываем в файл
                            cache_writer(line, filename);
                        }



                    }
                }

            }
            catch { MessageBox.Show("Не удалось загрузить файл Цен сайта в кеш."); }
        }
        public static void cache_writer(string content, string filename) // записывает список файлов в csv 
        {
            StreamWriter g = new StreamWriter(@"D:\ty\" + filename, false, Encoding.GetEncoding("Windows-1251"));
            g.WriteLine(content);
            g.Close();
        }

        private void button2_Click(object sender, EventArgs e) // Другой способ
        {

            label1.Text = "Начинаем скачивание";
            Thread th1 = new Thread(async () =>
            {
                await GetSiteInfo();
                Action action = () =>
                {
                    
                    label1.Text = "Скачивание завершено";
                    
                    progressBar1.Visible = false;
                };
                if (InvokeRequired)
                {
                    BeginInvoke(action);

                }
                else action();


            });
            Thread t = new Thread(new ThreadStart(delegate {
                int Count = 120000;
               
                for (int i = 0; i < Count; ++i)
                {
                    this.Invoke(new ThreadStart(delegate
                    {
                        progressBar1.Maximum = Count;
                        progressBar1.Value++;
                        if (label1.Text == "Скачивание завершено") {
                            //Thread.Sleep(1000);
                            //progressBar1.Value = Count;
                            progressBar1.Visible = false;
                            label1.Text = "Файл скачан и сохранен";
                        }
                    }));
                }
                if (label1.Text == "Начинаем скачивание") {
                    MessageBox.Show("Пока не удалось заскачать файл. Он продолжится скачиваться в фоновом режиме");
                }
            }));
            Thread th2 = new Thread(async () =>
            {
                
                Action action = () =>
                {
                    progressBar1.Value = 100;
                    
                };
                if (InvokeRequired)
                {
                    BeginInvoke(action);

                }
                else action();


            });

            th1.Start();
            t.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
