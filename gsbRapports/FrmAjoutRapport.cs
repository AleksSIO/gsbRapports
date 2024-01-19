using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gsbRapports
{
    public partial class FrmAjoutRapport : Form
    {
        private gsbrapports2021Entities mesDonneesEF;
        public FrmAjoutRapport(gsbrapports2021Entities mesDonneesEF)
        {
            InitializeComponent();
            this.mesDonneesEF = mesDonneesEF;
            this.bdgVisiteur.DataSource = mesDonneesEF.visiteurs.ToList();
            this.bdgMedecin.DataSource = mesDonneesEF.medecins.ToList();
            this.bdgFamille.DataSource = mesDonneesEF.familles.Include("medicaments").ToList();
            this.bdgMedicament.DataSource = this.bdgFamille;
            this.bdgMedicament.DataMember = "medicaments";

            dtgMedicament.DataSource = bdgMedicament;
            bdgFamille.CurrentChanged += CmbFamille_CurrentChanged;


        }

        private void CmbFamille_CurrentChanged(object sender, EventArgs e)
        {

            this.bdgMedicament.DataSource = ((famille)cmbFamille.SelectedValue).medicaments.ToList();
        }

        private int newNumRapport()
        {
            int n;
            int dernier = (from ra in this.mesDonneesEF.rapports
                           select ra.id).Max();
            n = dernier + 1;
            return n;
        }

        private rapport newRapport()
        {
            int n = newNumRapport();
            medecin medecin= (medecin)cmbMedecin.SelectedValue;
            visiteur v = (visiteur)cmbVisiteur.SelectedValue;
            DateTime d = this.dtRapport.Value;
            string motif = this.tbMotif.Text;
            string bilan = this.tbBilan.Text;
            rapport r = new rapport();
            r.id = n;
            r.motif = motif;
            r.bilan = bilan;
            r.date = d;
            r.idMedecin = medecin.id;
            r.idVisiteur = v.id;
            return r;
        }

        private offrir newOffrir()
        {
            rapport r = newRapport();
            DataGridViewRow selectedMedicament = dtgMedicament.SelectedRows[0];
            medicament medicament = (medicament)selectedMedicament.DataBoundItem;
            offrir o = new offrir();
            o.idRapport = r.id;
            o.idMedicament = medicament.id;
            o.quantite = 1;
            
            return o;
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            this.mesDonneesEF.rapports.Add(newRapport());
            this.mesDonneesEF.offrirs.Add(newOffrir());
            this.bdgVisiteur.EndEdit();
            this.bdgMedicament.EndEdit();   
            this.bdgFamille.EndEdit();
            this.bdgMedecin.EndEdit();
            this.mesDonneesEF.SaveChanges();
            MessageBox.Show("Enregistrement validé");
        }
    }
}
