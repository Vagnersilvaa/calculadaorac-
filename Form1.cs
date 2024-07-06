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
    public partial class Form1 : Form
    {
        List<string> ListaHistorico = new List<string>();



        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        
        
        //Botões Layout:
        public void botaoClick(string caracter)
        {

            if (labelTexto.Text == "" | labelTexto.Text == null)
            {
                labelTexto.Text = caracter;
            }
            else
            {
                labelTexto.Text += caracter;
            }

            buttonLimpar.Text = "AC";
        }
        private void button0_Click(object sender, EventArgs e)
        {
            botaoClick("0");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            botaoClick("1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            botaoClick("2");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            botaoClick("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            botaoClick("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            botaoClick("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            botaoClick("6");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            botaoClick("7");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            botaoClick("8");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            botaoClick("9");
        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            botaoClick(",");
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            botaoClick("/");
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            
                botaoClick("x");
        }

        private void buttonSubtrair_Click(object sender, EventArgs e)
        {
            botaoClick("-");
        }

        private void buttonSomar_Click(object sender, EventArgs e)
        {
            botaoClick("+");
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            switch (e.KeyChar)
            {
                case (char)48:
                    button0.PerformClick();
                    break;

                case (char)49:
                    button1.PerformClick();
                    break;

                case (char)50:
                    button2.PerformClick();
                    break;
                
                case (char)51:
                    button3.PerformClick();
                    break;

                case (char)52:
                    button4.PerformClick();
                    break;
                
                case (char)53:
                    button5.PerformClick();
                    break;

                case (char)54:
                    button6.PerformClick();
                    break;

                case (char)55:
                    button7.PerformClick();
                    break;

                case (char)56:
                    button8.PerformClick();
                    break;

                case (char)57:
                    button9.PerformClick();
                    break;

                case (char)44:
                    buttonVirgula.PerformClick();
                    break;

                case (char)43:
                    buttonSomar.PerformClick();
                    break;

                case (char)45:
                    buttonSubtrair.PerformClick();
                    break;

                case (char)42:
                    buttonMultiplicar.PerformClick();
                    break;

                case (char)47:
                    buttonDividir.PerformClick();
                    break;

                case (char)8:
                    buttonVoltar.PerformClick();
                    break;



            }






        }


        //Botões de execução:      

        private void buttonResultado_Click(object sender, EventArgs e)
        {

            //Variavéis
            String operacao = labelTexto.Text;
            char separadorMa = '+';
            char separadorMe = '-';
            char separadorMu = 'x';
            char separadorDi = '/';
            double resultadoMultiplicação = 1;
            double resultadoDivisão = 0;
            double resultadoSoma = 0;
            double resultadoSubtracao = 0;



            //Resolução:

            // Realizar primeiro filtro -> Sinal de +
            string[] numeros = operacao.Split(separadorMa);

            for (int i = 0; i < numeros.Length; i++)
            {
                #region Resultado da parte que contém subtração
                try
                {
                    
                    if (numeros[i].Contains("-"))
                    {
                        string[] subtraidos = numeros[i].Split(separadorMe);

                        // Descubrir numeros que serão subtraídos
                        for (int s = 0; s < subtraidos.Length; s++)
                        {
                            //Se multiplicação -> Separar os números para multiplicação
                            if (subtraidos[s].Contains("x"))
                            {
                                string numMul = subtraidos[s];
                                string[] multiplicadores = numMul.Split(separadorMu);


                                //Multiplicar
                                resultadoMultiplicação = 1;
                                for (int m = 0; m < multiplicadores.Length; m++)
                                {   
                                   resultadoMultiplicação *= Convert.ToDouble(multiplicadores[m]);
                                    
                                }
                                subtraidos[s] = resultadoMultiplicação.ToString();
                            }

                            //Se divisão -> Separar os números para divisão
                            if (subtraidos[s].Contains("/"))
                            {
                                string numDiv = subtraidos[s];
                                string[] divisores = numDiv.Split(separadorDi);

                                //Dividir
                                resultadoDivisão = 0;
                                for (int d = 0; d < divisores.Length; d++)
                                {

                                    if (resultadoDivisão == 0)
                                    {
                                        resultadoDivisão = Convert.ToDouble(divisores[d]);
                                    }
                                    else
                                    {
                                        resultadoDivisão /= Convert.ToDouble(divisores[d]);
                                    }
                                }

                                subtraidos[s] = resultadoDivisão.ToString();

                            }

                        }

                        //Subtrair os números
                        resultadoSubtracao = 0;
                        for (int s = 0; s < subtraidos.Length; s++)
                        {
                            if (resultadoSubtracao == 0)
                            {
                                resultadoSubtracao = Convert.ToDouble(subtraidos[s]);
                            }
                            else
                            {
                                resultadoSubtracao -= Convert.ToDouble(subtraidos[s]);
                            }

                        }
                        numeros[i] = resultadoSubtracao.ToString();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro subtração: " + ex);
                }
                #endregion

                #region Resultado da parte que contém multiplicação
                try
                {
                    

                    if (numeros[i].Contains("x"))
                    {
                        string[] multiplicadores = numeros[i].Split(separadorMu);

                        // Descubrir numeros que serão multiplicados
                        for (int m = 0; m < multiplicadores.Length; m++)
                        {

                            //Se divisão -> Separar os números para divisão
                            if (multiplicadores[m].Contains("/"))
                            {
                                string numDiv = multiplicadores[m];
                                string[] divisores = numDiv.Split(separadorDi);

                                //Dividir 
                                resultadoDivisão = 0;
                                for (int d = 0; d < divisores.Length; d++)
                                {

                                    if (resultadoDivisão == 0)
                                    {
                                        resultadoDivisão = Convert.ToDouble(divisores[d]);
                                    }
                                    else
                                    {
                                        resultadoDivisão /= Convert.ToDouble(divisores[d]);
                                    }

                                }

                                multiplicadores[m] = resultadoDivisão.ToString();
                            }

                        }

                        //Multiplicar os números
                        resultadoMultiplicação = 1;
                        for (int m = 0; m < multiplicadores.Length; m++)
                        {
                            resultadoMultiplicação *= Convert.ToDouble(multiplicadores[m]);
                        }
                        numeros[i] = resultadoMultiplicação.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro multiplicação: " + ex);
                }
                #endregion

                #region Resultado da parte que contém divisão
                try
                {
                    
                    if (numeros[i].Contains("/"))
                    {
                        string[] divisores = numeros[i].Split(separadorDi);

                        // Descubrir numeros que serão dividos
                        for (int d = 0; d < divisores.Length; d++)
                        {

                            //Se multiplicação -> Separar os números para multiplicar
                            if (divisores[d].Contains("*"))
                            {
                                string numMul = divisores[d];
                                string[] multiplicadores = numMul.Split(separadorMu);

                                //Multiplicar 
                                resultadoMultiplicação = 0;
                                for (int m = 0; m < multiplicadores.Length; m++)
                                {
                                    double numero = Convert.ToDouble(multiplicadores[m]);
                                    resultadoMultiplicação = numero * resultadoMultiplicação;
                                }

                                divisores[d] = resultadoMultiplicação.ToString();
                            }


                        }

                        //Dividir os números
                        resultadoDivisão = 0;
                        for (int d = 0; d < divisores.Length; d++)
                        {

                            if (resultadoDivisão == 0)
                            {
                                resultadoDivisão = Convert.ToDouble(divisores[d]);
                            }
                            else
                            {
                                resultadoDivisão /= Convert.ToDouble(divisores[d]);
                            }
                        }
                        numeros[i] = resultadoDivisão.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro divisão: " + ex);
                }
                #endregion

                #region Resultado Soma
                try
                {
                    resultadoSubtracao = 0;
                    resultadoSoma += Convert.ToDouble(numeros[i]);
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Erro soma: " + ex);
                }
                #endregion


                //Mostrar resultado
                labelTexto.Text = resultadoSoma.ToString();
                labelHistorico.Text = operacao;


                ListaHistorico.Add(labelHistorico.Text);
                ListaHistorico.Add("= " + labelTexto.Text);
            }

        }

        private void buttonLimpar_Click(object sender, EventArgs e)
        {
            labelHistorico.Text = "";
            labelTexto.Text = "";
        }

        private void buttonVoltar_Click_1(object sender, EventArgs e)
        {
            int quant = labelTexto.Text.Length;
            string ultimoNum = labelTexto.Text.Substring(quant - 1);
            labelTexto.Text = labelTexto.Text.Replace(ultimoNum, ("".ToString()));
        }

        private void históricoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Hide();

            Historico h = new Historico(ListaHistorico);

            h.Show();
            h.Visible = false;
            h.ShowDialog();
            Show();
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            FrmAcesso FrmMain = new FrmAcesso();
            FrmMain.Show();
            this.Hide();
        }
    }

}

