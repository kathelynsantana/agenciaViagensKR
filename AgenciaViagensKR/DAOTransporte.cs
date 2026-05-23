using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgenciaViagensKR
{
    //Entidade: Transporte
    class DAOTransporte
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
        public string[] nome;
        public long[] cnpj;
        public string[] tipoTransporte;
        public int[] frotaDisponivel;

        //Conectando o Banco de Dados...
        public DAOTransporte()
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
        public void cadastrarTransporte(string nome, long cnpj, string tipoTransporte, int frotaDisponivel)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{nome}', '{cnpj}', '{tipoTransporte}', '{frotaDisponivel}')";
                this.comando = $"Insert into transporte(codigo, nome, cnpj, tipoTransporte, frotaDisponivel) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                Console.WriteLine($"Os dados do transporte foram inseridos com sucesso!\n{resultado}");
                Console.WriteLine("O cadastro foi concluído com sucesso!");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                Console.WriteLine("Erro! Algo falhou na inserção de dados e no cadastro!");
            }//Fim do try_catch
        }//Fim do Cadastrar

        //Consultar
            //Consultar por Código do Transporte
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
                        this.msg = $"\nCódigo:             {this.codigo[i]} "        +
                                   $"\nNome:               {this.nome[i]} "          +
                                   $"\nCNPJ:               {this.cnpj[i]}"           +
                                   $"\nTipo de Transporte: {this.tipoTransporte[i]}" +
                                   $"\nFrota Disponível:   {this.frotaDisponivel[i]}";
                        return this.msg;
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar por Código do Transporte

            //Consultar Nome
            public string consultarNome(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.nome[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Nome

            //Consultar CNPJ
            public string consultarCnpj(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.cnpj[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar CNPJ

            //Consultar Tipo de Transporte
            public string consultarTipoTransporte(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.tipoTransporte[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Tipo de Transporte

            //Consultar Frota Disponível
            public string consultarFrotaDisponivel(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.frotaDisponivel[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Frota Disponível

        //Atualizar
        public string atualizarTransporte(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
                string query = $"update transporte set {campo} = '{novoDado}' where codigo = '{codigo}'";

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
        public string excluirTransporte(int codigo)
        {
            try
            {
                //Configurando o excluir...
                string query = $"delete from transporte where codigo = '{codigo}'";

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
            //Buscando todos os dados da tabela do transporte...
            string query = "select * from transporte";

            //Instanciando os valores...
            this.codigo          = new int[100];
            this.nome            = new string[100];
            this.cnpj            = new long[100];
            this.tipoTransporte  = new string[100];
            this.frotaDisponivel = new int[100];

            //Preenchendo os vetores com valores padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]          = 0;
                this.nome[i]            = "";
                this.cnpj[i]            = 0;
                this.tipoTransporte[i]  = "";
                this.frotaDisponivel[i] = 0;
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
                this.codigo[i]          = Convert.ToInt32(leitura["codigo"]);
                this.nome[i]            = leitura["nome"] + "";
                this.cnpj[i]            = Convert.ToInt64(leitura["cnpj"]);
                this.tipoTransporte[i]  = leitura["tipoTransporte"] + "";
                this.frotaDisponivel[i] = Convert.ToInt32(leitura["frotaDisponivel"]);

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Transporte
}//Fim do projeto