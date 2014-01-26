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
        public Aplicatie()
        {
           
        }
        public Aplicatie(string user)
        {
            InitializeComponent();
            initComp();
            lblUser.Text = "Buna ziua, " + user;
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


    }
}
