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


            table_element.DataSource = Crud.getAllElements();

            this.table_element.Columns["Id_element"].Visible = false;
            this.table_element.Columns["elementsImg"].Visible = false;


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

            settingsForm.Show();
        }

        private void table_element_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == table_element.Columns["Details"].Index)
            {
                T_elements thisElement = (T_elements)table_element.Rows[e.RowIndex].DataBoundItem;

                FormModal settingsForm = new FormModal(thisElement);
                settingsForm.Show();
            }
        }
    }
}
