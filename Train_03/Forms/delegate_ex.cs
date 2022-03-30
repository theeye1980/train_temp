using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_03.Forms
{
    public partial class delegate_ex : Form
    {
        delegate void MesuarMethod(int RepeatCount);
        public delegate_ex()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            int RepeatCount = 12000;
            Stopwatch time1 = Stopwatch.StartNew();
            MesuarString(RepeatCount);
            time1.Stop();

            Console.WriteLine(time1.Elapsed.TotalMilliseconds);
            Stopwatch time2 = Stopwatch.StartNew();
            MesuarStringBuilder(RepeatCount);

            time2.Stop();

            Console.WriteLine(time2.Elapsed.TotalMilliseconds);
            */

            MesuarMethod method1 = MesuarString;
            Measure(method1);

            method1 = MesuarStringBuilder;
            Measure(method1);
        }

        private void Measure(MesuarMethod method) {
            int RepeatCount = 12000;
            Stopwatch time = Stopwatch.StartNew();
            method(RepeatCount);
            time.Stop();

            Console.WriteLine(time.Elapsed.TotalMilliseconds);
        }
        private void MesuarString(int RepeatCount) {
            string str = "Ахтунг";
            for (int i = 0; i < RepeatCount; i++) {
                str += "{i}";


            }
        
        }
        private void MesuarStringBuilder(int RepeatCount)
        {
            StringBuilder StringBuilderResult = new StringBuilder("Tese");
            for (int i = 0; i < RepeatCount; i++)
            {
                StringBuilderResult.Append("{i}");

            }

        }
    }
}
