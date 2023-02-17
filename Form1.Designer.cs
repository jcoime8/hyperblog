namespace LIstaTDA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.LstCelulares = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NUDTxtCamaras = new System.Windows.Forms.NumericUpDown();
            this.MaskedTxtTamaño = new System.Windows.Forms.MaskedTextBox();
            this.TxtColor = new System.Windows.Forms.TextBox();
            this.TxtModelo = new System.Windows.Forms.TextBox();
            this.TxtMaterial = new System.Windows.Forms.TextBox();
            this.TxtMarca = new System.Windows.Forms.TextBox();
            this.LblModelo = new System.Windows.Forms.Label();
            this.LblMaterial = new System.Windows.Forms.Label();
            this.LblCamaras = new System.Windows.Forms.Label();
            this.LblTamaño = new System.Windows.Forms.Label();
            this.LblColor = new System.Windows.Forms.Label();
            this.LblMarca = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnContar = new System.Windows.Forms.Button();
            this.BtnAñadir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTxtCamaras)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstCelulares
            // 
            this.LstCelulares.FormattingEnabled = true;
            this.LstCelulares.Location = new System.Drawing.Point(9, 10);
            this.LstCelulares.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.LstCelulares.Name = "LstCelulares";
            this.LstCelulares.Size = new System.Drawing.Size(196, 394);
            this.LstCelulares.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.NUDTxtCamaras);
            this.groupBox1.Controls.Add(this.MaskedTxtTamaño);
            this.groupBox1.Controls.Add(this.TxtColor);
            this.groupBox1.Controls.Add(this.TxtModelo);
            this.groupBox1.Controls.Add(this.TxtMaterial);
            this.groupBox1.Controls.Add(this.TxtMarca);
            this.groupBox1.Controls.Add(this.LblModelo);
            this.groupBox1.Controls.Add(this.LblMaterial);
            this.groupBox1.Controls.Add(this.LblCamaras);
            this.groupBox1.Controls.Add(this.LblTamaño);
            this.groupBox1.Controls.Add(this.LblColor);
            this.groupBox1.Controls.Add(this.LblMarca);
            this.groupBox1.Location = new System.Drawing.Point(209, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(712, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Celular";
            // 
            // NUDTxtCamaras
            // 
            this.NUDTxtCamaras.Location = new System.Drawing.Point(378, 41);
            this.NUDTxtCamaras.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.NUDTxtCamaras.Name = "NUDTxtCamaras";
            this.NUDTxtCamaras.Size = new System.Drawing.Size(167, 20);
            this.NUDTxtCamaras.TabIndex = 11;
            this.NUDTxtCamaras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaskedTxtTamaño
            // 
            this.MaskedTxtTamaño.Location = new System.Drawing.Point(64, 136);
            this.MaskedTxtTamaño.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaskedTxtTamaño.Mask = "000,00";
            this.MaskedTxtTamaño.Name = "MaskedTxtTamaño";
            this.MaskedTxtTamaño.Size = new System.Drawing.Size(168, 20);
            this.MaskedTxtTamaño.TabIndex = 10;
            this.MaskedTxtTamaño.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtColor
            // 
            this.TxtColor.Location = new System.Drawing.Point(64, 87);
            this.TxtColor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtColor.Name = "TxtColor";
            this.TxtColor.Size = new System.Drawing.Size(168, 20);
            this.TxtColor.TabIndex = 9;
            // 
            // TxtModelo
            // 
            this.TxtModelo.Location = new System.Drawing.Point(378, 136);
            this.TxtModelo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtModelo.Name = "TxtModelo";
            this.TxtModelo.Size = new System.Drawing.Size(168, 20);
            this.TxtModelo.TabIndex = 8;
            // 
            // TxtMaterial
            // 
            this.TxtMaterial.Location = new System.Drawing.Point(378, 87);
            this.TxtMaterial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMaterial.Name = "TxtMaterial";
            this.TxtMaterial.Size = new System.Drawing.Size(168, 20);
            this.TxtMaterial.TabIndex = 7;
            // 
            // TxtMarca
            // 
            this.TxtMarca.Location = new System.Drawing.Point(64, 41);
            this.TxtMarca.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtMarca.Name = "TxtMarca";
            this.TxtMarca.Size = new System.Drawing.Size(168, 20);
            this.TxtMarca.TabIndex = 6;
            // 
            // LblModelo
            // 
            this.LblModelo.AutoSize = true;
            this.LblModelo.Location = new System.Drawing.Point(299, 141);
            this.LblModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblModelo.Name = "LblModelo";
            this.LblModelo.Size = new System.Drawing.Size(42, 13);
            this.LblModelo.TabIndex = 5;
            this.LblModelo.Text = "Modelo";
            // 
            // LblMaterial
            // 
            this.LblMaterial.AutoSize = true;
            this.LblMaterial.Location = new System.Drawing.Point(299, 92);
            this.LblMaterial.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMaterial.Name = "LblMaterial";
            this.LblMaterial.Size = new System.Drawing.Size(44, 13);
            this.LblMaterial.TabIndex = 4;
            this.LblMaterial.Text = "Material";
            // 
            // LblCamaras
            // 
            this.LblCamaras.AutoSize = true;
            this.LblCamaras.Location = new System.Drawing.Point(299, 46);
            this.LblCamaras.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCamaras.Name = "LblCamaras";
            this.LblCamaras.Size = new System.Drawing.Size(48, 13);
            this.LblCamaras.TabIndex = 3;
            this.LblCamaras.Text = "Camaras";
            // 
            // LblTamaño
            // 
            this.LblTamaño.AutoSize = true;
            this.LblTamaño.Location = new System.Drawing.Point(4, 141);
            this.LblTamaño.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTamaño.Name = "LblTamaño";
            this.LblTamaño.Size = new System.Drawing.Size(46, 13);
            this.LblTamaño.TabIndex = 2;
            this.LblTamaño.Text = "Tamaño";
            // 
            // LblColor
            // 
            this.LblColor.AutoSize = true;
            this.LblColor.Location = new System.Drawing.Point(4, 92);
            this.LblColor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblColor.Name = "LblColor";
            this.LblColor.Size = new System.Drawing.Size(31, 13);
            this.LblColor.TabIndex = 1;
            this.LblColor.Text = "Color";
            // 
            // LblMarca
            // 
            this.LblMarca.AutoSize = true;
            this.LblMarca.Location = new System.Drawing.Point(4, 46);
            this.LblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblMarca.Name = "LblMarca";
            this.LblMarca.Size = new System.Drawing.Size(37, 13);
            this.LblMarca.TabIndex = 0;
            this.LblMarca.Text = "Marca";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnContar);
            this.panel1.Controls.Add(this.BtnAñadir);
            this.panel1.Location = new System.Drawing.Point(209, 221);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 183);
            this.panel1.TabIndex = 2;
            // 
            // BtnContar
            // 
            this.BtnContar.Location = new System.Drawing.Point(73, 19);
            this.BtnContar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnContar.Name = "BtnContar";
            this.BtnContar.Size = new System.Drawing.Size(62, 32);
            this.BtnContar.TabIndex = 1;
            this.BtnContar.Text = "Contar";
            this.BtnContar.UseVisualStyleBackColor = true;
            this.BtnContar.Click += new System.EventHandler(this.BtnContar_Click);
            // 
            // BtnAñadir
            // 
            this.BtnAñadir.Location = new System.Drawing.Point(7, 19);
            this.BtnAñadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BtnAñadir.Name = "BtnAñadir";
            this.BtnAñadir.Size = new System.Drawing.Size(62, 32);
            this.BtnAñadir.TabIndex = 0;
            this.BtnAñadir.Text = "Añadir";
            this.BtnAñadir.UseVisualStyleBackColor = true;
            this.BtnAñadir.Click += new System.EventHandler(this.BtnAñadir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 421);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LstCelulares);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lista de Celulares";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUDTxtCamaras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstCelulares;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown NUDTxtCamaras;
        private System.Windows.Forms.MaskedTextBox MaskedTxtTamaño;
        private System.Windows.Forms.TextBox TxtColor;
        private System.Windows.Forms.TextBox TxtModelo;
        private System.Windows.Forms.TextBox TxtMaterial;
        private System.Windows.Forms.TextBox TxtMarca;
        private System.Windows.Forms.Label LblModelo;
        private System.Windows.Forms.Label LblMaterial;
        private System.Windows.Forms.Label LblCamaras;
        private System.Windows.Forms.Label LblTamaño;
        private System.Windows.Forms.Label LblColor;
        private System.Windows.Forms.Label LblMarca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnContar;
        private System.Windows.Forms.Button BtnAñadir;
    }
}

