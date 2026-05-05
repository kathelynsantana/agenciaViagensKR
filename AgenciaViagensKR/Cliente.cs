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
    //Área do Cliente
    public partial class Cliente : Form
    {
        //Variáveis
        CadastrarCli cadCli;
        LoginCli logCli;
        ConsultarCli conCli;
        AtualizarCli atuCli;
        ExcluirCli excCli;
      

        public Cliente()
        {
            //Inicialização...
            InitializeComponent();
        }

        //Botão Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de cadastro do cliente
            cadCli = new CadastrarCli();
            cadCli.ShowDialog();

        }//Fim do Botão Cadastrar

        //Botão de Login
        private void button2_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de login do cliente
            logCli = new LoginCli();
            logCli.ShowDialog();

        }//Fim do Botão de Login

        //Botão de Consultar
        private void button3_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de consulta do cliente
            conCli = new ConsultarCli();
            conCli.ShowDialog();

        }//Fim do Botão de Consultar

        //Botão de Atualização
        private void button4_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de atualização do cliente
            atuCli = new AtualizarCli();
            atuCli.ShowDialog();

        }//Fim do Botão de Atualização

        //Botão de Exclusão
        private void button5_Click(object sender, EventArgs e)
        {
            //Redirecionando para a tela de exclusão do cliente
            excCli = new ExcluirCli();
            excCli.ShowDialog();

        }//Fim do Botão de Exclusão
    }//Fim da Área do Cliente
}//Fim do projeto
