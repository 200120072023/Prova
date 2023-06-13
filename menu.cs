namespace Prova
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             Correcao c= new Correcao();
             c.ShowDialog();
            
            
        }
    }
}