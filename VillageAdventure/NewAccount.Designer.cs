
namespace VillageAdventure
{
    partial class frm_newAccount
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
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_password1 = new System.Windows.Forms.TextBox();
            this.txt_usernameRegister = new System.Windows.Forms.TextBox();
            this.lbl_Register = new System.Windows.Forms.Label();
            this.lbl_password1 = new System.Windows.Forms.Label();
            this.lbl_usernameRegister = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.lbl_password2 = new System.Windows.Forms.Label();
            this.chck_showPasswordRegister = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_register
            // 
            this.btn_register.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(29, 318);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(312, 51);
            this.btn_register.TabIndex = 15;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // txt_password1
            // 
            this.txt_password1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password1.Location = new System.Drawing.Point(143, 181);
            this.txt_password1.Name = "txt_password1";
            this.txt_password1.Size = new System.Drawing.Size(198, 27);
            this.txt_password1.TabIndex = 12;
            this.txt_password1.UseSystemPasswordChar = true;
            // 
            // txt_usernameRegister
            // 
            this.txt_usernameRegister.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usernameRegister.Location = new System.Drawing.Point(143, 120);
            this.txt_usernameRegister.Name = "txt_usernameRegister";
            this.txt_usernameRegister.Size = new System.Drawing.Size(198, 27);
            this.txt_usernameRegister.TabIndex = 11;
            // 
            // lbl_Register
            // 
            this.lbl_Register.AutoSize = true;
            this.lbl_Register.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Register.Location = new System.Drawing.Point(170, 23);
            this.lbl_Register.Name = "lbl_Register";
            this.lbl_Register.Size = new System.Drawing.Size(167, 38);
            this.lbl_Register.TabIndex = 10;
            this.lbl_Register.Text = "Register";
            // 
            // lbl_password1
            // 
            this.lbl_password1.AutoSize = true;
            this.lbl_password1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password1.Location = new System.Drawing.Point(26, 184);
            this.lbl_password1.Name = "lbl_password1";
            this.lbl_password1.Size = new System.Drawing.Size(95, 18);
            this.lbl_password1.TabIndex = 9;
            this.lbl_password1.Text = "Password";
            // 
            // lbl_usernameRegister
            // 
            this.lbl_usernameRegister.AutoSize = true;
            this.lbl_usernameRegister.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernameRegister.Location = new System.Drawing.Point(26, 123);
            this.lbl_usernameRegister.Name = "lbl_usernameRegister";
            this.lbl_usernameRegister.Size = new System.Drawing.Size(98, 18);
            this.lbl_usernameRegister.TabIndex = 8;
            this.lbl_usernameRegister.Text = "Username";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::VillageAdventure.Properties.Resources.Logo;
            this.pbx_logo.Location = new System.Drawing.Point(23, 23);
            this.pbx_logo.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(114, 55);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 13;
            this.pbx_logo.TabStop = false;
            // 
            // txt_password2
            // 
            this.txt_password2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password2.Location = new System.Drawing.Point(143, 247);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(198, 27);
            this.txt_password2.TabIndex = 13;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // lbl_password2
            // 
            this.lbl_password2.AutoSize = true;
            this.lbl_password2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password2.Location = new System.Drawing.Point(26, 238);
            this.lbl_password2.Name = "lbl_password2";
            this.lbl_password2.Size = new System.Drawing.Size(95, 36);
            this.lbl_password2.TabIndex = 16;
            this.lbl_password2.Text = "Repeat\r\nPassword";
            // 
            // chck_showPasswordRegister
            // 
            this.chck_showPasswordRegister.AutoSize = true;
            this.chck_showPasswordRegister.Location = new System.Drawing.Point(29, 295);
            this.chck_showPasswordRegister.Name = "chck_showPasswordRegister";
            this.chck_showPasswordRegister.Size = new System.Drawing.Size(107, 17);
            this.chck_showPasswordRegister.TabIndex = 18;
            this.chck_showPasswordRegister.Text = "Show Passwords";
            this.chck_showPasswordRegister.UseVisualStyleBackColor = true;
            this.chck_showPasswordRegister.CheckedChanged += new System.EventHandler(this.chck_showPasswordRegister_CheckedChanged);
            // 
            // frm_newAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(386, 398);
            this.Controls.Add(this.chck_showPasswordRegister);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.lbl_password2);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.pbx_logo);
            this.Controls.Add(this.txt_password1);
            this.Controls.Add(this.txt_usernameRegister);
            this.Controls.Add(this.lbl_Register);
            this.Controls.Add(this.lbl_password1);
            this.Controls.Add(this.lbl_usernameRegister);
            this.Name = "frm_newAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Account";
            this.Load += new System.EventHandler(this.frm_newAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.TextBox txt_password1;
        private System.Windows.Forms.TextBox txt_usernameRegister;
        private System.Windows.Forms.Label lbl_Register;
        private System.Windows.Forms.Label lbl_password1;
        private System.Windows.Forms.Label lbl_usernameRegister;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.Label lbl_password2;
        private System.Windows.Forms.CheckBox chck_showPasswordRegister;
    }
}