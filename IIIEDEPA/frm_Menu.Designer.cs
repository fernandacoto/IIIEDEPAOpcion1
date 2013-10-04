namespace IIIEDEPA
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btn_EDEPA = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.link_creditos = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(24, 419);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "pruebapdf";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btn_EDEPA
            // 
            this.btn_EDEPA.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_EDEPA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EDEPA.BackgroundImage")));
            this.btn_EDEPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_EDEPA.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_EDEPA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_EDEPA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EDEPA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btn_EDEPA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_EDEPA.Location = new System.Drawing.Point(27, 290);
            this.btn_EDEPA.Name = "btn_EDEPA";
            this.btn_EDEPA.Size = new System.Drawing.Size(171, 75);
            this.btn_EDEPA.TabIndex = 2;
            this.btn_EDEPA.Text = "III EDEPA";
            this.btn_EDEPA.UseVisualStyleBackColor = true;
            this.btn_EDEPA.Click += new System.EventHandler(this.btn_EDEPA_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(467, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 75);
            this.button1.TabIndex = 3;
            this.button1.Text = "Actividades";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // link_creditos
            // 
            this.link_creditos.AutoSize = true;
            this.link_creditos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.link_creditos.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.link_creditos.Location = new System.Drawing.Point(628, 460);
            this.link_creditos.Name = "link_creditos";
            this.link_creditos.Size = new System.Drawing.Size(66, 16);
            this.link_creditos.TabIndex = 4;
            this.link_creditos.TabStop = true;
            this.link_creditos.Text = "Créditos";
            this.link_creditos.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.link_creditos_LinkClicked);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 476);
            this.Controls.Add(this.link_creditos);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EDEPA);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btn_EDEPA;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel link_creditos;
    }
}