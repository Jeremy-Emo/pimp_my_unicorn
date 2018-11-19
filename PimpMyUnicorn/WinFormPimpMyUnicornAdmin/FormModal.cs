using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WinFormPimpMyUnicorn
{
    public partial class FormModal : Form
    {
        public FormModal()
        {
            InitializeComponent();
        }

        private static Image DisplayBase64Picture(string base64)
        {
            Image newPicture;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64))) { newPicture = Image.FromStream(ms); }
            return newPicture;
        }

        private void add_image_Click(object sender, EventArgs e)
        {
            DialogResult dial = openFileDialog1.ShowDialog();
            if(dial != DialogResult.Cancel)
            {
                string base64 = "";
                using (var image = openFileDialog1.OpenFile())
                {

                    string filename = openFileDialog1.FileName;
                    byte[] array = File.ReadAllBytes(filename);

                    base64 = Convert.ToBase64String(array);

                };

                display_image.Image = DisplayBase64Picture(base64);

            }

        }

    }
}
