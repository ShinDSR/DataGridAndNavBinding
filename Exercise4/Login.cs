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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string nama = "Danang";
            string pass = "12345";

            if(txUsername.Text == "" || txPass.Text == "")
            {
                MessageBox.Show("Harap isi semua data");
            }
            else if(txUsername.Text == nama && txPass.Text == pass && checkBox.Checked)
            {
                Menu mn = new Menu();
                this.Hide();
                mn.Show();
            }
            else if(txUsername.Text != nama || txPass.Text != pass && checkBox.Checked)
            {                
                MessageBox.Show("Username atau Password salah");
            }
            else
            {
                MessageBox.Show("Harap menyetujui 'Term & Condition' !!");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
