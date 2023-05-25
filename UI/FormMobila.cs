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
    public partial class FormMobila : Form
    {
        public FormMobila()
        {

          InitializeComponent();

         

        }

        private void btnAdaugareMobila_Click(object sender, EventArgs e)
        {
            // Deschide un formular sau dialog pentru adăugarea unui client nou
            using (FormAdaugareMobila formAdaugareMobila = new FormAdaugareMobila())
            {
                DialogResult result = formAdaugareMobila.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Clientul a fost adăugat cu succes, poți efectua acțiuni suplimentare
                    // sau actualiza lista de clienți, dacă este cazul
                }
            }
        }

        private void btnVizualizareLista_Click (object sender, EventArgs e) 
        {
            // Deschide un formular sau dialog pentru afișarea listei de clienți
            using (FormListaMobila formListaMobila = new FormListaMobila())
            {
                formListaMobila.ShowDialog();
            }
            // Codul pentru acțiunea de adăugare a mobilei noi

        }

        private void btnCautareMobila_Click(object sender, EventArgs e)
        {
            // Codul pentru acțiunea de adăugare a mobilei noi
        }

        private void btnModificareMobila_Click(object sender, EventArgs e)
        {
            // Codul pentru acțiunea de adăugare a mobilei noi
        }

        private void btnStergereMobila_Click(object sender, EventArgs e)
        {
            // Codul pentru acțiunea de adăugare a mobilei noi
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
