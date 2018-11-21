using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPimpMyUnicorn;

namespace WinFormPimpMyUnicornAdmin
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();

            List<T_parties> parties = Crud.getAllParties();
            List<T_elements> elements = Crud.getAllElements();

            foreach(T_elements element in elements)
            {
                element.partieLibelle = parties.Where(x => x.Id_partie == element.partie_id).First().partieLibelle;
            }

            table_element.DataSource = new BindingList<T_elements>(elements);

            table_element.Columns["Id_element"].Visible = false;
            table_element.Columns["elementsImg"].Visible = false;
            table_element.Columns["partie_id"].Visible = false;

            DataGridViewButtonColumn dgBtnCol = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Details",
                HeaderText = "Details",
                Name = "Details"
            };
            table_element.Columns.Add(dgBtnCol);

            DataGridViewButtonColumn delBtnCol = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Supprimer",
                HeaderText = "Supprimer",
                Name = "Supprimer"
            };
            table_element.Columns.Add(delBtnCol);

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            FormModal settingsForm = new FormModal();

            if (!settingsForm.IsDisposed)
            {
                settingsForm.ShowDialog();
            }

            
        }

        private void table_element_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == table_element.Columns["Details"].Index)
            {
                T_elements thisElement = (T_elements)table_element.Rows[e.RowIndex].DataBoundItem;

                FormModal settingsForm = new FormModal(thisElement);
                settingsForm.Show();
            }
            else if (e.ColumnIndex == table_element.Columns["Supprimer"].Index)
            {
                T_elements thisElement = (T_elements)table_element.Rows[e.RowIndex].DataBoundItem;

                DialogResult confirmResult = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet éléments ?", "Êtes-vous sûr ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    Crud.deleteElement(thisElement.Id_element);
                    table_element.Rows.RemoveAt(e.RowIndex);
                }
            }

        }
    }
}
