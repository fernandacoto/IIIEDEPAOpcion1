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
    public partial class frm_Objetivos : Form
    {
        public frm_Objetivos()
        {
            InitializeComponent();
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            frm_SobreEDEPA edepa = new frm_SobreEDEPA();
            this.Hide();
            edepa.Show();
        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            frm_Comite comite = new frm_Comite();
            this.Hide();
            comite.Show();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.Show();
        }
    }
}
