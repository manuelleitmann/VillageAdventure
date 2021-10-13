
namespace VillageAdventure
{
    partial class frm_main
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
            this.pbx_background = new System.Windows.Forms.PictureBox();
            this.pbx_fire = new System.Windows.Forms.PictureBox();
            this.pbx_mainCharacter = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_background)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mainCharacter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_background
            // 
            this.pbx_background.Image = global::VillageAdventure.Properties.Resources.Background2;
            this.pbx_background.Location = new System.Drawing.Point(-5, -36);
            this.pbx_background.Name = "pbx_background";
            this.pbx_background.Size = new System.Drawing.Size(560, 716);
            this.pbx_background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_background.TabIndex = 0;
            this.pbx_background.TabStop = false;
            // 
            // pbx_fire
            // 
            this.pbx_fire.BackColor = System.Drawing.Color.Transparent;
            this.pbx_fire.Image = global::VillageAdventure.Properties.Resources.FireGIF;
            this.pbx_fire.Location = new System.Drawing.Point(233, 546);
            this.pbx_fire.Name = "pbx_fire";
            this.pbx_fire.Size = new System.Drawing.Size(89, 42);
            this.pbx_fire.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_fire.TabIndex = 1;
            this.pbx_fire.TabStop = false;
            this.pbx_fire.Click += new System.EventHandler(this.pbx_fire_Click);
            // 
            // pbx_mainCharacter
            // 
            this.pbx_mainCharacter.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pbx_mainCharacter.Location = new System.Drawing.Point(233, 404);
            this.pbx_mainCharacter.Name = "pbx_mainCharacter";
            this.pbx_mainCharacter.Size = new System.Drawing.Size(58, 50);
            this.pbx_mainCharacter.TabIndex = 2;
            this.pbx_mainCharacter.TabStop = false;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 615);
            this.Controls.Add(this.pbx_mainCharacter);
            this.Controls.Add(this.pbx_fire);
            this.Controls.Add(this.pbx_background);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Village Adventure";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_background)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_fire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_mainCharacter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_background;
        private System.Windows.Forms.PictureBox pbx_fire;
        private System.Windows.Forms.PictureBox pbx_mainCharacter;
    }
}

