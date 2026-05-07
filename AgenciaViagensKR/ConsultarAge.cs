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
    //Área de Consulta do Agente de Viagens
    public partial class ConsultarAge : Form
    {
        //Variáveis
        DAOAgente agente;

        public ConsultarAge()
        {
            //Inicialização...
            InitializeComponent();
            this.agente = new DAOAgente();

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
            datagrid.Columns[2].Name = "Email";
            datagrid.Columns[3].Name = "Senha";
            datagrid.Columns[4].Name = "Comissão";
        }//Fim do nome das colunas do DataGridView

        //Definir e configurar a estrutura da tabela
        public void configurarDataGrid(DataGridView dataGrid)
        {
            //Definindo algumas permissões...
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToResizeColumns = false;
            dataGrid.AllowUserToResizeRows = false;

            dataGrid.ColumnCount = 5;
        }//Fim do definir e configurar a estrutura da tabela

        //Adicionar dados no DataGridView
        public void adicionarDados(DataGridView datagrid)
        {
            //Preencher o vetor
            this.agente.preencherVetor();
            for (int i = 0; i < this.agente.contar; i++)
            {
                datagrid.Rows.Add(this.agente.codigo[i], this.agente.nome[i], this.agente.email[i], this.agente.senha[i], this.agente.comissao[i]);
            }//Fim do for
        }//Fim do adicionar dados no DataGridView

        //Retornar o DataGridView
        public DataGridView retornarData()
        {
            return dataGridView1;
        }//Fim do retornar o DataGridView

    }//Fim da Área de Consulta do Agente de Viagens
}//Fim do projeto
