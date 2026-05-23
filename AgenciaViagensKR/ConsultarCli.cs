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
    //Área de Consulta do Cliente
    public partial class ConsultarCli : Form
    {
        //Variáveis
        DAOCliente cliente;

        public ConsultarCli()
        {
            //Inicializando...
            InitializeComponent();
            this.cliente = new DAOCliente();

            chamarConsulta(dataGridView1);//Configurar toda a estrutura
        }

        //Chamar o método de consulta
        public void chamarConsulta(DataGridView datagrid)
        {
            configurarDataGrid(datagrid);
            nomeColunas(datagrid);
            adicionarDados(datagrid);

        }//Fim do método de consulta

        //DatagridView
        //Exibição do DataGridView
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }//Fim da exibição do DataGridViews

        //Configurando o DataGridView
        //Nome das colunas do DataGridView
        public void nomeColunas(DataGridView datagrid)
        {
            //Definindo os nomes das colunas do DataGridView...
            datagrid.Columns[0].Name = "Código";
            datagrid.Columns[1].Name = "Nome";
            datagrid.Columns[2].Name = "CPF";
            datagrid.Columns[3].Name = "Data de Nascimento";
            datagrid.Columns[4].Name = "Email";
            datagrid.Columns[5].Name = "Senha";
            datagrid.Columns[6].Name = "Telefone";
            datagrid.Columns[7].Name = "Histórico";
        }//Fim do nome das colunas do DataGridView

        //Definir e configurar a estrutura da tabela
        public void configurarDataGrid(DataGridView dataGrid)
        {
            //Definindo algumas permissões...
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnCount = 8;
        }//Fim do definir e configurar a estrutura da tabela

        //Adicionar dados no DataGridView
        public void adicionarDados(DataGridView datagrid)
        {
            //Preencher o vetor
            this.cliente.preencherVetor();
            for (int i = 0; i < this.cliente.contar; i++)
            {
                datagrid.Rows.Add(this.cliente.codigo[i], this.cliente.nome[i], this.cliente.cpf[i], this.cliente.dataNascimento[i], this.cliente.email[i], this.cliente.senha[i], this.cliente.telefone[i], this.cliente.historico[i]);
            }//Fim do for
        }//Fim do adicionar dados no DataGridView

        //Retornar o DataGridView
        public DataGridView retornarData()
        {
            return dataGridView1;
        }//Fim do retornar o DataGridView

        //Botão de Voltar
        private void button6_Click(object sender, EventArgs e)
        {
            //Fechar a aba...
            this.Close();

        }//Fim do Botão de Voltar
    }//Fim da Área de Consulta do Cliente
}//Fim do projeto