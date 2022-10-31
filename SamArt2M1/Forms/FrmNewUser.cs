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
    public partial class FrmNewUser : Form
    {
        public FrmNewUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DataImage objImg = new DataImage();
            objImg.Username = txtNewUser.Text;
            objImg.Email = txtNewEmail.Text;
            objImg.nPassword = txtNewPass.Text;
            objImg.Perfil = ConvertImg();
            objImg.Names = txtNames.Text;
            objImg.Lastnames = txtLastNames.Text;
            objImg.FechaDeNacimiento1 = dtNewUser.Value;
            objImg.Phone1 =Convert.ToInt32(txtPhone.Text);
            objImg.Montoin = Convert.ToDecimal(txtMontoin.Text);
            MessageBox.Show(objImg.SaveChanges());
        }

        private byte[] ConvertImg() 
        {
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            cuiProfilePicture1.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmAdmin FrmAdminReturn = new FrmAdmin();
            FrmAdminReturn.Show();
            Hide();
        }

        private void cuiProfilePicture1_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();

            //var xd = of.ShowDialog();

            DialogResult dr = of.ShowDialog();
            if (dr == DialogResult.OK)
            {
                cuiProfilePicture1.Image = Image.FromFile(of.FileName);
            }
        }

        private void FrmNewUser_Load(object sender, EventArgs e)
        {

        }
    }
}
