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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.cmbData = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbCauta = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTratament = new System.Windows.Forms.TabPage();
            this.dgPacienti = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbDoctor = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblData = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbSectie = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.cmbData.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tbCauta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).BeginInit();
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
            this.tabControl1.Controls.Add(this.cmbData);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 566);
            this.tabControl1.TabIndex = 1;
            // 
            // cmbData
            // 
            this.cmbData.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.cmbData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cmbData.Controls.Add(this.tabControl2);
            this.cmbData.Controls.Add(this.dgPacienti);
            this.cmbData.Location = new System.Drawing.Point(4, 22);
            this.cmbData.Name = "cmbData";
            this.cmbData.Padding = new System.Windows.Forms.Padding(3);
            this.cmbData.Size = new System.Drawing.Size(920, 540);
            this.cmbData.TabIndex = 0;
            this.cmbData.Text = "Pacienti";
            this.cmbData.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbCauta);
            this.tabControl2.Controls.Add(this.tbTratament);
            this.tabControl2.Location = new System.Drawing.Point(25, 227);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(879, 298);
            this.tabControl2.TabIndex = 1;
            // 
            // tbCauta
            // 
            this.tbCauta.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbCauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCauta.Controls.Add(this.cmbSectie);
            this.tbCauta.Controls.Add(this.label4);
            this.tbCauta.Controls.Add(this.textBox1);
            this.tbCauta.Controls.Add(this.label3);
            this.tbCauta.Controls.Add(this.comboBox1);
            this.tbCauta.Controls.Add(this.lblData);
            this.tbCauta.Controls.Add(this.cmbDoctor);
            this.tbCauta.Controls.Add(this.label2);
            this.tbCauta.Controls.Add(this.label1);
            this.tbCauta.Location = new System.Drawing.Point(4, 22);
            this.tbCauta.Name = "tbCauta";
            this.tbCauta.Padding = new System.Windows.Forms.Padding(3);
            this.tbCauta.Size = new System.Drawing.Size(871, 272);
            this.tbCauta.TabIndex = 0;
            this.tbCauta.Text = "Cauta";
            this.tbCauta.UseVisualStyleBackColor = true;
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
            this.tbTratament.Location = new System.Drawing.Point(4, 22);
            this.tbTratament.Name = "tbTratament";
            this.tbTratament.Padding = new System.Windows.Forms.Padding(3);
            this.tbTratament.Size = new System.Drawing.Size(871, 272);
            this.tbTratament.TabIndex = 1;
            this.tbTratament.Text = "Tratament";
            this.tbTratament.UseVisualStyleBackColor = true;
            // 
            // dgPacienti
            // 
            this.dgPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienti.Location = new System.Drawing.Point(25, 15);
            this.dgPacienti.Name = "dgPacienti";
            this.dgPacienti.Size = new System.Drawing.Size(879, 195);
            this.dgPacienti.TabIndex = 0;
            this.dgPacienti.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgPacienti_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Doctor principal";
            // 
            // cmbDoctor
            // 
            this.cmbDoctor.FormattingEnabled = true;
            this.cmbDoctor.Location = new System.Drawing.Point(35, 124);
            this.cmbDoctor.Name = "cmbDoctor";
            this.cmbDoctor.Size = new System.Drawing.Size(121, 21);
            this.cmbDoctor.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblData.Location = new System.Drawing.Point(208, 86);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(141, 16);
            this.lblData.TabIndex = 3;
            this.lblData.Text = "Internat dupa data: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(459, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nume";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(422, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(679, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Sectie";
            // 
            // cmbSectie
            // 
            this.cmbSectie.FormattingEnabled = true;
            this.cmbSectie.Location = new System.Drawing.Point(643, 123);
            this.cmbSectie.Name = "cmbSectie";
            this.cmbSectie.Size = new System.Drawing.Size(121, 21);
            this.cmbSectie.TabIndex = 8;
            // 
            // Aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 625);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aplicatie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicatie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.cmbData.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tbCauta.ResumeLayout(false);
            this.tbCauta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage cmbData;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbCauta;
        private System.Windows.Forms.TabPage tbTratament;
        private System.Windows.Forms.DataGridView dgPacienti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.ComboBox cmbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSectie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
    }
}