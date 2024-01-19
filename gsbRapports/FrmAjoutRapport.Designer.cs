namespace gsbRapports
{
    partial class FrmAjoutRapport
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
            this.lblVisiteur = new System.Windows.Forms.Label();
            this.cmbVisiteur = new System.Windows.Forms.ComboBox();
            this.bdgVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.lblMedecin = new System.Windows.Forms.Label();
            this.cmbMedecin = new System.Windows.Forms.ComboBox();
            this.bdgMedecin = new System.Windows.Forms.BindingSource(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.dtRapport = new System.Windows.Forms.DateTimePicker();
            this.lblMotif = new System.Windows.Forms.Label();
            this.tbMotif = new System.Windows.Forms.TextBox();
            this.lblBilan = new System.Windows.Forms.Label();
            this.tbBilan = new System.Windows.Forms.TextBox();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMedicament = new System.Windows.Forms.Label();
            this.cmbFamille = new System.Windows.Forms.ComboBox();
            this.bdgFamille = new System.Windows.Forms.BindingSource(this.components);
            this.dtgMedicament = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomCommercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFamille = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bdgMedicament = new System.Windows.Forms.BindingSource(this.components);
            this.lblMed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVisiteur
            // 
            this.lblVisiteur.AutoSize = true;
            this.lblVisiteur.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisiteur.Location = new System.Drawing.Point(93, 78);
            this.lblVisiteur.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVisiteur.Name = "lblVisiteur";
            this.lblVisiteur.Size = new System.Drawing.Size(99, 30);
            this.lblVisiteur.TabIndex = 0;
            this.lblVisiteur.Text = "Visiteur";
            // 
            // cmbVisiteur
            // 
            this.cmbVisiteur.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgVisiteur, "nom", true));
            this.cmbVisiteur.DataSource = this.bdgVisiteur;
            this.cmbVisiteur.DisplayMember = "nom";
            this.cmbVisiteur.FormattingEnabled = true;
            this.cmbVisiteur.Location = new System.Drawing.Point(434, 78);
            this.cmbVisiteur.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbVisiteur.Name = "cmbVisiteur";
            this.cmbVisiteur.Size = new System.Drawing.Size(347, 28);
            this.cmbVisiteur.TabIndex = 1;
            // 
            // bdgVisiteur
            // 
            this.bdgVisiteur.DataSource = typeof(gsbRapports.visiteur);
            // 
            // lblMedecin
            // 
            this.lblMedecin.AutoSize = true;
            this.lblMedecin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedecin.Location = new System.Drawing.Point(93, 191);
            this.lblMedecin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedecin.Name = "lblMedecin";
            this.lblMedecin.Size = new System.Drawing.Size(110, 30);
            this.lblMedecin.TabIndex = 2;
            this.lblMedecin.Text = "Médecin";
            // 
            // cmbMedecin
            // 
            this.cmbMedecin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bdgMedecin, "nom", true));
            this.cmbMedecin.DataSource = this.bdgMedecin;
            this.cmbMedecin.DisplayMember = "nom";
            this.cmbMedecin.FormattingEnabled = true;
            this.cmbMedecin.Location = new System.Drawing.Point(434, 191);
            this.cmbMedecin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbMedecin.Name = "cmbMedecin";
            this.cmbMedecin.Size = new System.Drawing.Size(347, 28);
            this.cmbMedecin.TabIndex = 3;
            // 
            // bdgMedecin
            // 
            this.bdgMedecin.DataSource = typeof(gsbRapports.medecin);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(93, 383);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(67, 30);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "Date";
            // 
            // dtRapport
            // 
            this.dtRapport.Location = new System.Drawing.Point(434, 383);
            this.dtRapport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtRapport.Name = "dtRapport";
            this.dtRapport.Size = new System.Drawing.Size(347, 26);
            this.dtRapport.TabIndex = 5;
            // 
            // lblMotif
            // 
            this.lblMotif.AutoSize = true;
            this.lblMotif.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMotif.Location = new System.Drawing.Point(93, 482);
            this.lblMotif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMotif.Name = "lblMotif";
            this.lblMotif.Size = new System.Drawing.Size(69, 30);
            this.lblMotif.TabIndex = 6;
            this.lblMotif.Text = "Motif";
            // 
            // tbMotif
            // 
            this.tbMotif.Location = new System.Drawing.Point(434, 482);
            this.tbMotif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbMotif.Name = "tbMotif";
            this.tbMotif.Size = new System.Drawing.Size(347, 26);
            this.tbMotif.TabIndex = 7;
            // 
            // lblBilan
            // 
            this.lblBilan.AutoSize = true;
            this.lblBilan.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBilan.Location = new System.Drawing.Point(93, 600);
            this.lblBilan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBilan.Name = "lblBilan";
            this.lblBilan.Size = new System.Drawing.Size(70, 30);
            this.lblBilan.TabIndex = 8;
            this.lblBilan.Text = "Bilan";
            // 
            // tbBilan
            // 
            this.tbBilan.Location = new System.Drawing.Point(434, 600);
            this.tbBilan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBilan.Name = "tbBilan";
            this.tbBilan.Size = new System.Drawing.Size(347, 26);
            this.tbBilan.TabIndex = 9;
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(206, 762);
            this.btnEnregistrer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(496, 69);
            this.btnEnregistrer.TabIndex = 10;
            this.btnEnregistrer.Text = "Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblMedicament
            // 
            this.lblMedicament.AutoSize = true;
            this.lblMedicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMedicament.Location = new System.Drawing.Point(93, 289);
            this.lblMedicament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMedicament.Name = "lblMedicament";
            this.lblMedicament.Size = new System.Drawing.Size(292, 30);
            this.lblMedicament.TabIndex = 11;
            this.lblMedicament.Text = "Famille de médicaments";
            // 
            // cmbFamille
            // 
            this.cmbFamille.DataSource = this.bdgFamille;
            this.cmbFamille.DisplayMember = "libelle";
            this.cmbFamille.FormattingEnabled = true;
            this.cmbFamille.Location = new System.Drawing.Point(434, 289);
            this.cmbFamille.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbFamille.Name = "cmbFamille";
            this.cmbFamille.Size = new System.Drawing.Size(347, 28);
            this.cmbFamille.TabIndex = 12;
            // 
            // bdgFamille
            // 
            this.bdgFamille.DataSource = typeof(gsbRapports.famille);
            // 
            // dtgMedicament
            // 
            this.dtgMedicament.AllowUserToAddRows = false;
            this.dtgMedicament.AllowUserToDeleteRows = false;
            this.dtgMedicament.AutoGenerateColumns = false;
            this.dtgMedicament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicament.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomCommercialDataGridViewTextBoxColumn,
            this.idFamille});
            this.dtgMedicament.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.bdgFamille, "id", true));
            this.dtgMedicament.DataSource = this.bdgMedicament;
            this.dtgMedicament.Location = new System.Drawing.Point(867, 343);
            this.dtgMedicament.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgMedicament.MultiSelect = false;
            this.dtgMedicament.Name = "dtgMedicament";
            this.dtgMedicament.RowHeadersWidth = 62;
            this.dtgMedicament.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgMedicament.Size = new System.Drawing.Size(508, 231);
            this.dtgMedicament.TabIndex = 13;
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
            // nomCommercialDataGridViewTextBoxColumn
            // 
            this.nomCommercialDataGridViewTextBoxColumn.DataPropertyName = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.HeaderText = "nomCommercial";
            this.nomCommercialDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nomCommercialDataGridViewTextBoxColumn.Name = "nomCommercialDataGridViewTextBoxColumn";
            this.nomCommercialDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomCommercialDataGridViewTextBoxColumn.Width = 150;
            // 
            // idFamille
            // 
            this.idFamille.DataPropertyName = "idFamille";
            this.idFamille.HeaderText = "idFamille";
            this.idFamille.MinimumWidth = 8;
            this.idFamille.Name = "idFamille";
            this.idFamille.ReadOnly = true;
            this.idFamille.Width = 150;
            // 
            // bdgMedicament
            // 
            this.bdgMedicament.DataSource = typeof(gsbRapports.medicament);
            // 
            // lblMed
            // 
            this.lblMed.AutoSize = true;
            this.lblMed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMed.Location = new System.Drawing.Point(861, 289);
            this.lblMed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMed.Name = "lblMed";
            this.lblMed.Size = new System.Drawing.Size(153, 30);
            this.lblMed.TabIndex = 14;
            this.lblMed.Text = "Médicament";
            // 
            // FrmAjoutRapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1466, 897);
            this.Controls.Add(this.lblMed);
            this.Controls.Add(this.dtgMedicament);
            this.Controls.Add(this.cmbFamille);
            this.Controls.Add(this.lblMedicament);
            this.Controls.Add(this.btnEnregistrer);
            this.Controls.Add(this.tbBilan);
            this.Controls.Add(this.lblBilan);
            this.Controls.Add(this.tbMotif);
            this.Controls.Add(this.lblMotif);
            this.Controls.Add(this.dtRapport);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbMedecin);
            this.Controls.Add(this.lblMedecin);
            this.Controls.Add(this.cmbVisiteur);
            this.Controls.Add(this.lblVisiteur);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmAjoutRapport";
            this.Text = "Ajouter Rapport";
            ((System.ComponentModel.ISupportInitialize)(this.bdgVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedecin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgFamille)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicament)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdgMedicament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVisiteur;
        private System.Windows.Forms.ComboBox cmbVisiteur;
        private System.Windows.Forms.Label lblMedecin;
        private System.Windows.Forms.ComboBox cmbMedecin;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dtRapport;
        private System.Windows.Forms.Label lblMotif;
        private System.Windows.Forms.TextBox tbMotif;
        private System.Windows.Forms.Label lblBilan;
        private System.Windows.Forms.TextBox tbBilan;
        private System.Windows.Forms.BindingSource bdgVisiteur;
        private System.Windows.Forms.BindingSource bdgMedecin;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMedicament;
        private System.Windows.Forms.ComboBox cmbFamille;
        private System.Windows.Forms.BindingSource bdgFamille;
        private System.Windows.Forms.DataGridView dtgMedicament;
        private System.Windows.Forms.Label lblMed;
        private System.Windows.Forms.BindingSource bdgMedicament;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomCommercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFamille;
    }
}