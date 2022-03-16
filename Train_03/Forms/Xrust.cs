using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_03.Forms
{
    public partial class Xrust : Form
    {
        public Xrust()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            progressBar1.Value = 12;
            Thread thread = new Thread(()=> {
                M(label1);
                Task.Delay(5000).Wait();
            });

            Thread thread1 = new Thread(() => {
                PB(progressBar1);
            });


            thread.Start();
            thread1.Start();

            

        }
        void M(Label label) {

            label.Text = "asdkflj";

        
        }
        void PB(ProgressBar progressBar) {

            progressBar.Value = 0;
            fg:
            for (int i = 0; i < 100; i++) {

                progressBar.Value = i;
                
            }
            
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            Thread th1 = new Thread(() =>
            {
                Action action = () =>
                {
                    label1.Text = "asdfdasfd 2";
                };
                if (InvokeRequired)
                {
                    Invoke(action);

                }
                else action();


            });
            th1.Start();
        }
    }
    
}
