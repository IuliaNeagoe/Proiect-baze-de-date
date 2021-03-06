﻿using System;
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
    public partial class Login : Form
    {
        public BusinessLayer objbs = new BusinessLayer();
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ///DateTime dt = DateTime.Now;
            if (objbs.calllog(txbUsername.Text, txbPassword.Text) == true)
            {
                string nume =objbs.get_UserName(txbUsername.Text);
                Aplicatie f = new Aplicatie(nume,txbUsername.Text.TrimEnd());
                this.Close();
                f.Show();
            }
            else
                MessageBox.Show("Eroare de logare! Mai incercati!");
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
