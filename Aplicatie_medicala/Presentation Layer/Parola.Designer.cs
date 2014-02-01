namespace Aplicatie_medicala
{
    partial class Parola
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
            this.btnAddParola = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txbParola = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddParola
            // 
            this.btnAddParola.Location = new System.Drawing.Point(72, 102);
            this.btnAddParola.Name = "btnAddParola";
            this.btnAddParola.Size = new System.Drawing.Size(192, 23);
            this.btnAddParola.TabIndex = 0;
            this.btnAddParola.Text = "Salvare parola";
            this.btnAddParola.UseVisualStyleBackColor = true;
            this.btnAddParola.Click += new System.EventHandler(this.btnAddParola_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(31, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Parola";
            // 
            // txbParola
            // 
            this.txbParola.Location = new System.Drawing.Point(124, 53);
            this.txbParola.Name = "txbParola";
            this.txbParola.Size = new System.Drawing.Size(165, 20);
            this.txbParola.TabIndex = 6;
            this.txbParola.UseSystemPasswordChar = true;
            // 
            // Parola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Aplicatie_medicala.Properties.Resources.backgound;
            this.ClientSize = new System.Drawing.Size(378, 158);
            this.Controls.Add(this.txbParola);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnAddParola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Parola";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parola";
            this.Load += new System.EventHandler(this.Parola_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddParola;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txbParola;
    }
}