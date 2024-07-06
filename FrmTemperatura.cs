using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class FrmTemperatura : Form
    {
        public FrmTemperatura()
        {
            InitializeComponent();
        }

        private void FrmTemperatura_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Tcel, Tkel, Tfah;
            
            Tcel = int .Parse(textBox1.Text);

            Tkel = Tcel + 273;

            Tfah = (((Tcel * 9) / 5) + 32);

            label3.Text = Tkel.ToString();
            label5.Text = Tfah.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmAcesso FrmMain = new FrmAcesso();
            FrmMain.Show();
            this.Hide();
        }
    }
}
