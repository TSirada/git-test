using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phone
{
    public partial class frmTax : Form
    {
        public frmTax()
        {
            InitializeComponent();
        }
        const double Tax = 0.07;

        private void button1_Click(object sender, EventArgs e)
        {
            double dblPrice;
            double dblTax;
            double dblNetPrice;

            dblPrice = Convert.ToDouble(txtPrice.Text);
            dblTax = dblPrice * Tax;
            dblNetPrice = dblPrice + dblTax;

            txtTax.Text = dblTax.ToString("#,###.##");
            txtNetPrice.Text = dblNetPrice.ToString("#,###.##");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
