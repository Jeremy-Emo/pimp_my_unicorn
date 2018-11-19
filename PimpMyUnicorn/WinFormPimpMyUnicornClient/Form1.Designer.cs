namespace WinFormPimpMyUnicornClient
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCatégorie = new System.Windows.Forms.ComboBox();
            this.comboBoxElement = new System.Windows.Forms.ComboBox();
            this.buttonCréation = new System.Windows.Forms.Button();
            this.Titre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCatégorie
            // 
            this.comboBoxCatégorie.FormattingEnabled = true;
            this.comboBoxCatégorie.Location = new System.Drawing.Point(307, 144);
            this.comboBoxCatégorie.Name = "comboBoxCatégorie";
            this.comboBoxCatégorie.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCatégorie.TabIndex = 0;
            // 
            // comboBoxElement
            // 
            this.comboBoxElement.FormattingEnabled = true;
            this.comboBoxElement.Location = new System.Drawing.Point(657, 143);
            this.comboBoxElement.Name = "comboBoxElement";
            this.comboBoxElement.Size = new System.Drawing.Size(121, 21);
            this.comboBoxElement.TabIndex = 1;
            // 
            // buttonCréation
            // 
            this.buttonCréation.Location = new System.Drawing.Point(866, 140);
            this.buttonCréation.Name = "buttonCréation";
            this.buttonCréation.Size = new System.Drawing.Size(90, 24);
            this.buttonCréation.TabIndex = 4;
            this.buttonCréation.Text = "Création";
            this.buttonCréation.UseVisualStyleBackColor = true;
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titre.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Titre.Location = new System.Drawing.Point(467, 18);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(178, 25);
            this.Titre.TabIndex = 5;
            this.Titre.Text = "Pimp My Unicorn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 9F);
            this.label2.Location = new System.Drawing.Point(186, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Catégorie :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(554, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Élément :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WinFormPimpMyUnicornClient.Properties.Resources.Licorne;
            this.pictureBox1.Location = new System.Drawing.Point(116, 197);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(948, 457);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1116, 680);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.buttonCréation);
            this.Controls.Add(this.comboBoxElement);
            this.Controls.Add(this.comboBoxCatégorie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pimp My Unicorn";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCatégorie;
        private System.Windows.Forms.ComboBox comboBoxElement;
        private System.Windows.Forms.Button buttonCréation;
        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

