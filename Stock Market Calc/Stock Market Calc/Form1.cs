using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Market_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultsbox.Text = "----------------------------------------------Results----------------------------------------------" + Environment.NewLine;
            double qn, mxp, rslt;
            double.TryParse(quantitybox.Text, out qn);
            double.TryParse(quantitybox.Text, out mxp);
            rslt = qn * mxp;
            resultsbox.Text = rslt.ToString("C").Remove(0, 1);

        }
    }
}
