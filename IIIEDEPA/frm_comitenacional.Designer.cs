namespace IIIEDEPA
{
    partial class frm_comitenacional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_comitenacional));
            this.lbl_Nacional = new System.Windows.Forms.Label();
            this.lbl_comite1 = new System.Windows.Forms.Label();
            this.btn_inicio = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nacional
            // 
            this.lbl_Nacional.AutoSize = true;
            this.lbl_Nacional.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Nacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_Nacional.Location = new System.Drawing.Point(137, 9);
            this.lbl_Nacional.Name = "lbl_Nacional";
            this.lbl_Nacional.Size = new System.Drawing.Size(368, 40);
            this.lbl_Nacional.TabIndex = 4;
            this.lbl_Nacional.Text = "Comité Científico Nacional";
            // 
            // lbl_comite1
            // 
            this.lbl_comite1.AutoSize = true;
            this.lbl_comite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_comite1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_comite1.Location = new System.Drawing.Point(27, 76);
            this.lbl_comite1.Name = "lbl_comite1";
            this.lbl_comite1.Size = new System.Drawing.Size(489, 112);
            this.lbl_comite1.TabIndex = 5;
            this.lbl_comite1.Text = resources.GetString("lbl_comite1.Text");
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
            this.btn_inicio.Location = new System.Drawing.Point(567, 425);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 50);
            this.btn_inicio.TabIndex = 12;
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
            this.btn_atras.Location = new System.Drawing.Point(278, 425);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(100, 50);
            this.btn_atras.TabIndex = 11;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // frm_comitenacional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.lbl_comite1);
            this.Controls.Add(this.lbl_Nacional);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_comitenacional";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comité Científico Nacional";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nacional;
        private System.Windows.Forms.Label lbl_comite1;
        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Button btn_atras;
    }
}