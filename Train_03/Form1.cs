using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Train_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
    }
}
