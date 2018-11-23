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
            drawDataGridElement();

            table_element.Columns["Id_element"].Visible = false;
            table_element.Columns["elementsImg"].Visible = false;
            table_element.Columns["partie_id"].Visible = false;
            table_element.Columns["elementLibelle"].HeaderText = "Element";
            table_element.Columns["partieLibelle"].HeaderText = "Partie";

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


            drawDataGridPartie();
            table_partie.Columns["Id_partie"].Visible = false;
            table_partie.Columns["partieLibelle"].HeaderText = "Element";
            table_partie.Columns["partieOrdre"].HeaderText = "Ordre";

            DataGridViewButtonColumn dgBtnColPartie = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Details",
                HeaderText = "Details",
                Name = "Details"
            };
            table_partie.Columns.Add(dgBtnColPartie);

            DataGridViewButtonColumn delBtnColPartie = new DataGridViewButtonColumn
            {
                UseColumnTextForButtonValue = true,
                Text = "Supprimer",
                HeaderText = "Supprimer",
                Name = "Supprimer"
            };
            table_partie.Columns.Add(delBtnColPartie);

        }

        public void drawDataGridElement()
        {
            List<T_parties> parties = Crud.getAllParties();
            List<T_elements> elements = Crud.getAllElements();

            foreach (T_elements element in elements)
            {
                element.partieLibelle = parties.Where(x => x.Id_partie == element.partie_id).First().partieLibelle;
            }

            table_element.DataSource = new BindingList<T_elements>(elements);
        }

        public void drawDataGridPartie()
        {
            List<T_parties> parties = Crud.getAllParties();
            table_partie.DataSource = new BindingList<T_parties>(parties);
        }
        private void btn_create_Click(object sender, EventArgs e)
        {
            FormModal settingsForm = new FormModal();
            settingsForm.onUpdateDataGrid += new FormModal.updateDataGrid(SettingsForm_onUpdateDataGrid);
            if (!settingsForm.IsDisposed)
            {
                settingsForm.ShowDialog();
            }

            
        }

        private void SettingsForm_onUpdateDataGrid()
        {
            this.Invoke(new MethodInvoker(delegate { this.drawDataGridElement(); }));
        }

        private void FormPartie_onUpdateDataGrid()
        {
            this.Invoke(new MethodInvoker(delegate { this.drawDataGridPartie(); }));
        }

        private void table_element_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == table_element.Columns["Details"].Index)
            {
                T_elements thisElement = (T_elements)table_element.Rows[e.RowIndex].DataBoundItem;

                FormModal settingsForm = new FormModal(thisElement);
                settingsForm.onUpdateDataGrid += new FormModal.updateDataGrid(SettingsForm_onUpdateDataGrid);
                settingsForm.Show();
            }
            else if (e.ColumnIndex == table_element.Columns["Supprimer"].Index)
            {
                T_elements thisElement = (T_elements)table_element.Rows[e.RowIndex].DataBoundItem;

                DialogResult confirmResult = MessageBox.Show("Etes-vous sur de vouloir supprimer cet elements ?", "Etes-vous sur ?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    Crud.deleteElement(thisElement.Id_element);
                    table_element.Rows.RemoveAt(e.RowIndex);
                }
            }

        }

        private void btn_create_partie_Click(object sender, EventArgs e)
        {
            FormPartie formPartie = new FormPartie();
            formPartie.onUpdateDataGrid += new FormPartie.updateDataGrid(FormPartie_onUpdateDataGrid);
            formPartie.ShowDialog();
        }
    }
}
