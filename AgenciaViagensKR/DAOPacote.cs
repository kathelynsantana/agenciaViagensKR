using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Importando os comandos de conexão com o banco
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaViagensKR
{
    //Entidade: Pacote de Viagens
    class DAOPacote
    {
        //Variáveis
        public string dados;
        public string comando;
        public string campo;
        public string novoDado;
        public int i;
        public int contar;
        public string msg;

        //Variáveis e Vetores do Banco de Dados
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public int[] codigo;
        public string[] destino;
        public double[] valor;
        public DateTime[] dataIda;
        public DateTime[] dataVolta;
        public string[] hotel;

        //Conectando o Banco de Dados...
        public DAOPacote()
        {
            //Conexão com o Banco de Dados
            string conexaoString = "server=localhost;database=agenciaDeViagens;uid=root;pwd=;";
            this.conexao = new MySqlConnection(conexaoString);
            try
            {
                this.conexao.Open();
                MessageBox.Show("Conectado com sucesso!");
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao conectar ao banco de dados: {erro.Message}");
            }//Fim do try_catch
        }//Fim da conexão


        //----------------------------------------------------------------------------------------------------
        //Métodos
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
            //Consultar por Código do Pacote de Viagens
            public string consultarCodigo(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                this.msg = "";
                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        this.msg = $"\nCódigo:        {this.codigo[i]}"    +
                                   $"\nDestino:       {this.destino[i]}"   +
                                   $"\nValor:         {this.valor[i]}"     +
                                   $"\nData de Ida:   {this.dataIda[i]}"   +
                                   $"\nData de Volta: {this.dataVolta[i]}" +
                                   $"\nHotel:         {this.hotel[i]}";
                        return this.msg;
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar por Código do Transporte

            //Consultar Destino
            public string consultarDestino(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (int i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.destino[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Destino

            //Consultar Valor
            public string consultarValor(int codigo)
            {
                for (int i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.valor[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Valor

            //Consultar Data de Ida
            public string consultarDataIda(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.dataIda[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Data de Ida

            //Consultar Data de Volta
            public string consultarDataVolta(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.dataVolta[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Data de Volta

            //Consultar Hotel
            public string consultarHotel(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.hotel[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Hotel

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
                this.dataIda[i]   = new DateTime();
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
                this.destino[i]   = leitura["destino"] + "";
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
