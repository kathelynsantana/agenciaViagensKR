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
    //Área de Excluir Cliente
    public partial class ExcluirCli : Form
    {
        //Variáveis
        DAOCliente cliente;

        public ExcluirCli()
        {
            //Inicialização...
            InitializeComponent();
            cliente = new DAOCliente();
        }

        //Textbox do Código do Cliente
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do Textbox do Código do Cliente

        //Botão Excluir
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se o campo do código está vazio...
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo do código!");
            }
            else
            {
                //Executando a exclusão...
                int codigo = Convert.ToInt32(maskedTextBox1.Text);
                string excluido = this.cliente.excluirCliente(codigo);
                MessageBox.Show(excluido);//Exibindo a mensagem de exclusão do método
                maskedTextBox1.Text = "";//Limpando o campo do código

            }//Fim do if else
        }//Fim do Botão Excluir
    }//Fim da Área de Excluir Cliente
}//Fim do projeto
