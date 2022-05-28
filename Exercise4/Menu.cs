using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise4
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void pictGrid_Click(object sender, EventArgs e)
        {
            DataGrid grid = new DataGrid();
            this.Hide();
            grid.Show();
        }

        private void pictNav_Click(object sender, EventArgs e)
        {
            NavBinding nav = new NavBinding();
            this.Hide();
            nav.Show();
        }

        private void btnMBack_Click(object sender, EventArgs e)
        {
            Login log = new Login();
            this.Hide();
            log.Show();
        }
    }
}
