﻿namespace WinFormPimpMyUnicorn
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.add_image = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox_ = new System.Windows.Forms.ComboBox();
            this.add_element = new System.Windows.Forms.Button();
            this.display_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 0;
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(52, 123);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(143, 20);
            this.textBox2.TabIndex = 2;
            // 
            // comboBox_
            // 
            this.comboBox_.FormattingEnabled = true;
            this.comboBox_.Location = new System.Drawing.Point(52, 180);
            this.comboBox_.Name = "comboBox_";
            this.comboBox_.Size = new System.Drawing.Size(194, 21);
            this.comboBox_.TabIndex = 3;
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
            this.Controls.Add(this.comboBox_);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.add_image);
            this.Controls.Add(this.textBox1);
            this.Name = "FormModal";
            this.Text = "FormModal";
            ((System.ComponentModel.ISupportInitialize)(this.display_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button add_image;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox_;
        private System.Windows.Forms.Button add_element;
        private System.Windows.Forms.PictureBox display_image;
    }
}