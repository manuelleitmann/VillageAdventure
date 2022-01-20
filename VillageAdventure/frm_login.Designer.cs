
namespace VillageAdventure
{
    partial class frm_login
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
            this.chck_showPassword = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_newaccount = new System.Windows.Forms.Button();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.lbl_header = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pbx_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // chck_showPassword
            // 
            this.chck_showPassword.AutoSize = true;
            this.chck_showPassword.Location = new System.Drawing.Point(43, 286);
            this.chck_showPassword.Margin = new System.Windows.Forms.Padding(4);
            this.chck_showPassword.Name = "chck_showPassword";
            this.chck_showPassword.Size = new System.Drawing.Size(129, 21);
            this.chck_showPassword.TabIndex = 17;
            this.chck_showPassword.Text = "Show Password";
            this.chck_showPassword.UseVisualStyleBackColor = true;
            this.chck_showPassword.CheckedChanged += new System.EventHandler(this.chck_showPassword_CheckedChanged_1);
            // 
            // btn_login
            // 
            this.btn_login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(265, 325);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(191, 63);
            this.btn_login.TabIndex = 16;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click_1);
            // 
            // btn_newaccount
            // 
            this.btn_newaccount.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_newaccount.Location = new System.Drawing.Point(40, 325);
            this.btn_newaccount.Margin = new System.Windows.Forms.Padding(4);
            this.btn_newaccount.Name = "btn_newaccount";
            this.btn_newaccount.Size = new System.Drawing.Size(191, 63);
            this.btn_newaccount.TabIndex = 15;
            this.btn_newaccount.Text = "New Account";
            this.btn_newaccount.UseVisualStyleBackColor = true;
            this.btn_newaccount.Click += new System.EventHandler(this.btn_newaccount_Click_1);
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(192, 227);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(263, 32);
            this.txt_password.TabIndex = 13;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(192, 151);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(263, 32);
            this.txt_username.TabIndex = 12;
            // 
            // lbl_header
            // 
            this.lbl_header.AutoSize = true;
            this.lbl_header.Font = new System.Drawing.Font("Verdana", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_header.Location = new System.Drawing.Point(228, 32);
            this.lbl_header.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_header.Name = "lbl_header";
            this.lbl_header.Size = new System.Drawing.Size(143, 48);
            this.lbl_header.TabIndex = 11;
            this.lbl_header.Text = "Login";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(36, 230);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(122, 25);
            this.lbl_password.TabIndex = 10;
            this.lbl_password.Text = "Password";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(36, 155);
            this.lbl_username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(124, 25);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "Username";
            // 
            // pbx_logo
            // 
            this.pbx_logo.Image = global::VillageAdventure.Properties.Resources.LogoBGremoved;
            this.pbx_logo.Location = new System.Drawing.Point(32, 32);
            this.pbx_logo.Margin = new System.Windows.Forms.Padding(0);
            this.pbx_logo.Name = "pbx_logo";
            this.pbx_logo.Size = new System.Drawing.Size(152, 68);
            this.pbx_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_logo.TabIndex = 14;
            this.pbx_logo.TabStop = false;
            // 
            // frm_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 421);
            this.Controls.Add(this.chck_showPassword);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.btn_newaccount);
            this.Controls.Add(this.pbx_logo);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_header);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Name = "frm_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_login";
            this.Load += new System.EventHandler(this.frm_login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chck_showPassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_newaccount;
        private System.Windows.Forms.PictureBox pbx_logo;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label lbl_header;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_username;
    }
}