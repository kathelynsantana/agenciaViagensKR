using MySqlX.XDevAPI;
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
    //Área de Login Agente de Viagens
    public partial class LoginAge : Form
    {
        //Variáveis de outras entidades
        DAOAgente agente;

        public LoginAge()
        {
            //Inicialização...
            InitializeComponent();
            agente = new DAOAgente();
        }

        //MaskedTextBox's
        //MaskedTextBox do E-mail
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do E-mail

        //MaskedTextBox da Senha
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox da Senha

        //Botão de Login
        private void button1_Click(object sender, EventArgs e)
        {
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
            {
                MessageBox.Show("Por favor, preencha todos os campos para realizar o login!");
            }

            //Variáveis para receber os dados
            string email = maskedTextBox1.Text;
            string senha = maskedTextBox2.Text;

            //Chamando o método de validação de login...
            agente.validarLoginAgente(maskedTextBox1.Text, maskedTextBox2.Text);

        }//Fim do botão de Login

        //Botão de Voltar
        private void button6_Click(object sender, EventArgs e)
        {
            //Fechar a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Área de Login Agente de Viagens
}//Fim do projeto
