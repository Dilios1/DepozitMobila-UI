using System.Drawing;
using System.Windows.Forms;

namespace UI
{
    partial class FormAdaugareClient
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
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.txtNumarTelefon = new System.Windows.Forms.TextBox();
            this.txtCNP = new System.Windows.Forms.TextBox();
            this.dtpDataInregistrare = new System.Windows.Forms.DateTimePicker();
            this.txtNumarComenzi = new System.Windows.Forms.TextBox();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPrenume = new System.Windows.Forms.Label();
            this.lblAdresa = new System.Windows.Forms.Label();
            this.lblNrTel = new System.Windows.Forms.Label();
            this.lblCNP = new System.Windows.Forms.Label();
            this.lblNrComenzi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(58, 12);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(200, 20);
            this.txtNume.TabIndex = 1;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // txtPrenume
            // 
            this.txtPrenume.Location = new System.Drawing.Point(58, 41);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(200, 20);
            this.txtPrenume.TabIndex = 2;
            this.txtPrenume.TextChanged += new System.EventHandler(this.txtPrenume_TextChanged);
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(58, 67);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(200, 20);
            this.txtAdresa.TabIndex = 4;
            this.txtAdresa.TextChanged += new System.EventHandler(this.txtAdresa_TextChanged);
            // 
            // txtNumarTelefon
            // 
            this.txtNumarTelefon.Location = new System.Drawing.Point(58, 93);
            this.txtNumarTelefon.Name = "txtNumarTelefon";
            this.txtNumarTelefon.Size = new System.Drawing.Size(200, 20);
            this.txtNumarTelefon.TabIndex = 5;
            // 
            // txtCNP
            // 
            this.txtCNP.Location = new System.Drawing.Point(58, 119);
            this.txtCNP.Name = "txtCNP";
            this.txtCNP.Size = new System.Drawing.Size(200, 20);
            this.txtCNP.TabIndex = 6;
            // 
            // dtpDataInregistrare
            // 
            this.dtpDataInregistrare.Location = new System.Drawing.Point(58, 145);
            this.dtpDataInregistrare.Name = "dtpDataInregistrare";
            this.dtpDataInregistrare.Size = new System.Drawing.Size(200, 20);
            this.dtpDataInregistrare.TabIndex = 7;
            // 
            // txtNumarComenzi
            // 
            this.txtNumarComenzi.Location = new System.Drawing.Point(58, 171);
            this.txtNumarComenzi.Name = "txtNumarComenzi";
            this.txtNumarComenzi.Size = new System.Drawing.Size(200, 20);
            this.txtNumarComenzi.TabIndex = 8;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(20, 230);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(100, 30);
            this.btnAdauga.TabIndex = 9;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click_1);
            // 
            // lblNume
            // 
            this.lblNume.Location = new System.Drawing.Point(-2, 12);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(41, 18);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // lblPrenume
            // 
            this.lblPrenume.Location = new System.Drawing.Point(-2, 44);
            this.lblPrenume.Name = "lblPrenume";
            this.lblPrenume.Size = new System.Drawing.Size(54, 23);
            this.lblPrenume.TabIndex = 3;
            this.lblPrenume.Text = "Prenume:";
            // 
            // lblAdresa
            // 
            this.lblAdresa.AutoSize = true;
            this.lblAdresa.Location = new System.Drawing.Point(-2, 70);
            this.lblAdresa.Name = "lblAdresa";
            this.lblAdresa.Size = new System.Drawing.Size(43, 13);
            this.lblAdresa.TabIndex = 10;
            this.lblAdresa.Text = "Adresa:";
            // 
            // lblNrTel
            // 
            this.lblNrTel.AutoSize = true;
            this.lblNrTel.Location = new System.Drawing.Point(-2, 96);
            this.lblNrTel.Name = "lblNrTel";
            this.lblNrTel.Size = new System.Drawing.Size(59, 13);
            this.lblNrTel.TabIndex = 11;
            this.lblNrTel.Text = "Numar Tel:";
            // 
            // lblCNP
            // 
            this.lblCNP.AutoSize = true;
            this.lblCNP.Location = new System.Drawing.Point(4, 122);
            this.lblCNP.Name = "lblCNP";
            this.lblCNP.Size = new System.Drawing.Size(32, 13);
            this.lblCNP.TabIndex = 12;
            this.lblCNP.Text = "CNP:";
            // 
            // lblNrComenzi
            // 
            this.lblNrComenzi.AutoSize = true;
            this.lblNrComenzi.Location = new System.Drawing.Point(-7, 174);
            this.lblNrComenzi.Name = "lblNrComenzi";
            this.lblNrComenzi.Size = new System.Drawing.Size(64, 13);
            this.lblNrComenzi.TabIndex = 13;
            this.lblNrComenzi.Text = "Nr Comenzi:";
            // 
            // FormAdaugareClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 296);
            this.Controls.Add(this.lblNrComenzi);
            this.Controls.Add(this.lblCNP);
            this.Controls.Add(this.lblNrTel);
            this.Controls.Add(this.lblAdresa);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.lblPrenume);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.txtNumarTelefon);
            this.Controls.Add(this.txtCNP);
            this.Controls.Add(this.dtpDataInregistrare);
            this.Controls.Add(this.txtNumarComenzi);
            this.Controls.Add(this.btnAdauga);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAdaugareClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adaugare client nou";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNume;
        private Label lblPrenume;
        private Label lblAdresa;
        private Label lblNrTel;
        private Label lblCNP;
        private Label lblNrComenzi;
    }
}