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
    public partial class DataGrid : Form
    {
        public DataGrid()
        {
            InitializeComponent();
        }

        private void DataGrid_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

            dataGridView1.Columns[0].HeaderText = "No. Mahasiswa";
            dataGridView1.Columns[1].HeaderText = "Nama Mahasiswa";
            dataGridView1.Columns[2].HeaderText = "Alamat Mahasiswa";
            dataGridView1.Columns[3].HeaderText = "Jenis Kelamin";
            dataGridView1.Columns[4].HeaderText = "No. Telepon";

            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.Purple;
            dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;

            dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Blue;
            dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;

            dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.Cyan;
            dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;

            dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.Green;
            dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.DarkRed;
            dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu mn = new Menu();
            this.Hide();
            mn.Show();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            View v = new View();

            v.nimVR.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            v.namaVR.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            v.almtVR.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            v.kelVR.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            v.telpVR.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            this.Hide();
            v.Show();
        }
    }
}
