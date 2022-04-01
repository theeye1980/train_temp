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
    public delegate void KeyPressDelegate();
    public partial class delegat : Form
    {
        public delegat()
        {
            InitializeComponent();
        }
        static private void buttonW_Click() {
            Console.WriteLine("В атаку");
        }
        static private void buttonS_Click()
        {
            Console.WriteLine("Ну нах");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            KeyBoardMaster keyBoardMaster = new KeyBoardMaster();

            keyBoardMaster.wKeyPressedEvent += buttonW_Click;
            keyBoardMaster.wKeyPressedEvent += buttonS_Click;

            while (textBox1.Text == "rr") {
                gg();
                Thread.Sleep(13110);
                textBox1.Text = "r34r";
            }

        }
        private async void gg() {
            await Task.Run(() =>
            {
                while (this.textBox1.Text == "rr")
                {
                    delegat.buttonS_Click();
                    Task.Delay(10);
                }
            });
    }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class KeyBoardMaster{

        public event KeyPressDelegate wKeyPressedEvent = null;
        public event KeyPressDelegate sKeyPressedEvent = null;

        public void WKeyPressedEvent()
        {
            if (wKeyPressedEvent != null)
            {

            }
            if (sKeyPressedEvent != null)
            {

            }

        }

    }

}
