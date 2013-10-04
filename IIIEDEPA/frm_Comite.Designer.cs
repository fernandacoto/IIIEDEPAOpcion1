namespace IIIEDEPA
{
    partial class frm_Comite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Comite));
            this.lbl_comite = new System.Windows.Forms.Label();
            this.lbl_comite1 = new System.Windows.Forms.Label();
            this.lbl_Internacional = new System.Windows.Forms.Label();
            this.lbl_comite2 = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_comite
            // 
            this.lbl_comite.AutoSize = true;
            this.lbl_comite.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_comite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_comite.Location = new System.Drawing.Point(201, 9);
            this.lbl_comite.Name = "lbl_comite";
            this.lbl_comite.Size = new System.Drawing.Size(277, 40);
            this.lbl_comite.TabIndex = 1;
            this.lbl_comite.Text = "Comité Organizador";
            // 
            // lbl_comite1
            // 
            this.lbl_comite1.AutoSize = true;
            this.lbl_comite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_comite1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_comite1.Location = new System.Drawing.Point(21, 62);
            this.lbl_comite1.Name = "lbl_comite1";
            this.lbl_comite1.Size = new System.Drawing.Size(609, 64);
            this.lbl_comite1.TabIndex = 2;
            this.lbl_comite1.Text = resources.GetString("lbl_comite1.Text");
            // 
            // lbl_Internacional
            // 
            this.lbl_Internacional.AutoSize = true;
            this.lbl_Internacional.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Internacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_Internacional.Location = new System.Drawing.Point(134, 142);
            this.lbl_Internacional.Name = "lbl_Internacional";
            this.lbl_Internacional.Size = new System.Drawing.Size(427, 40);
            this.lbl_Internacional.TabIndex = 3;
            this.lbl_Internacional.Text = "Comité Científico Internacional";
            // 
            // lbl_comite2
            // 
            this.lbl_comite2.AutoSize = true;
            this.lbl_comite2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_comite2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_comite2.Location = new System.Drawing.Point(38, 199);
            this.lbl_comite2.Name = "lbl_comite2";
            this.lbl_comite2.Size = new System.Drawing.Size(607, 144);
            this.lbl_comite2.TabIndex = 4;
            this.lbl_comite2.Text = resources.GetString("lbl_comite2.Text");
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
            this.btn_inicio.Location = new System.Drawing.Point(585, 411);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 50);
            this.btn_inicio.TabIndex = 10;
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
            this.btn_atras.Location = new System.Drawing.Point(215, 411);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 50);
            this.btn_atras.TabIndex = 9;
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
            this.btn_siguiente.Location = new System.Drawing.Point(321, 411);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(100, 50);
            this.btn_siguiente.TabIndex = 8;
            this.btn_siguiente.Text = "Siguiente";
            this.btn_siguiente.UseVisualStyleBackColor = true;
            this.btn_siguiente.Click += new System.EventHandler(this.btn_siguiente_Click);
            // 
            // frm_Comite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_siguiente);
            this.Controls.Add(this.lbl_comite2);
            this.Controls.Add(this.lbl_Internacional);
            this.Controls.Add(this.lbl_comite1);
            this.Controls.Add(this.lbl_comite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Comite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_comite;
        private System.Windows.Forms.Label lbl_comite1;
        private System.Windows.Forms.Label lbl_Internacional;
        private System.Windows.Forms.Label lbl_comite2;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_siguiente;
    }
}