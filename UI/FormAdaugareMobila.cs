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
    public partial class FormAdaugareMobila : Form
    {
        private System.Windows.Forms.RadioButton radioButtonRosu;
        private System.Windows.Forms.RadioButton radioButtonVerde;
        private System.Windows.Forms.RadioButton radioButtonAlbastru;
        private System.Windows.Forms.RadioButton radioButtonNegru;
        private System.Windows.Forms.CheckBox checkBoxScaun;
        private System.Windows.Forms.CheckBox checkBoxMasa;
        private System.Windows.Forms.CheckBox checkBoxDulap;
        
        public FormAdaugareMobila()
        {
            InitializeComponent();
        }

        private void lblTitluAdaugareMobila_Click(object sender, EventArgs e)
        {

        }

        private bool ValidareDate(string culoare, List<string> tipMobila)
        {
            // Efectuează validarea datelor introduse
            // Poți adăuga orice validări necesare aici
            // Returnează true dacă datele sunt valide, altfel false

            return !string.IsNullOrEmpty(culoare) &&
                   tipMobila.Any(tip => tip != null);
        }

        private void AdaugaMobila(string culoare, List<string> tipMobila)
        {
            // Adaugă mobila în sistem
            // Poți implementa codul specific pentru adăugarea mobilei în baza de date sau în obiectele tale existente

            foreach (var tip in tipMobila)
            {
                Mobila mobila = new Mobila(tip, "", "", culoare, 0, 0);
                Mobila.listaMobila.Add(mobila);
            }
        }

       

      

        private void btnAdaugaMobila_Click(object sender, EventArgs e)
        {
            // Obține valoarea selectată pentru culoare
            string culoare = "";

            if (radioButtonRosu.Checked)
                culoare = "Rosu";
            else if (radioButtonVerde.Checked)
                culoare = "Verde";
            else if (radioButtonAlbastru.Checked)
                culoare = "Albastru";
            else if (radioButtonNegru.Checked)
                culoare = "Negru";

            // Obține tipurile de mobilă selectate
            List<string> tipuriMobila = new List<string>();

            if (checkBoxScaun.Checked)
                tipuriMobila.Add("Scaun");

            if (checkBoxMasa.Checked)
                tipuriMobila.Add("Masa");

            if (checkBoxDulap.Checked)
                tipuriMobila.Add("Dulap");

            // Validează și adaugă mobila în sistem
            if (ValidareDate(culoare, tipuriMobila))
            {
                AdaugaMobila(culoare, tipuriMobila);
                MessageBox.Show("Mobila adăugată cu succes!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
        }
    }


}

