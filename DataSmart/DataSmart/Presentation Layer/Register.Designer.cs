
namespace DataSmart.Presentation_Layer
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegBack = new System.Windows.Forms.Button();
            this.pnlRegister = new System.Windows.Forms.Panel();
            this.cbCampus = new System.Windows.Forms.ComboBox();
            this.pbLogoReigster = new System.Windows.Forms.PictureBox();
            this.lblConPass = new System.Windows.Forms.Label();
            this.tbConPass = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.lblCampus = new System.Windows.Forms.Label();
            this.lbllblEmail = new System.Windows.Forms.Label();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbSurname = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblRegisterHeading = new System.Windows.Forms.Label();
<<<<<<< Updated upstream
            this.pbShowPass = new System.Windows.Forms.PictureBox();
            this.pbShowCon = new System.Windows.Forms.PictureBox();
=======
>>>>>>> Stashed changes
            this.pnlRegister.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoReigster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.White;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(418, 261);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(117, 33);
            this.btnRegister.TabIndex = 11;
            this.btnRegister.Text = "REGISTER";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegBack
            // 
            this.btnRegBack.BackColor = System.Drawing.Color.White;
            this.btnRegBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegBack.Location = new System.Drawing.Point(90, 261);
            this.btnRegBack.Name = "btnRegBack";
            this.btnRegBack.Size = new System.Drawing.Size(79, 33);
            this.btnRegBack.TabIndex = 8;
            this.btnRegBack.Text = "BACK";
            this.btnRegBack.UseVisualStyleBackColor = false;
            this.btnRegBack.Click += new System.EventHandler(this.btnRegBack_Click);
            // 
            // pnlRegister
            // 
            this.pnlRegister.BackgroundImage = global::DataSmart.Properties.Resources.Top_Back;
            this.pnlRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlRegister.Controls.Add(this.pbShowCon);
            this.pnlRegister.Controls.Add(this.pbShowPass);
            this.pnlRegister.Controls.Add(this.cbCampus);
            this.pnlRegister.Controls.Add(this.pbLogoReigster);
            this.pnlRegister.Controls.Add(this.lblConPass);
            this.pnlRegister.Controls.Add(this.tbConPass);
            this.pnlRegister.Controls.Add(this.lblPassword);
            this.pnlRegister.Controls.Add(this.tbPassword);
            this.pnlRegister.Controls.Add(this.lblUsername);
            this.pnlRegister.Controls.Add(this.tbUsername);
            this.pnlRegister.Controls.Add(this.lblCampus);
            this.pnlRegister.Controls.Add(this.lbllblEmail);
            this.pnlRegister.Controls.Add(this.lblSurname);
            this.pnlRegister.Controls.Add(this.lblName);
            this.pnlRegister.Controls.Add(this.tbEmail);
            this.pnlRegister.Controls.Add(this.tbSurname);
            this.pnlRegister.Controls.Add(this.tbName);
            this.pnlRegister.Controls.Add(this.lblRegisterHeading);
            this.pnlRegister.Location = new System.Drawing.Point(1, 2);
            this.pnlRegister.Name = "pnlRegister";
            this.pnlRegister.Size = new System.Drawing.Size(746, 249);
            this.pnlRegister.TabIndex = 12;
            // 
            // cbCampus
            // 
            this.cbCampus.FormattingEnabled = true;
            this.cbCampus.Items.AddRange(new object[] {
            "PTA",
            "PE",
            "KP"});
            this.cbCampus.Location = new System.Drawing.Point(409, 120);
            this.cbCampus.Name = "cbCampus";
            this.cbCampus.Size = new System.Drawing.Size(154, 21);
            this.cbCampus.TabIndex = 18;
            // 
            // pbLogoReigster
            // 
            this.pbLogoReigster.Image = global::DataSmart.Properties.Resources.DataSmart_Logo;
            this.pbLogoReigster.Location = new System.Drawing.Point(3, 3);
            this.pbLogoReigster.Name = "pbLogoReigster";
            this.pbLogoReigster.Size = new System.Drawing.Size(159, 121);
            this.pbLogoReigster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogoReigster.TabIndex = 17;
            this.pbLogoReigster.TabStop = false;
            // 
            // lblConPass
            // 
            this.lblConPass.AutoSize = true;
            this.lblConPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConPass.Location = new System.Drawing.Point(264, 199);
            this.lblConPass.Name = "lblConPass";
            this.lblConPass.Size = new System.Drawing.Size(119, 16);
            this.lblConPass.TabIndex = 16;
            this.lblConPass.Text = "Confirm Password:";
            // 
            // tbConPass
            // 
            this.tbConPass.Location = new System.Drawing.Point(410, 198);
            this.tbConPass.Name = "tbConPass";
            this.tbConPass.Size = new System.Drawing.Size(153, 20);
            this.tbConPass.TabIndex = 15;
            this.tbConPass.TextChanged += new System.EventHandler(this.tbConPass_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(264, 173);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 16);
            this.lblPassword.TabIndex = 14;
            this.lblPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(410, 172);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(153, 20);
            this.tbPassword.TabIndex = 13;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(264, 147);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(74, 16);
            this.lblUsername.TabIndex = 12;
            this.lblUsername.Text = "Username:";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(410, 146);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.ReadOnly = true;
            this.tbUsername.Size = new System.Drawing.Size(153, 20);
            this.tbUsername.TabIndex = 11;
            this.tbUsername.Click += new System.EventHandler(this.tbUsername_Click);
            // 
            // lblCampus
            // 
            this.lblCampus.AutoSize = true;
            this.lblCampus.BackColor = System.Drawing.Color.Transparent;
            this.lblCampus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCampus.Location = new System.Drawing.Point(264, 120);
            this.lblCampus.Name = "lblCampus";
            this.lblCampus.Size = new System.Drawing.Size(61, 16);
            this.lblCampus.TabIndex = 9;
            this.lblCampus.Text = "Campus:";
            // 
            // lbllblEmail
            // 
            this.lbllblEmail.AutoSize = true;
            this.lbllblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lbllblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllblEmail.Location = new System.Drawing.Point(264, 94);
            this.lbllblEmail.Name = "lbllblEmail";
            this.lbllblEmail.Size = new System.Drawing.Size(45, 16);
            this.lbllblEmail.TabIndex = 7;
            this.lbllblEmail.Text = "Email:";
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.Location = new System.Drawing.Point(264, 67);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(65, 16);
            this.lblSurname.TabIndex = 6;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(264, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(410, 93);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(153, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // tbSurname
            // 
            this.tbSurname.Location = new System.Drawing.Point(411, 66);
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.Size = new System.Drawing.Size(153, 20);
            this.tbSurname.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(410, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(153, 20);
            this.tbName.TabIndex = 1;
            // 
            // lblRegisterHeading
            // 
            this.lblRegisterHeading.AutoSize = true;
            this.lblRegisterHeading.BackColor = System.Drawing.Color.Transparent;
            this.lblRegisterHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHeading.Location = new System.Drawing.Point(340, 5);
            this.lblRegisterHeading.Name = "lblRegisterHeading";
            this.lblRegisterHeading.Size = new System.Drawing.Size(87, 24);
            this.lblRegisterHeading.TabIndex = 0;
            this.lblRegisterHeading.Text = "Register";
            // 
<<<<<<< Updated upstream
            // pbShowPass
            // 
            this.pbShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowPass.Location = new System.Drawing.Point(569, 172);
            this.pbShowPass.Name = "pbShowPass";
            this.pbShowPass.Size = new System.Drawing.Size(22, 20);
            this.pbShowPass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowPass.TabIndex = 19;
            this.pbShowPass.TabStop = false;
            this.pbShowPass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowPass_MouseDown);
            this.pbShowPass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowPass_MouseUp);
            // 
            // pbShowCon
            // 
            this.pbShowCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbShowCon.Location = new System.Drawing.Point(569, 198);
            this.pbShowCon.Name = "pbShowCon";
            this.pbShowCon.Size = new System.Drawing.Size(22, 20);
            this.pbShowCon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbShowCon.TabIndex = 20;
            this.pbShowCon.TabStop = false;
            this.pbShowCon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbShowCon_MouseDown);
            this.pbShowCon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbShowCon_MouseUp);
            // 
=======
>>>>>>> Stashed changes
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 301);
            this.Controls.Add(this.pnlRegister);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnRegBack);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.pnlRegister.ResumeLayout(false);
            this.pnlRegister.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoReigster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowPass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowCon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegBack;
        public System.Windows.Forms.Panel pnlRegister;
        private System.Windows.Forms.PictureBox pbLogoReigster;
        private System.Windows.Forms.Label lblConPass;
        private System.Windows.Forms.TextBox tbConPass;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Label lblCampus;
        private System.Windows.Forms.Label lbllblEmail;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbSurname;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblRegisterHeading;
        private System.Windows.Forms.ComboBox cbCampus;
        private System.Windows.Forms.PictureBox pbShowCon;
        private System.Windows.Forms.PictureBox pbShowPass;
    }
}