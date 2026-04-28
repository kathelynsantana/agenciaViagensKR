using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Importando os comandos de conexão com o banco

namespace AgenciaViagensKR
{
    //Homepage
    class DAOForm
    {
        //Váriavéis
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        
        //Conectando o Banco de Dados...
        public DAOForm()
        {
            //Conexão com o Banco de Dados
            this.conexao = new MySqlConnection("server=localhost;DataBase=agenciaDeViagens;Uid=root;Password=;Convert Zero DateTime=True");
            try
            {
                this.conexao.Open();//Abrir a conexão
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Algo deu errado!");
                this.conexao.Close();//Fechar a conexão
            }//Fim do try_catch
        }//Fim da conexão
    }//Fim do Homepage
}//Fim do projeto
