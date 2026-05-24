using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgenciaViagensKR
{
    //Área de Cadastrar Cliente
    public partial class CadastrarCli : Form
    {
        //Variáveis
        DAOCliente cliente;

        public CadastrarCli()
        {
            //Inicializando...
            InitializeComponent();
            cliente = new DAOCliente();
        }

        //Textbox's
        //TextBox do Nome
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do TextBox do Nome

        //TextBox do E-mail
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do TextBox do E-mail

        //TextBox da Senha
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do TextBox da Senha

        //TextBox do Histórico
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do TextBox do Histórico

        //MaskedTextBox's
        //MaskedTextBox do CPF
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do CPF

        //MaskedTextBox da Data de Nascimento
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox da Data de Nascimento

        //Botão de Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (maskedTextBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                long cpf = Convert.ToInt64(maskedTextBox1.Text.Replace(",", "").Replace("-", ""));//Tratando os caracteres e removendo eles
                string email = textBox2.Text;
                string senha = textBox3.Text;
                string telefone = maskedTextBox3.Text;
                string historico = textBox4.Text;

                //Tratamento do Datetime...
                string dt = maskedTextBox2.Text;
                string dtDia = dt.Substring(0, 2);
                string dtMes = dt.Substring(3, 2);
                string dtAno = dt.Substring(6, 4);
                String dtNascimento = (dtAno + "-" + dtMes + "-" + dtDia);

                //Inserindo esses dados no Banco de Dados...
                this.cliente.cadastrarCliente(nome, cpf, Convert.ToDateTime(maskedTextBox2.Text), email, senha, telefone, historico);

                //Limpando os campos após o cadastro...
                LimparCampos();
            }//Fim do if_else
        }//Fim do Botão de Cadastrar

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox3.Text = "";
            textBox4.Text = "";

        }//Fim do método de Limpar os Campos

        //Botão de Validação do CPF
        private void button2_Click(object sender, EventArgs e)
        {
            //Variáveis
            string cpfDigitado = maskedTextBox1.Text.Replace(",", "").Replace("-", "").Replace(".", "");//Tratando os caracteres e removendo eles

            //Convertendo o CPF para long...
            long cpf = Convert.ToInt64(cpfDigitado);

            //Chamando o método de validação do CPF...
            this.cliente.validarCpf(cpf);

        }//Fim do Botão de Validação do CPF

        //Botão de Voltar
        private void button6_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Área de Cadastrar Cliente
}//Fim do projeto
