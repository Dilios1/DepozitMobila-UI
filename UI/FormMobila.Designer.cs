using System.Drawing;

namespace UI
{
    partial class FormMobila
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
            this.lblMenMobila = new System.Windows.Forms.Label();
            this.btnAdaugareMobila = new System.Windows.Forms.Button();
            this.btnVizualizareLista = new System.Windows.Forms.Button();
            this.btnInapoi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMenMobila
            // 
            this.lblMenMobila.AutoSize = true;
            this.lblMenMobila.Location = new System.Drawing.Point(347, 32);
            this.lblMenMobila.Name = "lblMenMobila";
            this.lblMenMobila.Size = new System.Drawing.Size(85, 13);
            this.lblMenMobila.TabIndex = 1;
            this.lblMenMobila.Text = "MENIU MOBILA";
            // 
            // btnAdaugareMobila
            // 
            this.btnAdaugareMobila.Location = new System.Drawing.Point(65, 71);
            this.btnAdaugareMobila.Name = "btnAdaugareMobila";
            this.btnAdaugareMobila.Size = new System.Drawing.Size(150, 23);
            this.btnAdaugareMobila.TabIndex = 2;
            this.btnAdaugareMobila.Text = "Adaugare mobilă nouă";
            this.btnAdaugareMobila.UseVisualStyleBackColor = true;
            this.btnAdaugareMobila.Click += new System.EventHandler(this.btnAdaugareMobila_Click);
            // 
            // btnVizualizareLista
            // 
            this.btnVizualizareLista.Location = new System.Drawing.Point(65, 110);
            this.btnVizualizareLista.Name = "btnVizualizareLista";
            this.btnVizualizareLista.Size = new System.Drawing.Size(150, 23);
            this.btnVizualizareLista.TabIndex = 3;
            this.btnVizualizareLista.Text = "Vizualizare lista mobilei";
            this.btnVizualizareLista.UseVisualStyleBackColor = true;
            this.btnVizualizareLista.Click += new System.EventHandler(this.btnVizualizareLista_Click);
            // 
            // btnInapoi
            // 
            this.btnInapoi.Location = new System.Drawing.Point(65, 282);
            this.btnInapoi.Name = "btnInapoi";
            this.btnInapoi.Size = new System.Drawing.Size(150, 23);
            this.btnInapoi.TabIndex = 7;
            this.btnInapoi.Text = "Meniu Anterior";
            this.btnInapoi.UseVisualStyleBackColor = true;
            this.btnInapoi.Click += new System.EventHandler(this.btnInapoi_Click);
            // 
            // FormMobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInapoi);
            this.Controls.Add(this.btnVizualizareLista);
            this.Controls.Add(this.btnAdaugareMobila);
            this.Controls.Add(this.lblMenMobila);
            this.Name = "FormMobila";
            this.Text = "FormMobila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblMenMobila;
        private System.Windows.Forms.Button btnAdaugareMobila;
        private System.Windows.Forms.Button btnVizualizareLista;
        private System.Windows.Forms.Button btnInapoi;
    }
}