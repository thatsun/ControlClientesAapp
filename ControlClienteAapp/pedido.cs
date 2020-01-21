using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlClienteAapp
{
    public partial class pedido : Form
    {
        public pedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            (printPreviewDialog1 as Form).WindowState = FormWindowState.Maximized;
            (printPreviewDialog1 as Form).ControlBox = false;
            printPreviewDialog1.ShowDialog();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("Hello Printing", new Font("Arial",14,FontStyle.Bold),Brushes.Black, new Point(15,100));
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }
    }
}
