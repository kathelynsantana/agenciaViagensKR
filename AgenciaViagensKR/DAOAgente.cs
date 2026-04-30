using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaViagensKR
{
    //Entidade: Agente de Viagens
    class DAOAgente
    {
        //Variáveis
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public string dados;
        public string comando;
        public int i;
        public int contar;
        public string campo;
        public string novoDado;

        //Variáveis do Banco de Dados
        public int[] codigo;
        public int[] nome;
        public string[] email;
        public string[] senha;
        public long[] comissao;

        //Cadastrar
        public void cadastrarAgente(int codigo, string nome, string email, string senha, double comissao)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{nome}', '{email}', '{senha}', '{comissao}')";
                this.comando = $"Insert into agenteDeViagens(codigo, nome, email, senha, comissao) values{this.dados}";

                //Inserindo e executando o comando no banco de dados
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                Console.WriteLine($"Os dados do agente de viagens foram inseridos com sucesso!\n{resultado}");
                Console.WriteLine("O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                Console.WriteLine($"Erro! Algo falhou na inserção de dados e no cadastro, tente novamente.");
            }//Fim do try_catch
        }//Fim do Cadastrar Agente de Viagens

        //Login

        //Consultar

        //Atualizar 
        public string atualizarAgente(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
                string query = $"update agente set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Os dados foram tualizados com sucesso!";
            }
            catch
            {
                //Erro na atualização
                return $"Algo deu errado na atualização!";
            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir
        public string excluirAgente(int codigo)
        {
            try
            {
                //Configurando o excluir...
                string query = $"delete from agenteDeViagens where codigo = '{codigo}'";

                //Executando...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Deletado com sucesso!";
            }
            catch (Exception erro)
            {
                //Erro na exclusão
                return $"Algo deu errado na exclusão!";
            }//Fim do try_catch
        }//Fim do Excluir
    }//Fim da Entidade Agente de Viagens
}//Fim do projeto
