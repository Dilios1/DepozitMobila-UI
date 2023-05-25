using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class FormClienti : Form
    {
        public FormClienti()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaugareClient_Click(object sender, EventArgs e)
        {
            // Deschide un formular sau dialog pentru adăugarea unui client nou
            using (FormAdaugareClient formAdaugareClient = new FormAdaugareClient())
            {
                DialogResult result = formAdaugareClient.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Clientul a fost adăugat cu succes, poți efectua acțiuni suplimentare
                    // sau actualiza lista de clienți, dacă este cazul
                }
            }
        }

        

        private void btnVizualizareLista_Click(object sender, EventArgs e)
        {
            // Deschide un formular sau dialog pentru afișarea listei de clienți
            using (FormListaClienti formListaClienti = new FormListaClienti())
            {
                formListaClienti.ShowDialog();
            }
        }

        private void btnInapoi_Click(object sender, EventArgs e)
        {
            // Deschide meniul de selecție a Clienti, Mobila sau Depozit
            var form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }

}
