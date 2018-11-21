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
using WinFormPimpMyUnicornAdmin;

namespace WinFormPimpMyUnicorn
{
    public partial class FormModal : Form
    {
        public FormModal(T_elements thisElement = null)
        {

            InitializeComponent();
            var _parties = Crud.getAllParties();

            if (_parties != null && _parties.Count > 0)
            {
                
                Dictionary<int, string> parties = _parties.ToDictionary(p => p.Id_partie, p => p.partieLibelle);

                select_partie.DataSource = new BindingSource(parties, null);
                select_partie.DisplayMember = "Value";
                select_partie.ValueMember = "Key";

                if(thisElement != null)
                {
                    name_element.Text = thisElement.elementLibelle;
                    display_image.Image = DisplayBase64Picture(thisElement.elementsImg);
                    select_partie.SelectedValue = thisElement.partie_id;
                }

            } else
            {
                MessageBox.Show("Impossible de récupérer les parties de licorne", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Dispose();
            }
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

                name_img.Text = openFileDialog1.SafeFileName;

            }

        }

        private void add_element_Click(object sender, EventArgs e)
        {
            string nomElement = name_element.Text;
            byte[] byteArrayForImage = new byte[0];
            using(MemoryStream ms = new MemoryStream())
            {
                new Bitmap(display_image.Image).Save(ms, display_image.Image.RawFormat);
                byteArrayForImage = ms.ToArray();
            }
            string image = Convert.ToBase64String(byteArrayForImage);
            int partieID = Convert.ToInt32(select_partie.SelectedValue);
            Crud.insertElement(nomElement, image, partieID);
            this.Dispose();
        }
    }
}
