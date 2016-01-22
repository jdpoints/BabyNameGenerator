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
    public partial class frmStatus : Form
    {
        public int ValidNames { get; set; }
        public int TriedNames { get; set; }
        public int GoodNames { get; set; }
        public string Title { get; set; }

        public frmStatus()
        {
            InitializeComponent();
            this.Title = "Default";
        }

        public frmStatus(string name)
        {
            InitializeComponent();
            this.Title = name;
            this.Text = name;
        }

        private void frmStatus_Load(object sender, EventArgs e)
        {
            using (var context = new NameGeneratorContext())
            {
                int activeFirst = context.first_name
                    .Where(n => n.Active == true)
                    .Count();

                int activeMiddle = context.middle_name
                    .Where(n => n.Active == true)
                    .Count();

                var activeNames = context.full_name
                    .Where(n => n.middle_name.Active == true)
                    .Where(n => n.first_name.Active == true);

                this.TriedNames = activeNames.Count();
                this.GoodNames = activeNames
                    .Where(n => n.Good == true)
                    .Count();

                this.ValidNames = activeFirst * activeMiddle;

                if (this.GoodNames == 0 
                    || this.TriedNames == 0)
                {
                    this.progbarNames.Value = 0;
                }
                else
                {
                    this.progbarNames.Value = Convert.ToInt32((this.TriedNames / this.ValidNames) * 100);
                }
            }

            this.txtValidNames.Text = this.ValidNames.ToString();
            this.txtTriedNames.Text = this.TriedNames.ToString();
            this.txtGoodNames.Text = this.GoodNames.ToString();
        }
    }
}
