using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace varela420
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TXTtextoA_TextChanged(object sender, EventArgs e)
        {
            string varTextoA;

            varTextoA = TXTtextoA.Text;

            label1.Text = varTextoA.Length.ToString();
        }

        private void TXTtextoB_TextChanged(object sender, EventArgs e)
        {
            string varTextoB;

            varTextoB = TXTtextoB.Text;

            label2.Text = varTextoB.Length.ToString();
        }

        private void BTNCOMPARAR_Click(object sender, EventArgs e)
        {

        }
    }
}
