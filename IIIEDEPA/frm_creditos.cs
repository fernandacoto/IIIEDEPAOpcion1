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
    public partial class frm_creditos : Form
    {
        public frm_creditos()
        {
            InitializeComponent();
        }

        private void btn_inicio_Click(object sender, EventArgs e)
        {
            frm_Menu menu = new frm_Menu();
            this.Hide();
            menu.Show();
        }
    }
}
