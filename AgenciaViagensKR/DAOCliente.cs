using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaViagensKR
{
    //Entidade: Cliente
    class DAOCliente
    {
        //Variáveis
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public string dados;
        public string comando;


        //Cadastrar um novo cliente
        public void cadastrarCliente(int codigo, string nome, double cpf, DateTime dataNascimento, string email, int telefone, string historico)
        {
            try
            {
                //Configurando o comando de Inserção de Dados
                this.dados = $"('', '{nome}', '{cpf}', '{dataNascimento}, '{email}', '{telefone}', '{historico}')";
                this.comando = $"Insert into cliente(codigo, nome, cpf, dataNascimento, email, telefone, historico) values{this.dados}";

                //Inserindo e executando o comando no banco de dados
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                Console.WriteLine($"Os dados do cliente foram inseridos com sucesso!\n{resultado}");
                Console.WriteLine("O cadastro foi concluído!\n\n");
            }
            catch(Exception erro)
            {
                Console.WriteLine($"Erro! Algo falhou na inserção de dados e no cadastro, tente novamente.\n\n {erro}");
            }//Fim do catch
        }//Fim do Cadastrar Cliente

        //Consultar
        //Login
        //Atualizar
        //Excluir
    }
}//Fim do projeto
