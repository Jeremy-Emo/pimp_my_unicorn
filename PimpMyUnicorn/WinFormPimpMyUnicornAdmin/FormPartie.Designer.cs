namespace WinFormPimpMyUnicorn
{
    partial class FormPartie
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
            this.partie_nom = new System.Windows.Forms.TextBox();
            this.partie_ordre = new System.Windows.Forms.TextBox();
            this.btn_add_partie = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_partie_libelle = new System.Windows.Forms.Label();
            this.lbl_partie_ordre = new System.Windows.Forms.Label();
            this.id_partie = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // partie_nom
            // 
            this.partie_nom.Location = new System.Drawing.Point(62, 79);
            this.partie_nom.Name = "partie_nom";
            this.partie_nom.Size = new System.Drawing.Size(146, 20);
            this.partie_nom.TabIndex = 0;
            // 
            // partie_ordre
            // 
            this.partie_ordre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.partie_ordre.Location = new System.Drawing.Point(327, 79);
            this.partie_ordre.Name = "partie_ordre";
            this.partie_ordre.Size = new System.Drawing.Size(134, 20);
            this.partie_ordre.TabIndex = 1;
            this.partie_ordre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.partie_ordre_KeyPress);
            // 
            // btn_add_partie
            // 
            this.btn_add_partie.Location = new System.Drawing.Point(163, 135);
            this.btn_add_partie.Name = "btn_add_partie";
            this.btn_add_partie.Size = new System.Drawing.Size(96, 34);
            this.btn_add_partie.TabIndex = 2;
            this.btn_add_partie.Text = "Valider";
            this.btn_add_partie.UseVisualStyleBackColor = true;
            this.btn_add_partie.Click += new System.EventHandler(this.btn_add_partie_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_exit.Location = new System.Drawing.Point(289, 135);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(99, 34);
            this.btn_exit.TabIndex = 3;
            this.btn_exit.Text = "Retour";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_partie_libelle
            // 
            this.lbl_partie_libelle.AutoSize = true;
            this.lbl_partie_libelle.Location = new System.Drawing.Point(62, 60);
            this.lbl_partie_libelle.Name = "lbl_partie_libelle";
            this.lbl_partie_libelle.Size = new System.Drawing.Size(90, 13);
            this.lbl_partie_libelle.TabIndex = 4;
            this.lbl_partie_libelle.Text = "Nom de la partie :";
            // 
            // lbl_partie_ordre
            // 
            this.lbl_partie_ordre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_partie_ordre.AutoSize = true;
            this.lbl_partie_ordre.Location = new System.Drawing.Point(327, 59);
            this.lbl_partie_ordre.Name = "lbl_partie_ordre";
            this.lbl_partie_ordre.Size = new System.Drawing.Size(94, 13);
            this.lbl_partie_ordre.TabIndex = 5;
            this.lbl_partie_ordre.Text = "Ordre de la partie :";
            // 
            // id_partie
            // 
            this.id_partie.Location = new System.Drawing.Point(0, 165);
            this.id_partie.Name = "id_partie";
            this.id_partie.Size = new System.Drawing.Size(50, 20);
            this.id_partie.TabIndex = 6;
            this.id_partie.Visible = false;
            // 
            // FormPartie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 185);
            this.Controls.Add(this.id_partie);
            this.Controls.Add(this.lbl_partie_ordre);
            this.Controls.Add(this.lbl_partie_libelle);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_add_partie);
            this.Controls.Add(this.partie_ordre);
            this.Controls.Add(this.partie_nom);
            this.Name = "FormPartie";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox partie_nom;
        private System.Windows.Forms.TextBox partie_ordre;
        private System.Windows.Forms.Button btn_add_partie;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_partie_libelle;
        private System.Windows.Forms.Label lbl_partie_ordre;
        private System.Windows.Forms.TextBox id_partie;
    }
}