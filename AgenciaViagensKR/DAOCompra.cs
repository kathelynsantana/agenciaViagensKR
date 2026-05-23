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
    //Entidade: Compra
    class DAOCompra
    {
        //Variáveis de outras entidades
        DAOAgente agente;
        DAOCliente cliente;

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
        public DateTime[] dataCompra;
        public double[] total;
        public string[] descricao;
        public string[] venda;
        public int[] codigoCliente;
        public int[] codigoAgenteDeViagens;

        //Conectando o Banco de Dados...
        public DAOCompra()
        {
            //Conexão com o banco de dados...
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
            }
        }//Fim da conexão com o Banco de Dados


        //---------------------------------------------------------------------------------------------------
        //Métodos
        //Cadastrar
        public void cadastrarCompra(DateTime dataCompra, double total, string descricao, string venda, int codigoCliente, int codigoAgenteDeViagens)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{dataCompra}', '{total}', '{descricao}', '{venda}', '{codigoCliente}', '{codigoAgenteDeViagens}')";
                this.comando = $"Insert into compra(dataCompra, total, descricao, venda, codigoCliente, codigoAgenteDeViagens) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                MessageBox.Show($"Os dados do cliente foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show("O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                MessageBox.Show($"Erro ao cadastrar a compra, tente novamente!" + erro);
            }//Fim do try_catch
        }//Fim do método Cadastrar

        //Consultar
            //Consultar por Código
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
                        this.msg = $"\nCódigo:                      {this.codigo[i]}"        +
                                   $"\nData da compra:              {this.dataCompra [i]}"   +
                                   $"\nTotal:                       {this.total[i]}"         +
                                   $"\nDescrição:                   {this.descricao[i]}"     +
                                   $"\nVenda:                       {this.venda[i]}"         +
                                   $"\nCódigo do Cliente:           {this.codigoCliente[i]}" +
                                   $"\nCódigo do Agente de Viagens: {this.codigoAgenteDeViagens[i]}";
                        return this.msg;
                    }//Fim do if
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do método Consultar por Código

            //Consultar Data da Compra
            public string consultarDataCompra(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.dataCompra[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do método Consultar Data da Compra

            //Consultar Total da Compra
            public string consultarTotal(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.total[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Total da Compra

            //Consultar Descrição
            public string consultarDescricao(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.descricao[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Descrição

            //Consultar Venda
            public string consultarVenda(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.venda[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Venda

            //Consultar Código do Cliente
            public string consultarCodigoCliente(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                //Conectando a Entidade Cliente...
                DAOCliente cliente = new DAOCliente();

                //Verificando o código com o método de verificação...
                return cliente.consultarCodigo(codigo);

            }//Fim do Consultar Código do Cliente

            //Cosnultar Código do Agente de Viagens
            public string consultarCodigoAgenteViagens(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                //Conectando a Entidade Agente de Viagens...
                DAOAgente agente = new DAOAgente();

                //Verificando o código com o método de verificação...
                return agente.consultarCodigo(codigo);

            }//Fim do Consultar Código do Cliente

        //Atualizar
        public string atualizarCompra(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
                string query = $"update compra set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Os dados foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados da compra!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do método Atualizar

        //Excluir
        public string excluirCompra(int codigo)
        {
            try
            {
                //Configurando o excluir...
                string query = $"delete from compra where codigo = '{codigo}'";

                //Executando o comando de exclusão...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Deletado com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Erro! Algo deu errado na exclusão!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Excluir


        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor
        public void preencherVetor()
        {
            //Buscando todos os dados da tabela de compra...
            string query = "select * from compra";

            //Instanciando os valores...
            this.codigo                = new int[100];
            this.dataCompra            = new DateTime[100];
            this.total                 = new double[100];
            this.descricao             = new string[100];
            this.venda                 = new string[100];
            this.codigoCliente         = new int[100];
            this.codigoAgenteDeViagens = new int[100];

            //Preenchendo os vetores com valores padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]                = 0;
                this.dataCompra[i]            = new DateTime();
                this.total[i]                 = 0;
                this.descricao[i]             = "";
                this.venda[i]                 = "";
                this.codigoCliente[i]         = 0;
                this.codigoAgenteDeViagens[i] = 0;
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
                this.codigo[i]                = Convert.ToInt32(leitura["codigo"]);
                this.dataCompra[i]            = Convert.ToDateTime(leitura["dataCompra"]);
                this.total[i]                 = Convert.ToDouble(leitura["total"]);
                this.descricao[i]             = leitura["descricao"] + "";
                this.venda[i]                 = leitura["venda"] + "";
                this.codigoCliente[i]         = Convert.ToInt32(leitura["codigoCliente"]);
                this.codigoAgenteDeViagens[i] = Convert.ToInt32(leitura["codigoAgenteDeViagens"]);

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Compra
}//Fim do projeto