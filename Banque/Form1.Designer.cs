namespace Banque
{
    partial class FrmBanque
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab_OngletsApplications = new System.Windows.Forms.TabControl();
            this.tabAccueil = new System.Windows.Forms.TabPage();
            this.lblAgence = new System.Windows.Forms.Label();
            this.lblphraseagence = new System.Windows.Forms.Label();
            this.DgvListeComptes = new System.Windows.Forms.DataGridView();
            this.tabConsultation = new System.Windows.Forms.TabPage();
            this.txbSolde = new System.Windows.Forms.TextBox();
            this.txbTitulaire = new System.Windows.Forms.TextBox();
            this.txbNumCompte = new System.Windows.Forms.TextBox();
            this.cbxCompte = new System.Windows.Forms.ComboBox();
            this.lblSoldeCompte = new System.Windows.Forms.Label();
            this.lblTitulaire = new System.Windows.Forms.Label();
            this.lblnumcompte = new System.Windows.Forms.Label();
            this.lblchoisir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCreation = new System.Windows.Forms.TabPage();
            this.BtnCreerCompte = new System.Windows.Forms.Button();
            this.txbCreaSolde = new System.Windows.Forms.TextBox();
            this.txbCreaNomTitulaire = new System.Windows.Forms.TextBox();
            this.txbCreaNumCompte = new System.Windows.Forms.TextBox();
            this.lblCreaSolde = new System.Windows.Forms.Label();
            this.lblCreaNomTitu = new System.Windows.Forms.Label();
            this.lblCreaNumCompte = new System.Windows.Forms.Label();
            this.lblCreaCompte = new System.Windows.Forms.Label();
            this.tabVersement = new System.Windows.Forms.TabPage();
            this.lblMessageVers = new System.Windows.Forms.Label();
            this.CbxChoixCompteVers = new System.Windows.Forms.ComboBox();
            this.BtnAnnulerSaisie = new System.Windows.Forms.Button();
            this.BtnEnregistrerVersement = new System.Windows.Forms.Button();
            this.txbMontantACred = new System.Windows.Forms.TextBox();
            this.lblMontantACred = new System.Windows.Forms.Label();
            this.lblCompteACred = new System.Windows.Forms.Label();
            this.lblPhraseVersement = new System.Windows.Forms.Label();
            this.tabRetrait = new System.Windows.Forms.TabPage();
            this.lblDebit = new System.Windows.Forms.Label();
            this.txbMontantDebit = new System.Windows.Forms.TextBox();
            this.CbxCompteDebit = new System.Windows.Forms.ComboBox();
            this.BtnAnnulerSaisieRetrait = new System.Windows.Forms.Button();
            this.BtnEnregistrerRetrait = new System.Windows.Forms.Button();
            this.lblMontantDebit = new System.Windows.Forms.Label();
            this.lblCompteDebit = new System.Windows.Forms.Label();
            this.lblEnregistrement = new System.Windows.Forms.Label();
            this.TabVirement = new System.Windows.Forms.TabPage();
            this.lblMessageVirement = new System.Windows.Forms.Label();
            this.txbMontantVirement = new System.Windows.Forms.TextBox();
            this.cbxCreditVirement = new System.Windows.Forms.ComboBox();
            this.cbxDebitVirement = new System.Windows.Forms.ComboBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.lblMontantVirement = new System.Windows.Forms.Label();
            this.lblCreditVirement = new System.Windows.Forms.Label();
            this.lblDebitVirement = new System.Windows.Forms.Label();
            this.lblVirement = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tab_OngletsApplications.SuspendLayout();
            this.tabAccueil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeComptes)).BeginInit();
            this.tabConsultation.SuspendLayout();
            this.tabCreation.SuspendLayout();
            this.tabVersement.SuspendLayout();
            this.tabRetrait.SuspendLayout();
            this.TabVirement.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_OngletsApplications
            // 
            this.tab_OngletsApplications.Controls.Add(this.tabAccueil);
            this.tab_OngletsApplications.Controls.Add(this.tabConsultation);
            this.tab_OngletsApplications.Controls.Add(this.tabCreation);
            this.tab_OngletsApplications.Controls.Add(this.tabVersement);
            this.tab_OngletsApplications.Controls.Add(this.tabRetrait);
            this.tab_OngletsApplications.Controls.Add(this.TabVirement);
            this.tab_OngletsApplications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tab_OngletsApplications.Location = new System.Drawing.Point(0, 0);
            this.tab_OngletsApplications.Name = "tab_OngletsApplications";
            this.tab_OngletsApplications.SelectedIndex = 0;
            this.tab_OngletsApplications.Size = new System.Drawing.Size(956, 491);
            this.tab_OngletsApplications.TabIndex = 0;
            this.tab_OngletsApplications.Enter += new System.EventHandler(this.tab_OngletsApplications_Enter);
            // 
            // tabAccueil
            // 
            this.tabAccueil.Controls.Add(this.label2);
            this.tabAccueil.Controls.Add(this.lblAgence);
            this.tabAccueil.Controls.Add(this.lblphraseagence);
            this.tabAccueil.Controls.Add(this.DgvListeComptes);
            this.tabAccueil.Location = new System.Drawing.Point(4, 22);
            this.tabAccueil.Name = "tabAccueil";
            this.tabAccueil.Padding = new System.Windows.Forms.Padding(3);
            this.tabAccueil.Size = new System.Drawing.Size(948, 465);
            this.tabAccueil.TabIndex = 0;
            this.tabAccueil.Text = "Accueil";
            this.tabAccueil.UseVisualStyleBackColor = true;
            this.tabAccueil.Click += new System.EventHandler(this.tabAccueil_Click);
            // 
            // lblAgence
            // 
            this.lblAgence.AutoSize = true;
            this.lblAgence.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgence.Location = new System.Drawing.Point(415, 93);
            this.lblAgence.Name = "lblAgence";
            this.lblAgence.Size = new System.Drawing.Size(0, 24);
            this.lblAgence.TabIndex = 3;
            // 
            // lblphraseagence
            // 
            this.lblphraseagence.AutoSize = true;
            this.lblphraseagence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblphraseagence.Location = new System.Drawing.Point(329, 167);
            this.lblphraseagence.Name = "lblphraseagence";
            this.lblphraseagence.Size = new System.Drawing.Size(252, 20);
            this.lblphraseagence.TabIndex = 1;
            this.lblphraseagence.Text = "Liste des comptes de l\'agence";
            // 
            // DgvListeComptes
            // 
            this.DgvListeComptes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListeComptes.Location = new System.Drawing.Point(310, 223);
            this.DgvListeComptes.Name = "DgvListeComptes";
            this.DgvListeComptes.Size = new System.Drawing.Size(344, 187);
            this.DgvListeComptes.TabIndex = 0;
            // 
            // tabConsultation
            // 
            this.tabConsultation.Controls.Add(this.txbSolde);
            this.tabConsultation.Controls.Add(this.txbTitulaire);
            this.tabConsultation.Controls.Add(this.txbNumCompte);
            this.tabConsultation.Controls.Add(this.cbxCompte);
            this.tabConsultation.Controls.Add(this.lblSoldeCompte);
            this.tabConsultation.Controls.Add(this.lblTitulaire);
            this.tabConsultation.Controls.Add(this.lblnumcompte);
            this.tabConsultation.Controls.Add(this.lblchoisir);
            this.tabConsultation.Controls.Add(this.label1);
            this.tabConsultation.Location = new System.Drawing.Point(4, 22);
            this.tabConsultation.Name = "tabConsultation";
            this.tabConsultation.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsultation.Size = new System.Drawing.Size(948, 465);
            this.tabConsultation.TabIndex = 1;
            this.tabConsultation.Text = "Consultation";
            this.tabConsultation.UseVisualStyleBackColor = true;
            this.tabConsultation.Enter += new System.EventHandler(this.tabConsultation_Enter);
            // 
            // txbSolde
            // 
            this.txbSolde.Location = new System.Drawing.Point(479, 333);
            this.txbSolde.Name = "txbSolde";
            this.txbSolde.Size = new System.Drawing.Size(100, 20);
            this.txbSolde.TabIndex = 8;
            // 
            // txbTitulaire
            // 
            this.txbTitulaire.Location = new System.Drawing.Point(479, 290);
            this.txbTitulaire.Name = "txbTitulaire";
            this.txbTitulaire.Size = new System.Drawing.Size(100, 20);
            this.txbTitulaire.TabIndex = 7;
            // 
            // txbNumCompte
            // 
            this.txbNumCompte.Location = new System.Drawing.Point(479, 243);
            this.txbNumCompte.Name = "txbNumCompte";
            this.txbNumCompte.Size = new System.Drawing.Size(100, 20);
            this.txbNumCompte.TabIndex = 6;
            // 
            // cbxCompte
            // 
            this.cbxCompte.FormattingEnabled = true;
            this.cbxCompte.Location = new System.Drawing.Point(479, 151);
            this.cbxCompte.Name = "cbxCompte";
            this.cbxCompte.Size = new System.Drawing.Size(121, 21);
            this.cbxCompte.TabIndex = 5;
            this.cbxCompte.SelectedIndexChanged += new System.EventHandler(this.cbxCompte_SelectedIndexChanged);
            // 
            // lblSoldeCompte
            // 
            this.lblSoldeCompte.AutoSize = true;
            this.lblSoldeCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoldeCompte.Location = new System.Drawing.Point(258, 334);
            this.lblSoldeCompte.Name = "lblSoldeCompte";
            this.lblSoldeCompte.Size = new System.Drawing.Size(157, 20);
            this.lblSoldeCompte.TabIndex = 4;
            this.lblSoldeCompte.Text = "Solde du Compte :";
            // 
            // lblTitulaire
            // 
            this.lblTitulaire.AutoSize = true;
            this.lblTitulaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulaire.Location = new System.Drawing.Point(258, 291);
            this.lblTitulaire.Name = "lblTitulaire";
            this.lblTitulaire.Size = new System.Drawing.Size(83, 20);
            this.lblTitulaire.TabIndex = 3;
            this.lblTitulaire.Text = "Titulaire :";
            // 
            // lblnumcompte
            // 
            this.lblnumcompte.AutoSize = true;
            this.lblnumcompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumcompte.Location = new System.Drawing.Point(258, 244);
            this.lblnumcompte.Name = "lblnumcompte";
            this.lblnumcompte.Size = new System.Drawing.Size(124, 20);
            this.lblnumcompte.TabIndex = 2;
            this.lblnumcompte.Text = "N°de Compte :";
            // 
            // lblchoisir
            // 
            this.lblchoisir.AutoSize = true;
            this.lblchoisir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblchoisir.Location = new System.Drawing.Point(258, 152);
            this.lblchoisir.Name = "lblchoisir";
            this.lblchoisir.Size = new System.Drawing.Size(163, 20);
            this.lblchoisir.TabIndex = 1;
            this.lblchoisir.Text = "Choisir un compte :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation de Compte";
            // 
            // tabCreation
            // 
            this.tabCreation.Controls.Add(this.BtnCreerCompte);
            this.tabCreation.Controls.Add(this.txbCreaSolde);
            this.tabCreation.Controls.Add(this.txbCreaNomTitulaire);
            this.tabCreation.Controls.Add(this.txbCreaNumCompte);
            this.tabCreation.Controls.Add(this.lblCreaSolde);
            this.tabCreation.Controls.Add(this.lblCreaNomTitu);
            this.tabCreation.Controls.Add(this.lblCreaNumCompte);
            this.tabCreation.Controls.Add(this.lblCreaCompte);
            this.tabCreation.Location = new System.Drawing.Point(4, 22);
            this.tabCreation.Name = "tabCreation";
            this.tabCreation.Size = new System.Drawing.Size(948, 465);
            this.tabCreation.TabIndex = 2;
            this.tabCreation.Text = "Creation";
            this.tabCreation.UseVisualStyleBackColor = true;
            // 
            // BtnCreerCompte
            // 
            this.BtnCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreerCompte.Location = new System.Drawing.Point(308, 293);
            this.BtnCreerCompte.Name = "BtnCreerCompte";
            this.BtnCreerCompte.Size = new System.Drawing.Size(314, 48);
            this.BtnCreerCompte.TabIndex = 7;
            this.BtnCreerCompte.Text = "Créer le Compte";
            this.BtnCreerCompte.UseVisualStyleBackColor = true;
            this.BtnCreerCompte.Click += new System.EventHandler(this.BtnCreerCompte_Click);
            // 
            // txbCreaSolde
            // 
            this.txbCreaSolde.Location = new System.Drawing.Point(522, 230);
            this.txbCreaSolde.Name = "txbCreaSolde";
            this.txbCreaSolde.Size = new System.Drawing.Size(100, 20);
            this.txbCreaSolde.TabIndex = 6;
            // 
            // txbCreaNomTitulaire
            // 
            this.txbCreaNomTitulaire.Location = new System.Drawing.Point(522, 189);
            this.txbCreaNomTitulaire.Name = "txbCreaNomTitulaire";
            this.txbCreaNomTitulaire.Size = new System.Drawing.Size(100, 20);
            this.txbCreaNomTitulaire.TabIndex = 5;
            // 
            // txbCreaNumCompte
            // 
            this.txbCreaNumCompte.Location = new System.Drawing.Point(522, 147);
            this.txbCreaNumCompte.Name = "txbCreaNumCompte";
            this.txbCreaNumCompte.Size = new System.Drawing.Size(100, 20);
            this.txbCreaNumCompte.TabIndex = 4;
            // 
            // lblCreaSolde
            // 
            this.lblCreaSolde.AutoSize = true;
            this.lblCreaSolde.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaSolde.Location = new System.Drawing.Point(361, 228);
            this.lblCreaSolde.Name = "lblCreaSolde";
            this.lblCreaSolde.Size = new System.Drawing.Size(112, 20);
            this.lblCreaSolde.TabIndex = 3;
            this.lblCreaSolde.Text = "Solde initial :";
            // 
            // lblCreaNomTitu
            // 
            this.lblCreaNomTitu.AutoSize = true;
            this.lblCreaNomTitu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaNomTitu.Location = new System.Drawing.Point(324, 187);
            this.lblCreaNomTitu.Name = "lblCreaNomTitu";
            this.lblCreaNomTitu.Size = new System.Drawing.Size(149, 20);
            this.lblCreaNomTitu.TabIndex = 2;
            this.lblCreaNomTitu.Text = "Nom du Titulaire :";
            // 
            // lblCreaNumCompte
            // 
            this.lblCreaNumCompte.AutoSize = true;
            this.lblCreaNumCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaNumCompte.Location = new System.Drawing.Point(304, 148);
            this.lblCreaNumCompte.Name = "lblCreaNumCompte";
            this.lblCreaNumCompte.Size = new System.Drawing.Size(173, 20);
            this.lblCreaNumCompte.TabIndex = 1;
            this.lblCreaNumCompte.Text = "Numéro du Compte :";
            // 
            // lblCreaCompte
            // 
            this.lblCreaCompte.AutoSize = true;
            this.lblCreaCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreaCompte.Location = new System.Drawing.Point(324, 87);
            this.lblCreaCompte.Name = "lblCreaCompte";
            this.lblCreaCompte.Size = new System.Drawing.Size(242, 24);
            this.lblCreaCompte.TabIndex = 0;
            this.lblCreaCompte.Text = "CRÉATION DE COMPTE";
            // 
            // tabVersement
            // 
            this.tabVersement.Controls.Add(this.lblMessageVers);
            this.tabVersement.Controls.Add(this.CbxChoixCompteVers);
            this.tabVersement.Controls.Add(this.BtnAnnulerSaisie);
            this.tabVersement.Controls.Add(this.BtnEnregistrerVersement);
            this.tabVersement.Controls.Add(this.txbMontantACred);
            this.tabVersement.Controls.Add(this.lblMontantACred);
            this.tabVersement.Controls.Add(this.lblCompteACred);
            this.tabVersement.Controls.Add(this.lblPhraseVersement);
            this.tabVersement.Location = new System.Drawing.Point(4, 22);
            this.tabVersement.Name = "tabVersement";
            this.tabVersement.Size = new System.Drawing.Size(948, 465);
            this.tabVersement.TabIndex = 3;
            this.tabVersement.Text = "Versement";
            this.tabVersement.UseVisualStyleBackColor = true;
            this.tabVersement.Click += new System.EventHandler(this.tabVersement_Click);
            this.tabVersement.Enter += new System.EventHandler(this.tabVersement_Enter);
            // 
            // lblMessageVers
            // 
            this.lblMessageVers.AutoSize = true;
            this.lblMessageVers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageVers.Location = new System.Drawing.Point(246, 406);
            this.lblMessageVers.Name = "lblMessageVers";
            this.lblMessageVers.Size = new System.Drawing.Size(0, 16);
            this.lblMessageVers.TabIndex = 8;
            // 
            // CbxChoixCompteVers
            // 
            this.CbxChoixCompteVers.FormattingEnabled = true;
            this.CbxChoixCompteVers.Location = new System.Drawing.Point(471, 144);
            this.CbxChoixCompteVers.Name = "CbxChoixCompteVers";
            this.CbxChoixCompteVers.Size = new System.Drawing.Size(121, 21);
            this.CbxChoixCompteVers.TabIndex = 7;
            this.CbxChoixCompteVers.SelectedIndexChanged += new System.EventHandler(this.CbxChoixCompteVers_SelectedIndexChanged);
            // 
            // BtnAnnulerSaisie
            // 
            this.BtnAnnulerSaisie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerSaisie.Location = new System.Drawing.Point(471, 325);
            this.BtnAnnulerSaisie.Name = "BtnAnnulerSaisie";
            this.BtnAnnulerSaisie.Size = new System.Drawing.Size(161, 49);
            this.BtnAnnulerSaisie.TabIndex = 6;
            this.BtnAnnulerSaisie.Text = "Annuler la Saisie";
            this.BtnAnnulerSaisie.UseVisualStyleBackColor = true;
            this.BtnAnnulerSaisie.Click += new System.EventHandler(this.BtnAnnulerSaisie_Click);
            // 
            // BtnEnregistrerVersement
            // 
            this.BtnEnregistrerVersement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrerVersement.Location = new System.Drawing.Point(246, 325);
            this.BtnEnregistrerVersement.Name = "BtnEnregistrerVersement";
            this.BtnEnregistrerVersement.Size = new System.Drawing.Size(141, 49);
            this.BtnEnregistrerVersement.TabIndex = 5;
            this.BtnEnregistrerVersement.Text = "Enregistrer le Versement";
            this.BtnEnregistrerVersement.UseVisualStyleBackColor = true;
            this.BtnEnregistrerVersement.Click += new System.EventHandler(this.BtnEnregistrerVersement_Click);
            // 
            // txbMontantACred
            // 
            this.txbMontantACred.Location = new System.Drawing.Point(471, 193);
            this.txbMontantACred.Name = "txbMontantACred";
            this.txbMontantACred.Size = new System.Drawing.Size(183, 20);
            this.txbMontantACred.TabIndex = 4;
            // 
            // lblMontantACred
            // 
            this.lblMontantACred.AutoSize = true;
            this.lblMontantACred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantACred.Location = new System.Drawing.Point(293, 193);
            this.lblMontantACred.Name = "lblMontantACred";
            this.lblMontantACred.Size = new System.Drawing.Size(169, 20);
            this.lblMontantACred.TabIndex = 2;
            this.lblMontantACred.Text = "Montant à Créditer :";
            // 
            // lblCompteACred
            // 
            this.lblCompteACred.AutoSize = true;
            this.lblCompteACred.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteACred.Location = new System.Drawing.Point(293, 144);
            this.lblCompteACred.Name = "lblCompteACred";
            this.lblCompteACred.Size = new System.Drawing.Size(165, 20);
            this.lblCompteACred.TabIndex = 1;
            this.lblCompteACred.Text = "Compte à Créditer :";
            // 
            // lblPhraseVersement
            // 
            this.lblPhraseVersement.AutoSize = true;
            this.lblPhraseVersement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhraseVersement.Location = new System.Drawing.Point(289, 66);
            this.lblPhraseVersement.Name = "lblPhraseVersement";
            this.lblPhraseVersement.Size = new System.Drawing.Size(388, 24);
            this.lblPhraseVersement.TabIndex = 0;
            this.lblPhraseVersement.Text = "ENREGSITREMENT D\'UN VERSEMENT";
            // 
            // tabRetrait
            // 
            this.tabRetrait.Controls.Add(this.lblDebit);
            this.tabRetrait.Controls.Add(this.txbMontantDebit);
            this.tabRetrait.Controls.Add(this.CbxCompteDebit);
            this.tabRetrait.Controls.Add(this.BtnAnnulerSaisieRetrait);
            this.tabRetrait.Controls.Add(this.BtnEnregistrerRetrait);
            this.tabRetrait.Controls.Add(this.lblMontantDebit);
            this.tabRetrait.Controls.Add(this.lblCompteDebit);
            this.tabRetrait.Controls.Add(this.lblEnregistrement);
            this.tabRetrait.Location = new System.Drawing.Point(4, 22);
            this.tabRetrait.Name = "tabRetrait";
            this.tabRetrait.Size = new System.Drawing.Size(948, 465);
            this.tabRetrait.TabIndex = 4;
            this.tabRetrait.Text = "Retrait";
            this.tabRetrait.UseVisualStyleBackColor = true;
            this.tabRetrait.Click += new System.EventHandler(this.tabRetrait_Click);
            this.tabRetrait.Enter += new System.EventHandler(this.tabRetrait_Enter);
            // 
            // lblDebit
            // 
            this.lblDebit.AutoSize = true;
            this.lblDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebit.Location = new System.Drawing.Point(276, 402);
            this.lblDebit.Name = "lblDebit";
            this.lblDebit.Size = new System.Drawing.Size(0, 20);
            this.lblDebit.TabIndex = 7;
            // 
            // txbMontantDebit
            // 
            this.txbMontantDebit.Location = new System.Drawing.Point(385, 185);
            this.txbMontantDebit.Name = "txbMontantDebit";
            this.txbMontantDebit.Size = new System.Drawing.Size(100, 20);
            this.txbMontantDebit.TabIndex = 6;
            // 
            // CbxCompteDebit
            // 
            this.CbxCompteDebit.FormattingEnabled = true;
            this.CbxCompteDebit.Location = new System.Drawing.Point(385, 129);
            this.CbxCompteDebit.Name = "CbxCompteDebit";
            this.CbxCompteDebit.Size = new System.Drawing.Size(121, 21);
            this.CbxCompteDebit.TabIndex = 5;
            this.CbxCompteDebit.SelectedIndexChanged += new System.EventHandler(this.CbxCompteDebit_SelectedIndexChanged);
            // 
            // BtnAnnulerSaisieRetrait
            // 
            this.BtnAnnulerSaisieRetrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnnulerSaisieRetrait.Location = new System.Drawing.Point(463, 301);
            this.BtnAnnulerSaisieRetrait.Name = "BtnAnnulerSaisieRetrait";
            this.BtnAnnulerSaisieRetrait.Size = new System.Drawing.Size(162, 51);
            this.BtnAnnulerSaisieRetrait.TabIndex = 4;
            this.BtnAnnulerSaisieRetrait.Text = "Annuler la Saisie";
            this.BtnAnnulerSaisieRetrait.UseVisualStyleBackColor = true;
            this.BtnAnnulerSaisieRetrait.Click += new System.EventHandler(this.BtnAnnulerSaisieRetrait_Click);
            // 
            // BtnEnregistrerRetrait
            // 
            this.BtnEnregistrerRetrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEnregistrerRetrait.Location = new System.Drawing.Point(276, 301);
            this.BtnEnregistrerRetrait.Name = "BtnEnregistrerRetrait";
            this.BtnEnregistrerRetrait.Size = new System.Drawing.Size(143, 51);
            this.BtnEnregistrerRetrait.TabIndex = 3;
            this.BtnEnregistrerRetrait.Text = "Enregistrer le retrait";
            this.BtnEnregistrerRetrait.UseVisualStyleBackColor = true;
            this.BtnEnregistrerRetrait.Click += new System.EventHandler(this.BtnEnregistrerRetrait_Click);
            // 
            // lblMontantDebit
            // 
            this.lblMontantDebit.AutoSize = true;
            this.lblMontantDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantDebit.Location = new System.Drawing.Point(218, 185);
            this.lblMontantDebit.Name = "lblMontantDebit";
            this.lblMontantDebit.Size = new System.Drawing.Size(161, 20);
            this.lblMontantDebit.TabIndex = 2;
            this.lblMontantDebit.Text = "Montant à débiter :";
            this.lblMontantDebit.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCompteDebit
            // 
            this.lblCompteDebit.AutoSize = true;
            this.lblCompteDebit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompteDebit.Location = new System.Drawing.Point(217, 127);
            this.lblCompteDebit.Name = "lblCompteDebit";
            this.lblCompteDebit.Size = new System.Drawing.Size(157, 20);
            this.lblCompteDebit.TabIndex = 1;
            this.lblCompteDebit.Text = "Compte à débiter :";
            // 
            // lblEnregistrement
            // 
            this.lblEnregistrement.AutoSize = true;
            this.lblEnregistrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnregistrement.Location = new System.Drawing.Point(258, 63);
            this.lblEnregistrement.Name = "lblEnregistrement";
            this.lblEnregistrement.Size = new System.Drawing.Size(347, 24);
            this.lblEnregistrement.TabIndex = 0;
            this.lblEnregistrement.Text = "ENREGISTREMENT D\'UN RETRAIT";
            // 
            // TabVirement
            // 
            this.TabVirement.Controls.Add(this.lblMessageVirement);
            this.TabVirement.Controls.Add(this.txbMontantVirement);
            this.TabVirement.Controls.Add(this.cbxCreditVirement);
            this.TabVirement.Controls.Add(this.cbxDebitVirement);
            this.TabVirement.Controls.Add(this.btnAnnuler);
            this.TabVirement.Controls.Add(this.btnEnregistrer);
            this.TabVirement.Controls.Add(this.lblMontantVirement);
            this.TabVirement.Controls.Add(this.lblCreditVirement);
            this.TabVirement.Controls.Add(this.lblDebitVirement);
            this.TabVirement.Controls.Add(this.lblVirement);
            this.TabVirement.Location = new System.Drawing.Point(4, 22);
            this.TabVirement.Name = "TabVirement";
            this.TabVirement.Size = new System.Drawing.Size(948, 465);
            this.TabVirement.TabIndex = 5;
            this.TabVirement.Text = "Virement";
            this.TabVirement.UseVisualStyleBackColor = true;
            // 
            // lblMessageVirement
            // 
            this.lblMessageVirement.AutoSize = true;
            this.lblMessageVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessageVirement.Location = new System.Drawing.Point(196, 272);
            this.lblMessageVirement.Name = "lblMessageVirement";
            this.lblMessageVirement.Size = new System.Drawing.Size(0, 20);
            this.lblMessageVirement.TabIndex = 9;
            // 
            // txbMontantVirement
            // 
            this.txbMontantVirement.Location = new System.Drawing.Point(375, 225);
            this.txbMontantVirement.Name = "txbMontantVirement";
            this.txbMontantVirement.Size = new System.Drawing.Size(121, 20);
            this.txbMontantVirement.TabIndex = 8;
            // 
            // cbxCreditVirement
            // 
            this.cbxCreditVirement.FormattingEnabled = true;
            this.cbxCreditVirement.Location = new System.Drawing.Point(375, 169);
            this.cbxCreditVirement.Name = "cbxCreditVirement";
            this.cbxCreditVirement.Size = new System.Drawing.Size(121, 21);
            this.cbxCreditVirement.TabIndex = 7;
            this.cbxCreditVirement.SelectedIndexChanged += new System.EventHandler(this.cbxCreditVirement_SelectedIndexChanged);
            // 
            // cbxDebitVirement
            // 
            this.cbxDebitVirement.FormattingEnabled = true;
            this.cbxDebitVirement.Location = new System.Drawing.Point(375, 116);
            this.cbxDebitVirement.Name = "cbxDebitVirement";
            this.cbxDebitVirement.Size = new System.Drawing.Size(121, 21);
            this.cbxDebitVirement.TabIndex = 6;
            this.cbxDebitVirement.SelectedIndexChanged += new System.EventHandler(this.cbxDebitVirement_SelectedIndexChanged);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnnuler.Location = new System.Drawing.Point(412, 313);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(178, 53);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler la saisie";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnregistrer.Location = new System.Drawing.Point(177, 313);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(178, 53);
            this.btnEnregistrer.TabIndex = 4;
            this.btnEnregistrer.Text = "Enregistrer le virement";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            this.btnEnregistrer.Click += new System.EventHandler(this.btnEnregistrer_Click);
            // 
            // lblMontantVirement
            // 
            this.lblMontantVirement.AutoSize = true;
            this.lblMontantVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontantVirement.Location = new System.Drawing.Point(175, 223);
            this.lblMontantVirement.Name = "lblMontantVirement";
            this.lblMontantVirement.Size = new System.Drawing.Size(139, 20);
            this.lblMontantVirement.TabIndex = 3;
            this.lblMontantVirement.Text = "Montant à virer :";
            // 
            // lblCreditVirement
            // 
            this.lblCreditVirement.AutoSize = true;
            this.lblCreditVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreditVirement.Location = new System.Drawing.Point(173, 167);
            this.lblCreditVirement.Name = "lblCreditVirement";
            this.lblCreditVirement.Size = new System.Drawing.Size(165, 20);
            this.lblCreditVirement.TabIndex = 2;
            this.lblCreditVirement.Text = "Compte à Créditer :";
            // 
            // lblDebitVirement
            // 
            this.lblDebitVirement.AutoSize = true;
            this.lblDebitVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebitVirement.Location = new System.Drawing.Point(173, 117);
            this.lblDebitVirement.Name = "lblDebitVirement";
            this.lblDebitVirement.Size = new System.Drawing.Size(162, 20);
            this.lblDebitVirement.TabIndex = 1;
            this.lblDebitVirement.Text = "Compte à débiter : ";
            // 
            // lblVirement
            // 
            this.lblVirement.AutoSize = true;
            this.lblVirement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVirement.Location = new System.Drawing.Point(274, 41);
            this.lblVirement.Name = "lblVirement";
            this.lblVirement.Size = new System.Drawing.Size(316, 20);
            this.lblVirement.TabIndex = 0;
            this.lblVirement.Text = "ENREGISTREMENT D\'UN VIREMENT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(478, 108);
            this.label2.TabIndex = 4;
            this.label2.Text = "TEST GIT";
            // 
            // FrmBanque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 491);
            this.Controls.Add(this.tab_OngletsApplications);
            this.Name = "FrmBanque";
            this.Text = "Formulaire Banque";
            this.Load += new System.EventHandler(this.FrmBanque_Load);
            this.tab_OngletsApplications.ResumeLayout(false);
            this.tabAccueil.ResumeLayout(false);
            this.tabAccueil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListeComptes)).EndInit();
            this.tabConsultation.ResumeLayout(false);
            this.tabConsultation.PerformLayout();
            this.tabCreation.ResumeLayout(false);
            this.tabCreation.PerformLayout();
            this.tabVersement.ResumeLayout(false);
            this.tabVersement.PerformLayout();
            this.tabRetrait.ResumeLayout(false);
            this.tabRetrait.PerformLayout();
            this.TabVirement.ResumeLayout(false);
            this.TabVirement.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_OngletsApplications;
        private System.Windows.Forms.TabPage tabAccueil;
        private System.Windows.Forms.TabPage tabConsultation;
        private System.Windows.Forms.TabPage tabCreation;
        private System.Windows.Forms.TabPage tabVersement;
        private System.Windows.Forms.TabPage tabRetrait;
        private System.Windows.Forms.TabPage TabVirement;
        private System.Windows.Forms.DataGridView DgvListeComptes;
        private System.Windows.Forms.Label lblphraseagence;
        private System.Windows.Forms.Label lblAgence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSoldeCompte;
        private System.Windows.Forms.Label lblTitulaire;
        private System.Windows.Forms.Label lblnumcompte;
        private System.Windows.Forms.Label lblchoisir;
        private System.Windows.Forms.TextBox txbSolde;
        private System.Windows.Forms.TextBox txbTitulaire;
        private System.Windows.Forms.TextBox txbNumCompte;
        private System.Windows.Forms.ComboBox cbxCompte;
        private System.Windows.Forms.Label lblCreaSolde;
        private System.Windows.Forms.Label lblCreaNomTitu;
        private System.Windows.Forms.Label lblCreaNumCompte;
        private System.Windows.Forms.Label lblCreaCompte;
        private System.Windows.Forms.TextBox txbCreaSolde;
        private System.Windows.Forms.TextBox txbCreaNomTitulaire;
        private System.Windows.Forms.TextBox txbCreaNumCompte;
        private System.Windows.Forms.Button BtnCreerCompte;
        private System.Windows.Forms.Label lblPhraseVersement;
        private System.Windows.Forms.Button BtnAnnulerSaisie;
        private System.Windows.Forms.Button BtnEnregistrerVersement;
        private System.Windows.Forms.TextBox txbMontantACred;
        private System.Windows.Forms.Label lblMontantACred;
        private System.Windows.Forms.Label lblCompteACred;
        private System.Windows.Forms.ComboBox CbxChoixCompteVers;
        private System.Windows.Forms.Label lblMessageVers;
        private System.Windows.Forms.Label lblEnregistrement;
        private System.Windows.Forms.TextBox txbMontantDebit;
        private System.Windows.Forms.ComboBox CbxCompteDebit;
        private System.Windows.Forms.Button BtnAnnulerSaisieRetrait;
        private System.Windows.Forms.Button BtnEnregistrerRetrait;
        private System.Windows.Forms.Label lblMontantDebit;
        private System.Windows.Forms.Label lblCompteDebit;
        private System.Windows.Forms.Label lblDebit;
        private System.Windows.Forms.ComboBox cbxCreditVirement;
        private System.Windows.Forms.ComboBox cbxDebitVirement;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnEnregistrer;
        private System.Windows.Forms.Label lblMontantVirement;
        private System.Windows.Forms.Label lblCreditVirement;
        private System.Windows.Forms.Label lblDebitVirement;
        private System.Windows.Forms.Label lblVirement;
        private System.Windows.Forms.TextBox txbMontantVirement;
        private System.Windows.Forms.Label lblMessageVirement;
        private System.Windows.Forms.Label label2;
    }
}

