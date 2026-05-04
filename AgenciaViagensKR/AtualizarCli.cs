using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//AJUSTARRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRRR
namespace AgenciaViagensKR
{
    //Área de Atualizar Cliente
    public partial class AtualizarCli : Form
    {
        //Váriaveis
        DAOCliente cliente;

        public AtualizarCli()
        {
            //Inicialização...
            InitializeComponent();
            cliente = new DAOCliente();
        }

        //MaskedTextBox's
        //MaskedTextBox do Código
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do Código

        //MaskedTextBox do Nome
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do Nome

        //MaskedTextBox do CPF
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do CPF

        //MaskedTextBox da Data de Nascimento
        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox da Data de Nascimento

        //MaskedTextBox do E-mail
        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do E-mail

        //MaskedTextBox da Senha
        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox da Senha

        //MaskedTextBox do Telefone
        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do Telefone

        //MaskedTextBox do Histórico de Compras
        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do Histórico de Compras

        //Botão de Buscar
        private void button2_Click(object sender, EventArgs e)
        {
            //Verificando se o campo do código está vazio...
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Por favor, informe o código do cliente!");
            }
            else
            {
                //Buscando os dados do cliente no Banco de Dados e exibindo...
                int codigo = Convert.ToInt32(maskedTextBox1.Text);
                maskedTextBox2.Text = cliente.consultarNome(codigo);
                maskedTextBox3.Text = cliente.consultarCpf(codigo);
                maskedTextBox4.Text = cliente.consultarDataNascimento(codigo);
                maskedTextBox5.Text = cliente.consultarEmail(codigo);
                maskedTextBox6.Text = cliente.consultarSenha(codigo);
                maskedTextBox7.Text = cliente.consultarTelefone(codigo);
                maskedTextBox8.Text = cliente.consultarHistorico(codigo);

            }//Fim do if_else
        } //Fim do Botão de Buscar

        //Botão de Atualizar
        private void button1_Click(object sender, EventArgs e)
        {
            //Variável local
            int codigo = Convert.ToInt32(maskedTextBox1.Text);

            //Atualizando...
            
        }//Fim do Botão de Atualizar
    }//Fim da Área de Atualizar Cliente
}//Fim do projeto
