using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IIIEDEPA
{
    public partial class frm_Comite : Form
    {
        public frm_Comite()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.Show();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            frm_Objetivos objetivos = new frm_Objetivos();
            this.Hide();
            objetivos.Show();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            frm_comitenacional nacional = new frm_comitenacional();
            this.Hide();
            nacional.Show();
        }
    }
}
