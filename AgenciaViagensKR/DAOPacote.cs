using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagensKR
{
    //Entidade: Pacote de Viagens
    class DAOPacote
    {
        //Variáveis
        public MySqlConnection conexao;
        public string dados;
        public string comando;
        public string campo;
        public string novoDado;
        public int i;
        public int contar;

        //Variáveis do Banco de Dados
        public int[] codigo;
        public string[] destino;
        public double[] valor;
        public DateTime[] dataIda;
        public DateTime[] dataVolta;
        public string[] hotel;

        //Cadastrar
        public void cadastrarPacote(string destino, double valor, DateTime dataIda, DateTime dataVolta, string hotel)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{destino}', '{valor}', '{dataIda}', '{dataVolta}', '{hotel}')";
                this.comando = $"Insert into pacote(codigo, destino, valor, dataIda, dataVolta, hotel) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                Console.WriteLine($"Os dados do pacote de viagens foram inseridos com sucesso!\n{resultado}");
                Console.WriteLine("O cadastro foi concluído!\n\n");
            }
            catch(Exception erro)
            {
                //Erro no cadastro
                Console.WriteLine("Erro, algo falhou na inserção de dados e no cadastro!");

            }//Fim do try_catch
        }//Fim do Cadastrar

        //Consultar
        //Atualizar
        public string atualizarPacote(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
                string query = $"update pacote set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return "Os dados foram atualizados com sucesso!";
            }
            catch(Exception erro)
            {
                //Erro na atualização
                return "Erro! Algo deu errado na atualização!";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir
        public string excluirPacote(int codigo)
        {
            try
            {
                //Configurando a exclusão...
                string query = $"delete from pacote where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return "Deletado com sucesso!";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return "Erro! Algo deu errado na exclusão!";

            }//Fim do try_catch
        }//Fim do Excluir


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela pacote de viagens...
            string query = "select * from pacote";

            //Instanciando todos os valores...
            this.codigo    = new int[100];
            this.destino   = new string[100];
            this.valor     = new double[100];
            this.dataIda   = new DateTime[100];
            this.dataVolta = new DateTime[100];
            this.hotel     = new string[100];

            //Preenchendo os vetores com valores padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]    = 0;
                this.destino[i]   = "";
                this.valor[i]     = 0;
                this.dataIda[i] = new DateTime();
                this.dataVolta[i] = new DateTime();
                this.hotel[i]     = "";
            }//Fim do for

            //Executando o comando do SQL...
            MySqlCommand coletar = new MySqlCommand(query, this.conexao);

            //Leitura dos dados no banco de dados...
            MySqlDataReader leitura = coletar.ExecuteReader();//Percorre o banco de dados e traz os dados

            //Zerando o contador...
            i = 0;
            this.contar = 0;

            while (leitura.Read())
            {
                //Fazendo a leitura dos dados...
                this.codigo[i]    = Convert.ToInt32(leitura["codigo"]);
                this.destino[i]   = leitura["destiosno"] + "";
                this.valor[i]     = Convert.ToDouble(leitura["valor"]);
                this.dataIda[i]   = Convert.ToDateTime(leitura["dataIda"]);
                this.dataVolta[i] = Convert.ToDateTime(leitura["dataVolta"]);
                this.hotel[i]     = leitura["hotel"] + "";

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Preencher Vetor

    }//Fim da Entidade Pacote de Viagens
}//Fim do projeto
