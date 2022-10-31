using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Infraestructure.Repository;

namespace SamArt2M1.Forms
{
    public partial class FrmAdmin : Form
    {
        public string Row;
        public int RowId;
        DataImage IObj = new DataImage();
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            FrmNewUser newUser = new FrmNewUser();
            newUser.Show();
            Hide();
        }

        private void FrmAdmin_Load(object sender, EventArgs e)
        {
            dtbUsers.DataSource = IObj.ShowUsers();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Form1 NewLogin = new Form1();
            NewLogin.Show();
            Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtbUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dtbUsers.Rows[e.RowIndex];
            Row = Convert.ToString(fila.Cells[0].Value);
            RowId = (int)dtbUsers.CurrentRow.Cells[0].Value;
            //RowId = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IObj.DeleteUsers(RowId)) 
            {
                MessageBox.Show("Usuario Eliminado");
                dtbUsers.DataSource = IObj.ShowUsers();
            }
        }

        private void dtbUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
