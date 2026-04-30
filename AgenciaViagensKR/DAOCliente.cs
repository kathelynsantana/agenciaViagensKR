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
        public int i;
        public int contar;
        public string campo;
        public string novoDado;

        //Variáveis do Banco de Dados
        public string[] codigo;
        public string[] nome;
        public long[] cpf;
        public DateTime[] dataNascimento;
        public string[] email;
        public string[] senha;
        public int[] telefone;
        public string[] historico;

        //Cadastrar
        public void cadastrarCliente(int codigo, string nome, double cpf, DateTime dataNascimento, string email, string senha, int telefone, string historico)
        {
            try
            {
                //Configurando o comando de Inserção de Dados
                this.dados = $"('', '{nome}', '{cpf}', '{dataNascimento}, '{email}', '{senha}', '{telefone}', '{historico}')";
                this.comando = $"Insert into cliente(codigo, nome, cpf, dataNascimento, email, senha, telefone, historico) values{this.dados}";

                //Inserindo e executando o comando no banco de dados
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                Console.WriteLine($"Os dados do cliente foram inseridos com sucesso!\n{resultado}");
                Console.WriteLine("O cadastro foi concluído!\n\n");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                Console.WriteLine($"Erro! Algo falhou na inserção de dados e no cadastro, tente novamente.");
            }//Fim do try_catch
        }//Fim do Cadastrar

        //Consultar
        //Login
            //Consultar e-mail
            public string consultarEmail(string email)
            {
                for (int i = 0; i < this.contar; i++)
                {
                    //Verificando o e-mail...
                    if (email == this.email[i])
                    {
                        return "E-mail válidado!";
                    }//Fim do if
                }//Fim do for

                //Se o e-mail estiver incorreto...
                return "O e-mail de login informado é inválido!";
            }//Fim do Consultar E-mail

            //Consultar senha
            public string consultarSenha(string senha)
            {
                for (int i = 0; i < this.contar; i++)
                {
                    //Verificando o e-mail...
                    if (senha == this.senha[i])
                    {
                        return "Senha válidada!";
                    }//Fim do if
                }//Fim do for

                //Se o e-mail estiver incorreto...
                return "A senha informada é inválida!";
            }//Fim do Consultar Senha

        //Atualizar
        public string atualizarCliente(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
                string query = $"update cliente set {campo} = '{novoDado}' where codigo = '{codigo}'";

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
        public string excluirCliente(int codigo)
        {
            try
            {
                //Configurando o excluir...
                string query = $"delete from cliente where codigo = '{codigo}'";

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
    }//Fim da Entidade Cliente
}//Fim do projeto
