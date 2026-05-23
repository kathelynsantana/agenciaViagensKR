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
                maskedTextBox2.Text = this.cliente.consultarNome(codigo);
                maskedTextBox3.Text = this.cliente.consultarCpf(codigo);
                maskedTextBox4.Text = this.cliente.consultarDataNascimento(codigo);
                maskedTextBox5.Text = this.cliente.consultarEmail(codigo);
                maskedTextBox7.Text = this.cliente.consultarTelefone(codigo);
                maskedTextBox8.Text = this.cliente.consultarHistorico(codigo);

            }//Fim do if_else
        } //Fim do Botão de Buscar

        //Botão de Atualizar
        private void button1_Click(object sender, EventArgs e)
        {
            //Variáveis locais
            int codigo = Convert.ToInt32(maskedTextBox1.Text);
            string verificacao = this.cliente.consultarCodigo(codigo);

            //Verificando se o código existe...
            if (verificacao == "O código informado não existe!")
            {
                //Se não existir...
                MessageBox.Show($"O cliente não foi encontrado. Não foi possível realizar a atualização!");
                return;

            }//Fim da verificação do código 

            //Atualizando...
            this.cliente.atualizarCliente(codigo, "nome", maskedTextBox2.Text);
            this.cliente.atualizarCliente(codigo, "cpf", maskedTextBox3.Text);
            this.cliente.atualizarCliente(codigo, "dataNascimento", maskedTextBox4.Text);
            this.cliente.atualizarCliente(codigo, "email", maskedTextBox5.Text);
            this.cliente.atualizarCliente(codigo, "telefone", maskedTextBox7.Text);
            this.cliente.atualizarCliente(codigo, "historico", maskedTextBox8.Text);

            MessageBox.Show("Os dados foram atualizados com sucesso!");

            //Limpar os campos
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            maskedTextBox3.Text = "";
            maskedTextBox4.Text = "";
            maskedTextBox5.Text = "";
            maskedTextBox7.Text = "";
            maskedTextBox8.Text = "";

        }//Fim do Botão de Atualizar

        //Botão de Voltar
        private void button6_Click(object sender, EventArgs e)
        {
            //Fechando a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Área de Atualizar Cliente
}//Fim do projeto
