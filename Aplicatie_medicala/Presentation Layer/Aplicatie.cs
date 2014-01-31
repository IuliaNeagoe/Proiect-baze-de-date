using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicatie_medicala
{
    public partial class Aplicatie : Form
    {
        public BusinessLayer objbs = new BusinessLayer();
        public string cnp;
        public string cnp_pacient;
        public Aplicatie()
        {
           
        }
        public Aplicatie(string user, string cnp)
        {
            InitializeComponent();
            initComp();
            lblUser.Text = "Buna ziua, " + user;
            this.cnp = cnp;

            //initializare lista medici

            foreach (var medic in objbs.get_ListaMedici())
            {
                cmbDoctor.Items.Add(medic);
            }

            //initializare lista sectii

            foreach (var sectie in objbs.get_ListaSectii())
            {
                cmbSectie.Items.Add(sectie);
                cmbSectiePers.Items.Add(sectie);
            }

            //initializare lista date

            foreach (var data in objbs.get_ListaDataInternare())
            {
                cmbInternare.Items.Add(data);

            }

            //initializare moduri de adminstarare tratament
            foreach (var mod in objbs.get_ListaModAdministrare())
            {
                chbModAdmin.Items.Add(mod);
            }

            //initializare lista categorii
            foreach (var categorie in objbs.get_ListaCategorii())
            {
                cmbCategorie.Items.Add(categorie);
            }
            cmbCategorie.Text = "";
            cmbSectiePers.Text = "";
            //incarca lista cu pacientii de pe sectia user-ului in dgPacienti

            dgPacienti.DataSource = objbs.get_Pacienti(cnp);

            //incarca tabela Personal
            dgPersonal.DataSource = objbs.table_personal();
        }

        private void initComp()
        {
            //butonul de adaugare tratament/diagnostic e implicit invizibil, devine vizibil doar cand se logheaza un doctor
            btnAdd.Visible = true ;
            tbPersonal.IsAccessible = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgPacienti_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //afisam tabul cu tratament
            dgPacienti.Enabled = false;
            tabDetalii.SelectTab(tbTratament);
        }

        private void cmbDiagnostic_SelectedIndexChanged(object sender, EventArgs e)
        {
            //se alege diagnosticul pentru care sa fie afisate medicamentele si modul de administrare
        }

        private void lblIesi_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Close();
            f.Show();
        }

        private void btnSkip_Click(object sender, EventArgs e)
        {
            dgPacienti.Enabled = true;
        }

        private void dgPacienti_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgPacienti.RowCount - 1) /// verific sa nu fie click pe numele coloanei
            {
                if (e.Button == MouseButtons.Right)
                {
                    dgPacienti.Rows[e.RowIndex].Selected = true;
                    ctxmRefresh.Show(Cursor.Position);
                }
            }
        }

        private void dgPersonal_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //la click pe un rand se afiseaza pentru persoana respectiva in dgOperatii ce operatii a efectuat si e posibil revert-ul

        }

        private void btnCautaPers_Click(object sender, EventArgs e)
        {
            //se face cautarea 
            lblOperatii.Text = "Operatii asupra bazei de date efectuate de " + txbNumePers + ": ";
            //doar numele
            if (txbNumePers.Text != "" && txbPrenumePers.Text == "" && cmbCategorie.Text == "" && cmbSectiePers.Text == "" && txbUsername.Text == "")
            for (int i = 0; i < dgPersonal.Rows.Count - 1; i++)
            {
                dgPersonal.CurrentCell = null;
                var row = dgPersonal.Rows[i];
           
                if (row.Cells[2].Value.ToString() == txbNumePers.Text)
                    row.Visible = true;
                else
                row.Visible=false;
            }

            //doar prenumele
            if (txbNumePers.Text == "" && txbPrenumePers.Text != "" && cmbCategorie.Text == "" && cmbSectiePers.Text == "" && txbUsername.Text == "")
                for (int i = 0; i < dgPersonal.Rows.Count - 1; i++)
                {
                    dgPersonal.CurrentCell = null;
                    var row = dgPersonal.Rows[i];

                    if (row.Cells[3].Value.ToString() == txbPrenumePers.Text)
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            //doar categorie
            if (txbNumePers.Text == "" && txbPrenumePers.Text == "" && cmbCategorie.Text != "" && cmbSectiePers.Text == "" && txbUsername.Text == "")
                for (int i = 0; i < dgPersonal.Rows.Count - 1; i++)
                {
                    dgPersonal.CurrentCell = null;
                    var row = dgPersonal.Rows[i];

                    if (objbs.get_idcateg(cmbCategorie.Text)>0  && Convert.ToInt32(row.Cells[1].Value) == objbs.get_idcateg(cmbCategorie.Text))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

            //doar sectie
            if (txbNumePers.Text == "" && txbPrenumePers.Text == "" && cmbCategorie.Text == "" && cmbSectiePers.Text != "" && txbUsername.Text == "")
                for (int i = 0; i < dgPersonal.Rows.Count - 1; i++)
                {
                    dgPersonal.CurrentCell = null;
                    var row = dgPersonal.Rows[i];

                    if (objbs.get_idsectie(cmbSectiePers.Text) > 0 && Convert.ToInt32(row.Cells[6].Value) == objbs.get_idsectie(cmbSectiePers.Text))
                        row.Visible = true;
                    else
                        row.Visible = false;
                }
            //doar username
            if (txbNumePers.Text == "" && txbPrenumePers.Text == "" && cmbCategorie.Text == "" && cmbSectiePers.Text == "" && txbUsername.Text != "")
                for (int i = 0; i < dgPersonal.Rows.Count - 1; i++)
                {
                    dgPersonal.CurrentCell = null;
                    var row = dgPersonal.Rows[i];

                    if ( row.Cells[0].Value.ToString() == txbUsername.Text)
                        row.Visible = true;
                    else
                        row.Visible = false;
                }

        }

        private void Aplicatie_Load(object sender, EventArgs e)
        {

        }

        private void reimprospatareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //actualizare tabel pacienti
            dgPacienti.DataSource = objbs.get_Pacienti(cnp);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabDetalii.SelectTab(tbDiagnostic);
        }

        //activare la click a popularii tabelei diagnostic pentru pacientul selectat
        private void dgPacienti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1 && e.RowIndex != dgPacienti.RowCount - 1)
                dgDiagnostic.DataSource = objbs.get_detalii_pacient(dgPacienti.Rows[e.RowIndex].Cells[0].Value.ToString());
        }

        private void btnAddPersonal_Click(object sender, EventArgs e)
        {
            //apelarea functiei de adaugare Personal
           // if (objbs.insert_Personal(txbNumePers.Text,txbPrenumePers.Text,))...to be continued by Iulia :)
            DateTime now=DateTime.Now;
            DateTime later=DateTime.MaxValue;
            //try
            //{
            //    objbs.insert_Personal("1871225323741", "Medic", "Popescu", "David", "Bucuresti, nr.15", "0753432761", "Pediatrie", now, later, 4000, "david");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void btnAddPacient_Click(object sender, EventArgs e)
        {
            if (objbs.insert_Pacient(txbCNP_Pacient.Text, txbNume_Pacient.Text,
                txbPrenume_Pacient.Text, txbVarsta_Pacient.Text, txbAdresa_Pacient.Text,
                txbTelefon_Pacient.Text, txbEmail_Pacient.Text, chboxInternat.Checked, cnp))
            {
                cnp_pacient = txbCNP_Pacient.Text;
                MessageBox.Show("Pacientul a fost inserat in baza de date");
            }
            else
                MessageBox.Show("Pacientul nu a fost inserat in baza de date");

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAddMed_Click(object sender, EventArgs e)
        {
            //prima data adaugam diagnosticul daca acesta nu a fost adaugat--se face adaugarea la 
            //pacientul care are cnp-ul pastrat in cnp_pacient

           objbs.insert_Diagnostic_Tratament(txbDiagnostic.Text,txbMedicament.Text, cnp_pacient, chbxAdministrare.CheckedItems.ToString());
          //  objbs.insert_Diagnostic_Tratament("Raceala", "Ibuprofen", "1780925376859", "1/zi");
        }


    }
}
