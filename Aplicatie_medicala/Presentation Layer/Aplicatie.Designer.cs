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
            this.tbPacienti = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgPacienti = new System.Windows.Forms.DataGridView();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tbCauta = new System.Windows.Forms.TabPage();
            this.tbTratament = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tbPacienti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).BeginInit();
            this.tabControl2.SuspendLayout();
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
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(928, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tbPacienti
            // 
            this.tbPacienti.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbPacienti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbPacienti.Controls.Add(this.tabControl2);
            this.tbPacienti.Controls.Add(this.dgPacienti);
            this.tbPacienti.Location = new System.Drawing.Point(4, 22);
            this.tbPacienti.Name = "tbPacienti";
            this.tbPacienti.Padding = new System.Windows.Forms.Padding(3);
            this.tbPacienti.Size = new System.Drawing.Size(920, 400);
            this.tbPacienti.TabIndex = 0;
            this.tbPacienti.Text = "Pacienti";
            this.tbPacienti.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(920, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Personal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgPacienti
            // 
            this.dgPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPacienti.Location = new System.Drawing.Point(25, 15);
            this.dgPacienti.Name = "dgPacienti";
            this.dgPacienti.Size = new System.Drawing.Size(879, 195);
            this.dgPacienti.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tbCauta);
            this.tabControl2.Controls.Add(this.tbTratament);
            this.tabControl2.Location = new System.Drawing.Point(25, 227);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(879, 167);
            this.tabControl2.TabIndex = 1;
            // 
            // tbCauta
            // 
            this.tbCauta.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbCauta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbCauta.Location = new System.Drawing.Point(4, 22);
            this.tbCauta.Name = "tbCauta";
            this.tbCauta.Padding = new System.Windows.Forms.Padding(3);
            this.tbCauta.Size = new System.Drawing.Size(871, 141);
            this.tbCauta.TabIndex = 0;
            this.tbCauta.Text = "Cauta";
            this.tbCauta.UseVisualStyleBackColor = true;
            // 
            // tbTratament
            // 
            this.tbTratament.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.tbTratament.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tbTratament.Location = new System.Drawing.Point(4, 22);
            this.tbTratament.Name = "tbTratament";
            this.tbTratament.Padding = new System.Windows.Forms.Padding(3);
            this.tbTratament.Size = new System.Drawing.Size(871, 141);
            this.tbTratament.TabIndex = 1;
            this.tbTratament.Text = "Tratament";
            this.tbTratament.UseVisualStyleBackColor = true;
            // 
            // Aplicatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(952, 490);
            this.ControlBox = false;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Aplicatie";
            this.Text = "Aplicatie";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tbPacienti.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgPacienti)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbPacienti;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tbCauta;
        private System.Windows.Forms.TabPage tbTratament;
        private System.Windows.Forms.DataGridView dgPacienti;
    }
}