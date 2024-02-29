namespace RevisaIA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.seleccionarButton = new MaterialSkin.Controls.MaterialButton();
            this.ruta = new MaterialSkin.Controls.MaterialTextBox();
            this.consultarButton = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBoxOrganismos = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.hojasTextBox = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // seleccionarButton
            // 
            this.seleccionarButton.AutoSize = false;
            this.seleccionarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.seleccionarButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.seleccionarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.seleccionarButton.Depth = 0;
            this.seleccionarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.seleccionarButton.HighEmphasis = true;
            this.seleccionarButton.Icon = null;
            this.seleccionarButton.Location = new System.Drawing.Point(81, 80);
            this.seleccionarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.seleccionarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.seleccionarButton.Name = "seleccionarButton";
            this.seleccionarButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.seleccionarButton.Size = new System.Drawing.Size(105, 38);
            this.seleccionarButton.TabIndex = 0;
            this.seleccionarButton.Text = "Seleccionar Archivo";
            this.seleccionarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Text;
            this.seleccionarButton.UseAccentColor = false;
            this.seleccionarButton.UseVisualStyleBackColor = true;
            this.seleccionarButton.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ruta
            // 
            this.ruta.AnimateReadOnly = false;
            this.ruta.BackColor = System.Drawing.SystemColors.Menu;
            this.ruta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ruta.Depth = 0;
            this.ruta.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ruta.LeadingIcon = null;
            this.ruta.Location = new System.Drawing.Point(207, 80);
            this.ruta.MaxLength = 50;
            this.ruta.MouseState = MaterialSkin.MouseState.OUT;
            this.ruta.Multiline = false;
            this.ruta.Name = "ruta";
            this.ruta.Size = new System.Drawing.Size(405, 50);
            this.ruta.TabIndex = 3;
            this.ruta.Text = "";
            this.ruta.TrailingIcon = null;
            // 
            // consultarButton
            // 
            this.consultarButton.AutoSize = false;
            this.consultarButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.consultarButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.consultarButton.Depth = 0;
            this.consultarButton.HighEmphasis = true;
            this.consultarButton.Icon = null;
            this.consultarButton.Location = new System.Drawing.Point(285, 258);
            this.consultarButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.consultarButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.consultarButton.Name = "consultarButton";
            this.consultarButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.consultarButton.Size = new System.Drawing.Size(200, 50);
            this.consultarButton.TabIndex = 4;
            this.consultarButton.Text = "CONSULTAR";
            this.consultarButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.consultarButton.UseAccentColor = false;
            this.consultarButton.UseVisualStyleBackColor = true;
            this.consultarButton.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "© Copyright: Rodrigo Agustín Tardini. Permisos de uso: rodrigotardini@gmail.com";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RevisaIA.Properties.Resources.revisaIA;
            this.pictureBox1.Location = new System.Drawing.Point(285, 317);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 198);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comboBoxOrganismos
            // 
            this.comboBoxOrganismos.AutoResize = false;
            this.comboBoxOrganismos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboBoxOrganismos.Depth = 0;
            this.comboBoxOrganismos.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxOrganismos.DropDownHeight = 174;
            this.comboBoxOrganismos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOrganismos.DropDownWidth = 121;
            this.comboBoxOrganismos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboBoxOrganismos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboBoxOrganismos.FormattingEnabled = true;
            this.comboBoxOrganismos.IntegralHeight = false;
            this.comboBoxOrganismos.ItemHeight = 43;
            this.comboBoxOrganismos.Location = new System.Drawing.Point(207, 137);
            this.comboBoxOrganismos.MaxDropDownItems = 4;
            this.comboBoxOrganismos.MouseState = MaterialSkin.MouseState.OUT;
            this.comboBoxOrganismos.Name = "comboBoxOrganismos";
            this.comboBoxOrganismos.Size = new System.Drawing.Size(405, 49);
            this.comboBoxOrganismos.StartIndex = 0;
            this.comboBoxOrganismos.TabIndex = 7;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(93, 151);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(93, 19);
            this.materialLabel1.TabIndex = 8;
            this.materialLabel1.Text = "ORGANISMO";
            // 
            // hojasTextBox
            // 
            this.hojasTextBox.AnimateReadOnly = false;
            this.hojasTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.hojasTextBox.Depth = 0;
            this.hojasTextBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.hojasTextBox.LeadingIcon = null;
            this.hojasTextBox.Location = new System.Drawing.Point(207, 203);
            this.hojasTextBox.MaxLength = 50;
            this.hojasTextBox.MouseState = MaterialSkin.MouseState.OUT;
            this.hojasTextBox.Multiline = false;
            this.hojasTextBox.Name = "hojasTextBox";
            this.hojasTextBox.Size = new System.Drawing.Size(405, 50);
            this.hojasTextBox.TabIndex = 9;
            this.hojasTextBox.Text = "";
            this.hojasTextBox.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(51, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(150, 19);
            this.materialLabel2.TabIndex = 10;
            this.materialLabel2.Text = "HOJAS A PROCESAR";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 535);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.hojasTextBox);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.comboBoxOrganismos);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.seleccionarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RevisaIA";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox ruta;
        private MaterialSkin.Controls.MaterialButton consultarButton;
        public MaterialSkin.Controls.MaterialButton seleccionarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialComboBox comboBoxOrganismos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox hojasTextBox;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}

