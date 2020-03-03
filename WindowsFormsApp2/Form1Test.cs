using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1Test : Form
    {
        public Form1Test()
        {
            InitializeComponent();
        }

        private void Form1Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            constructorinp inp = new constructorinp(this);
            inp.Show();
        }
    }
}
