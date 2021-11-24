
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
            this.pbx_platform = new System.Windows.Forms.PictureBox();
            this.pbx_platform2 = new System.Windows.Forms.PictureBox();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform)).BeginInit();
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
            this.pbx_player.Location = new System.Drawing.Point(302, 213);
            this.pbx_player.Name = "pbx_player";
            this.pbx_player.Size = new System.Drawing.Size(67, 123);
            this.pbx_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_player.TabIndex = 2;
            this.pbx_player.TabStop = false;
            // 
            // pbx_platform
            // 
            this.pbx_platform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_platform.Location = new System.Drawing.Point(12, 160);
            this.pbx_platform.Name = "pbx_platform";
            this.pbx_platform.Size = new System.Drawing.Size(355, 19);
            this.pbx_platform.TabIndex = 1;
            this.pbx_platform.TabStop = false;
            // 
            // pbx_platform2
            // 
            this.pbx_platform2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_platform2.Location = new System.Drawing.Point(415, 476);
            this.pbx_platform2.Name = "pbx_platform2";
            this.pbx_platform2.Size = new System.Drawing.Size(139, 19);
            this.pbx_platform2.TabIndex = 3;
            this.pbx_platform2.TabStop = false;
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
            // frm_JumpAndRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.pbx_platform2);
            this.Controls.Add(this.pbx_player);
            this.Controls.Add(this.pbx_platform);
            this.Name = "frm_JumpAndRun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JumpAndRun";
            this.Load += new System.EventHandler(this.frm_JumpAndRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.PictureBox pbx_platform;
        private System.Windows.Forms.PictureBox pbx_player;
        private System.Windows.Forms.PictureBox pbx_platform2;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Label lbl_close;
    }
}

