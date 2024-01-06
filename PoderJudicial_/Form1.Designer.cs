namespace PoderJudicial_
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
            this.consultarButton.Location = new System.Drawing.Point(268, 154);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.consultarButton);
            this.Controls.Add(this.ruta);
            this.Controls.Add(this.seleccionarButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poder Judicial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialTextBox ruta;
        private MaterialSkin.Controls.MaterialButton consultarButton;
        public MaterialSkin.Controls.MaterialButton seleccionarButton;
    }
}

