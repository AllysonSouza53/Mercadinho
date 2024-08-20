using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mercadinho
{
    public partial class Form1 : Form
    {
        double TC;
        public Form1()
        {
            InitializeComponent();
        }

        private void Bip_Click(object sender, EventArgs e)
        {

            double VU = double.Parse(Evu.Text);
            int Q = int.Parse(Eq.Text);

            double TVP = VU * Q;
            TC += VU * Q;

            CTtc.Text = TC.ToString();

            string item = Ep.Text + " | " + Eq.Text + " | R$" + TVP;
            LTp.Items.Add(item);

            Ep.Text = " ";
            Eq.Text = " ";
            Evu.Text = " ";

            Ep.Focus();
        }

        private void Bnc_Click(object sender, EventArgs e)
        {
            TC = 00.00;

            Ep.Text = " ";
            Eq.Text = " ";
            Evu.Text = " ";

            CTtc.Text = TC.ToString();

            LTp.Items.Clear();

            Ep.Focus();
        }

        private void Bf_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
