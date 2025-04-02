using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMCCalculadora
{
    public partial class frmIMCCalculadora : Form
    {
        public frmIMCCalculadora()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso, altura, idade, imc = 0;
                       

            try
            {
                peso = Convert.ToDouble(txtPeso.Text);

                altura = Convert.ToDouble(txtAltura.Text);

                idade = Convert.ToDouble(txtIdade.Text);   
                
                

              if (rdbSexoF.Checked && idade < 65 || rdbSexoM.Checked && idade < 65)
                {
                    imc = peso / (altura * altura);

                    txtResultado.Text = imc.ToString("0.00");

                    if (idade >= 20 && imc >= 40)
                    {
                        rdbObesidadeGrauIII.Checked = true;
                    }
                    else if (idade >= 20 && idade <= 64 && imc >= 35 && imc <= 39.9)
                    {
                        rdbObesidadeGrauII.Checked = true;
                    }
                    else if (idade >= 20 && idade <= 64 && imc >= 30 && imc <= 34.9)
                    {
                        rdbObesidadeGrauI.Checked = true;
                    }
                    else if (idade >= 20 && idade <= 64 && imc >= 25 && imc <= 29.9)
                    {
                        rdbSobrepeso.Checked = true;
                    }
                    else if (idade >= 20 && idade <= 64 && imc >= 18.5 && imc <= 24.9)
                    {
                        rdbPesoNormal.Checked = true;
                    }
                    else if (idade >= 20 && idade <= 64 && imc < 18.5)
                    {
                        rdbAbaixoDoPeso.Checked = true;
                    }
                }

                else if (rdbSexoF.Checked && idade > 65)
                {

                    imc = peso / (altura * altura);

                    txtResultado.Text = imc.ToString("0.00");

                    /************************    IMC MULHERES IDADE >= 65    ************************/

                    if (idade >= 65 && imc >= 42)
                    {
                        rdbObesidadeGrauIII.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 37.1 && imc <= 41.9)
                    {
                        rdbObesidadeGrauII.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 32.1 && imc <= 37.0)
                    {
                        rdbObesidadeGrauI.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 27.1 && imc <= 32.0)
                    {
                        rdbSobrepeso.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 22.0 && imc <= 27.0)
                    {
                        rdbPesoNormal.Checked = true;
                    }
                    else if (idade >= 65 && imc < 21.9)
                    {
                        rdbAbaixoDoPeso.Checked = true;
                    }

                }

                else if (rdbSexoM.Checked && idade > 65)
                {
                    imc = peso / (altura * altura);

                    txtResultado.Text = imc.ToString("0.00");

                    /************************    IMC HOMENS IDADE >= 65    ************************/

                    if (idade >= 65 && imc >= 40)
                    {
                        rdbObesidadeGrauIII.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 35.1 && imc <= 39.9)
                    {
                        rdbObesidadeGrauII.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 30.1 && imc <= 35.0)
                    {
                        rdbObesidadeGrauI.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 27.1 && imc <= 30.0)
                    {
                        rdbSobrepeso.Checked = true;
                    }
                    else if (idade >= 65 && imc >= 22.0 && imc <= 27.0)
                    {
                        rdbPesoNormal.Checked = true;
                    }
                    else if (idade >= 65 && imc < 21.9)
                    {
                        rdbAbaixoDoPeso.Checked = true;
                    }

                }

                if (rdbSexoF.Checked == false && rdbSexoM.Checked == false)
                {
                    MessageBox.Show("Selecione o sexo!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                if (idade < 20)
                {
                    MessageBox.Show("Idade inválida! Insira uma idade Maior que 19 anos", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtIdade.Focus();
                }
                               
            }
            catch (Exception)
            {
                MessageBox.Show("Preencha todos os campos!", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeso.Focus();
            }                       

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtPeso.Clear();
            txtAltura.Clear();
            txtIdade.Clear();
            txtResultado.Clear();
            rdbSexoF.Checked = false;
            rdbSexoM.Checked = false;
            txtPeso.Focus();
            rdbAbaixoDoPeso.Checked = false;
            rdbPesoNormal.Checked = false;
            rdbSobrepeso.Checked = false;
            rdbObesidadeGrauI.Checked = false;
            rdbObesidadeGrauII.Checked = false;
            rdbObesidadeGrauIII.Checked = false;
        }
    }
}
