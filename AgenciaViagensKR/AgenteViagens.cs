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
    //Agente de Viagens
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
            InitializeComponent();
        }

        //Botão Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            //Cadastrar Agente de Viagens
            cadAge = new CadastrarAge();
            cadAge.ShowDialog();

        }//Fim do Botão Cadastrar

        //Botão de Login
        private void button2_Click(object sender, EventArgs e)
        {
            //Cadastrar Agente de Viagens
            logAge = new LoginAge();
            logAge.ShowDialog();

        }//Fim do Botão de Login

        //Botão de Consultar
        private void button3_Click(object sender, EventArgs e)
        {
            //Consultar um Agente de Viagens
            conAge = new ConsultarAge();
            conAge.ShowDialog();

        }//Fim do Botão de Consultar

        //Botão de Atualização
        private void button4_Click(object sender, EventArgs e)
        {
            //Atualizar um Agente de Viagens
            atuAge = new AtualizarAge();
            atuAge.ShowDialog();

        }//Fim do Botão de Atualização

        //Botão de Exclusão
        private void button5_Click(object sender, EventArgs e)
        {
            //Excluir um Agente de Viagens
            excAge = new ExcluirAge();
            excAge.ShowDialog();

        }//Fim do Botão de Exclusão
    }//Fim do Agente de Viagens
}//Fim do projeto
