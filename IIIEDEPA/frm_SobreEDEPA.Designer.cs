namespace IIIEDEPA
{
    partial class frm_SobreEDEPA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SobreEDEPA));
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.lbl_contenido = new System.Windows.Forms.Label();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_titulo.Location = new System.Drawing.Point(216, 9);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(242, 40);
            this.lbl_titulo.TabIndex = 0;
            this.lbl_titulo.Text = "Qué es III EDEPA?";
            // 
            // lbl_contenido
            // 
            this.lbl_contenido.AutoSize = true;
            this.lbl_contenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_contenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contenido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_contenido.Location = new System.Drawing.Point(12, 88);
            this.lbl_contenido.Name = "lbl_contenido";
            this.lbl_contenido.Size = new System.Drawing.Size(660, 192);
            this.lbl_contenido.TabIndex = 1;
            this.lbl_contenido.Text = resources.GetString("lbl_contenido.Text");
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.BackgroundImage")));
            this.btn_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_siguiente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_siguiente.Location = new System.Drawing.Point(318, 427);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(100, 50);
            this.btn_siguiente.TabIndex = 2;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_atras.BackgroundImage")));
            this.btn_atras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_atras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_atras.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_atras.Location = new System.Drawing.Point(212, 427);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 50);
            this.btn_atras.TabIndex = 3;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_inicio
            // 
            this.btn_inicio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_inicio.BackgroundImage")));
            this.btn_inicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_inicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_inicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_inicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_inicio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_inicio.Location = new System.Drawing.Point(582, 427);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 50);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // frm_SobreEDEPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lbl_contenido);
            this.Controls.Add(this.lbl_titulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_SobreEDEPA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre EDEPA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Label lbl_contenido;
        private System.Windows.Forms.Button btn_siguiente;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_inicio;
    }
}