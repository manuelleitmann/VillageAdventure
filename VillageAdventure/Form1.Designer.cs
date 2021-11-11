
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
            this.pbx_player = new System.Windows.Forms.PictureBox();
            this.tmr_move = new System.Windows.Forms.Timer(this.components);
            this.pbx_platform = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_player
            // 
            this.pbx_player.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_player.Location = new System.Drawing.Point(195, 268);
            this.pbx_player.Name = "pbx_player";
            this.pbx_player.Size = new System.Drawing.Size(67, 91);
            this.pbx_player.TabIndex = 0;
            this.pbx_player.TabStop = false;
            // 
            // tmr_move
            // 
            this.tmr_move.Enabled = true;
            this.tmr_move.Interval = 20;
            this.tmr_move.Tick += new System.EventHandler(this.tmr_move_Tick);
            // 
            // pbx_platform
            // 
            this.pbx_platform.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_platform.Location = new System.Drawing.Point(-1, 534);
            this.pbx_platform.Name = "pbx_platform";
            this.pbx_platform.Size = new System.Drawing.Size(1077, 19);
            this.pbx_platform.TabIndex = 1;
            this.pbx_platform.TabStop = false;
            // 
            // frm_JumpAndRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 552);
            this.Controls.Add(this.pbx_platform);
            this.Controls.Add(this.pbx_player);
            this.Name = "frm_JumpAndRun";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_JumpAndRun_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platform)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_player;
        private System.Windows.Forms.Timer tmr_move;
        private System.Windows.Forms.PictureBox pbx_platform;
    }
}

