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
    //Área de Excluir Agente de Viagens
    public partial class ExcluirAge : Form
    {
        //Variáveis
        DAOAgente agente;

        public ExcluirAge()
        {
            //Inicialização...
            InitializeComponent();
            agente = new DAOAgente();
        }

        //Botão de Excluir
        private void button1_Click(object sender, EventArgs e)
        {
            //Verificando se o campo do código está vazio...
            if (maskedTextBox1.Text == "")
            {
                MessageBox.Show("Por favor, preencha o campo do código!");
            }
            else
            {
                //Variáveis locais
                int codigo = Convert.ToInt32(maskedTextBox1.Text);
                string verificacao = this.agente.consultarCodigo(codigo);

                //Verificando se o código existe...
                if (verificacao == "O código informado não existe!")
                {
                    //Se não existir...
                    MessageBox.Show($"O agente de viagens não foi encontrado. Não foi possível realizar a exclusão!");
                    return;

                }//Fim da verificação do código 

                //Executando a exclusão...
                string excluido = this.agente.excluirAgente(codigo);
                MessageBox.Show(excluido);//Exibindo a mensagem de exclusão do método
                maskedTextBox1.Text = "";//Limpando o campo do código

            }//Fim do if else
        }//Fim do Botão de Excluir

        //Botão de Voltar
        private void button6_Click(object sender, EventArgs e)
        {
            //echando a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Área de Excluir Agente de Viagens
}//Fim do projeto
