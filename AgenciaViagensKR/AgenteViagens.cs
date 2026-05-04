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
    //Área do Agente de Viagens
    public partial class AgenteViagens : Form
    {
        //Variáveis
        CadastrarAge cadAge;
        LoginAge logAge;
        ConsultarAge conAge;
        AtualizarAge atuAge;
        ExcluirAge excAge;

        public AgenteViagens()
        {
            //Inicialização...
            InitializeComponent();
        }

        //Botão Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de cadastro do agente de viagens
            cadAge = new CadastrarAge();
            cadAge.ShowDialog();

        }//Fim do Botão Cadastrar

        //Botão de Login
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de login do agente de viagens
            logAge = new LoginAge();
            logAge.ShowDialog();

        }//Fim do Botão de Login

        //Botão de Consultar
        private void button3_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de consulta do agente de viagens
            conAge = new ConsultarAge();
            conAge.ShowDialog();

        }//Fim do Botão de Consultar

        //Botão de Atualização
        private void button4_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de atualização do agente de viagens
            atuAge = new AtualizarAge();
            atuAge.ShowDialog();

        }//Fim do Botão de Atualização

        //Botão de Exclusão
        private void button5_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de exclusão do agente de viagens
            excAge = new ExcluirAge();
            excAge.ShowDialog();

        }//Fim do Botão de Exclusão
    }//Fim da Área do Agente de Viagens
}//Fim do projeto
