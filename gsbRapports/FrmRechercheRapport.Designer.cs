
namespace gsbRapports
{
    partial class FrmRechercheRapport
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
            this.components = new System.ComponentModel.Container();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.bdgSvisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.cmbDate = new System.Windows.Forms.ComboBox();
            this.bdgSrapport = new System.Windows.Forms.BindingSource(this.components);
            this.btnRechercher = new System.Windows.Forms.Button();
            this.dtgRapport = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.motifDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVisiteurDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMedecinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblFiltrer = new System.Windows.Forms.Label();
            this.ckbFiltre = new System.Windows.Forms.CheckBox();
            this.cmbMedecin = new System.Windows.Forms.ComboBox();
            this.bdgSmedecin = new System.Windows.Forms.BindingSource(this.components);
            this.btnFiltrer = new System.Windows.Forms.Button();
            this.btnGenerer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSrapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSmedecin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(140, 117);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(71, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.Location = new System.Drawing.Point(642, 117);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(107, 30);
            this.lblVisiteur.TabIndex = 1;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // cmbVisiteur
            // 
            this.cmbVisiteur.DataSource = this.bdgSvisiteur;
            this.cmbVisiteur.DisplayMember = "nom";
            this.cmbVisiteur.FormattingEnabled = true;
            this.cmbVisiteur.Location = new System.Drawing.Point(807, 117);
            this.cmbVisiteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVisiteur.Name = "cmbVisiteur";
            this.cmbVisiteur.Size = new System.Drawing.Size(316, 28);
            this.cmbVisiteur.TabIndex = 2;
            // 
            // bdgSvisiteur
            // 
            this.bdgSvisiteur.DataSource = typeof(gsbRapports.visiteur);
            // 
            // cmbDate
            // 
            this.cmbDate.DataSource = this.bdgSrapport;
            this.cmbDate.DisplayMember = "date";
            this.cmbDate.FormattingEnabled = true;
            this.cmbDate.Location = new System.Drawing.Point(252, 117);
            this.cmbDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbDate.Name = "cmbDate";
            this.cmbDate.Size = new System.Drawing.Size(316, 28);
            this.cmbDate.TabIndex = 3;
            // 
            // bdgSrapport
            // 
            this.bdgSrapport.DataSource = typeof(gsbRapports.rapport);
            // 
            // btnRechercher
            // 
            this.btnRechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRechercher.Location = new System.Drawing.Point(396, 229);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(402, 46);
            this.btnRechercher.TabIndex = 4;
            this.btnRechercher.Text = "Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            this.btnRechercher.Click += new System.EventHandler(this.btnRechercher_Click);
            // 
            // dtgRapport
            // 
            this.dtgRapport.AllowUserToAddRows = false;
            this.dtgRapport.AllowUserToDeleteRows = false;
            this.dtgRapport.AutoGenerateColumns = false;
            this.dtgRapport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRapport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.motifDataGridViewTextBoxColumn,
            this.bilanDataGridViewTextBoxColumn,
            this.idVisiteurDataGridViewTextBoxColumn,
            this.idMedecinDataGridViewTextBoxColumn});
            this.dtgRapport.DataSource = this.bdgSrapport;
            this.dtgRapport.Location = new System.Drawing.Point(123, 448);
            this.dtgRapport.Name = "dtgRapport";
            this.dtgRapport.RowHeadersWidth = 62;
            this.dtgRapport.RowTemplate.Height = 28;
            this.dtgRapport.Size = new System.Drawing.Size(964, 271);
            this.dtgRapport.TabIndex = 5;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 150;
            // 
            // motifDataGridViewTextBoxColumn
            // 
            this.motifDataGridViewTextBoxColumn.DataPropertyName = "motif";
            this.motifDataGridViewTextBoxColumn.HeaderText = "motif";
            this.motifDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.motifDataGridViewTextBoxColumn.Name = "motifDataGridViewTextBoxColumn";
            this.motifDataGridViewTextBoxColumn.Width = 150;
            // 
            // bilanDataGridViewTextBoxColumn
            // 
            this.bilanDataGridViewTextBoxColumn.DataPropertyName = "bilan";
            this.bilanDataGridViewTextBoxColumn.HeaderText = "bilan";
            this.bilanDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.bilanDataGridViewTextBoxColumn.Name = "bilanDataGridViewTextBoxColumn";
            this.bilanDataGridViewTextBoxColumn.Width = 150;
            // 
            // idVisiteurDataGridViewTextBoxColumn
            // 
            this.idVisiteurDataGridViewTextBoxColumn.DataPropertyName = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.HeaderText = "idVisiteur";
            this.idVisiteurDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idVisiteurDataGridViewTextBoxColumn.Name = "idVisiteurDataGridViewTextBoxColumn";
            this.idVisiteurDataGridViewTextBoxColumn.Width = 150;
            // 
            // idMedecinDataGridViewTextBoxColumn
            // 
            this.idMedecinDataGridViewTextBoxColumn.DataPropertyName = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.HeaderText = "idMedecin";
            this.idMedecinDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMedecinDataGridViewTextBoxColumn.Name = "idMedecinDataGridViewTextBoxColumn";
            this.idMedecinDataGridViewTextBoxColumn.Width = 150;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(123, 785);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(402, 46);
            this.btnEnregistrer.TabIndex = 6;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblFiltrer
            // 
            this.lblFiltrer.AutoSize = true;
            this.lblFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltrer.Location = new System.Drawing.Point(140, 375);
            this.lblFiltrer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltrer.Name = "lblFiltrer";
            this.lblFiltrer.Size = new System.Drawing.Size(263, 30);
            this.lblFiltrer.TabIndex = 7;
            this.lblFiltrer.Text = "Filtrer par médecin :";
            // 
            // ckbFiltre
            // 
            this.ckbFiltre.AutoSize = true;
            this.ckbFiltre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFiltre.Location = new System.Drawing.Point(434, 382);
            this.ckbFiltre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ckbFiltre.Name = "ckbFiltre";
            this.ckbFiltre.Size = new System.Drawing.Size(72, 29);
            this.ckbFiltre.TabIndex = 8;
            this.ckbFiltre.Text = "Oui";
            this.ckbFiltre.UseVisualStyleBackColor = true;
            this.ckbFiltre.CheckedChanged += new System.EventHandler(this.ckbFiltre_CheckedChanged);
            // 
            // cmbMedecin
            // 
            this.cmbMedecin.Enabled = false;
            this.cmbMedecin.FormattingEnabled = true;
            this.cmbMedecin.Location = new System.Drawing.Point(609, 380);
            this.cmbMedecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMedecin.Name = "cmbMedecin";
            this.cmbMedecin.Size = new System.Drawing.Size(316, 28);
            this.cmbMedecin.TabIndex = 9;
            // 
            // bdgSmedecin
            // 
            this.bdgSmedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // btnFiltrer
            // 
            this.btnFiltrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrer.Location = new System.Drawing.Point(968, 377);
            this.btnFiltrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrer.Name = "btnFiltrer";
            this.btnFiltrer.Size = new System.Drawing.Size(120, 38);
            this.btnFiltrer.TabIndex = 10;
            this.btnFiltrer.Text = "Filtrer";
            this.btnFiltrer.UseVisualStyleBackColor = true;
            this.btnFiltrer.Click += new System.EventHandler(this.btnFiltrer_Click);
            // 
            // btnGenerer
            // 
            this.btnGenerer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerer.Location = new System.Drawing.Point(686, 785);
            this.btnGenerer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGenerer.Name = "btnGenerer";
            this.btnGenerer.Size = new System.Drawing.Size(402, 46);
            this.btnGenerer.TabIndex = 11;
            this.btnGenerer.Text = "Générer XML";
            this.btnGenerer.UseVisualStyleBackColor = true;
            this.btnGenerer.Click += new System.EventHandler(this.btnGenerer_Click);
            // 
            // FrmRechercheRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 875);
            this.Controls.Add(this.btnGenerer);
            this.Controls.Add(this.btnFiltrer);
            this.Controls.Add(this.cmbMedecin);
            this.Controls.Add(this.ckbFiltre);
            this.Controls.Add(this.lblFiltrer);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.dtgRapport);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.cmbDate);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Controls.Add(this.lblDate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmRechercheRapport";
            this.Text = "Recherche de rapport";
            ((System.ComponentModel.ISupportInitialize)(this.bdgSvisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSrapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgSmedecin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.ComboBox cmbDate;
        private System.Windows.Forms.BindingSource bdgSvisiteur;
        private System.Windows.Forms.BindingSource bdgSrapport;
        private System.Windows.Forms.Button btnRechercher;
        private System.Windows.Forms.DataGridView dtgRapport;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn motifDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bilanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVisiteurDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMedecinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblFiltrer;
        private System.Windows.Forms.CheckBox ckbFiltre;
        private System.Windows.Forms.ComboBox cmbMedecin;
        private System.Windows.Forms.BindingSource bdgSmedecin;
        private System.Windows.Forms.Button btnFiltrer;
        private System.Windows.Forms.Button btnGenerer;
    }
}