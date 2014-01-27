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
            this.btnAddMed = new System.Windows.Forms.Button();
            this.btnTermina = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.txbMedicament = new System.Windows.Forms.TextBox();
            this.txbDiagnostic = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgPacienti = new System.Windows.Forms.DataGridView();
            this.tbPersonal = new System.Windows.Forms.TabPage();
            this.lblOperatii = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCautaPers = new System.Windows.Forms.Button();
            this.txbUsername = new System.Windows.Forms.TextBox();
            this.cmbSectiePers = new System.Windows.Forms.ComboBox();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.txbPrenumePers = new System.Windows.Forms.TextBox();
            this.txbNumePers = new System.Windows.Forms.TextBox();
            this.dgPersonal = new System.Windows.Forms.DataGridView();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
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
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).BeginInit();
            this.tbPersonal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).BeginInit();
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
            this.dgDiagnostic.AllowUserToAddRows = false;
            this.dgDiagnostic.AllowUserToDeleteRows = false;
            this.dgDiagnostic.AllowUserToResizeRows = false;
            this.dgDiagnostic.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgDiagnostic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDiagnostic.Location = new System.Drawing.Point(491, 68);
            this.dgDiagnostic.MultiSelect = false;
            this.dgDiagnostic.Name = "dgDiagnostic";
            this.dgDiagnostic.ReadOnly = true;
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
            this.tabPage1.Controls.Add(this.btnAddMed);
            this.tabPage1.Controls.Add(this.btnTermina);
            this.tabPage1.Controls.Add(this.checkedListBox1);
            this.tabPage1.Controls.Add(this.txbMedicament);
            this.tabPage1.Controls.Add(this.txbDiagnostic);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(871, 198);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Diagnostic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddMed
            // 
            this.btnAddMed.Location = new System.Drawing.Point(700, 55);
            this.btnAddMed.Name = "btnAddMed";
            this.btnAddMed.Size = new System.Drawing.Size(90, 84);
            this.btnAddMed.TabIndex = 9;
            this.btnAddMed.Text = "Adauga medicament";
            this.btnAddMed.UseVisualStyleBackColor = true;
            // 
            // btnTermina
            // 
            this.btnTermina.Location = new System.Drawing.Point(513, 55);
            this.btnTermina.Name = "btnTermina";
            this.btnTermina.Size = new System.Drawing.Size(90, 84);
            this.btnTermina.TabIndex = 8;
            this.btnTermina.Text = "Termina";
            this.btnTermina.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(221, 87);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(166, 94);
            this.checkedListBox1.TabIndex = 7;
            // 
            // txbMedicament
            // 
            this.txbMedicament.Location = new System.Drawing.Point(138, 61);
            this.txbMedicament.Name = "txbMedicament";
            this.txbMedicament.Size = new System.Drawing.Size(249, 20);
            this.txbMedicament.TabIndex = 6;
            // 
            // txbDiagnostic
            // 
            this.txbDiagnostic.Location = new System.Drawing.Point(138, 21);
            this.txbDiagnostic.Name = "txbDiagnostic";
            this.txbDiagnostic.Size = new System.Drawing.Size(249, 20);
            this.txbDiagnostic.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(28, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Mod administrare";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(28, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Medicament";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(28, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Diagnostic";
            // 
            // dgPacienti
            // 
            this.dgPacienti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienti.Location = new System.Drawing.Point(25, 15);
            this.dgPacienti.Name = "dgPacienti";
            this.dgPacienti.Size = new System.Drawing.Size(406, 280);
            this.dgPacienti.TabIndex = 0;
            this.dgPacienti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacienti_CellContentDoubleClick);
            this.dgPacienti.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPacienti_CellMouseClick);
            // 
            // tbPersonal
            // 
            this.tbPersonal.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbPersonal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPersonal.Controls.Add(this.lblOperatii);
            this.tbPersonal.Controls.Add(this.dataGridView1);
            this.tbPersonal.Controls.Add(this.tabControl3);
            this.tbPersonal.Location = new System.Drawing.Point(4, 22);
            this.tbPersonal.Name = "tbPersonal";
            this.tbPersonal.Padding = new System.Windows.Forms.Padding(3);
            this.tbPersonal.Size = new System.Drawing.Size(920, 540);
            this.tbPersonal.TabIndex = 1;
            this.tbPersonal.Text = "Personal";
            this.tbPersonal.UseVisualStyleBackColor = true;
            // 
            // lblOperatii
            // 
            this.lblOperatii.AutoSize = true;
            this.lblOperatii.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOperatii.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblOperatii.Location = new System.Drawing.Point(495, 18);
            this.lblOperatii.Name = "lblOperatii";
            this.lblOperatii.Size = new System.Drawing.Size(355, 18);
            this.lblOperatii.TabIndex = 11;
            this.lblOperatii.Text = "Operatii asupra bazei de date efectuate de    : \r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(498, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(377, 195);
            this.dataGridView1.TabIndex = 10;
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage2);
            this.tabControl3.Location = new System.Drawing.Point(15, 18);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(399, 516);
            this.tabControl3.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.btnCautaPers);
            this.tabPage2.Controls.Add(this.txbUsername);
            this.tabPage2.Controls.Add(this.cmbSectiePers);
            this.tabPage2.Controls.Add(this.cmbFunctie);
            this.tabPage2.Controls.Add(this.txbPrenumePers);
            this.tabPage2.Controls.Add(this.txbNumePers);
            this.tabPage2.Controls.Add(this.dgPersonal);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(391, 490);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Cautare";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCautaPers
            // 
            this.btnCautaPers.Location = new System.Drawing.Point(140, 260);
            this.btnCautaPers.Name = "btnCautaPers";
            this.btnCautaPers.Size = new System.Drawing.Size(75, 23);
            this.btnCautaPers.TabIndex = 15;
            this.btnCautaPers.Text = "Cauta";
            this.btnCautaPers.UseVisualStyleBackColor = true;
            this.btnCautaPers.Click += new System.EventHandler(this.btnCautaPers_Click);
            // 
            // txbUsername
            // 
            this.txbUsername.Location = new System.Drawing.Point(126, 223);
            this.txbUsername.Name = "txbUsername";
            this.txbUsername.Size = new System.Drawing.Size(192, 20);
            this.txbUsername.TabIndex = 14;
            // 
            // cmbSectiePers
            // 
            this.cmbSectiePers.FormattingEnabled = true;
            this.cmbSectiePers.Location = new System.Drawing.Point(126, 171);
            this.cmbSectiePers.Name = "cmbSectiePers";
            this.cmbSectiePers.Size = new System.Drawing.Size(192, 21);
            this.cmbSectiePers.TabIndex = 13;
            // 
            // cmbFunctie
            // 
            this.cmbFunctie.FormattingEnabled = true;
            this.cmbFunctie.Location = new System.Drawing.Point(126, 119);
            this.cmbFunctie.Name = "cmbFunctie";
            this.cmbFunctie.Size = new System.Drawing.Size(192, 21);
            this.cmbFunctie.TabIndex = 12;
            // 
            // txbPrenumePers
            // 
            this.txbPrenumePers.Location = new System.Drawing.Point(126, 73);
            this.txbPrenumePers.Name = "txbPrenumePers";
            this.txbPrenumePers.Size = new System.Drawing.Size(192, 20);
            this.txbPrenumePers.TabIndex = 11;
            // 
            // txbNumePers
            // 
            this.txbNumePers.Location = new System.Drawing.Point(126, 34);
            this.txbNumePers.Name = "txbNumePers";
            this.txbNumePers.Size = new System.Drawing.Size(192, 20);
            this.txbNumePers.TabIndex = 10;
            // 
            // dgPersonal
            // 
            this.dgPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPersonal.Location = new System.Drawing.Point(9, 289);
            this.dgPersonal.Name = "dgPersonal";
            this.dgPersonal.Size = new System.Drawing.Size(355, 195);
            this.dgPersonal.TabIndex = 9;
            this.dgPersonal.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgPersonal_CellMouseClick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(6, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 18);
            this.label15.TabIndex = 8;
            this.label15.Text = "Username";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(6, 174);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 18);
            this.label14.TabIndex = 7;
            this.label14.Text = "Sectie";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(6, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 18);
            this.label13.TabIndex = 6;
            this.label13.Text = "Functie";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(6, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Prenume";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(6, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 18);
            this.label11.TabIndex = 4;
            this.label11.Text = "Nume";
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
            this.Load += new System.EventHandler(this.Aplicatie_Load);
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
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).EndInit();
            this.tbPersonal.ResumeLayout(false);
            this.tbPersonal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPersonal)).EndInit();
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
        private System.Windows.Forms.Button btnAddMed;
        private System.Windows.Forms.Button btnTermina;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TextBox txbMedicament;
        private System.Windows.Forms.TextBox txbDiagnostic;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCautaPers;
        private System.Windows.Forms.TextBox txbUsername;
        private System.Windows.Forms.ComboBox cmbSectiePers;
        private System.Windows.Forms.ComboBox cmbFunctie;
        private System.Windows.Forms.TextBox txbPrenumePers;
        private System.Windows.Forms.TextBox txbNumePers;
        private System.Windows.Forms.DataGridView dgPersonal;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblOperatii;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}