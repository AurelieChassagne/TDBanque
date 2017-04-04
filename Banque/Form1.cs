using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using libBanque;

namespace Banque
{
    public partial class FrmBanque : Form
    {
        private AgenceBancaire monAgence;
        public FrmBanque()
        {
            InitializeComponent();
        }

        private void FrmBanque_Load(object sender, EventArgs e)
        {
            initialiserbanque();
            remplirListeComptes();
        }
        #region Méthodes
        private void initialiserbanque()
        {
            // Création de l'objet Agence Bancaire
            monAgence = new AgenceBancaire("LYON 5ème");
            lblAgence.Text = "Agence de " + monAgence.NomAgence;

            // Création de comptes et ajout de ces comptes à l'agence bancaire
            CompteBancaire CB1 = new CompteBancaire("123456G", "Mr Fernand NAUDIN", 3500); 
            CompteBancaire CB2 = new CompteBancaire("546921K", "Mr Raoul VOLFONI");
            CompteBancaire CB3 = new CompteBancaire("963852R", "Mme DUCE", 4000);
            monAgence.ajouterCompte(CB1);
            monAgence.ajouterCompte(CB2);
            monAgence.ajouterCompte(CB3);

        }

        private void remplirListeComptes()
        {
            // La Source de données du DataGridView est une collection d'objets
            // Le DataGrid contient autant de lignes que la collection contient d'objets
            // Le DataGrid contient autant de colonnes que l'objet contient de property

            DgvListeComptes.DataSource = monAgence.LesComptes;

            // On redimensionne automatiquement la largeur des colonnes du DataGridView

            DgvListeComptes.AutoResizeColumns();
            
        }

        #endregion

        private void tabAccueil_Click(object sender, EventArgs e)
        {

        }

        private void tab_OngletsApplications_Enter(object sender, EventArgs e)
        {
            cbxDebitVirement.Items.Clear();
            cbxDebitVirement.ResetText();
            cbxCreditVirement.Items.Clear();
            cbxCreditVirement.ResetText();
            txbMontantVirement.Text = "";
            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                cbxDebitVirement.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
                cbxCreditVirement.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");

            }
        }

        private void tabConsultation_Enter(object sender, EventArgs e)
        {
            // On SUpprimer le contenu actuel éventuel de la combobox
            cbxCompte.Items.Clear();

            // ON remplit la combobox avec la structure itérative "foreach"
            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                cbxCompte.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        private void cbxCompte_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ON récupère l'index de la sélection dans la combobox
            int i = cbxCompte.SelectedIndex;
            CompteBancaire leCompte;

            leCompte = monAgence.LesComptes.ElementAt(i);
            txbNumCompte.Text = leCompte.NumCompte;
            txbTitulaire.Text = leCompte.NomTitulaire;
            txbSolde.Text = leCompte.SoldeCompte.ToString();
        }

        private void BtnCreerCompte_Click(object sender, EventArgs e)
        {
            CompteBancaire CB;
            CB = new CompteBancaire(txbCreaNumCompte.Text, txbCreaNomTitulaire.Text, Decimal.Parse(txbCreaSolde.Text));
            monAgence.LesComptes.Add(CB);
        }

        private void tabVersement_Enter(object sender, EventArgs e)
        {

            CbxChoixCompteVers.Items.Clear();
            CbxChoixCompteVers.ResetText();
            txbMontantACred.Text = "";
            lblMessageVers.Text = "";
            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                CbxChoixCompteVers.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        private void BtnAnnulerSaisie_Click(object sender, EventArgs e)
        {
            CbxChoixCompteVers.Items.Clear();
            txbMontantACred.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabRetrait_Click(object sender, EventArgs e)
        {

        }

        private void BtnEnregistrerRetrait_Click(object sender, EventArgs e)
        {
            int i = CbxCompteDebit.SelectedIndex;
            CompteBancaire CB;
            CB = monAgence.LesComptes.ElementAt(i);
            if(CB.DebiterCompte(Decimal.Parse(txbMontantDebit.Text)) == true){
                lblDebit.Text = "Le Compte a été débité avec succès";
                lblDebit.ForeColor = Color.Green;
            }
            else
            {
                lblDebit.Text = "Vous n'avez pas un solde suffisant sur votre compte";
                lblDebit.ForeColor = Color.Red;
            }

        }

        private void BtnAnnulerSaisieRetrait_Click(object sender, EventArgs e)
        {
            CbxCompteDebit.Items.Clear();
            txbMontantDebit.Text = "";
        }

        private void BtnEnregistrerVersement_Click(object sender, EventArgs e)
        {
            int i = CbxChoixCompteVers.SelectedIndex;
            CompteBancaire CB;
            CB = monAgence.LesComptes.ElementAt(i);
            CB.CrediterCompte(Decimal.Parse(txbMontantACred.Text));
            lblMessageVers.Text = "Le Compte a été crédité avec succès";
            lblMessageVers.ForeColor = Color.Green;
        }

        private void tabRetrait_Enter(object sender, EventArgs e)
        {
            CbxCompteDebit.Items.Clear();
            CbxCompteDebit.ResetText();
            txbMontantDebit.Text = "";
            lblMessageVers.Text = "";
            foreach (CompteBancaire unCompte in monAgence.LesComptes)
            {
                CbxCompteDebit.Items.Add(unCompte.NumCompte + " (" + unCompte.NomTitulaire + ")");
            }
        }

        private void cbxDebitVirement_SelectedIndexChanged(object sender, EventArgs e)
        {
            // ON récupère l'index de la sélection dans la combobox
            int i = cbxCompte.SelectedIndex;
            CompteBancaire leCompte;

            leCompte = monAgence.LesComptes.ElementAt(i);
            txbNumCompte.Text = leCompte.NumCompte;
            txbTitulaire.Text = leCompte.NomTitulaire;
            txbSolde.Text = leCompte.SoldeCompte.ToString();
        }

        private void cbxCreditVirement_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxCompteDebit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbxChoixCompteVers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void tabVersement_Click(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            cbxDebitVirement.Items.Clear();
            cbxCreditVirement.Items.Clear();
        }

        private void btnEnregistrer_Click(object sender, EventArgs e)
        {
            if (cbxDebitVirement.Text != "" && cbxCreditVirement.Text != "" && txbMontantVirement.Text != "")
            {
                lblMessageVirement.Text = "";
                int i = cbxDebitVirement.SelectedIndex;

                CompteBancaire CB;
                CB = monAgence.LesComptes.ElementAt(i);
                if (CB.DebiterCompte(Decimal.Parse(txbMontantVirement.Text)) == true)
                {

                    int j = cbxCreditVirement.SelectedIndex;
                    CompteBancaire CB22;
                    CB22 = monAgence.LesComptes.ElementAt(j);
                    CB22.CrediterCompte(Decimal.Parse(txbMontantVirement.Text));

                    lblMessageVirement.Text = "Le virement à bien été effectué";
                    lblMessageVirement.ForeColor = Color.Green;
                }
                else
                {
                    lblMessageVirement.Text = "Une erreur est survenue";
                    lblMessageVirement.ForeColor = Color.Red;
                }
            }
            else
            {
                lblMessageVirement.Text = "Une erreur est survenue";
                lblMessageVirement.ForeColor = Color.Red;
            }
        }
    }
}
