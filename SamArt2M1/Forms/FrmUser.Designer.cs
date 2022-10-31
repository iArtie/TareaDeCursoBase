
namespace SamArt2M1.Forms
{
    partial class FrmUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rESUMENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOSPRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactanosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.cuiProfilePicture1 = new SamArt2M1.CustomUI.CUIProfilePicture();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rESUMENToolStripMenuItem,
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem,
            this.nUEVOSPRODUCTOSToolStripMenuItem,
            this.contactanosToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // rESUMENToolStripMenuItem
            // 
            this.rESUMENToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rESUMENToolStripMenuItem.Name = "rESUMENToolStripMenuItem";
            this.rESUMENToolStripMenuItem.Size = new System.Drawing.Size(112, 29);
            this.rESUMENToolStripMenuItem.Text = "RESUMEN";
            // 
            // tRANSFERENCIASYPEDIDOSToolStripMenuItem
            // 
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem.Name = "tRANSFERENCIASYPEDIDOSToolStripMenuItem";
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem.Size = new System.Drawing.Size(282, 29);
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem.Text = "TRANSFERENCIAS Y PEDIDOS";
            this.tRANSFERENCIASYPEDIDOSToolStripMenuItem.Click += new System.EventHandler(this.tRANSFERENCIASYPEDIDOSToolStripMenuItem_Click);
            // 
            // nUEVOSPRODUCTOSToolStripMenuItem
            // 
            this.nUEVOSPRODUCTOSToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.nUEVOSPRODUCTOSToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.nUEVOSPRODUCTOSToolStripMenuItem.Name = "nUEVOSPRODUCTOSToolStripMenuItem";
            this.nUEVOSPRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(160, 29);
            this.nUEVOSPRODUCTOSToolStripMenuItem.Text = "CONTACTANOS";
            this.nUEVOSPRODUCTOSToolStripMenuItem.Click += new System.EventHandler(this.nUEVOSPRODUCTOSToolStripMenuItem_Click);
            // 
            // contactanosToolStripMenuItem
            // 
            this.contactanosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.contactanosToolStripMenuItem.Name = "contactanosToolStripMenuItem";
            this.contactanosToolStripMenuItem.Size = new System.Drawing.Size(165, 29);
            this.contactanosToolStripMenuItem.Text = "CERRAR SESION";
            this.contactanosToolStripMenuItem.Click += new System.EventHandler(this.contactanosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.cuiProfilePicture1);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(731, 222);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(328, 177);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(55, 45);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "xd";
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // cuiProfilePicture1
            // 
            this.cuiProfilePicture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cuiProfilePicture1.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.cuiProfilePicture1.BorderColor2 = System.Drawing.Color.MediumPurple;
            this.cuiProfilePicture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cuiProfilePicture1.BorderSize = 3;
            this.cuiProfilePicture1.GardientAngle = 50F;
            this.cuiProfilePicture1.Location = new System.Drawing.Point(275, 14);
            this.cuiProfilePicture1.Name = "cuiProfilePicture1";
            this.cuiProfilePicture1.Size = new System.Drawing.Size(158, 158);
            this.cuiProfilePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuiProfilePicture1.TabIndex = 3;
            this.cuiProfilePicture1.TabStop = false;
            this.cuiProfilePicture1.Click += new System.EventHandler(this.cuiProfilePicture1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 254);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(731, 315);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 629);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUser";
            this.Text = "FrmUser";
            this.Load += new System.EventHandler(this.FrmUser_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rESUMENToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tRANSFERENCIASYPEDIDOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOSPRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem contactanosToolStripMenuItem;
        public CustomUI.CUIProfilePicture cuiProfilePicture1;
        public System.Windows.Forms.Label lblUser;
    }
}