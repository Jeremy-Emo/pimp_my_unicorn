namespace WinFormPimpMyUnicornClient
{
    partial class InterfaceClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceClient));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.pictureBoxRight = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeft = new System.Windows.Forms.PictureBox();
            this.labelTitre = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.shuffleButton = new System.Windows.Forms.Button();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.saveUnicorn = new System.Windows.Forms.Button();
            this.pictureBoxMain = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.Violet;
            this.panelHeader.Controls.Add(this.pictureBoxRight);
            this.panelHeader.Controls.Add(this.pictureBoxLeft);
            this.panelHeader.Controls.Add(this.labelTitre);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRight.Image")));
            this.pictureBoxRight.Location = new System.Drawing.Point(1204, 6);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(48, 50);
            this.pictureBoxRight.TabIndex = 27;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.Image")));
            this.pictureBoxLeft.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(48, 50);
            this.pictureBoxLeft.TabIndex = 26;
            this.pictureBoxLeft.TabStop = false;
            // 
            // labelTitre
            // 
            this.labelTitre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitre.AutoSize = true;
            this.labelTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitre.ForeColor = System.Drawing.Color.Fuchsia;
            this.labelTitre.Location = new System.Drawing.Point(563, 19);
            this.labelTitre.Name = "labelTitre";
            this.labelTitre.Size = new System.Drawing.Size(175, 25);
            this.labelTitre.TabIndex = 0;
            this.labelTitre.Text = "Pimp My Unicorn";
            // 
            // panelRight
            // 
            this.panelRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelRight.BackColor = System.Drawing.Color.HotPink;
            this.panelRight.Controls.Add(this.buttonReset);
            this.panelRight.Controls.Add(this.shuffleButton);
            this.panelRight.Location = new System.Drawing.Point(1025, 65);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(239, 624);
            this.panelRight.TabIndex = 0;
            // 
            // shuffleButton
            // 
            this.shuffleButton.BackColor = System.Drawing.Color.White;
            this.shuffleButton.Location = new System.Drawing.Point(4, 30);
            this.shuffleButton.Name = "shuffleButton";
            this.shuffleButton.Size = new System.Drawing.Size(230, 23);
            this.shuffleButton.TabIndex = 0;
            this.shuffleButton.Text = "Aléatoire";
            this.shuffleButton.UseVisualStyleBackColor = false;
            this.shuffleButton.Click += new System.EventHandler(this.shuffleButton_Click);
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BackColor = System.Drawing.Color.Violet;
            this.panelFooter.Location = new System.Drawing.Point(0, 689);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1264, 56);
            this.panelFooter.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLeft.BackColor = System.Drawing.Color.HotPink;
            this.panelLeft.Controls.Add(this.saveUnicorn);
            this.panelLeft.Location = new System.Drawing.Point(0, 65);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(250, 624);
            this.panelLeft.TabIndex = 2;
            // 
            // saveUnicorn
            // 
            this.saveUnicorn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveUnicorn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveUnicorn.Location = new System.Drawing.Point(15, 30);
            this.saveUnicorn.Name = "saveUnicorn";
            this.saveUnicorn.Size = new System.Drawing.Size(219, 23);
            this.saveUnicorn.TabIndex = 0;
            this.saveUnicorn.Text = "Enregistrer ma Licorne";
            this.saveUnicorn.UseVisualStyleBackColor = false;
            this.saveUnicorn.Click += new System.EventHandler(this.saveUnicorn_Click);
            // 
            // pictureBoxMain
            // 
            this.pictureBoxMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxMain.Location = new System.Drawing.Point(250, 65);
            this.pictureBoxMain.Name = "pictureBoxMain";
            this.pictureBoxMain.Size = new System.Drawing.Size(775, 624);
            this.pictureBoxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMain.TabIndex = 3;
            this.pictureBoxMain.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.BackColor = System.Drawing.Color.White;
            this.buttonReset.Location = new System.Drawing.Point(4, 3);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(230, 23);
            this.buttonReset.TabIndex = 1;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = false;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // InterfaceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 745);
            this.Controls.Add(this.pictureBoxMain);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pimp My Unicorn ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.InterfaceClient_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelTitre;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button saveUnicorn;
        private System.Windows.Forms.PictureBox pictureBoxMain;
        private System.Windows.Forms.Button shuffleButton;
        private System.Windows.Forms.Button buttonReset;
    }
}