namespace IIIEDEPA
{
    partial class frm_creditos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_creditos));
            this.btn_inicio = new System.Windows.Forms.Button();
            this.lbl_Nacional = new System.Windows.Forms.Label();
            this.lbl_comite1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.btn_inicio.Location = new System.Drawing.Point(585, 413);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 50);
            this.btn_inicio.TabIndex = 5;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // lbl_Nacional
            // 
            this.lbl_Nacional.AutoSize = true;
            this.lbl_Nacional.Font = new System.Drawing.Font("Segoe Script", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lbl_Nacional.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_Nacional.Location = new System.Drawing.Point(263, 9);
            this.lbl_Nacional.Name = "lbl_Nacional";
            this.lbl_Nacional.Size = new System.Drawing.Size(119, 40);
            this.lbl_Nacional.TabIndex = 6;
            this.lbl_Nacional.Text = "Créditos";
            // 
            // lbl_comite1
            // 
            this.lbl_comite1.AutoSize = true;
            this.lbl_comite1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_comite1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(29)))), ((int)(((byte)(6)))));
            this.lbl_comite1.Location = new System.Drawing.Point(201, 79);
            this.lbl_comite1.Name = "lbl_comite1";
            this.lbl_comite1.Size = new System.Drawing.Size(295, 144);
            this.lbl_comite1.TabIndex = 7;
            this.lbl_comite1.Text = resources.GetString("lbl_comite1.Text");
            // 
            // frm_creditos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.lbl_comite1);
            this.Controls.Add(this.lbl_Nacional);
            this.Controls.Add(this.btn_inicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_creditos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Créditos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_inicio;
        private System.Windows.Forms.Label lbl_Nacional;
        private System.Windows.Forms.Label lbl_comite1;
    }
}