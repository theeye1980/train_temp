using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Train_03.Forms;

namespace Train_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProgressBar NetworkProgressBar = new ProgressBar();
        }

        private void завтракToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void асинхронныйЗавтракToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asyncBr asyncBr = new asyncBr();
            asyncBr.Visible = true;
        }

        private void синхронныйЗавтракToolStripMenuItem_Click(object sender, EventArgs e)
        {
            brackfast brackfast = new brackfast();
            brackfast.Visible = true;
        }
        private readonly HttpClient _httpClient = new HttpClient();


        private async  void button1_Click(object sender, EventArgs e)
        {// Capture the task handle here so we can await the background task later.
            var getDotNetFoundationHtmlTask = _httpClient.GetStringAsync("https://dotnetfoundation.org");

            // Any other work on the UI thread can be done here, such as enabling a Progress Bar.
            // This is important to do here, before the "await" call, so that the user
            // sees the progress bar before execution of this method is yielded.
            NetworkProgressBar.Enabled = true;
            NetworkProgressBar.Visible = true;
            NetworkProgressBar.Value = 23;
           
           

            // The await operator suspends OnSeeTheDotNetsButtonClick(), returning control to its caller.
            // This is what allows the app to be responsive and not block the UI thread.
            var html = await getDotNetFoundationHtmlTask;
            int count = Regex.Matches(html, @"\.NET").Count;

            label1.Text = $"Number of .NETs on dotnetfoundation.org: {count}";
            NetworkProgressBar.Value = 100;

        }
        public async Task<int> GetDotNetCount()
        {
            // Suspends GetDotNetCount() to allow the caller (the web server)
            // to accept another request, rather than blocking on this one.
            var html = await _httpClient.GetStringAsync("https://dotnetfoundation.org");

            return Regex.Matches(html, @"\.NET").Count;
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

        private void выводНаФормуИзДругогоПотокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getResponseFromOtherCurrent_frm getResponseFromOtherCurrent_frm = new getResponseFromOtherCurrent_frm();
            getResponseFromOtherCurrent_frm.Visible = true;
        }
    }
}