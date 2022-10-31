using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SamArt2M1.CustomUI;
namespace SamArt2M1.Forms
{
    public partial class FrmUser : Form
    {
        public FrmUser()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FrmUser_Load(object sender, EventArgs e)
        {
            //cuiProfilePicture1.ImageLocation = "https://scontent.fmga7-1.fna.fbcdn.net/v/t39.30808-6/241168083_2955292904687506_5533164720638879820_n.jpg?_nc_cat=103&ccb=1-7&_nc_sid=09cbfe&_nc_ohc=CRVRFo2KsukAX-Lnnux&_nc_ht=scontent.fmga7-1.fna&oh=00_AT9j8PImkOXmdwlF8IjE-iM93kNLRu8075ivYOuhstRUpA&oe=62AE8F8D";
            
            
            
          
        }

        private void profileUser_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void nUEVOSPRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contactanosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            DialogResult res = MessageBox.Show("Si cierra esta ventana perdera sus datos \n ¿Esta seguro que desea salir?", "",
                   MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
               

            }
            if (res == DialogResult.OK)
            {

                form1.Show();
                Hide();
                
            }

        }

        private void cuiProfilePicture1_Click(object sender, EventArgs e)
        {

        }

        private void tRANSFERENCIASYPEDIDOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTransaction FrmT = new FrmTransaction();
            FrmT.Show();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

