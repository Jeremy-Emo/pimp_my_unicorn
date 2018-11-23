using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormPimpMyUnicornAdmin;

namespace WinFormPimpMyUnicorn
{
    public partial class FormPartie : Form
    {

        public delegate void updateDataGrid();

        public event updateDataGrid onUpdateDataGrid;

        public FormPartie(T_parties thisPartie = null)
        {
            InitializeComponent();

            if (thisPartie != null)
            {
                partie_nom.Text = thisPartie.partieLibelle;
                partie_ordre.Text = thisPartie.partieOrdre.ToString();
                id_partie.Text = thisPartie.Id_partie.ToString();

                btn_add_partie.Click -= new EventHandler(btn_add_partie_Click);
                btn_add_partie.Click += new EventHandler(update_partie_Click);
            }
        }

        private void partie_ordre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_add_partie_Click(object sender, EventArgs e)
        {
            string nomPartie = string.Empty;
            int ordrePartie = 0;
            Information(out nomPartie, out ordrePartie);
            Crud.insertPartie(nomPartie, ordrePartie);
            if (onUpdateDataGrid != null) onUpdateDataGrid();
            this.Dispose();
        }

        private void update_partie_Click(object sender, EventArgs e)
        {
            string nomPartie = string.Empty;
            int ordrePartie = 0;
            int idPartie = Convert.ToInt32(id_partie.Text);
            Information(out nomPartie, out ordrePartie);
            Crud.updatePartie(idPartie, nomPartie, ordrePartie);
            if (onUpdateDataGrid != null) onUpdateDataGrid();
            this.Dispose();
        }

        private void Information(out string nomPartie, out int partieOrdre)
        {
            nomPartie = partie_nom.Text;
            partieOrdre = Convert.ToInt32(partie_ordre.Text);
        }
    }
}
