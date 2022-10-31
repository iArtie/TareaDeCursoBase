using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SamArt2M1.Forms
{
    public partial class FrmTransaction : Form
    {
        
        
        public FrmTransaction()
        {
            InitializeComponent();
        }
        bool val = false;
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            val = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (val == true)
            {
                this.Location = Cursor.Position;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            val = false;
        }

        private void FrmTransaction_Load(object sender, EventArgs e)
        {

        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
           
            Hide();
        }
    }
}
