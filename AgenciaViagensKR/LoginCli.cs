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
    //Área de Login Cliente
    public partial class LoginCli : Form
    {
        DAOCliente cliente;
        public LoginCli()
        {
            //Inicialização...
            InitializeComponent();
            cliente = new DAOCliente();
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
            //Verificando se os campos estão vazios...
            if ((maskedTextBox1.Text == "") || (maskedTextBox2.Text == ""))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");

            }
            else
            {
                
            }//Fim do if_else
        }//Fim do Botão de Login
    }//Fim da Área de Login Cliente
}//Fim do projeto
