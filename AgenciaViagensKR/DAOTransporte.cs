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
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public string dados;
        public string comando;

        //Váriaveis do Banco de Dados
        public int[] codigo;
        public string[] nome;
        public long[] cnpj;
        public string[] tipoTransporte;
        public int[] frotaDisponivel;

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
                Console.WriteLine("O cadastro foi concluído com sucesso!s");
            }
            catch (Exception erro)
            {
                //Erro no cadastro
                Console.WriteLine("Erro! Algo falhou na inserção de dados e no cadastro!");
            }//Fim do try_catch
        }//Fim do Cadastrar

        //Consultar

        //Atualizar
        public string atualizarTransporte(int codigo, string campo, string novoDado)
        {
            try
            {
                //Configurando a atualização...
            }
            catch(Exception erro)
            {

            }//Fim do try_catch
        }//Fim do Atualizar
        
        //Excluir

        //---------------------------------------------------------------------------------------------------
        //Método Preencher Vetor


    }//Fim da Entidade Transporte
}//Fim do projeto
