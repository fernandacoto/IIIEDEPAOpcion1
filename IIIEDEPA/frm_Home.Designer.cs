namespace IIIEDEPA
{
    partial class frm_Home
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Home));
            this.pbx_logoTEC = new System.Windows.Forms.PictureBox();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_ingresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoTEC)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_logoTEC
            // 
            this.pbx_logoTEC.Image = ((System.Drawing.Image)(resources.GetObject("pbx_logoTEC.Image")));
            this.pbx_logoTEC.Location = new System.Drawing.Point(233, 12);
            this.pbx_logoTEC.Name = "pbx_logoTEC";
            this.pbx_logoTEC.Size = new System.Drawing.Size(204, 204);
            this.pbx_logoTEC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbx_logoTEC.TabIndex = 0;
            this.pbx_logoTEC.TabStop = false;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(2, 234);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(681, 22);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "III Encuentro sobre Didáctica de la Estadística,la Probabilidad y el Análisis de " +
                "Datos";
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ingresar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_ingresar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ingresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ingresar.BackgroundImage")));
            this.btn_ingresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ingresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ingresar.Location = new System.Drawing.Point(272, 274);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(148, 72);
            this.btn_ingresar.TabIndex = 2;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btn_ingresar.UseVisualStyleBackColor = false;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // frm_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.pbx_logoTEC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frm_Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logoTEC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_logoTEC;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.Button btn_ingresar;

    }
}

