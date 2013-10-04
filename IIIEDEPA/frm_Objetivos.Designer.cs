namespace IIIEDEPA
{
    partial class frm_Objetivos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Objetivos));
            this.lbl_objetivos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_objetivos
            // 
            this.lbl_objetivos.AutoSize = true;
            this.lbl_objetivos.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_objetivos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_objetivos.Location = new System.Drawing.Point(210, 9);
            this.lbl_objetivos.Name = "lbl_objetivos";
            this.lbl_objetivos.Size = new System.Drawing.Size(260, 40);
            this.lbl_objetivos.TabIndex = 0;
            this.lbl_objetivos.Text = "Objetivos Generales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(634, 160);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
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
            this.btn_inicio.TabIndex = 7;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
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
            this.btn_atras.TabIndex = 6;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
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
            this.btn_siguiente.TabIndex = 5;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // frm_Objetivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_objetivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Objetivos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Objetivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_objetivos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_siguiente;
    }
}