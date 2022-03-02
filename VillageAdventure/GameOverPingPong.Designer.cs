
namespace VillageAdventure
{
    partial class GameOverPingPong
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
            this.btn_closepp = new System.Windows.Forms.Button();
            this.btn_menupp = new System.Windows.Forms.Button();
            this.btn_restartpp = new System.Windows.Forms.Button();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_closepp
            // 
            this.btn_closepp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_closepp.Location = new System.Drawing.Point(66, 146);
            this.btn_closepp.Name = "btn_closepp";
            this.btn_closepp.Size = new System.Drawing.Size(140, 31);
            this.btn_closepp.TabIndex = 12;
            this.btn_closepp.Text = "Close";
            this.btn_closepp.UseVisualStyleBackColor = true;
            this.btn_closepp.Click += new System.EventHandler(this.btn_closepp_Click);
            // 
            // btn_menupp
            // 
            this.btn_menupp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menupp.Location = new System.Drawing.Point(66, 109);
            this.btn_menupp.Name = "btn_menupp";
            this.btn_menupp.Size = new System.Drawing.Size(140, 31);
            this.btn_menupp.TabIndex = 11;
            this.btn_menupp.Text = "Menu";
            this.btn_menupp.UseVisualStyleBackColor = true;
            this.btn_menupp.Click += new System.EventHandler(this.btn_menupp_Click);
            // 
            // btn_restartpp
            // 
            this.btn_restartpp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_restartpp.Location = new System.Drawing.Point(66, 72);
            this.btn_restartpp.Name = "btn_restartpp";
            this.btn_restartpp.Size = new System.Drawing.Size(140, 31);
            this.btn_restartpp.TabIndex = 10;
            this.btn_restartpp.Text = "Restart";
            this.btn_restartpp.UseVisualStyleBackColor = true;
            this.btn_restartpp.Click += new System.EventHandler(this.btn_restartpp_Click);
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.ForeColor = System.Drawing.Color.Red;
            this.lbl_restart.Location = new System.Drawing.Point(61, 25);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(145, 29);
            this.lbl_restart.TabIndex = 9;
            this.lbl_restart.Text = "Game Over";
            // 
            // GameOverPingPong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 207);
            this.Controls.Add(this.btn_closepp);
            this.Controls.Add(this.btn_menupp);
            this.Controls.Add(this.btn_restartpp);
            this.Controls.Add(this.lbl_restart);
            this.Name = "GameOverPingPong";
            this.Text = "GameOverPingPong";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_closepp;
        private System.Windows.Forms.Button btn_menupp;
        private System.Windows.Forms.Button btn_restartpp;
        private System.Windows.Forms.Label lbl_restart;
    }
}