using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace IIIEDEPA
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string path = Directory.GetCurrentDirectory();
            linkLabel1.Text = path;

            //string target = @"c:\temp";
            //Process.Start(@"C:/Users/morales/Desktop/Trabajos Fernanda/VIII Semestre 2013/Asistencia/IIIEDEPA/Documentos/prueba.pdf");
            try
            {
                //Process.Start(@"..\..\.\IIIEDEPADocs\prueba.pdf");
                Process.Start(@"http://sdrv.ms/18CsL8N");
            }
            catch (Exception)
            { }
        }

        private void btn_EDEPA_Click(object sender, EventArgs e)
        {
            frm_SobreEDEPA sobre = new frm_SobreEDEPA();
            this.Hide();
            sobre.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_submenu sub = new frm_submenu();
            this.Hide();
            sub.Show();
        }

        private void link_creditos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm_creditos creditos = new frm_creditos();
            this.Hide();
            creditos.Show();
        }
    }
}
