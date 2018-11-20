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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModal));
            this.name_element = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.add_image = new System.Windows.Forms.Button();
            this.select_partie = new System.Windows.Forms.ComboBox();
            this.add_element = new System.Windows.Forms.Button();
            this.display_image = new System.Windows.Forms.PictureBox();
            this.name_img = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_element
            // 
            this.name_element.Location = new System.Drawing.Point(26, 179);
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
            this.add_image.Location = new System.Drawing.Point(175, 231);
            this.add_image.Name = "add_image";
            this.add_image.Size = new System.Drawing.Size(45, 20);
            this.add_image.TabIndex = 1;
            this.add_image.Text = "...";
            this.add_image.UseVisualStyleBackColor = true;
            this.add_image.Click += new System.EventHandler(this.add_image_Click);
            // 
            // select_partie
            // 
            this.select_partie.FormattingEnabled = true;
            this.select_partie.Location = new System.Drawing.Point(26, 288);
            this.select_partie.Name = "select_partie";
            this.select_partie.Size = new System.Drawing.Size(194, 21);
            this.select_partie.TabIndex = 3;
            // 
            // add_element
            // 
            this.add_element.Location = new System.Drawing.Point(92, 344);
            this.add_element.Name = "add_element";
            this.add_element.Size = new System.Drawing.Size(61, 35);
            this.add_element.TabIndex = 4;
            this.add_element.Text = "Valider";
            this.add_element.UseVisualStyleBackColor = true;
            // 
            // display_image
            // 
            this.display_image.Location = new System.Drawing.Point(254, -2);
            this.display_image.Name = "display_image";
            this.display_image.Size = new System.Drawing.Size(689, 568);
            this.display_image.TabIndex = 5;
            this.display_image.TabStop = false;
            // 
            // name_img
            // 
            this.name_img.AutoSize = true;
            this.name_img.Location = new System.Drawing.Point(23, 231);
            this.name_img.Name = "name_img";
            this.name_img.Size = new System.Drawing.Size(0, 13);
            this.name_img.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.select_partie);
            this.panel1.Controls.Add(this.name_img);
            this.panel1.Controls.Add(this.name_element);
            this.panel1.Controls.Add(this.add_image);
            this.panel1.Controls.Add(this.add_element);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 581);
            this.panel1.TabIndex = 7;
            // 
            // FormModal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.display_image);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormModal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormModal";
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox name_element;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button add_image;
        private System.Windows.Forms.ComboBox select_partie;
        private System.Windows.Forms.Button add_element;
        private System.Windows.Forms.PictureBox display_image;
        private System.Windows.Forms.Label name_img;
        private System.Windows.Forms.Panel panel1;
    }
}