using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Correcao : Form
    {
        public Correcao()
        {
            InitializeComponent();
        }

        private void bt_avaliar_Click(object sender, EventArgs e)
        {
            String[] resposta = { "A", "B", "D", "E", "C", "A", "A", "D", "E", "B" };


            Convert.ToInt32(tx_1);


            int um = resposta[0]; string quatro = resposta[3]; string sete = resposta[6]; string dez = resposta[9];
            string dois = resposta[1]; string cinco = resposta[4]; string oito = resposta[7];
            string tres = resposta[2]; string seis = resposta[5]; string nove = resposta[8];

            int soma = 0;
           
            for (int i = 0; i < resposta.Length; i++)
            {
                for( )
                {
                    soma ++;
                }

            }

            MessageBox.Show(soma.ToString());




        
        }
    }
}
