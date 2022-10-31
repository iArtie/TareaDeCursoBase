
namespace SamArt2M1.Forms
{
    partial class FrmAdmin
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
            this.cuiProfilePicture1 = new SamArt2M1.CustomUI.CUIProfilePicture();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnTransact = new System.Windows.Forms.Button();
            this.dtbUsers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtbUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiProfilePicture1
            // 
            this.cuiProfilePicture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cuiProfilePicture1.BorderColor = System.Drawing.Color.MintCream;
            this.cuiProfilePicture1.BorderColor2 = System.Drawing.Color.Black;
            this.cuiProfilePicture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cuiProfilePicture1.BorderSize = 3;
            this.cuiProfilePicture1.GardientAngle = 50F;
            this.cuiProfilePicture1.Location = new System.Drawing.Point(19, 26);
            this.cuiProfilePicture1.Name = "cuiProfilePicture1";
            this.cuiProfilePicture1.Size = new System.Drawing.Size(159, 159);
            this.cuiProfilePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cuiProfilePicture1.TabIndex = 0;
            this.cuiProfilePicture1.TabStop = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.ForeColor = System.Drawing.Color.SeaShell;
            this.btnAddUser.Location = new System.Drawing.Point(0, 230);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(200, 54);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Agregar Usuario";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnTransact);
            this.panel1.Controls.Add(this.btnAddUser);
            this.panel1.Controls.Add(this.cuiProfilePicture1);
            this.panel1.Location = new System.Drawing.Point(2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 524);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.OrangeRed;
            this.button1.Location = new System.Drawing.Point(0, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Eliminar Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose
            // 
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnClose.ForeColor = System.Drawing.Color.SeaShell;
            this.btnClose.Location = new System.Drawing.Point(0, 467);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(200, 54);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Cerrar Sesion";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnTransact
            // 
            this.btnTransact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransact.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTransact.ForeColor = System.Drawing.Color.SeaShell;
            this.btnTransact.Location = new System.Drawing.Point(0, 306);
            this.btnTransact.Name = "btnTransact";
            this.btnTransact.Size = new System.Drawing.Size(200, 54);
            this.btnTransact.TabIndex = 3;
            this.btnTransact.Text = "Transacciones";
            this.btnTransact.UseVisualStyleBackColor = true;
            // 
            // dtbUsers
            // 
            this.dtbUsers.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.dtbUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbUsers.Location = new System.Drawing.Point(208, -1);
            this.dtbUsers.Name = "dtbUsers";
            this.dtbUsers.RowTemplate.Height = 25;
            this.dtbUsers.Size = new System.Drawing.Size(592, 521);
            this.dtbUsers.TabIndex = 3;
            this.dtbUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbUsers_CellClick);
            this.dtbUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbUsers_CellContentClick);
            // 
            // FrmAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(33)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.dtbUsers);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdmin";
            this.Text = "FrmAdmin";
            this.Load += new System.EventHandler(this.FrmAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtbUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomUI.CUIProfilePicture cuiProfilePicture1;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTransact;
        private System.Windows.Forms.DataGridView dtbUsers;
        private System.Windows.Forms.Button button1;
    }
}