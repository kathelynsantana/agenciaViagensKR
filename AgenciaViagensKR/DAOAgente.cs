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
    //Entidade: Agente de Viagens
    class DAOAgente
    {
        //Variáveis
        public string dados;
        public string comando;
        public string campo;
        public string novoDado;
        public int i;
        public int contar;
        public string msg;

        //Variáveis de outras entidades
        GerencAge gerenc;

        //Variáveis e Vetores do Banco de Dados
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public int[] codigo;
        public string[] nome;
        public string[] email;
        public string[] senha;
        public double[] comissao;

        //Conectando o Banco de Dados...
        public DAOAgente()
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
        public void cadastrarAgente(string nome, string email, string senha, double comissao)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{nome}', '{email}', '{senha}', '{comissao}')";
                this.comando = $"Insert into agenteDeViagens(codigo, nome, email, senha, comissao) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                MessageBox.Show($"Os dados do agente de viagens foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show("O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                MessageBox.Show($"Erro! Algo falhou na inserção de dados e no cadastro!" + erro);
            }//Fim do try_catch
        }//Fim do Cadastrar

        //Consultar
            //Consultar por Código do Agente de Viagens
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
                        this.msg = $"\nCódigo:   {this.codigo[i]}"  +
                                   $"\nNome:     {this.nome[i]}"    +
                                   $"\nE-mail:   {this.email[i]}"   +
                                   $"\nSenha:    {this.senha[i]}"   +
                                   $"\nComissão: {this.comissao[i]}";
                        return this.msg;
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar por Código do Agente de Viagens

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

            //Consultar E-mail
            public string consultarEmail(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (int i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.email[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar E-mail

            //Consultar Comissão
            public string consultarComissao(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.comissao[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Comissão

        //Login
        public void validarLoginAgente(string email, string senha)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for (i = 0; i < this.contar; i++)
            {
                if ((this.email[i] == email) && (this.senha[i] == senha))
                {
                    //Se o e-mail e a senha forem encontrados...
                    MessageBox.Show("Login realizado com sucesso!");
                    MessageBox.Show("Bem-vindo(a)!");

                    //Redirecionando para a Área de Compras...
                    gerenc = new GerencAge();
                    gerenc.ShowDialog();
                    return;//Encerrando o processo de validação do login

                }//Fim do if
            }//Fim do for

            //Se o e-mail ou a senha não forem encontrados...
            MessageBox.Show("E-mail ou senha incorretos!");
        }//Fim do Login

        //Atualizar 
        public string atualizarAgente(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O agente de viagens não foi encontrado. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update agenteDeViagens set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Os dados foram atualizados com sucesso!\n{resultado}";
            }
            catch (Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir
        public string excluirAgente(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O agente de viagens não foi encontrado. Não foi possível realizar a exclusão!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from agenteDeViagens where codigo = '{codigo}'";

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
            //Buscando todos os dados da tabela do agente de viagens...
            string query = "select * from agenteDeViagens";

            //Instanciando os valores...
            this.codigo   = new int[100];
            this.nome     = new string[100];
            this.email    = new string[100];
            this.senha    = new string[100];
            this.comissao = new double[100];

            //Preenchendo os vetores com valores padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]   = 0;
                this.nome[i]     = "";
                this.email[i]    = "";
                this.senha[i]    = "";
                this.comissao[i] = 0.0;
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
                this.codigo[i]   = Convert.ToInt32(leitura["codigo"]);
                this.nome[i]     = leitura["nome"] + "";
                this.email[i]    = leitura["email"] + "";
                this.senha[i]    = leitura["senha"] + "";
                this.comissao[i] = Convert.ToDouble(leitura["comissao"]);

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Agente de Viagens
}//Fim do projeto