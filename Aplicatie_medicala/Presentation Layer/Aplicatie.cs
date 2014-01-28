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


    }
}
