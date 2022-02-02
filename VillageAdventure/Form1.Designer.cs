
namespace VillageAdventure
{
    partial class frm_JumpAndRun
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tmr_move = new System.Windows.Forms.Timer(this.components);
            this.pbx_player = new System.Windows.Forms.PictureBox();
            this.pbx_platform2 = new System.Windows.Forms.PictureBox();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.tmr_movePlatforms = new System.Windows.Forms.Timer(this.components);
            this.tmr_movePlayerPlatform = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_move
            // 
            this.tmr_move.Enabled = true;
            this.tmr_move.Interval = 20;
            this.tmr_move.Tick += new System.EventHandler(this.tmr_move_Tick);
            // 
            // pbx_player
            // 
            this.pbx_player.Image = global::VillageAdventure.Properties.Resources.PlayerFront;
            this.pbx_player.Location = new System.Drawing.Point(791, 337);
            this.pbx_player.Name = "pbx_player";
            this.pbx_player.Size = new System.Drawing.Size(67, 123);
            this.pbx_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_player.TabIndex = 2;
            this.pbx_player.TabStop = false;
            this.pbx_player.Tag = "player";
            // 
            // pbx_platform2
            // 
            this.pbx_platform2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_platform2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_platform2.Location = new System.Drawing.Point(1, 532);
            this.pbx_platform2.Name = "pbx_platform2";
            this.pbx_platform2.Size = new System.Drawing.Size(1077, 19);
            this.pbx_platform2.TabIndex = 3;
            this.pbx_platform2.TabStop = false;
            this.pbx_platform2.Tag = "platform";
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.Location = new System.Drawing.Point(13, 13);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(80, 18);
            this.lbl_restart.TabIndex = 4;
            this.lbl_restart.Text = "R - Restart";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(13, 31);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(71, 18);
            this.lbl_close.TabIndex = 5;
            this.lbl_close.Text = "C - Close";
            // 
            // tmr_movePlatforms
            // 
            this.tmr_movePlatforms.Enabled = true;
            this.tmr_movePlatforms.Interval = 20;
            this.tmr_movePlatforms.Tick += new System.EventHandler(this.tmr_movePlatforms_Tick);
            // 
            // tmr_movePlayerPlatform
            // 
            this.tmr_movePlayerPlatform.Enabled = true;
            this.tmr_movePlayerPlatform.Interval = 20;
            this.tmr_movePlayerPlatform.Tick += new System.EventHandler(this.tmr_movePlayerPlatform_Tick);
            // 
            // frm_JumpAndRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.pbx_platform2);
            this.Controls.Add(this.pbx_player);
            this.Name = "frm_JumpAndRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpAndRun";
            this.Load += new System.EventHandler(this.frm_JumpAndRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.PictureBox pbx_player;
        private System.Windows.Forms.PictureBox pbx_platform2;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Timer tmr_movePlatforms;
        private System.Windows.Forms.Timer tmr_movePlayerPlatform;
    }
}

