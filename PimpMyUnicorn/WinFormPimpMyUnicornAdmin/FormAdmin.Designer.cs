﻿namespace WinFormPimpMyUnicornAdmin
{
    partial class FormAdmin
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
            this.table_element = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).BeginInit();
            this.SuspendLayout();
            // 
            // table_element
            // 
            this.table_element.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_element.Location = new System.Drawing.Point(109, 153);
            this.table_element.Name = "table_element";
            this.table_element.Size = new System.Drawing.Size(969, 399);
            this.table_element.TabIndex = 0;
            // 
            // btn_create
            // 
            this.btn_create.Location = new System.Drawing.Point(499, 69);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(155, 48);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Créaction";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 573);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.table_element);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_element;
        private System.Windows.Forms.Button btn_create;
    }
}
