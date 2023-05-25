namespace UI
{
    partial class FormClienti
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
            this.lblMenClienti = new System.Windows.Forms.Label();
            this.btnAdaugareClient = new System.Windows.Forms.Button();
            this.btnVizualizareLista = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenClienti
            // 
            this.lblMenClienti.AutoSize = true;
            this.lblMenClienti.Location = new System.Drawing.Point(347, 32);
            this.lblMenClienti.Name = "lblMenClienti";
            this.lblMenClienti.Size = new System.Drawing.Size(86, 13);
            this.lblMenClienti.TabIndex = 1;
            this.lblMenClienti.Text = "MENIU CLIENTI";
            this.lblMenClienti.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAdaugareClient
            // 
            this.btnAdaugareClient.Location = new System.Drawing.Point(65, 71);
            this.btnAdaugareClient.Name = "btnAdaugareClient";
            this.btnAdaugareClient.Size = new System.Drawing.Size(96, 23);
            this.btnAdaugareClient.TabIndex = 2;
            this.btnAdaugareClient.Text = "Adaugare Client";
            this.btnAdaugareClient.UseVisualStyleBackColor = true;
            this.btnAdaugareClient.Click += new System.EventHandler(this.btnAdaugareClient_Click);
            // 
            // btnVizualizareLista
            // 
            this.btnVizualizareLista.Location = new System.Drawing.Point(65, 116);
            this.btnVizualizareLista.Name = "btnVizualizareLista";
            this.btnVizualizareLista.Size = new System.Drawing.Size(96, 23);
            this.btnVizualizareLista.TabIndex = 3;
            this.btnVizualizareLista.Text = "Vizualizare Lista";
            this.btnVizualizareLista.UseVisualStyleBackColor = true;
            this.btnVizualizareLista.Click += new System.EventHandler(this.btnVizualizareLista_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(65, 381);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(96, 23);
            this.btnInapoi.TabIndex = 4;
            this.btnInapoi.Text = "Meniu Anterior";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // FormClienti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnVizualizareLista);
            this.Controls.Add(this.btnAdaugareClient);
            this.Controls.Add(this.lblMenClienti);
            this.Name = "FormClienti";
            this.Text = "FormClienti";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenClienti;
        private System.Windows.Forms.Button btnAdaugareClient;
        private System.Windows.Forms.Button btnVizualizareLista;
        private System.Windows.Forms.Button btnInapoi;
    }
}