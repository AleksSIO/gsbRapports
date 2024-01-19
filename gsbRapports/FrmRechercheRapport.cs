using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmRechercheRapport : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        private List<rapport> lesRapportsActuels;
        public FrmRechercheRapport(gsbrapports2021Entities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgSrapport.DataSource = this.mesDonneesEF.rapports.ToList();
            this.bdgSvisiteur.DataSource = this.mesDonneesEF.visiteurs.ToList();
            this.bdgSmedecin.DataSource = this.mesDonneesEF.medecins.ToList();

            this.ckbFiltre.Enabled = false;

            var datesDistinctes = this.mesDonneesEF.rapports
            .Select(r => r.date)  
            .Distinct() 
            .OrderBy(date => date) 
            .ToList();     

            this.cmbDate.DataSource = datesDistinctes;

            this.dtgRapport.DataSource = null;
            this.dtgRapport.AutoGenerateColumns = false;
        }

        private void Rechercher()
        {
            var date = (DateTime)this.cmbDate.SelectedValue;
            visiteur v = (visiteur)this.cmbVisiteur.SelectedValue;

            var rapportsRecherches = this.mesDonneesEF.rapports
            .Where(r => r.date == date && r.idVisiteur == v.id)
            .ToList();

            this.dtgRapport.DataSource = rapportsRecherches;

            this.lesRapportsActuels = rapportsRecherches;

            this.ckbFiltre.Enabled = true;

            
        }

        private void btnRechercher_Click(object sender, EventArgs e)
        {
            Rechercher();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.bdgSrapport.EndEdit();
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement Validé");
        }

        private void ckbFiltre_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbFiltre.Checked)
            {
                cmbMedecin.Enabled = true;
                btnFiltrer.Enabled = true;
                var medecinsFiltres = this.lesRapportsActuels
                .Select(r => r.medecin)  
                .Distinct()
                .ToList();

                this.cmbMedecin.DataSource = medecinsFiltres;
                this.cmbMedecin.DisplayMember = "nom";
            }
            else
            {
                cmbMedecin.Enabled = false;
                btnFiltrer.Enabled = false; 
            }
        }

        private void btnFiltrer_Click(object sender, EventArgs e)
        {
            Filtrer();
        }

        private void Filtrer()
        {
            var date = (DateTime)this.cmbDate.SelectedValue;
            visiteur v = (visiteur)this.cmbVisiteur.SelectedValue;
            medecin m = (medecin)cmbMedecin.SelectedValue;

            var rapportsFiltres = this.mesDonneesEF.rapports
            .Where(r => r.date == date && r.idVisiteur == v.id  && r.idMedecin == m.id)
            .ToList();

            this.dtgRapport.DataSource = rapportsFiltres;
        }

        static void GenererFichierXml(DataTable dataTable, string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings
            {
                Indent = true,
                IndentChars = "    ",
                NewLineChars = "\n",
                NewLineHandling = NewLineHandling.Replace
            };

            using (XmlWriter xmlWriter = XmlWriter.Create(filePath, settings))
            {
                xmlWriter.WriteStartDocument();

                xmlWriter.WriteStartElement("Rapports");

                foreach (DataRow row in dataTable.Rows)
                {
                    xmlWriter.WriteStartElement("Rapport");
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        xmlWriter.WriteElementString(column.ColumnName, row[column].ToString());
                    }
                    xmlWriter.WriteEndElement();
                }
                xmlWriter.WriteEndElement();

                xmlWriter.WriteEndDocument();
            }
        }

        private void btnGenerer_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable("DataGridViewData");

            foreach (DataGridViewColumn column in dtgRapport.Columns)
            {
                dataTable.Columns.Add(column.HeaderText, typeof(string));
            }

            foreach (DataGridViewRow row in dtgRapport.Rows)
            {
                DataRow dataRow = dataTable.NewRow();
                for (int i = 0; i < dtgRapport.Columns.Count; i++)
                {
                    dataRow[i] = row.Cells[i].Value?.ToString() ?? "";
                }
                dataTable.Rows.Add(dataRow);
            }

            GenererFichierXml(dataTable, "output.xml");

            MessageBox.Show("Fichier XML généré avec succès.");
        }
    }
}
