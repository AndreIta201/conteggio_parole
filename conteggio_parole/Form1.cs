using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace conteggio_parole
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_verifica_Click(object sender, EventArgs e)
        {
            string frase = txt_n1.Text;
            int contaSpazi = 0;

            foreach (char c in frase)
            {
                if (c == ' ')
                {
                    contaSpazi++;
                }
            }
            if (contaSpazi > 0)
            {
                lbl_spazio.Text = "la frase contiene " + contaSpazi + " spazi";
            }
            else
            {
                lbl_spazio.Text = "la frase non contiene uno spazio";
            }




        }
    }
}
