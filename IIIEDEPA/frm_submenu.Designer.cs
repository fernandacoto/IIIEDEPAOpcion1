namespace IIIEDEPA
{
    partial class frm_submenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_submenu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_conferencias = new System.Windows.Forms.Button();
            this.btn_ponencias = new System.Windows.Forms.Button();
            this.btn_talleres = new System.Windows.Forms.Button();
            this.btn_inicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(282, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 212);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_conferencias
            // 
            this.btn_conferencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_conferencias.BackgroundImage")));
            this.btn_conferencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_conferencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_conferencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_conferencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_conferencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_conferencias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_conferencias.Location = new System.Drawing.Point(12, 40);
            this.btn_conferencias.Name = "btn_conferencias";
            this.btn_conferencias.Size = new System.Drawing.Size(135, 48);
            this.btn_conferencias.TabIndex = 1;
            this.btn_conferencias.Text = "Conferencias";
            this.btn_conferencias.UseVisualStyleBackColor = true;
            this.btn_conferencias.Click += new System.EventHandler(this.btn_conferencias_Click);
            // 
            // btn_ponencias
            // 
            this.btn_ponencias.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ponencias.BackgroundImage")));
            this.btn_ponencias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_ponencias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ponencias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ponencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ponencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_ponencias.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ponencias.Location = new System.Drawing.Point(12, 132);
            this.btn_ponencias.Name = "btn_ponencias";
            this.btn_ponencias.Size = new System.Drawing.Size(135, 48);
            this.btn_ponencias.TabIndex = 2;
            this.btn_ponencias.Text = "Ponencias";
            this.btn_ponencias.UseVisualStyleBackColor = true;
            // 
            // btn_talleres
            // 
            this.btn_talleres.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_talleres.BackgroundImage")));
            this.btn_talleres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_talleres.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_talleres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_talleres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_talleres.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btn_talleres.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_talleres.Location = new System.Drawing.Point(12, 239);
            this.btn_talleres.Name = "btn_talleres";
            this.btn_talleres.Size = new System.Drawing.Size(135, 48);
            this.btn_talleres.TabIndex = 3;
            this.btn_talleres.Text = "Talleres";
            this.btn_talleres.UseVisualStyleBackColor = true;
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
            this.btn_inicio.Location = new System.Drawing.Point(583, 413);
            this.btn_inicio.Name = "btn_inicio";
            this.btn_inicio.Size = new System.Drawing.Size(100, 50);
            this.btn_inicio.TabIndex = 4;
            this.btn_inicio.Text = "Inicio";
            this.btn_inicio.UseVisualStyleBackColor = true;
            this.btn_inicio.Click += new System.EventHandler(this.btn_inicio_Click);
            // 
            // frm_submenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(684, 462);
            this.Controls.Add(this.btn_inicio);
            this.Controls.Add(this.btn_talleres);
            this.Controls.Add(this.btn_ponencias);
            this.Controls.Add(this.btn_conferencias);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_submenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actividades";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_conferencias;
        private System.Windows.Forms.Button btn_ponencias;
        private System.Windows.Forms.Button btn_talleres;
        private System.Windows.Forms.Button btn_inicio;
    }
}