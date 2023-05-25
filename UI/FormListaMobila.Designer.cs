namespace UI
{
    partial class FormListaMobila
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
            this.listViewMobila = new System.Windows.Forms.ListView();
            this.btnDetalii = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewMobila
            // 
            this.listViewMobila.HideSelection = false;
            this.listViewMobila.Location = new System.Drawing.Point(0, 0);
            this.listViewMobila.Name = "listViewMobila";
            this.listViewMobila.Size = new System.Drawing.Size(121, 97);
            this.listViewMobila.TabIndex = 0;
            this.listViewMobila.UseCompatibleStateImageBehavior = false;
            this.listViewMobila.SelectedIndexChanged += new System.EventHandler(this.listViewMobila_SelectedIndexChanged_1);
            // 
            // btnDetalii
            // 
            this.btnDetalii.Location = new System.Drawing.Point(12, 230);
            this.btnDetalii.Name = "btnDetalii";
            this.btnDetalii.Size = new System.Drawing.Size(80, 30);
            this.btnDetalii.TabIndex = 1;
            this.btnDetalii.Text = "Detalii";
            this.btnDetalii.Click += new System.EventHandler(this.btnDetMobila_Click);
            // 
            // btnSterge
            // 
            this.btnSterge.Location = new System.Drawing.Point(100, 230);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(80, 30);
            this.btnSterge.TabIndex = 2;
            this.btnSterge.Text = "Șterge";
            this.btnSterge.Click += new System.EventHandler(this.btnStergeMobila_Click);
            // 
            // FormListaMobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 272);
            this.Controls.Add(this.listViewMobila);
            this.Controls.Add(this.btnDetalii);
            this.Controls.Add(this.btnSterge);
            this.Name = "FormListaMobila";
            this.Text = "Lista de Mobilă";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDetMobila;
        private System.Windows.Forms.Button btnStergeMobila;
    }
}