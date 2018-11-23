namespace WinFormPimpMyUnicornAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdmin));
            this.table_element = new System.Windows.Forms.DataGridView();
            this.btn_create = new System.Windows.Forms.Button();
            this.btn_create_partie = new System.Windows.Forms.Button();
            this.table_partie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_partie)).BeginInit();
            this.SuspendLayout();
            // 
            // table_element
            // 
            this.table_element.AllowUserToAddRows = false;
            this.table_element.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.table_element.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_element.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_element.Location = new System.Drawing.Point(0, 101);
            this.table_element.Name = "table_element";
            this.table_element.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_element.Size = new System.Drawing.Size(447, 490);
            this.table_element.TabIndex = 0;
            this.table_element.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_element_CellContentClick);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_create.Location = new System.Drawing.Point(171, 29);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(155, 48);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Ajouter élément";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_create_partie
            // 
            this.btn_create_partie.Location = new System.Drawing.Point(633, 29);
            this.btn_create_partie.Name = "btn_create_partie";
            this.btn_create_partie.Size = new System.Drawing.Size(151, 48);
            this.btn_create_partie.TabIndex = 2;
            this.btn_create_partie.Text = "Ajouter partie";
            this.btn_create_partie.UseVisualStyleBackColor = true;
            this.btn_create_partie.Click += new System.EventHandler(this.btn_create_partie_Click);
            // 
            // table_partie
            // 
            this.table_partie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_partie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_partie.Location = new System.Drawing.Point(545, 104);
            this.table_partie.Name = "table_partie";
            this.table_partie.Size = new System.Drawing.Size(400, 487);
            this.table_partie.TabIndex = 3;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 591);
            this.Controls.Add(this.table_partie);
            this.Controls.Add(this.btn_create_partie);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.table_element);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_partie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_element;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_create_partie;
        private System.Windows.Forms.DataGridView table_partie;
    }
}

