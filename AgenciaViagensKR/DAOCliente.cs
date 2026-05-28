using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; //Importando os comandos de conexão com o banco
using System.Windows.Forms;//Importando a estrutura de telas
using static Mysqlx.Expect.Open.Types.Condition.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AgenciaViagensKR
{
    //Entidade: Cliente
    class DAOCliente
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
        Compras comp;

        //Variáveis e Vetores do Banco de Dados
        public MySqlConnection conexao;//Criando a variável que representa a entidade do banco de dados
        public int[] codigo;
        public string[] nome;
        public long[] cpf;
        public DateTime[] dataNascimento;
        public string[] email;
        public string[] senha;
        public string[] telefone;
        public string[] historico;

        //Conectando o Banco de Dados...
        public DAOCliente()
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
        public void cadastrarCliente(string nome, long cpf, DateTime dataNascimento, string email, string senha, string telefone, string historico)
        {
            try
            {
                //Configurando o comando de inserção de dados...
                this.dados = $"('', '{nome}', '{cpf}', '{dataNascimento}', '{email}', '{senha}', '{telefone}', '{historico}')";
                this.comando = $"Insert into cliente(codigo, nome, cpf, dataNascimento, email, senha, telefone, historico) values{this.dados}";

                //Inserindo e executando o comando no banco de dados...
                MySqlCommand sql = new MySqlCommand(this.comando, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                MessageBox.Show($"Os dados do cliente foram inseridos com sucesso!\n{resultado}");
                MessageBox.Show("O cadastro foi concluído!\n\n" );
            }
            catch(Exception erro)
            {
                //Erro no cadastro
                MessageBox.Show($"Erro! Algo falhou na inserção de dados e no cadastro!" + erro);
            }//Fim do try_catch
        }//Fim do Cadastrar

        //Validação do CPF
        public void validarCpf(long cpf)
        {
            //Convertendo o CPF para string...
            string cpfString = cpf.ToString();

            //Verificando se o CPF tem 11 dígitos..
            if (cpfString.Length != 11)
            {
                //Se o CPF não tiver 11 dígitos...
                MessageBox.Show("Erro! CPF Inválido!");
            }
            else
            {
                //-------- Cálculo do primeiro dígito verificador (10° dígito) --------
                //Variáveis
                int soma1 = 0;//Variável que vai guardar o resultado de cada soma

                //Lendo os 9 primeiros dígitos...
                for (int i = 0; i < 9; i++)
                {
                    //Variável que vai ler dígito por dígito
                    char caractere = cpfString[i];

                    //Convertendo caractere para string e depois para int...
                    string stringDigito = caractere.ToString();
                    int digito = Convert.ToInt32(stringDigito);

                    //Calculando...
                    int multiplicador = 10 - i; //Vai passar por cada posição (ex: i x 10, i x 9 = digito x 10, digito x 9...)
                    soma1 = soma1 + (digito * multiplicador);

                }//Fim do for
    
                //Variáveis
                int resultado = soma1 % 11;
                int primeiroDigito;

                //Verificando o resultado da soma...
                if (resultado < 2)
                {
                    primeiroDigito = 0;
                }
                else
                {
                    primeiroDigito = 11 - resultado;

                }//Fim do if_else

                //Comparando com o 10º dígito do CPF (posição 9)
                int decimoDigito = Convert.ToInt32(cpfString[9].ToString());

                if (primeiroDigito != decimoDigito)
                {
                    //Se forem diferentes...
                    MessageBox.Show("Erro! CPF Inválido!");
                    return;//Sai do método

                }//Fim do if
                //-------- Fim do Cálculo do primeiro dígito verificador (10° dígito) --------

                //-------- Cálculo do segundo dígito verificador (11° dígito) --------
                int soma2 = 0;

                //Lendo os 10 primeiros dígitos...
                for (int i = 0; i < 10; i++)
                {
                    //Variável que vai ler dígito por dígito
                    char caractere = cpfString[i];

                    //Convertendo caractere para string e depois para int...
                    string stringDigito = caractere.ToString();
                    int digito = Convert.ToInt32(stringDigito);

                    //Calculando...
                    int multiplicador = 11 - i; //Vai passar por cada posição (ex: i x 10, i x 9 = digito x 10, digito x 9...)
                    soma2 = soma2 + (digito * multiplicador);

                }//Fim do for

                //Variáveis
                int resultado2 = soma2 % 11;
                int segundoDigito;

                //Verificando o resultado da soma...
                if (resultado2 < 2)
                {
                    segundoDigito = 0;
                }
                else
                {
                    segundoDigito = 11 - resultado2;
                }//Fim do if_else

                //Comparando com o 11º dígito do CPF (posição 10)
                int decimoPrimeiroDigito = Convert.ToInt32(cpfString[10].ToString());

                if (segundoDigito != decimoPrimeiroDigito)
                {
                    //Se forem diferentes...
                    MessageBox.Show("Erro! CPF Inválido!");
                }
                else
                {
                    //Se forem iguais...
                    MessageBox.Show("CPF Válido!");

                //-------- Fim do Cálculo do segundo dígito verificador (11° dígito) --------
                }//Fim do if_else

            }//Fim da verificação
        }//Fim da Validação do CPF

        //Consultar
            //Consultar por Código do Cliente
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
                                   $"\nCPF:                {this.cpf[i]}"            +
                                   $"\nData de Nascimento: {this.dataNascimento[i]}" +
                                   $"\nE-mail:             {this.email[i]}"          +
                                   $"\nSenha:              {this.senha[i]}"          +
                                   $"\nTelefone:           {this.telefone[i]}"       +
                                   $"\nHistorico:          {this.historico[i]}";
                        return this.msg;
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar por Código do Cliente

            //Consultar por Nome
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

            //Consultar CPF
            public string consultarCpf(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.cpf[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar CPF

            //Consultar Data de Nascimento
            public string consultarDataNascimento(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.dataNascimento[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Data de Nascimento

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

            //Consultar Telefone
            public string consultarTelefone(int codigo)
                {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return "" + this.telefone[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar Telefone

            //Consultar Histórico de Compras
            public string consultarHistorico(int codigo)
            {
                //Preenchendo todos os dados do vetor...
                preencherVetor();

                for (i = 0; i < this.contar; i++)
                {
                    //Verificando o código...
                    if (this.codigo[i] == codigo)
                    {
                        return this.historico[i];
                    }//Fim do if              
                }//Fim do for

                //Se o código não for encontrado...
                return "O código informado não existe!";
            }//Fim do Consultar o Histórico de Compras
        //Fim do Consultar

        //Login
        public void validarLoginCliente(string email, string senha)
        {
            //Preenchendo todos os dados do vetor...
            preencherVetor();

            for(i = 0; i < this.contar; i++)
            {
                if ((this.email[i] == email) && (this.senha[i] == senha))
                {
                    //Se o e-mail e a senha forem encontrados...
                    MessageBox.Show("Login realizado com sucesso!");
                    MessageBox.Show("Bem-vindo(a)!");

                    //Redirecionando para a Área de Compras...
                    comp = new Compras();
                    comp.ShowDialog();
                    return;//Encerrando o processo de login

                }//Fim do if
            }//Fim do for

            //Se o e-mail ou a senha não forem encontrados...
            MessageBox.Show("E-mail ou senha incorretos!");
        }//Fim do Login

        //Atualizar
        public string atualizarCliente(int codigo, string campo, string novoDado)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O cliente não foi encontrado. Não foi possível realizar a atualização!";

                }//Fim da verificação do código

                //Configurando a atualização...
                string query = $"update cliente set {campo} = '{novoDado}' where codigo = '{codigo}'";

                //Executando o comando de atualização...
                MySqlCommand sql = new MySqlCommand(query, this.conexao);
                string resultado = "" + sql.ExecuteNonQuery();//Executando o comando
                return $"Os dados do cliente foram atualizados com sucesso!\n{resultado}";
            }
            catch(Exception erro)
            {
                //Erro na atualização
                return $"Erro! Algo deu errado na atualização dos dados do cliente!\n\n{erro}";

            }//Fim do try_catch
        }//Fim do Atualizar

        //Excluir
        public string excluirCliente(int codigo)
        {
            try
            {
                //Verificando se o código existe...
                if (consultarCodigo(codigo) == "O código informado não existe!")
                {
                    //Se o código não for encontrado...
                    return $"O cliente não foi encontrado. Não foi possível realizar a exclusão!";

                }//Fim da verificação do código

                //Configurando o excluir...
                string query = $"delete from cliente where codigo = '{codigo}'";

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
            //Buscando todos os dados da tabela do cliente...
            string query = "select * from cliente";

            //Instanciando os valores...
            this.codigo         = new int[100];
            this.nome           = new string[100];
            this.cpf            = new long[100];
            this.dataNascimento = new DateTime[100];
            this.email          = new string[100];
            this.senha          = new string[100];
            this.telefone       = new string[100];
            this.historico      = new string[100];

            //Preenchendo os vetores com valores padrões...
            for (i = 0; i < 100; i++)
            {
                this.codigo[i]         = 0;
                this.nome[i]           = "";
                this.cpf[i]            = 0;
                this.dataNascimento[i] = new DateTime();
                this.email[i]          = "";
                this.senha[i]          = "";
                this.telefone[i]       = "";
                this.historico[i]      = "";
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
                this.codigo[i]         = Convert.ToInt32(leitura["codigo"]);
                this.nome[i]           = leitura["nome"] + "";
                this.cpf[i]            = Convert.ToInt64(leitura["cpf"]);
                this.email[i]          = leitura["email"] + "";
                this.senha[i]          = leitura["senha"] + "";
                this.telefone[i]       = leitura["telefone"] + "";
                this.historico[i]      = leitura["historico"] + "";

                //Informando sobre os dados no banco de dados...
                i++;//Vai para a próxima posição do vetor
                this.contar++;//Informa quantos dados foram encontrados
            }//Fim do while

            //Encerrando o processo de busca dos dados...
            leitura.Close();
        }//Fim do Método Preencher Vetor

    }//Fim da Entidade Cliente
}//Fim do projeto