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
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            FormModal settingsForm = new FormModal();

            if (!settingsForm.IsDisposed)
            {
                settingsForm.ShowDialog();
            }

            
        }
    }
}
