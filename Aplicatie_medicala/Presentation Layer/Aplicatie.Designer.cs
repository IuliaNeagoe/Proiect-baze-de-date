namespace Aplicatie_medicala
{
    partial class Aplicatie
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbPacienti = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.dgDiagnostic = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbCauta = new System.Windows.Forms.TabPage();
            this.btnCauta = new System.Windows.Forms.Button();
            this.cmbSectie = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbInternare = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTratament = new System.Windows.Forms.TabPage();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSkip = new System.Windows.Forms.Button();
            this.btnSaveChn = new System.Windows.Forms.Button();
            this.cmbMedicamente = new System.Windows.Forms.ComboBox();
            this.chbxAdministrare = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbDiagnostic = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgPacienti = new System.Windows.Forms.DataGridView();
            this.tbPersonal = new System.Windows.Forms.TabPage();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblIesi = new System.Windows.Forms.Label();
            this.ctxmRefresh = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.reimprospatareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbPacienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnostic)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.tbCauta.SuspendLayout();
            this.tbTratament.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).BeginInit();
            this.ctxmRefresh.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.exit;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(910, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 29);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbPacienti);
            this.tabControl1.Controls.Add(this.tbPersonal);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPacienti
            // 
            this.tbPacienti.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbPacienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPacienti.Controls.Add(this.label7);
            this.tbPacienti.Controls.Add(this.dgDiagnostic);
            this.tbPacienti.Controls.Add(this.tabControl2);
            this.tbPacienti.Controls.Add(this.dgPacienti);
            this.tbPacienti.Location = new System.Drawing.Point(4, 22);
            this.tbPacienti.Name = "tbPacienti";
            this.tbPacienti.Padding = new System.Windows.Forms.Padding(3);
            this.tbPacienti.Size = new System.Drawing.Size(920, 540);
            this.tbPacienti.TabIndex = 0;
            this.tbPacienti.Text = "Pacienti";
            this.tbPacienti.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.label7.Location = new System.Drawing.Point(488, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 18);
            this.label7.TabIndex = 3;
            this.label7.Text = "Pacientul ... sufera de: ";
            // 
            // dgDiagnostic
            // 
            this.dgDiagnostic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiagnostic.Location = new System.Drawing.Point(491, 68);
            this.dgDiagnostic.Name = "dgDiagnostic";
            this.dgDiagnostic.Size = new System.Drawing.Size(406, 227);
            this.dgDiagnostic.TabIndex = 2;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbCauta);
            this.tabControl2.Controls.Add(this.tbTratament);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(25, 301);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(879, 224);
            this.tabControl2.TabIndex = 1;
            // 
            // tbCauta
            // 
            this.tbCauta.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbCauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCauta.Controls.Add(this.btnCauta);
            this.tbCauta.Controls.Add(this.cmbSectie);
            this.tbCauta.Controls.Add(this.label4);
            this.tbCauta.Controls.Add(this.txbNume);
            this.tbCauta.Controls.Add(this.label3);
            this.tbCauta.Controls.Add(this.cmbInternare);
            this.tbCauta.Controls.Add(this.lblData);
            this.tbCauta.Controls.Add(this.cmbDoctor);
            this.tbCauta.Controls.Add(this.label2);
            this.tbCauta.Controls.Add(this.label1);
            this.tbCauta.Location = new System.Drawing.Point(4, 22);
            this.tbCauta.Name = "tbCauta";
            this.tbCauta.Padding = new System.Windows.Forms.Padding(3);
            this.tbCauta.Size = new System.Drawing.Size(871, 198);
            this.tbCauta.TabIndex = 0;
            this.tbCauta.Text = "Cauta";
            this.tbCauta.UseVisualStyleBackColor = true;
            // 
            // btnCauta
            // 
            this.btnCauta.Location = new System.Drawing.Point(254, 148);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(318, 23);
            this.btnCauta.TabIndex = 9;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = true;
            // 
            // cmbSectie
            // 
            this.cmbSectie.FormattingEnabled = true;
            this.cmbSectie.Location = new System.Drawing.Point(649, 101);
            this.cmbSectie.Name = "cmbSectie";
            this.cmbSectie.Size = new System.Drawing.Size(121, 21);
            this.cmbSectie.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(685, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sectie";
            // 
            // txbNume
            // 
            this.txbNume.Location = new System.Drawing.Point(428, 102);
            this.txbNume.Name = "txbNume";
            this.txbNume.Size = new System.Drawing.Size(155, 20);
            this.txbNume.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(465, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume";
            // 
            // cmbInternare
            // 
            this.cmbInternare.FormattingEnabled = true;
            this.cmbInternare.Location = new System.Drawing.Point(241, 102);
            this.cmbInternare.Name = "cmbInternare";
            this.cmbInternare.Size = new System.Drawing.Size(121, 21);
            this.cmbInternare.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(221, 64);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 16);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Internat dupa data: ";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(41, 102);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoctor.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(44, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor principal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cautati pacientul: ";
            // 
            // tbTratament
            // 
            this.tbTratament.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbTratament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTratament.Controls.Add(this.btnAdd);
            this.tbTratament.Controls.Add(this.btnSkip);
            this.tbTratament.Controls.Add(this.btnSaveChn);
            this.tbTratament.Controls.Add(this.cmbMedicamente);
            this.tbTratament.Controls.Add(this.chbxAdministrare);
            this.tbTratament.Controls.Add(this.label6);
            this.tbTratament.Controls.Add(this.cmbDiagnostic);
            this.tbTratament.Controls.Add(this.label5);
            this.tbTratament.Location = new System.Drawing.Point(4, 22);
            this.tbTratament.Name = "tbTratament";
            this.tbTratament.Padding = new System.Windows.Forms.Padding(3);
            this.tbTratament.Size = new System.Drawing.Size(871, 198);
            this.tbTratament.TabIndex = 1;
            this.tbTratament.Text = "Tratament";
            this.tbTratament.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(688, 65);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 62);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            // 
            // btnSkip
            // 
            this.btnSkip.Location = new System.Drawing.Point(270, 127);
            this.btnSkip.Name = "btnSkip";
            this.btnSkip.Size = new System.Drawing.Size(75, 23);
            this.btnSkip.TabIndex = 8;
            this.btnSkip.Text = "Iesi";
            this.btnSkip.UseVisualStyleBackColor = true;
            this.btnSkip.Click += new System.EventHandler(this.btnSkip_Click);
            // 
            // btnSaveChn
            // 
            this.btnSaveChn.Location = new System.Drawing.Point(97, 127);
            this.btnSaveChn.Name = "btnSaveChn";
            this.btnSaveChn.Size = new System.Drawing.Size(75, 23);
            this.btnSaveChn.TabIndex = 7;
            this.btnSaveChn.Text = "Salveaza";
            this.btnSaveChn.UseVisualStyleBackColor = true;
            // 
            // cmbMedicamente
            // 
            this.cmbMedicamente.FormattingEnabled = true;
            this.cmbMedicamente.Location = new System.Drawing.Point(188, 65);
            this.cmbMedicamente.Name = "cmbMedicamente";
            this.cmbMedicamente.Size = new System.Drawing.Size(189, 21);
            this.cmbMedicamente.TabIndex = 6;
            // 
            // chbxAdministrare
            // 
            this.chbxAdministrare.FormattingEnabled = true;
            this.chbxAdministrare.Location = new System.Drawing.Point(429, 64);
            this.chbxAdministrare.Name = "chbxAdministrare";
            this.chbxAdministrare.Size = new System.Drawing.Size(120, 94);
            this.chbxAdministrare.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(20, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 18);
            this.label6.TabIndex = 4;
            this.label6.Text = "Se administreaza:";
            // 
            // cmbDiagnostic
            // 
            this.cmbDiagnostic.FormattingEnabled = true;
            this.cmbDiagnostic.Location = new System.Drawing.Point(188, 15);
            this.cmbDiagnostic.Name = "cmbDiagnostic";
            this.cmbDiagnostic.Size = new System.Drawing.Size(189, 21);
            this.cmbDiagnostic.TabIndex = 3;
            this.cmbDiagnostic.SelectedIndexChanged += new System.EventHandler(this.cmbDiagnostic_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(20, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Pentru diagnosticul: ";
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 198);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgPacienti
            // 
            this.dgPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienti.Location = new System.Drawing.Point(25, 15);
            this.dgPacienti.Name = "dgPacienti";
            this.dgPacienti.Size = new System.Drawing.Size(406, 280);
            this.dgPacienti.TabIndex = 0;
            this.dgPacienti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacienti_CellContentDoubleClick);
            // 
            // tbPersonal
            // 
            this.tbPersonal.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPersonal.Location = new System.Drawing.Point(4, 22);
            this.tbPersonal.Name = "tbPersonal";
            this.tbPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonal.Size = new System.Drawing.Size(920, 540);
            this.tbPersonal.TabIndex = 1;
            this.tbPersonal.Text = "Personal";
            this.tbPersonal.UseVisualStyleBackColor = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblUser.Location = new System.Drawing.Point(468, 23);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(129, 29);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "Buna ziua, \r\n";
            // 
            // lblIesi
            // 
            this.lblIesi.AutoSize = true;
            this.lblIesi.BackColor = System.Drawing.Color.Transparent;
            this.lblIesi.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIesi.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.lblIesi.Location = new System.Drawing.Point(802, 23);
            this.lblIesi.Name = "lblIesi";
            this.lblIesi.Size = new System.Drawing.Size(89, 25);
            this.lblIesi.TabIndex = 3;
            this.lblIesi.Text = "Delogare";
            this.lblIesi.Click += new System.EventHandler(this.lblIesi_Click);
            // 
            // ctxmRefresh
            // 
            this.ctxmRefresh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reimprospatareToolStripMenuItem});
            this.ctxmRefresh.Name = "ctxmRefresh";
            this.ctxmRefresh.Size = new System.Drawing.Size(158, 26);
            // 
            // reimprospatareToolStripMenuItem
            // 
            this.reimprospatareToolStripMenuItem.Name = "reimprospatareToolStripMenuItem";
            this.reimprospatareToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reimprospatareToolStripMenuItem.Text = "Reimprospatare";
            // 
            // Aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 625);
            this.ControlBox = false;
            this.Controls.Add(this.lblIesi);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aplicatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbPacienti.ResumeLayout(false);
            this.tbPacienti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDiagnostic)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.tbCauta.ResumeLayout(false);
            this.tbCauta.PerformLayout();
            this.tbTratament.ResumeLayout(false);
            this.tbTratament.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).EndInit();
            this.ctxmRefresh.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPacienti;
        private System.Windows.Forms.TabPage tbPersonal;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbCauta;
        private System.Windows.Forms.TabPage tbTratament;
        private System.Windows.Forms.DataGridView dgPacienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbInternare;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSectie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMedicamente;
        private System.Windows.Forms.CheckedListBox chbxAdministrare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbDiagnostic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSkip;
        private System.Windows.Forms.Button btnSaveChn;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblIesi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgDiagnostic;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ContextMenuStrip ctxmRefresh;
        private System.Windows.Forms.ToolStripMenuItem reimprospatareToolStripMenuItem;
    }
}