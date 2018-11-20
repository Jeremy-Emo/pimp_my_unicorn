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

        public InterfaceClient()
        {
            using (MySqlConnection cn = new MySqlConnection(_connString))
            {
                cn.Open();
                string query = "SELECT Id_partie, partielibelle FROM t_parties";
                using (MySqlCommand cmd = new MySqlCommand(query, cn))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            _parties.Add(new PartiesDTO
                            {
                                ID = Convert.ToInt32(dr.GetValue(0)),
                                Libelle = dr.GetValue(1).ToString()
                            });
                        }
                    }
                }

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
                _elements = _elements.OrderBy(x => x.ID).ToList();


                InitializeComponent();

                int turn = 1;
                foreach(PartiesDTO partie in _parties)
                {
                    Dictionary<int, string> thisComboBoxValue = new Dictionary<int, string>
                    {
                        { -1, "Choisissez..." }
                    };
                    Dictionary <int, string> elements = _elements.Where(el => el.PartieID == partie.ID).ToDictionary(el => el.ID, el => el.Libelle);
                    foreach(KeyValuePair<int,string> value in elements)
                    { thisComboBoxValue.Add(value.Key, value.Value); };

                    Label thisLabel = new Label
                    {
                        Name = "labelPartie" + turn,
                        Location = new Point(10, 100 + 50 * turn),
                        BackColor = Color.Transparent,
                        Text = partie.Libelle + ":",
                        Font = new Font("Arial Black", 9)
                    };
                    thisLabel.Width = TextRenderer.MeasureText(thisLabel.Text, thisLabel.Font).Width;

                    ComboBox thisComboBox = new ComboBox
                    {
                        Name = "comboBoxPartie" + turn,
                        Location = new Point(90, 100 + 50 * turn),
                        DataSource = new BindingSource(thisComboBoxValue, null),
                        DisplayMember = "Value",
                        ValueMember = "Key"
                    };
                    thisComboBox.SelectedIndexChanged += new EventHandler(comboBoxChanged);

                    panelImage.Controls.Add(new PictureBox
                    {
                        Name = "pictureBoxPartie" + turn,
                        Location = new Point(0, 0),
                        Size = new Size(823, 791),
                        BackColor = Color.Transparent
                    });
                    panelLeft.Controls.AddRange(new Control[] { thisLabel, thisComboBox });

                    turn++;
                }

                saveUnicorn.Location = new Point(3, 100 + 50 * turn);
            }
        }

        private static Image DisplayBase64Picture(string base64)
        {
            Image newPicture;
            using (MemoryStream ms = new MemoryStream(Convert.FromBase64String(base64))) { newPicture = Image.FromStream(ms); }
            return newPicture;
        }

        private void saveUnicorn_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg";
            saveFileDialog1.Title = "Sauvegarder votre Licorne";
            saveFileDialog1.ShowDialog();
        }

        private void comboBoxChanged(object sender, EventArgs e)
        {
            ComboBox thisCombobox = (ComboBox)sender;
            int ID = Convert.ToInt32(thisCombobox.SelectedValue);
            char number = thisCombobox.Name[thisCombobox.Name.Length - 1];
            PictureBox thisPictureBox = (PictureBox)panelImage.Controls["pictureBoxPartie" + number];
            if (ID == -1)
            {
                thisPictureBox.Image = null;
            }
            else
            {
                thisPictureBox.Image = DisplayBase64Picture(_elements.Find(x => x.ID == ID).Image);
            }
        }
    }
}
