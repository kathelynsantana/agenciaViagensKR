using Org.BouncyCastle.Tls;

namespace AgenciaViagensKR
{
    //Homepage
    public partial class Homepage : Form
    {
        //Variáveis
        Cliente cli;
        AgenteViagens agvg;

        public Homepage()
        {
            //Inicialização
            InitializeComponent();
        }

        //Banner Colorido
        private void Homepage_Load(object sender, EventArgs e)
        {

        }//Fim do Banner Colorido

        //Acesso à Área do Cliente
        private void button1_Click(object sender, EventArgs e)
        {
            //Aba da Área do Cliente
            cli = new Cliente();
            cli.ShowDialog();

        }//Fim do Acesso à Área do Cliente

        //Acesso à Área do Agente de Viagens
        private void button2_Click(object sender, EventArgs e)
        {
            //Aba da Área do Agente de Viagens
            agvg = new AgenteViagens();
            agvg.ShowDialog();

        }//Fim do Acesso à Área do Agente de Viagens
    }//Fim da Homepage
}//Fim do projeto
