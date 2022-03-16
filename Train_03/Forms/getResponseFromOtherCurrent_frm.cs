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
    public partial class getResponseFromOtherCurrent_frm : Form
    {
        private Label lb;

        public getResponseFromOtherCurrent_frm()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb = new Label { Parent = this };
            new Thread(Work) { IsBackground = true }.Start();//запускаем поток
        }
        void Work()
        {
            var counter = 0;

            //цикл считывания данных
            while (true)
            {
                counter++;
                Thread.Sleep(100);//doing something
                SetText(lb, counter.ToString());//выводим показания в лейбл
            }
        }

        private void SetText(Control ctrl, string text)
        {
            if (InvokeRequired)
            {
                BeginInvoke((Action)(() => SetText(ctrl, text)));
                return;
            }

            ctrl.Text = text;
        }

    }

}
