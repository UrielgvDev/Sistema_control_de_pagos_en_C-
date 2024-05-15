using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto3
{
    public partial class imprimirdatos : Form
    {
        public imprimirdatos()
        {
            InitializeComponent();
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font tipotexto = new Font("Arial", 10, FontStyle.Bold);

            e.Graphics.DrawImage(pictureBox1.Image, 100, 200);
            e.Graphics.DrawString(textBox1.Text, tipotexto, Brushes.Black, 200, 103);
        }
    }
}
