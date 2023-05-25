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
    public partial class FormListaMobila : Form
    {
        private ListView listViewMobila;
        private Button btnDetalii;
        private Button btnSterge;

        public FormListaMobila()
        {
            InitializeComponent();
            PopuleazaListView1();
            AdaugaMobilaDinFisierInListView("mobila.txt");
        }

        private void PopuleazaListView1()
        {
            // Obține lista de mobilă din clasa "Mobila"
            List<Mobila> mobilier = ObțineListaMobila();

            // Șterge toate elementele din ListView
            listViewMobila.Items.Clear();

            // Adaugă fiecare obiect de mobilă în ListView
            foreach (Mobila mobila in mobilier)
            {
                ListViewItem item = new ListViewItem(mobila.TipMobila);
                item.SubItems.Add(mobila.Material);
                item.SubItems.Add(mobila.Culoare);
                item.SubItems.Add(mobila.Cantitate.ToString());
                item.SubItems.Add(mobila.Pret.ToString());
                listViewMobila.Items.Add(item);
            }
        }

        
        

        

        private void listViewMobila_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnDetMobila_Click(object sender, EventArgs e)
        {
            if (listViewMobila.SelectedItems.Count > 0)
            {
                // Obține detaliile obiectului de mobilă selectat din ListView
                string tipMobila = listViewMobila.SelectedItems[0].Text;
                string material = listViewMobila.SelectedItems[0].SubItems[1].Text;
                string culoare = listViewMobila.SelectedItems[0].SubItems[2].Text;
                string cantitate = listViewMobila.SelectedItems[0].SubItems[3].Text;
                string pret = listViewMobila.SelectedItems[0].SubItems[4].Text;

                // Afiseaza detaliile intr-un MessageBox
                string detaliiMobila = $"Detalii mobilă:\n" +
                    $"Tip mobilă: {tipMobila}\n" +
                    $"Material: {material}\n" +
                    $"Culoare: {culoare}\n" +
                    $"Cantitate: {cantitate}\n" +
                    $"Pret: {pret}";

                MessageBox.Show(detaliiMobila);
            }
            else
            {
                // Daca nu este selectat niciun obiect de mobilă, afiseaza un mesaj de avertizare
                MessageBox.Show("Selectați un obiect de mobilă din listă.");
            }
        }

        private void btnStergeMobila_Click(object sender, EventArgs e)
        {
            if (listViewMobila.SelectedItems.Count > 0)
            {
                // Obține detaliile obiectului de mobilă selectat din ListView
                string tipMobila = listViewMobila.SelectedItems[0].Text;
                string material = listViewMobila.SelectedItems[0].SubItems[1].Text;
                string culoare = listViewMobila.SelectedItems[0].SubItems[2].Text;
                string cantitate = listViewMobila.SelectedItems[0].SubItems[3].Text;
                string pret = listViewMobila.SelectedItems[0].SubItems[4].Text;

                // Afiseaza un dialog de confirmare pentru stergerea obiectului de mobilă
                DialogResult result = MessageBox.Show($"Doriți să ștergeți obiectul de mobilă:\n" +
                    $"Tip mobilă: {tipMobila}\n" +
                    $"Material: {material}\n" +
                    $"Culoare: {culoare}\n" +
                    $"Cantitate: {cantitate}\n" +
                    $"Pret: {pret}",
                    "Confirmare ștergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Executa logica de stergere a obiectului de mobilă din backend sau din sursa de date corespunzatoare

                    // Refresh ListView după ștergere
                    PopuleazaListView1();
                }
            }
            else
            {
                // Daca nu este selectat niciun obiect de mobilă, afiseaza un mesaj de avertizare
                MessageBox.Show("Selectați un obiect de mobilă din listă.");
            }
        }

        private void AdaugaMobilaInListView(Mobila mobila)
        {
            ListViewItem item = new ListViewItem(mobila.TipMobila);
            item.SubItems.Add(mobila.Material);
            item.SubItems.Add(mobila.Culoare);
            item.SubItems.Add(mobila.Cantitate.ToString());
            item.SubItems.Add(mobila.Pret.ToString());
            listViewMobila.Items.Add(item);
        }

        private void AdaugaMobilaDinFisierInListView(string caleFisier)
        {
            if (File.Exists(caleFisier))
            {
                string[] linii = File.ReadAllLines(caleFisier);

                foreach (string linie in linii)
                {
                    string[] valori = linie.Split(';');

                    if (valori.Length == 5)
                    {
                        Mobila mobila = new Mobila(valori[0], valori[1], valori[2], valori[3], int.Parse(valori[4]), double.Parse(valori[5]));
                        AdaugaMobilaInListView(mobila);
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

        private List<Mobila> ObțineListaMobila()
        {
            List<Mobila> listaMobila = new List<Mobila>();

            // Calea către fișierul text
            string caleFisier = "mobila.txt";

            // Citirea liniilor din fișierul text
            string[] linii = File.ReadAllLines(caleFisier);

            // Parcurgerea liniilor și adăugarea obiectelor de mobilă în listă
            foreach (string linie in linii)
            {
                string[] valori = linie.Split(','); // Sau alt separator, în funcție de formatul fișierului

                // Verificați dacă linia are suficiente valori pentru a crea un obiect de mobilă
                if (valori.Length >= 6) // Sau alt număr, în funcție de numărul de câmpuri din fișier
                {
                    // Creează obiectul de mobilă și adaugă-l în listă
                    Mobila mobila = new Mobila(valori[0], valori[1], valori[2], valori[3], int.Parse(valori[4]), double.Parse(valori[5]));
                    listaMobila.Add(mobila);
                }
            }

            return listaMobila;
        }

        private void listViewMobila_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
