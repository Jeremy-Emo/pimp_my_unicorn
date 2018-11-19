namespace WinFormPimpMyUnicorn
{
    partial class FormModal
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
            this.name_element = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.add_image = new System.Windows.Forms.Button();
            this.link_image = new System.Windows.Forms.TextBox();
            this.select_partie = new System.Windows.Forms.ComboBox();
            this.add_element = new System.Windows.Forms.Button();
            this.display_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).BeginInit();
            this.SuspendLayout();
            // 
            // name_element
            // 
            this.name_element.Location = new System.Drawing.Point(52, 71);
            this.name_element.Name = "name_element";
            this.name_element.Size = new System.Drawing.Size(194, 20);
            this.name_element.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // add_image
            // 
            this.add_image.Location = new System.Drawing.Point(201, 123);
            this.add_image.Name = "add_image";
            this.add_image.Size = new System.Drawing.Size(45, 20);
            this.add_image.TabIndex = 1;
            this.add_image.Text = "...";
            this.add_image.UseVisualStyleBackColor = true;
            this.add_image.Click += new System.EventHandler(this.add_image_Click);
            // 
            // link_image
            // 
            this.link_image.Location = new System.Drawing.Point(52, 123);
            this.link_image.Name = "link_image";
            this.link_image.Size = new System.Drawing.Size(143, 20);
            this.link_image.TabIndex = 2;
            // 
            // select_partie
            // 
            this.select_partie.FormattingEnabled = true;
            this.select_partie.Location = new System.Drawing.Point(52, 180);
            this.select_partie.Name = "select_partie";
            this.select_partie.Size = new System.Drawing.Size(194, 21);
            this.select_partie.TabIndex = 3;
            // 
            // add_element
            // 
            this.add_element.Location = new System.Drawing.Point(118, 236);
            this.add_element.Name = "add_element";
            this.add_element.Size = new System.Drawing.Size(61, 35);
            this.add_element.TabIndex = 4;
            this.add_element.Text = "Valider";
            this.add_element.UseVisualStyleBackColor = true;
            // 
            // display_image
            // 
            this.display_image.Location = new System.Drawing.Point(358, 71);
            this.display_image.Name = "display_image";
            this.display_image.Size = new System.Drawing.Size(783, 507);
            this.display_image.TabIndex = 5;
            this.display_image.TabStop = false;
            // 
            // FormModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 590);
            this.Controls.Add(this.display_image);
            this.Controls.Add(this.add_element);
            this.Controls.Add(this.select_partie);
            this.Controls.Add(this.link_image);
            this.Controls.Add(this.add_image);
            this.Controls.Add(this.name_element);
            this.Name = "FormModal";
            this.Text = "FormModal";
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name_element;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button add_image;
        private System.Windows.Forms.TextBox link_image;
        private System.Windows.Forms.ComboBox select_partie;
        private System.Windows.Forms.Button add_element;
        private System.Windows.Forms.PictureBox display_image;
    }
}