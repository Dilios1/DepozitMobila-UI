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
    public partial class FormAdaugareClient : Form
    {
        private TextBox txtNume;
        private TextBox txtPrenume;
        private TextBox txtAdresa;
        private TextBox txtNumarTelefon;
        private TextBox txtCNP;
        private DateTimePicker dtpDataInregistrare;
        private TextBox txtNumarComenzi;
        private Button btnAdauga;
        public FormAdaugareClient()
        {
            InitializeComponent();
        }

        

        

        private bool ValidareDate(string nume, string prenume, string adresa, string numarTelefon, string cnp, DateTime dataInregistrare, int numarComenzi)
        {
            // Efectuează validarea datelor introduse
            // Poți adăuga orice validări necesare aici
            // Returnează true dacă datele sunt valide, altfel false

            return !string.IsNullOrEmpty(nume) &&
                   !string.IsNullOrEmpty(prenume) &&
                   !string.IsNullOrEmpty(adresa) &&
                   !string.IsNullOrEmpty(numarTelefon) &&
                   !string.IsNullOrEmpty(cnp) &&
                   numarComenzi >= 0;
        }

        private void AdaugaClient(string nume, string prenume, string adresa, string numarTelefon, string cnp, DateTime dataInregistrare, int numarComenzi)
        {
            // Adaugă clientul în sistem
            // Poți implementa codul specific pentru adăugarea clientului în baza de date sau în obiectele tale existente
            Clienti client = new Clienti(nume, prenume, adresa, numarTelefon, cnp, dataInregistrare, numarComenzi);
            Clienti.listaClienti.Add(client);
            
        }

        private void lblNume_Click(object sender, EventArgs e)
        {

        }

        private void txtAdresa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdauga_Click_1(object sender, EventArgs e)
        {
            // Obține valorile introduse în câmpuri
            string nume = txtNume.Text;
            string prenume = txtPrenume.Text;
            string adresa = txtAdresa.Text;
            string numarTelefon = txtNumarTelefon.Text;
            string cnp = txtCNP.Text;
            DateTime dataInregistrare = dtpDataInregistrare.Value;
            int numarComenzi = int.Parse(txtNumarComenzi.Text);

            // Validează și adaugă clientul în sistem
            if (ValidareDate(nume, prenume, adresa, numarTelefon, cnp, dataInregistrare, numarComenzi))
            {
                AdaugaClient(nume, prenume, adresa, numarTelefon, cnp, dataInregistrare, numarComenzi);
                MessageBox.Show("Client adăugat cu succes!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Datele introduse nu sunt valide!");
            }
        }

        private void txtNume_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrenume_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

