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
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.saveUnicorn = new System.Windows.Forms.Button();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Violet;
            this.panelHeader.Controls.Add(this.pictureBoxRight);
            this.panelHeader.Controls.Add(this.pictureBoxLeft);
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1264, 65);
            this.panelHeader.TabIndex = 0;
            // 
            // pictureBoxRight
            // 
            this.pictureBoxRight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRight.Image")));
            this.pictureBoxRight.Location = new System.Drawing.Point(1204, 6);
            this.pictureBoxRight.Name = "pictureBoxRight";
            this.pictureBoxRight.Size = new System.Drawing.Size(48, 50);
            this.pictureBoxRight.TabIndex = 27;
            this.pictureBoxRight.TabStop = false;
            // 
            // pictureBoxLeft
            // 
            this.pictureBoxLeft.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeft.Image")));
            this.pictureBoxLeft.Location = new System.Drawing.Point(12, 6);
            this.pictureBoxLeft.Name = "pictureBoxLeft";
            this.pictureBoxLeft.Size = new System.Drawing.Size(48, 50);
            this.pictureBoxLeft.TabIndex = 26;
            this.pictureBoxLeft.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Fuchsia;
            this.label1.Location = new System.Drawing.Point(563, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pimp My Unicorn";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.HotPink;
            this.panelRight.Location = new System.Drawing.Point(1039, 65);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(225, 791);
            this.panelRight.TabIndex = 0;
            // 
            // panelFooter
            // 
            this.panelFooter.BackColor = System.Drawing.Color.Violet;
            this.panelFooter.Location = new System.Drawing.Point(0, 856);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1264, 65);
            this.panelFooter.TabIndex = 0;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.HotPink;
            this.panelLeft.Controls.Add(this.saveUnicorn);
            this.panelLeft.Location = new System.Drawing.Point(0, 65);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(225, 791);
            this.panelLeft.TabIndex = 2;
            // 
            // saveUnicorn
            // 
            this.saveUnicorn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.saveUnicorn.Location = new System.Drawing.Point(3, 33);
            this.saveUnicorn.Name = "saveUnicorn";
            this.saveUnicorn.Size = new System.Drawing.Size(219, 23);
            this.saveUnicorn.TabIndex = 0;
            this.saveUnicorn.Text = "Enregistrer ma Lincorne";
            this.saveUnicorn.UseVisualStyleBackColor = false;
            this.saveUnicorn.Click += new System.EventHandler(this.saveUnicorn_Click);
            // 
            // panelImage
            // 
            this.panelImage.BackColor = System.Drawing.Color.Transparent;
            this.panelImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelImage.Location = new System.Drawing.Point(225, 65);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(814, 791);
            this.panelImage.TabIndex = 3;
            this.panelImage.Paint += new System.Windows.Forms.PaintEventHandler(this.panelImage_Paint);
            // 
            // InterfaceClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 921);
            this.Controls.Add(this.panelImage);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InterfaceClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pimp My Unicorn ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeft)).EndInit();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRight;
        private System.Windows.Forms.PictureBox pictureBoxLeft;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Button saveUnicorn;
        private System.Windows.Forms.Panel panelImage;
    }
}