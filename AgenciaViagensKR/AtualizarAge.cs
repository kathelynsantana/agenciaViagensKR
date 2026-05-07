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
    //Área de Atualizar Agente
    public partial class AtualizarAge : Form
    {
        //Váriaveis
        DAOAgente agente;

        public AtualizarAge()
        {
            //Inicialização...
            InitializeComponent();
            agente = new DAOAgente();
        }

        //Botão de Atualizar
        private void button1_Click(object sender, EventArgs e)
        {
            //Variável local
            int codigo = Convert.ToInt32(maskedTextBox1.Text);

            //Atualizando...
            this.agente.atualizarAgente(codigo, "nome", maskedTextBox2.Text);
            this.agente.atualizarAgente(codigo, "email", maskedTextBox5.Text);
            this.agente.atualizarAgente(codigo, "comissao", maskedTextBox8.Text);

            MessageBox.Show("Os dados foram atualizados com sucesso!");

            //Limpar os campos
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox8.Text = "";

        }//Fim do Botão de Atualizar

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
                maskedTextBox2.Text = this.agente.consultarNome(codigo);
                maskedTextBox5.Text = this.agente.consultarEmail(codigo);
                maskedTextBox8.Text = this.agente.consultarComissao(codigo);

            }//Fim do if_else
        }//Fim do Botão de Buscar
    }//Fim da Área de Atualizar Agente
}//Fim do projeto
