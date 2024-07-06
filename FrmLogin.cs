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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            String Usuario = "vagner";
            String Senha = "vagner";
            if(TxtUsuario.Text == Usuario & TxtSenha.Text == Senha)
            {
                MessageBox.Show("Acesso Liberado");
                FrmAcesso FrmMain = new FrmAcesso();
                FrmMain.Show();
                this.Hide();
            }
        }
    }
}
