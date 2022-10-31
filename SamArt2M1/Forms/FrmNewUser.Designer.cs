
namespace SamArt2M1.Forms
{
    partial class FrmNewUser
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
            this.txtNewUser = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.txtLastNames = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtNewUser = new System.Windows.Forms.DateTimePicker();
            this.txtMontoin = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).BeginInit();
            this.SuspendLayout();
            // 
            // cuiProfilePicture1
            // 
            this.cuiProfilePicture1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.cuiProfilePicture1.BorderColor = System.Drawing.Color.RoyalBlue;
            this.cuiProfilePicture1.BorderColor2 = System.Drawing.Color.HotPink;
            this.cuiProfilePicture1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.cuiProfilePicture1.BorderSize = 2;
            this.cuiProfilePicture1.GardientAngle = 50F;
            this.cuiProfilePicture1.Location = new System.Drawing.Point(107, 35);
            this.cuiProfilePicture1.Name = "cuiProfilePicture1";
            this.cuiProfilePicture1.Size = new System.Drawing.Size(159, 159);
            this.cuiProfilePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cuiProfilePicture1.TabIndex = 0;
            this.cuiProfilePicture1.TabStop = false;
            this.cuiProfilePicture1.Click += new System.EventHandler(this.cuiProfilePicture1_Click);
            // 
            // txtNewUser
            // 
            this.txtNewUser.Location = new System.Drawing.Point(92, 486);
            this.txtNewUser.Name = "txtNewUser";
            this.txtNewUser.Size = new System.Drawing.Size(245, 23);
            this.txtNewUser.TabIndex = 1;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(92, 528);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(245, 23);
            this.txtNewPass.TabIndex = 2;
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(92, 444);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(245, 23);
            this.txtNewEmail.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(49, 599);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(99, 35);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Crear";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 599);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(99, 35);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 447);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "E-mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 489);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "User:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 531);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nombres:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Apellidos:";
            // 
            // txtNames
            // 
            this.txtNames.Location = new System.Drawing.Point(92, 246);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(245, 23);
            this.txtNames.TabIndex = 11;
            // 
            // txtLastNames
            // 
            this.txtLastNames.Location = new System.Drawing.Point(92, 287);
            this.txtLastNames.Name = "txtLastNames";
            this.txtLastNames.Size = new System.Drawing.Size(245, 23);
            this.txtLastNames.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Telefono:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(92, 370);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(245, 23);
            this.txtPhone.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 333);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Nacimiento:";
            // 
            // dtNewUser
            // 
            this.dtNewUser.Location = new System.Drawing.Point(92, 327);
            this.dtNewUser.Name = "dtNewUser";
            this.dtNewUser.Size = new System.Drawing.Size(245, 23);
            this.dtNewUser.TabIndex = 16;
            // 
            // txtMontoin
            // 
            this.txtMontoin.Location = new System.Drawing.Point(92, 412);
            this.txtMontoin.Name = "txtMontoin";
            this.txtMontoin.Size = new System.Drawing.Size(245, 23);
            this.txtMontoin.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 15);
            this.label8.TabIndex = 18;
            this.label8.Text = "Monto Inicial:";
            // 
            // FrmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 659);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMontoin);
            this.Controls.Add(this.dtNewUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLastNames);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtNewEmail);
            this.Controls.Add(this.txtNewPass);
            this.Controls.Add(this.txtNewUser);
            this.Controls.Add(this.cuiProfilePicture1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmNewUser";
            this.Text = "FrmNewUser";
            this.Load += new System.EventHandler(this.FrmNewUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cuiProfilePicture1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomUI.CUIProfilePicture cuiProfilePicture1;
        private System.Windows.Forms.TextBox txtNewUser;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtLastNames;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtNewUser;
        private System.Windows.Forms.TextBox txtMontoin;
        private System.Windows.Forms.Label label8;
    }
}