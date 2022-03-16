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

    }
}
