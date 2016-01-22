using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BabyNameGenerator
{
    public partial class frmMain : Form
    {
        private AName frmName = new AName();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.firstNameBox.Text = frmName.FirstName.Name;
            this.middleNameBox.Text = frmName.MiddleName.Name;
        }

        private void btnNewFirst_Click(object sender, EventArgs e)
        {
            frmName.NewFirst();
            this.firstNameBox.Text = frmName.FirstName.Name;
        }

        private void btnNewMiddle_Click(object sender, EventArgs e)
        {
            frmName.NewMiddle();
            this.middleNameBox.Text = frmName.MiddleName.Name;
        }

        private void btnRemoveFirst_Click(object sender, EventArgs e)
        {
            AName.RemoveFirst(frmName.FirstName.FirstID);
            frmName.NewFirst();
            this.firstNameBox.Text = frmName.FirstName.Name;
        }

        private void btnRemoveMiddle_Click(object sender, EventArgs e)
        {
            AName.RemoveMiddle(frmName.MiddleName.MiddleID);
            frmName.NewMiddle();
            this.middleNameBox.Text = frmName.MiddleName.Name;
        }

        private void btnGoodName_Click(object sender, EventArgs e)
        {
            frmName.WriteFull(true);
            frmName.RandomFirst();
            frmName.NewMiddle();
            this.firstNameBox.Text = frmName.FirstName.Name;
            this.middleNameBox.Text = frmName.MiddleName.Name;
        }

        private void btnBadName_Click(object sender, EventArgs e)
        {
            frmName.WriteFull(false);
            frmName.RandomFirst();
            frmName.NewMiddle();
            this.firstNameBox.Text = frmName.FirstName.Name;
            this.middleNameBox.Text = frmName.MiddleName.Name;
        }

        private void seeStatusSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStatus StatusPage = new frmStatus("Status Page");
            StatusPage.ShowDialog();
        }

        private void goodNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportNamesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exporter.ExportToFile();
        }
    }
}
