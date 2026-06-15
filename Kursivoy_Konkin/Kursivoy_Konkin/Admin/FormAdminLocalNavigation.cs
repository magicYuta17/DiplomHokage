using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursivoy_Konkin.Admin
{
    public partial class FormAdminLocalNavigation : Form
    {
        public FormAdminLocalNavigation()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAutorization f = new FormAutorization();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSettings f = new FormSettings();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAdminLocal f = new FormAdminLocal();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormRepairBD f = new FormRepairBD();
            this.Visible = false;
            f.ShowDialog();
            this.Close();
        }
    }
}
