using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace UI
{
    public partial class FormListaClienti : Form
    {
        private ListView listViewClienti;
        private Button btnDetalii;
        private Button btnSterge;
        public FormListaClienti()
        {
            InitializeComponent();
            PopuleazaListView();
            AdaugaClientiDinFisierInListView("clienti.txt");
            
        }


        private void PopuleazaListView()
        {
            // Obține lista de clienți prin apelul metodei ObțineListaClienti()
            List<Clienti> clienti = ObțineListaClienti();

            // Șterge toate elementele din ListView
            listViewClienti.Items.Clear();

            // Adaugă fiecare client în ListView
            foreach (Clienti client in clienti)
            {
                ListViewItem item = new ListViewItem(client.Nume);
                item.SubItems.Add(client.Prenume);
                item.SubItems.Add(client.Adresa);
                item.SubItems.Add(client.NumarTelefon);
                item.SubItems.Add(client.CNP);
                item.SubItems.Add(client.DataInregistrare.ToString());
                item.SubItems.Add(client.NumarComenzi.ToString());
                listViewClienti.Items.Add(item);
            }
        }

        private List<Clienti> ObțineListaClienti()
        {
            List<Clienti> listaClienti = new List<Clienti>();

            // Calea către fișierul text
            string caleFisier = "clienti.txt";

            // Citirea liniilor din fișierul text
            string[] linii = File.ReadAllLines(caleFisier);

            // Parcurgerea liniilor și adăugarea obiectelor de mobilă în listă
            foreach (string linie in linii)
            {
                string[] valori = linie.Split(';'); // Sau alt separator, în funcție de formatul datelor

                
                if (valori.Length == 7) 
                {
                    // Parsarea datelor
                    string nume = valori[0];
                    string prenume = valori[1];
                    string adresa = valori[2];
                    string numarTelefon = valori[3];
                    string cnp = valori[4];
                    DateTime dataInregistrare = DateTime.Parse(valori[5]);
                    int numarComenzi = int.Parse(valori[6]);

                    // Creează obiectul de client și adaugă-l în listă
                    Clienti client = new Clienti(nume, prenume, adresa, numarTelefon, cnp, dataInregistrare, numarComenzi);
                    listaClienti.Add(client);
                }
                else
                {
                    MessageBox.Show("Formatul liniei din fișier este incorect.");
                }
            }

            return listaClienti;
        }








        private void listViewClienti_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnDetalii_Click(object sender, EventArgs e)
        {
            if (listViewClienti.SelectedItems.Count > 0)
            {
                // Obține detaliile clientului selectat din ListView
                string nume = listViewClienti.SelectedItems[0].Text;
                string prenume = listViewClienti.SelectedItems[0].SubItems[1].Text;
                string adresa = listViewClienti.SelectedItems[0].SubItems[2].Text;
                string numarTelefon = listViewClienti.SelectedItems[0].SubItems[3].Text;
                string cnp = listViewClienti.SelectedItems[0].SubItems[4].Text;
                string dataInregistrare = listViewClienti.SelectedItems[0].SubItems[5].Text;
                string numarComenzi = listViewClienti.SelectedItems[0].SubItems[6].Text;

                // Afiseaza detaliile intr-un MessageBox
                string detaliiClient = $"Detalii client:\n" +
                    $"Nume: {nume}\n" +
                    $"Prenume: {prenume}\n" +
                    $"Adresa: {adresa}\n" +
                    $"Numar Telefon: {numarTelefon}\n" +
                    $"CNP: {cnp}\n" +
                    $"Data Inregistrare: {dataInregistrare}\n" +
                    $"Numar Comenzi: {numarComenzi}";

                MessageBox.Show(detaliiClient);
            }
            else
            {
                // Daca nu este selectat niciun client, afiseaza un mesaj de avertizare
                MessageBox.Show("Selectați un client din listă.");
            }
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            if (listViewClienti.SelectedItems.Count > 0)
            {
                // Obține detaliile clientului selectat din ListView
                string nume = listViewClienti.SelectedItems[0].Text;
                string prenume = listViewClienti.SelectedItems[0].SubItems[1].Text;
                string adresa = listViewClienti.SelectedItems[0].SubItems[2].Text;
                string numarTelefon = listViewClienti.SelectedItems[0].SubItems[3].Text;
                string cnp = listViewClienti.SelectedItems[0].SubItems[4].Text;
                string dataInregistrare = listViewClienti.SelectedItems[0].SubItems[5].Text;
                string numarComenzi = listViewClienti.SelectedItems[0].SubItems[6].Text;

                // Afiseaza un dialog de confirmare pentru stergerea clientului
                DialogResult result = MessageBox.Show($"Doriți să ștergeți clientul:\n" +
                    $"Nume: {nume}\n" +
                    $"Prenume: {prenume}\n" +
                    $"Adresa: {adresa}\n" +
                    $"Numar Telefon: {numarTelefon}\n" +
                    $"CNP: {cnp}\n" +
                    $"Data Inregistrare: {dataInregistrare}\n" +
                    $"Numar Comenzi: {numarComenzi}",
                    "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Executa logica de stergere a clientului din backend sau din sursa de date corespunzatoare

                    // Refresh ListView după ștergere
                    PopuleazaListView();
                }
            }
        }
        private void AdaugaClientiInListView(Clienti client)
        {
            ListViewItem item = new ListViewItem(client.Nume);
            item.SubItems.Add(client.Prenume);
            item.SubItems.Add(client.Adresa);
            item.SubItems.Add(client.NumarTelefon);
            item.SubItems.Add(client.CNP);
            item.SubItems.Add(client.DataInregistrare.ToString());
            item.SubItems.Add(client.NumarComenzi.ToString());
            listViewClienti.Items.Add(item);
        }
        private void AdaugaClientiDinFisierInListView(string caleFisier)
        {
            if (File.Exists(caleFisier))
            {
                string[] linii = File.ReadAllLines(caleFisier);

                foreach (string linie in linii)
                {
                    string[] valori = linie.Split(';');

                    if (valori.Length == 7)
                    {
                        string nume = valori[0];
                        string prenume = valori[1];
                        string adresa = valori[2];
                        string numarTelefon = valori[3];
                        string cnp = valori[4];
                        DateTime dataInregistrare = DateTime.Parse(valori[5]);
                        int numarComenzi = int.Parse(valori[6]);

                        Clienti client = new Clienti(nume, prenume, adresa, numarTelefon, cnp, dataInregistrare, numarComenzi);
                        AdaugaClientiInListView(client);
                    }
                    else
                    {
                        MessageBox.Show("Formatul liniei din fișier este incorect.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Fișierul nu există.");
            }
        }

    }
}

