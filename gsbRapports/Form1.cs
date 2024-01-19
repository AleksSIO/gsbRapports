using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class Form1 : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        public Form1()
        {
            this.InitializeComponent();
            this.mesDonneesEF = new gsbrapports2021Entities();
        }

        private void ajouterToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FrmAjoutRapport f = new FrmAjoutRapport(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void rechercherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRechercheRapport f = new FrmRechercheRapport(this.mesDonneesEF);
            f.MdiParent = this;
            f.Show();
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
