namespace UI
{
    partial class FormAdaugareMobila
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
            this.radioButtonRosu = new System.Windows.Forms.RadioButton();
            this.radioButtonVerde = new System.Windows.Forms.RadioButton();
            this.radioButtonAlbastru = new System.Windows.Forms.RadioButton();
            this.radioButtonNegru = new System.Windows.Forms.RadioButton();
            this.checkBoxScaun = new System.Windows.Forms.CheckBox();
            this.checkBoxMasa = new System.Windows.Forms.CheckBox();
            this.checkBoxDulap = new System.Windows.Forms.CheckBox();
            this.lblTitluAdaugareMobila = new System.Windows.Forms.Label();
            this.btnAdaugaMobila = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radioButtonRosu
            // 
            this.radioButtonRosu.AutoSize = true;
            this.radioButtonRosu.Location = new System.Drawing.Point(20, 150);
            this.radioButtonRosu.Name = "radioButtonRosu";
            this.radioButtonRosu.Size = new System.Drawing.Size(50, 17);
            this.radioButtonRosu.TabIndex = 6;
            this.radioButtonRosu.TabStop = true;
            this.radioButtonRosu.Text = "Roșu";
            this.radioButtonRosu.UseVisualStyleBackColor = true;
            // 
            // radioButtonVerde
            // 
            this.radioButtonVerde.AutoSize = true;
            this.radioButtonVerde.Location = new System.Drawing.Point(20, 180);
            this.radioButtonVerde.Name = "radioButtonVerde";
            this.radioButtonVerde.Size = new System.Drawing.Size(53, 17);
            this.radioButtonVerde.TabIndex = 7;
            this.radioButtonVerde.TabStop = true;
            this.radioButtonVerde.Text = "Verde";
            this.radioButtonVerde.UseVisualStyleBackColor = true;
            // 
            // radioButtonAlbastru
            // 
            this.radioButtonAlbastru.AutoSize = true;
            this.radioButtonAlbastru.Location = new System.Drawing.Point(20, 210);
            this.radioButtonAlbastru.Name = "radioButtonAlbastru";
            this.radioButtonAlbastru.Size = new System.Drawing.Size(63, 17);
            this.radioButtonAlbastru.TabIndex = 8;
            this.radioButtonAlbastru.TabStop = true;
            this.radioButtonAlbastru.Text = "Albastru";
            this.radioButtonAlbastru.UseVisualStyleBackColor = true;
            // 
            // radioButtonNegru
            // 
            this.radioButtonNegru.AutoSize = true;
            this.radioButtonNegru.Location = new System.Drawing.Point(20, 240);
            this.radioButtonNegru.Name = "radioButtonNegru";
            this.radioButtonNegru.Size = new System.Drawing.Size(73, 17);
            this.radioButtonNegru.TabIndex = 9;
            this.radioButtonNegru.TabStop = true;
            this.radioButtonNegru.Text = "Negru";
            this.radioButtonNegru.UseVisualStyleBackColor = true;
            // 
            // checkBoxScaun
            // 
            this.checkBoxScaun.AutoSize = true;
            this.checkBoxScaun.Location = new System.Drawing.Point(150, 150);
            this.checkBoxScaun.Name = "checkBoxScaun";
            this.checkBoxScaun.Size = new System.Drawing.Size(57, 17);
            this.checkBoxScaun.TabIndex = 9;
            this.checkBoxScaun.Text = "Scaun";
            this.checkBoxScaun.UseVisualStyleBackColor = true;
            // 
            // checkBoxMasa
            // 
            this.checkBoxMasa.AutoSize = true;
            this.checkBoxMasa.Location = new System.Drawing.Point(150, 180);
            this.checkBoxMasa.Name = "checkBoxMasa";
            this.checkBoxMasa.Size = new System.Drawing.Size(52, 17);
            this.checkBoxMasa.TabIndex = 10;
            this.checkBoxMasa.Text = "Masă";
            this.checkBoxMasa.UseVisualStyleBackColor = true;
            // 
            // checkBoxDulap
            // 
            this.checkBoxDulap.AutoSize = true;
            this.checkBoxDulap.Location = new System.Drawing.Point(150, 210);
            this.checkBoxDulap.Name = "checkBoxDulap";
            this.checkBoxDulap.Size = new System.Drawing.Size(54, 17);
            this.checkBoxDulap.TabIndex = 11;
            this.checkBoxDulap.Text = "Dulap";
            this.checkBoxDulap.UseVisualStyleBackColor = true;
            // 
            // lblTitluAdaugareMobila
            // 
            this.lblTitluAdaugareMobila.AutoSize = true;
            this.lblTitluAdaugareMobila.Location = new System.Drawing.Point(330, 35);
            this.lblTitluAdaugareMobila.Name = "lblTitluAdaugareMobila";
            this.lblTitluAdaugareMobila.Size = new System.Drawing.Size(87, 13);
            this.lblTitluAdaugareMobila.TabIndex = 13;
            this.lblTitluAdaugareMobila.Text = "Adaugare Mobila";
            this.lblTitluAdaugareMobila.Click += new System.EventHandler(this.lblTitluAdaugareMobila_Click);
            // 
            // btnAdaugaMobila
            // 
            this.btnAdaugaMobila.Location = new System.Drawing.Point(20, 392);
            this.btnAdaugaMobila.Name = "btnAdaugaMobila";
            this.btnAdaugaMobila.Size = new System.Drawing.Size(99, 23);
            this.btnAdaugaMobila.TabIndex = 14;
            this.btnAdaugaMobila.Text = "Adauga Mobila";
            this.btnAdaugaMobila.UseVisualStyleBackColor = true;
            this.btnAdaugaMobila.Click += new System.EventHandler(this.btnAdaugaMobila_Click);
            // 
            // FormAdaugareMobila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdaugaMobila);
            this.Controls.Add(this.lblTitluAdaugareMobila);
            this.Controls.Add(this.radioButtonRosu);
            this.Controls.Add(this.radioButtonVerde);
            this.Controls.Add(this.radioButtonAlbastru);
            this.Controls.Add(this.checkBoxScaun);
            this.Controls.Add(this.checkBoxMasa);
            this.Controls.Add(this.checkBoxDulap);
            this.Name = "FormAdaugareMobila";
            this.Text = "FormListaMobila";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitluAdaugareMobila;
        private System.Windows.Forms.Button btnAdaugaMobila;
    }
}