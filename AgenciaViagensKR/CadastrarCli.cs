namespace AgenciaViagensKR
{
    //Área de Cadastrar Cliente
    public partial class CadastrarCli : Form
    {
        //Variáveis
        DAOCliente cliente;

        public CadastrarCli()
        {
            //Inicialização...
            InitializeComponent();
            cliente = new DAOCliente();
        }

        //Textbox's
        //Textbox do Nome
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Textbox do Nome

        //Textbox do E-mail
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Textbox do E-mail

        //Textbox da Senha
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Textbox da Senha

        //Textbox do Histórico de Compras
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }//Fim do Textbox do Histórico de Compras


        //MaskedTextBox's
        //MaskedTextBox do CPF
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do CPF

        //MaskedTextBox da Data de Nascimento
        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox da Data de Nascimento

        //MaskedTextBox do Telefone
        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }//Fim do MaskedTextBox do Telefone

        //Botão Cadastrar
        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") || (maskedTextBox1.Text == "") || (maskedTextBox2.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (maskedTextBox3.Text == "") || (textBox4.Text == ""))
            {
                MessageBox.Show("Por favor, preencha todos os campos!");
            }
            else
            {
                //Variáveis locais
                string nome = textBox1.Text;
                long cpf = Convert.ToInt64(maskedTextBox1.Text.Replace(",", "").Replace("-", ""));//Trata os caracteres e remove eles
                string email = textBox2.Text;
                string senha = textBox3.Text;
                string telefone = maskedTextBox3.Text;
                string historico = textBox4.Text;

                //Tratamento do Datetime...
                string dt = maskedTextBox2.Text;
                string dtDia = dt.Substring(0, 2);
                string dtMes = dt.Substring(3, 2);
                string dtAno = dt.Substring(6, 4);
                String dtNascimento = (dtAno + "-" + dtMes + "-" + dtDia);

                //Inserindo esses dados no Banco de Dados...
                this.cliente.cadastrarCliente(nome, cpf, Convert.ToDateTime(maskedTextBox2.Text), email, senha, telefone, historico);

                //Limpando os campos após o cadastro...
                LimparCampos();

            }//Fim do if_else
        }//Fim do Botão Cadastrar

        //Limpar os campos
        private void LimparCampos()
        {
            textBox1.Text = "";
            maskedTextBox1.Text = "";
            maskedTextBox2.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            maskedTextBox3.Text = "";
            textBox4.Text = "";

        }//Fim do método de Limpar os Campos

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }//Fim da Área de Cadastrar Cliente
}//Fim do projeto
