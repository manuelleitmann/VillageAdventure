namespace VillageAdventure
{
    partial class frm_doodlejump
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
            this.components = new System.ComponentModel.Container();
            this.tmr_gravity = new System.Windows.Forms.Timer(this.components);
            this.tmr_falldown = new System.Windows.Forms.Timer(this.components);
            this.tmr_checkbounds = new System.Windows.Forms.Timer(this.components);
            this.tmr_spawnplatform = new System.Windows.Forms.Timer(this.components);
            this.pbx_left = new System.Windows.Forms.PictureBox();
            this.pbx_down = new System.Windows.Forms.PictureBox();
            this.pbx_character = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_gravity
            // 
            this.tmr_gravity.Enabled = true;
            this.tmr_gravity.Interval = 5;
            this.tmr_gravity.Tick += new System.EventHandler(this.tmr_gravity_Tick_1);
            // 
            // tmr_falldown
            // 
            this.tmr_falldown.Enabled = true;
            this.tmr_falldown.Interval = 1;
            this.tmr_falldown.Tick += new System.EventHandler(this.tmr_falldown_Tick_1);
            // 
            // tmr_checkbounds
            // 
            this.tmr_checkbounds.Enabled = true;
            this.tmr_checkbounds.Interval = 1;
            this.tmr_checkbounds.Tick += new System.EventHandler(this.tmr_checkbounds_Tick_1);
            // 
            // tmr_spawnplatform
            // 
            this.tmr_spawnplatform.Enabled = true;
            this.tmr_spawnplatform.Interval = 25;
            this.tmr_spawnplatform.Tick += new System.EventHandler(this.tmr_spawnplatform_Tick_1);
            // 
            // pbx_left
            // 
            this.pbx_left.Location = new System.Drawing.Point(-13, -6);
            this.pbx_left.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_left.Name = "pbx_left";
            this.pbx_left.Size = new System.Drawing.Size(13, 558);
            this.pbx_left.TabIndex = 5;
            this.pbx_left.TabStop = false;
            // 
            // pbx_down
            // 
            this.pbx_down.Location = new System.Drawing.Point(7, 566);
            this.pbx_down.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_down.Name = "pbx_down";
            this.pbx_down.Size = new System.Drawing.Size(440, 12);
            this.pbx_down.TabIndex = 4;
            this.pbx_down.TabStop = false;
            // 
            // pbx_character
            // 
            this.pbx_character.BackColor = System.Drawing.Color.Black;
            this.pbx_character.Location = new System.Drawing.Point(184, 396);
            this.pbx_character.Margin = new System.Windows.Forms.Padding(4);
            this.pbx_character.Name = "pbx_character";
            this.pbx_character.Size = new System.Drawing.Size(47, 36);
            this.pbx_character.TabIndex = 3;
            this.pbx_character.TabStop = false;
            // 
            // frm_doodlejump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(439, 566);
            this.Controls.Add(this.pbx_left);
            this.Controls.Add(this.pbx_down);
            this.Controls.Add(this.pbx_character);
            this.Name = "frm_doodlejump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doodlejump";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_doodlejump_FormClosed);
            this.Load += new System.EventHandler(this.frm_doodlejump_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_doodlejump_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_left;
        private System.Windows.Forms.PictureBox pbx_down;
        private System.Windows.Forms.PictureBox pbx_character;
        private System.Windows.Forms.Timer tmr_gravity;
        private System.Windows.Forms.Timer tmr_falldown;
        private System.Windows.Forms.Timer tmr_checkbounds;
        private System.Windows.Forms.Timer tmr_spawnplatform;
    }
}