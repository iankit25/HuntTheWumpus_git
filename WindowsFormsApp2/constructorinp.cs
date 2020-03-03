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
    public partial class constructorinp : Form
    {
        Form1Test parent;
        public constructorinp(Form1Test form)
        {
            InitializeComponent();
            this.parent = form;
        }

        private void constructorinp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("hello");
        }
    }
}
