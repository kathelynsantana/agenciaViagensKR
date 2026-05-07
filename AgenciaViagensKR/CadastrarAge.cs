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
    //Área de Cadastrar Agente de Viagens
    public partial class CadastrarAge : Form
    {
        //Variáveis
        DAOAgente agente;

        public CadastrarAge()
        {
            //Inicialização...
            InitializeComponent();
            agente = new DAOAgente();
        }

        //TextBox do Nome
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//TextBox do Nome

        //TextBox do E-mail
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//TextBox do E-mail

        //TextBox da Senha
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//TextBox da Senha

        //TextBox da Comissão
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//TextBox da Comissão

        //Botão de Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                string email = textBox2.Text;
                string senha = textBox3.Text;
                double comissao = Convert.ToDouble(textBox4.Text);

                //Inserindo esses dados no Banco de Dados...
                this.agente.cadastrarAgente(nome, email, senha, comissao);

                //Limpando os campos após o cadastro...
                LimparCampos();
            }//Fim do if_else
        }//Botão de Cadastrar

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";

        }//Fim do método de Limpar os Campos
    }//Fim do Área de Cadastrar Agente de Viagens
}//Fim do projeto
