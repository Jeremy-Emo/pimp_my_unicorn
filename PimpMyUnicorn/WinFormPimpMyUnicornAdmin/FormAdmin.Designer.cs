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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_partie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_element
            // 
            this.table_element.AllowUserToAddRows = false;
            this.table_element.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.table_element.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_element.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_element.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_element.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_element.Location = new System.Drawing.Point(18, 130);
            this.table_element.Name = "table_element";
            this.table_element.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.table_element.Size = new System.Drawing.Size(619, 526);
            this.table_element.TabIndex = 0;
            this.table_element.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_element_CellContentClick);
            // 
            // btn_create
            // 
            this.btn_create.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_create.Location = new System.Drawing.Point(240, 38);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(155, 48);
            this.btn_create.TabIndex = 1;
            this.btn_create.Text = "Ajouter élément";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // btn_create_partie
            // 
            this.btn_create_partie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_create_partie.Location = new System.Drawing.Point(286, 38);
            this.btn_create_partie.Name = "btn_create_partie";
            this.btn_create_partie.Size = new System.Drawing.Size(151, 48);
            this.btn_create_partie.TabIndex = 2;
            this.btn_create_partie.Text = "Ajouter partie";
            this.btn_create_partie.UseVisualStyleBackColor = true;
            this.btn_create_partie.Click += new System.EventHandler(this.btn_create_partie_Click);
            // 
            // table_partie
            // 
            this.table_partie.AllowUserToAddRows = false;
            this.table_partie.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.table_partie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table_partie.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.table_partie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.table_partie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_partie.Location = new System.Drawing.Point(15, 130);
            this.table_partie.Name = "table_partie";
            this.table_partie.Size = new System.Drawing.Size(653, 526);
            this.table_partie.TabIndex = 3;
            this.table_partie.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_partie_CellContentClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btn_create);
            this.splitContainer1.Panel1.Controls.Add(this.table_element);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btn_create_partie);
            this.splitContainer1.Panel2.Controls.Add(this.table_partie);
            this.splitContainer1.Size = new System.Drawing.Size(1342, 721);
            this.splitContainer1.SplitterDistance = 653;
            this.splitContainer1.TabIndex = 4;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.table_element)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_partie)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table_element;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Button btn_create_partie;
        private System.Windows.Forms.DataGridView table_partie;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}

