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
    public partial class Parola : Form
    {
        public string MyReturnValue{ get; set; }

        public void SetMyString()
        {
            MyReturnValue = txbParola.Text.ToString();
        }

        public Parola()
        {
            InitializeComponent();
            MyReturnValue = null;
        }

        private void Parola_Load(object sender, EventArgs e)
        {

        }

        private void btnAddParola_Click(object sender, EventArgs e)
        {
            SetMyString();
            this.Close();
        }
    }
}
