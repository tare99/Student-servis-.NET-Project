using DLWMS.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DLWMS.SQLite.forma_folder
{
    public partial class frmGlavna : Form
    {
        public frmGlavna()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Da li zelite izaci iz programa?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudenti frmStudenti = new frmStudenti();
            frmStudenti.MdiParent = this;
            frmStudenti.Show();
        }
    }
}
