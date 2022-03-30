using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
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


        private void выводНаФормуИзДругогоПотокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getResponseFromOtherCurrent_frm getResponseFromOtherCurrent_frm = new getResponseFromOtherCurrent_frm();
            getResponseFromOtherCurrent_frm.Visible = true;
        }

        private void примерПараллельногоВыполненияЗадачToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Parallel_ex Parallel_ex = new Parallel_ex();
            Parallel_ex.Visible = true;
        }

        private void иЕщеПримерСФайломАндреяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AndreyFileDwld andreyFileDwld = new AndreyFileDwld();
            andreyFileDwld.Visible = true;
        }

        private void урокХрустAsyncToolStripMenuItem_Click(object sender, EventArgs e)
        {
               Xrust xrust = new Xrust();
                xrust.Visible = true;
        }

        private void подключениеКУдаленнойБДНаTimewebToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timeweb_bd timeweb_Bd = new timeweb_bd();
            timeweb_Bd.Visible = true;  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int[] nums = Enumerable.Range(0, 9000000).ToArray();
            long total = 0;

            // Use type parameter to make subtotal a long, not an int
            Parallel.For<long>(0, nums.Length, () => 0, (j, loop, subtotal) =>
            {
                subtotal += nums[j];
                return subtotal;
            },
                (x) => Interlocked.Add(ref total, x)
            );

            Console.WriteLine("The total is {0:N0}", total);
            Console.WriteLine("Press any key to exit");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Set up matrices. Use small values to better view
            // result matrix. Increase the counts to see greater
            // speedup in the parallel loop vs. the sequential loop.
            int colCount = 180;
            int rowCount = 2000;
            int colCount2 = 270;
            double[,] m1 = InitializeMatrix(rowCount, colCount);
            double[,] m2 = InitializeMatrix(colCount, colCount2);
            double[,] result = new double[rowCount, colCount2];

            // First do the sequential version.
            Console.Error.WriteLine("Executing sequential loop...");
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            MultiplyMatricesSequential(m1, m2, result);
            stopwatch.Stop();
            string dkk = "Sequential loop time in milliseconds: " + stopwatch.ElapsedMilliseconds;
                                    
            //Console.Error.WriteLine();

            // For the skeptics.
            OfferToPrint(rowCount, colCount2, result);

            // Reset timer and results matrix.
            stopwatch.Reset();
            result = new double[rowCount, colCount2];

            // Do the parallel loop.
            Console.Error.WriteLine("Executing parallel loop...");
            stopwatch.Start();
            MultiplyMatricesParallel(m1, m2, result);
            stopwatch.Stop();

            OfferToPrint(rowCount, colCount2, result);


            Console.WriteLine("Parallel loop time in milliseconds: {0}",
                        stopwatch.ElapsedMilliseconds);
            Console.WriteLine(dkk);

            // Keep the console window open in debug mode.
            //Console.Error.WriteLine("Press any key to exit.");
            //Console.ReadKey();
        }

        #region Sequential_Loop
        static void MultiplyMatricesSequential(double[,] matA, double[,] matB,
                                                double[,] result)
        {
            int matACols = matA.GetLength(1);
            int matBCols = matB.GetLength(1);
            int matARows = matA.GetLength(0);

            for (int i = 0; i < matARows; i++)
            {
                for (int j = 0; j < matBCols; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matA[i, k] * matB[k, j];
                    }
                    result[i, j] += temp;
                }
            }
        }
        #endregion
        #region Parallel_Loop
        static void MultiplyMatricesParallel(double[,] matA, double[,] matB, double[,] result)
        {
            int matACols = matA.GetLength(1);
            int matBCols = matB.GetLength(1);
            int matARows = matA.GetLength(0);

            // A basic matrix multiplication.
            // Parallelize the outer loop to partition the source array by rows.
            Parallel.For(0, matARows, i =>
            {
                for (int j = 0; j < matBCols; j++)
                {
                    double temp = 0;
                    for (int k = 0; k < matACols; k++)
                    {
                        temp += matA[i, k] * matB[k, j];
                    }
                    result[i, j] = temp;
                }
            }); // Parallel.For
        }
        #endregion
        #region Helper_Methods
        static double[,] InitializeMatrix(int rows, int cols)
        {
            double[,] matrix = new double[rows, cols];

            Random r = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = r.Next(100);
                }
            }
            return matrix;
        }
        private static void OfferToPrint(int rowCount, int colCount, double[,] matrix)
        {
            Console.Error.Write("Computation complete. Print results (y/n)? ");
            //char c = Console.ReadKey(true).KeyChar;
            char c = 'Y';
            Console.Error.WriteLine(c);
            if (Char.ToUpperInvariant(c) == 'Y')
            {
                if (!Console.IsOutputRedirected &&
                    RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    Console.WindowWidth = 180;
                }

                Console.WriteLine();
                for (int x = 0; x < rowCount; x++)
                {
                    Console.WriteLine("ROW {0}: ", x);
                    for (int y = 0; y < colCount; y++)
                    {
                        Console.Write("{0:#.##} ", matrix[x, y]);
                    }
                    Console.WriteLine();
                }
            }
        }
        #endregion

        private void семинарToolStripMenuItem_Click(object sender, EventArgs e)
        {
            delegate_ex ele = new delegate_ex();
            ele.Visible = true;
        }
    }
}