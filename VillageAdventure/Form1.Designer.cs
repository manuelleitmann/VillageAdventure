
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
            this.pbx_collisionSpawnNew = new System.Windows.Forms.PictureBox();
            this.pbx_reEnable = new System.Windows.Forms.PictureBox();
            this.pbx_reEnableEnd = new System.Windows.Forms.PictureBox();
            this.pbx_collisionSpawnEnd = new System.Windows.Forms.PictureBox();
            this.pbx_platformStart = new System.Windows.Forms.PictureBox();
            this.lbl_time = new System.Windows.Forms.Label();
            this.tmr_removeStart = new System.Windows.Forms.Timer(this.components);
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            this.pbx_collisionGameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionSpawnNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_reEnable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_reEnableEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionSpawnEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionGameOver)).BeginInit();
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
            this.tmr_movePlatforms.Interval = 15;
            this.tmr_movePlatforms.Tick += new System.EventHandler(this.tmr_movePlatforms_Tick);
            // 
            // tmr_movePlayerPlatform
            // 
            this.tmr_movePlayerPlatform.Enabled = true;
            this.tmr_movePlayerPlatform.Interval = 20;
            this.tmr_movePlayerPlatform.Tick += new System.EventHandler(this.tmr_movePlayerPlatform_Tick);
            // 
            // pbx_collisionSpawnNew
            // 
            this.pbx_collisionSpawnNew.BackColor = System.Drawing.Color.Transparent;
            this.pbx_collisionSpawnNew.Location = new System.Drawing.Point(671, -1);
            this.pbx_collisionSpawnNew.Name = "pbx_collisionSpawnNew";
            this.pbx_collisionSpawnNew.Size = new System.Drawing.Size(10, 552);
            this.pbx_collisionSpawnNew.TabIndex = 6;
            this.pbx_collisionSpawnNew.TabStop = false;
            this.pbx_collisionSpawnNew.Visible = false;
            // 
            // pbx_reEnable
            // 
            this.pbx_reEnable.BackColor = System.Drawing.Color.Transparent;
            this.pbx_reEnable.Location = new System.Drawing.Point(460, -1);
            this.pbx_reEnable.Name = "pbx_reEnable";
            this.pbx_reEnable.Size = new System.Drawing.Size(10, 552);
            this.pbx_reEnable.TabIndex = 7;
            this.pbx_reEnable.TabStop = false;
            this.pbx_reEnable.Visible = false;
            // 
            // pbx_reEnableEnd
            // 
            this.pbx_reEnableEnd.BackColor = System.Drawing.Color.Transparent;
            this.pbx_reEnableEnd.Location = new System.Drawing.Point(1, -1);
            this.pbx_reEnableEnd.Name = "pbx_reEnableEnd";
            this.pbx_reEnableEnd.Size = new System.Drawing.Size(10, 552);
            this.pbx_reEnableEnd.TabIndex = 8;
            this.pbx_reEnableEnd.TabStop = false;
            this.pbx_reEnableEnd.Visible = false;
            // 
            // pbx_collisionSpawnEnd
            // 
            this.pbx_collisionSpawnEnd.BackColor = System.Drawing.Color.Transparent;
            this.pbx_collisionSpawnEnd.Location = new System.Drawing.Point(99, -1);
            this.pbx_collisionSpawnEnd.Name = "pbx_collisionSpawnEnd";
            this.pbx_collisionSpawnEnd.Size = new System.Drawing.Size(10, 552);
            this.pbx_collisionSpawnEnd.TabIndex = 9;
            this.pbx_collisionSpawnEnd.TabStop = false;
            this.pbx_collisionSpawnEnd.Visible = false;
            // 
            // pbx_platformStart
            // 
            this.pbx_platformStart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_platformStart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbx_platformStart.Location = new System.Drawing.Point(1, 264);
            this.pbx_platformStart.Name = "pbx_platformStart";
            this.pbx_platformStart.Size = new System.Drawing.Size(161, 19);
            this.pbx_platformStart.TabIndex = 10;
            this.pbx_platformStart.TabStop = false;
            this.pbx_platformStart.Tag = "platform";
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.Location = new System.Drawing.Point(1048, 13);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(16, 18);
            this.lbl_time.TabIndex = 11;
            this.lbl_time.Text = "0";
            // 
            // tmr_removeStart
            // 
            this.tmr_removeStart.Enabled = true;
            this.tmr_removeStart.Tick += new System.EventHandler(this.tmr_removeStart_Tick);
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 350;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // pbx_collisionGameOver
            // 
            this.pbx_collisionGameOver.BackColor = System.Drawing.Color.Transparent;
            this.pbx_collisionGameOver.Location = new System.Drawing.Point(-10, 0);
            this.pbx_collisionGameOver.Name = "pbx_collisionGameOver";
            this.pbx_collisionGameOver.Size = new System.Drawing.Size(10, 552);
            this.pbx_collisionGameOver.TabIndex = 12;
            this.pbx_collisionGameOver.TabStop = false;
            this.pbx_collisionGameOver.Visible = false;
            // 
            // frm_JumpAndRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.pbx_collisionGameOver);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pbx_platformStart);
            this.Controls.Add(this.pbx_collisionSpawnEnd);
            this.Controls.Add(this.pbx_reEnableEnd);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.pbx_platform2);
            this.Controls.Add(this.pbx_player);
            this.Controls.Add(this.pbx_collisionSpawnNew);
            this.Controls.Add(this.pbx_reEnable);
            this.Name = "frm_JumpAndRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpAndRun";
            this.Load += new System.EventHandler(this.frm_JumpAndRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionSpawnNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_reEnable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_reEnableEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionSpawnEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_collisionGameOver)).EndInit();
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
        private System.Windows.Forms.PictureBox pbx_collisionSpawnNew;
        private System.Windows.Forms.PictureBox pbx_reEnable;
        private System.Windows.Forms.PictureBox pbx_reEnableEnd;
        private System.Windows.Forms.PictureBox pbx_collisionSpawnEnd;
        private System.Windows.Forms.PictureBox pbx_platformStart;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Timer tmr_removeStart;
        private System.Windows.Forms.Timer tmr_time;
        private System.Windows.Forms.PictureBox pbx_collisionGameOver;
    }
}

