namespace UI
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lblMeniuPrincipal = new System.Windows.Forms.Label();
            this.btnClienti = new System.Windows.Forms.Button();
            this.btnMobila = new System.Windows.Forms.Button();
            this.btnDepozit = new System.Windows.Forms.Button();
            this.btnIesire = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lblMeniuPrincipal
            // 
            this.lblMeniuPrincipal.AutoSize = true;
            this.lblMeniuPrincipal.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.lblMeniuPrincipal.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblMeniuPrincipal.Location = new System.Drawing.Point(313, 26);
            this.lblMeniuPrincipal.Name = "lblMeniuPrincipal";
            this.lblMeniuPrincipal.Size = new System.Drawing.Size(101, 13);
            this.lblMeniuPrincipal.TabIndex = 2;
            this.lblMeniuPrincipal.Text = "MENIU PRINCIPAL";
            this.lblMeniuPrincipal.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnClienti
            // 
            this.btnClienti.Location = new System.Drawing.Point(67, 107);
            this.btnClienti.Name = "btnClienti";
            this.btnClienti.Size = new System.Drawing.Size(75, 23);
            this.btnClienti.TabIndex = 3;
            this.btnClienti.Text = "Clienti";
            this.btnClienti.UseVisualStyleBackColor = true;
            this.btnClienti.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMobila
            // 
            this.btnMobila.Location = new System.Drawing.Point(67, 150);
            this.btnMobila.Name = "btnMobila";
            this.btnMobila.Size = new System.Drawing.Size(75, 23);
            this.btnMobila.TabIndex = 4;
            this.btnMobila.Text = "Mobila";
            this.btnMobila.UseVisualStyleBackColor = true;
            this.btnMobila.Click += new System.EventHandler(this.btnMobila_Click);
            // 
            // btnDepozit
            // 
            this.btnDepozit.Location = new System.Drawing.Point(67, 201);
            this.btnDepozit.Name = "btnDepozit";
            this.btnDepozit.Size = new System.Drawing.Size(75, 23);
            this.btnDepozit.TabIndex = 5;
            this.btnDepozit.Text = "Depozit";
            this.btnDepozit.UseVisualStyleBackColor = true;
            this.btnDepozit.Click += new System.EventHandler(this.btnDepozit_Click);
            // 
            // btnIesire
            // 
            this.btnIesire.Location = new System.Drawing.Point(67, 257);
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(75, 23);
            this.btnIesire.TabIndex = 6;
            this.btnIesire.Text = "Iesire";
            this.btnIesire.UseVisualStyleBackColor = true;
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIesire);
            this.Controls.Add(this.btnDepozit);
            this.Controls.Add(this.btnMobila);
            this.Controls.Add(this.btnClienti);
            this.Controls.Add(this.lblMeniuPrincipal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label lblMeniuPrincipal;
        private System.Windows.Forms.Button btnClienti;
        private System.Windows.Forms.Button btnMobila;
        private System.Windows.Forms.Button btnDepozit;
        private System.Windows.Forms.Button btnIesire;
    }
}

