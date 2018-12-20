using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WinFormPimpMyUnicornClient.DTO;

namespace WinFormPimpMyUnicornClient
{
    public partial class InterfaceClient : Form
    {
        private string _connString = ConfigurationManager.ConnectionStrings["PimpMyUnicornDB"].ConnectionString;
        private List<PartiesDTO> _parties = new List<PartiesDTO>();
        private List<ElementsDTO> _elements = new List<ElementsDTO>();
        private Dictionary<string,int> lockers = new Dictionary<string,int>();
        private string labelGenerate = "labelPartie";
        private string comboBoxGenerate = "comboBoxPartie";
        private string buttonGenerate = "buttonLockerPartie";

        public InterfaceClient()
        {
            using (MySqlConnection cn = new MySqlConnection(_connString))
            {
                cn.Open();
                string query = "SELECT Id_partie, partieLibelle, partieOrdre FROM t_parties";
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _parties.Add(new PartiesDTO
                            {
                                ID = Convert.ToInt32(dr.GetValue(0)),
                                Libelle = dr.GetValue(1).ToString(),
                                partieOrdre = Convert.ToInt32(dr.GetValue(2))
                            });
                        }
                    }
                }
                _parties = _parties.OrderBy(x => x.partieOrdre).ToList();

                query = "SELECT Id_element, partie_id, elementLibelle, elementsImg FROM t_elements";
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _elements.Add(new ElementsDTO
                            {
                                ID = Convert.ToInt32(dr.GetValue(0)),
                                PartieID = Convert.ToInt32(dr.GetValue(1)),
                                Libelle = dr.GetValue(2).ToString(),
                                Image = dr.GetValue(3).ToString()
                            });
                        }
                    }
                }
            }
            _elements = _elements.OrderBy(x => x.ID).ToList();

            InitializeComponent();

            int turn = 1;
            foreach (PartiesDTO partie in _parties)
            {
                Dictionary<int, string> thisComboBoxValue = new Dictionary<int, string>
                {
                    { -1, "Rien" }
                };
                Dictionary<int, string> elements = _elements.Where(el => el.PartieID == partie.ID).ToDictionary(el => el.ID, el => el.Libelle);
                foreach (KeyValuePair<int, string> value in elements)
                { thisComboBoxValue.Add(value.Key, value.Value); };

                Label thisLabel = new Label
                {
                    Name = labelGenerate + turn,
                    Location = new Point(10, 30 + 50 * turn),
                    BackColor = Color.Transparent,
                    Text = partie.Libelle + ":",
                    Font = new Font("Arial Black", 9)
                };
                thisLabel.Width = TextRenderer.MeasureText(thisLabel.Text, thisLabel.Font).Width;

                ComboBox thisComboBox = new ComboBox
                {
                    Name = comboBoxGenerate + turn,
                    Location = new Point(90, 30 + 50 * turn),
                    DataSource = new BindingSource(thisComboBoxValue, ""),
                    DisplayMember = "Value",
                    ValueMember = "Key",
                    Cursor = Cursors.Hand
                };
                Button thisButton = new Button
                {
                    Name = buttonGenerate + turn,
                    Location = new Point(220, 28 + 50 * turn),
                    Text = "",
                    BackColor = Color.Transparent,
                    BackgroundImage = Image.FromFile(@"..\..\Resources\lock.png"),
                    Cursor = Cursors.Hand,
                    Width = 25,
                    Height = 25,
                    BackgroundImageLayout = ImageLayout.Center
                };
                lockers.Add(thisButton.Name, 0);
                thisButton.Click += ThisButton_Click;
                panelLeft.Controls.AddRange(new Control[] { thisLabel, thisComboBox, thisButton });
                turn++;
            }
        }

        private void ThisButton_Click(object sender, EventArgs e)
        {
            Button thisButton = (Button)sender;
            lockers[thisButton.Name] = lockers[thisButton.Name] == 0 ? 1 : 0;
            thisButton.BackColor = thisButton.BackColor == Color.Green ? Color.Transparent : Color.Green;
        }

        private void InterfaceClient_Shown(object sender, EventArgs e)
        {
            List<ComboBox> comboboxes = panelLeft.Controls.OfType<ComboBox>().ToList();
            foreach (ComboBox cb in comboboxes)
            {
                cb.SelectedIndexChanged -= comboBoxChanged;
                if (cb.Items.Count > 1)
                    cb.SelectedIndex = 1;
                cb.SelectedIndexChanged += comboBoxChanged;
                if (cb == comboboxes.Last())
                    comboBoxChanged(null, null);
            }
        }

        private void saveUnicorn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = ".png|*.png",
                Title = "Sauvegarder votre Licorne"
            };
            DialogResult dialog_result = saveFileDialog1.ShowDialog();
            if (dialog_result == DialogResult.OK)
                new Bitmap(pictureBoxMain.Image).Save(saveFileDialog1.FileName);
        }

        private void comboBoxChanged(object sender, EventArgs e)
        {
            List<ComboBox> comboboxes = panelLeft.Controls.OfType<ComboBox>().ToList();
            List<Image> images = new List<Image>();
            foreach (ComboBox cb in comboboxes)
            {
                int ID = Convert.ToInt32(cb.SelectedValue);
                if (ID != -1)
                    images.Add(DisplayBase64Picture(_elements.Find(x => x.ID == ID).Image));
            }
            pictureBoxMain.Image = CombineAndResizeTwoImages(images, pictureBoxMain.Width, pictureBoxMain.Height);
        }

        private void shuffleButton_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboboxes = panelLeft.Controls.OfType<ComboBox>().ToList();
            foreach (ComboBox cb in comboboxes)
            {
                string partieValue = cb.Name.Substring(cb.Name.Length - 1);
                if (lockers[buttonGenerate + partieValue] == 0)
                {
                    cb.SelectedIndexChanged -= comboBoxChanged;
                    int cbItems = cb.Items.Count;
                    if (cbItems > 1)
                        cb.SelectedIndex = new Random().Next(1, cbItems);
                    cb.SelectedIndexChanged += comboBoxChanged;
                }
                if (cb == comboboxes.Last())
                    comboBoxChanged(null, null);
            }
        }


        private static Image DisplayBase64Picture(string base64)
        {
            Image newPicture;
            if (string.IsNullOrEmpty(base64))
                base64 = "R0lGODlhAQABAIAAAAAAAP///yH5BAEAAAAALAAAAAABAAEAAAIBRAA7";
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64))) { newPicture = Image.FromStream(ms); }
            return newPicture;
        }

        private Bitmap CombineAndResizeTwoImages(List<Image> images, int width, int height)
        {
            int border = 0;
            if (width > height)
                border = height;
            else
                border = width;
            //a holder for the result
            Bitmap result = new Bitmap(border, border);

            //use a graphics object to draw the resized image into the bitmap
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the images into the target bitmap
                foreach (Image img in images)
                {
                    graphics.DrawImage(img, 0, 0, border, border);
                }
            }
            //return the resulting bitmap
            return result;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            List<ComboBox> comboboxes = panelLeft.Controls.OfType<ComboBox>().ToList();
            foreach (ComboBox cb in comboboxes)
            {
                string partieValue = cb.Name.Substring(cb.Name.Length - 1);
                if(lockers[buttonGenerate + partieValue] == 1)
                {
                    Button thisButton = (Button)Controls.Find(buttonGenerate + partieValue, true)[0];
                    thisButton.PerformClick();
                }
                cb.SelectedIndexChanged -= comboBoxChanged;
                cb.SelectedIndex = 1;
                cb.SelectedIndexChanged += comboBoxChanged;
                if (cb == comboboxes.Last())
                    comboBoxChanged(null, null);
            }
        }
    }
}
