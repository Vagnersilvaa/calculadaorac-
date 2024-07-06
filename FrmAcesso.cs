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
    public partial class FrmAcesso : Form
    {
        public FrmAcesso()
        {
            InitializeComponent();
        }

        private void BtnCalculadora_Click(object sender, EventArgs e)
        {
            Form1 FrmMain = new Form1();
            FrmMain.Show();
            this.Hide();
        }
    }
}
