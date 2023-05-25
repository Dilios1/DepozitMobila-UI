using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormListaClienti
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            // Initializarea componentelor formularului
            this.listViewClienti = new ListView();
            this.btnDetalii = new Button();
            this.btnSterge = new Button();

            // Proprietăți formular
            this.Text = "Lista clienți";
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ClientSize = new Size(400, 300);

            // ListView Clienti
            this.listViewClienti.Location = new Point(20, 20);
            this.listViewClienti.Size = new Size(360, 200);
            this.listViewClienti.View = View.Details;
            this.listViewClienti.Columns.Add("Nume");
            this.listViewClienti.Columns.Add("Prenume");
            this.listViewClienti.Columns.Add("Strada");
            this.Controls.Add(this.listViewClienti);

            // Buton Detalii
            this.btnDetalii.Location = new Point(20, 230);
            this.btnDetalii.Size = new Size(100, 30);
            this.btnDetalii.Text = "Detalii";
            this.btnDetalii.Click += btnDetalii_Click;
            this.Controls.Add(this.btnDetalii);

            // Buton Sterge
            this.btnSterge.Location = new Point(140, 230);
            this.btnSterge.Size = new Size(100, 30);
            this.btnSterge.Text = "Șterge";
            this.btnSterge.Click += btnSterge_Click;
            this.Controls.Add(this.btnSterge);

            // Populare ListView cu datele clientilor
            PopuleazaListView();

        }

        #endregion
    }
}