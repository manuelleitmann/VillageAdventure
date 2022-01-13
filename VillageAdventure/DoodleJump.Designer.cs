
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
            this.pbx_character = new System.Windows.Forms.PictureBox();
            this.tmr_falldown = new System.Windows.Forms.Timer(this.components);
            this.tmr_checkbounds = new System.Windows.Forms.Timer(this.components);
            this.pbx_down = new System.Windows.Forms.PictureBox();
            this.pbx_left = new System.Windows.Forms.PictureBox();
            this.tmr_spawnplatform = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_gravity
            // 
            this.tmr_gravity.Enabled = true;
            this.tmr_gravity.Interval = 5;
            this.tmr_gravity.Tick += new System.EventHandler(this.tmr_gravity_Tick);
            // 
            // pbx_character
            // 
            this.pbx_character.BackColor = System.Drawing.Color.Black;
            this.pbx_character.Location = new System.Drawing.Point(133, 326);
            this.pbx_character.Name = "pbx_character";
            this.pbx_character.Size = new System.Drawing.Size(35, 29);
            this.pbx_character.TabIndex = 0;
            this.pbx_character.TabStop = false;
            this.pbx_character.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tmr_falldown
            // 
            this.tmr_falldown.Enabled = true;
            this.tmr_falldown.Interval = 1;
            this.tmr_falldown.Tick += new System.EventHandler(this.tmr_falldown_Tick);
            // 
            // tmr_checkbounds
            // 
            this.tmr_checkbounds.Enabled = true;
            this.tmr_checkbounds.Interval = 1;
            this.tmr_checkbounds.Tick += new System.EventHandler(this.tmr_checkbounds_Tick);
            // 
            // pbx_down
            // 
            this.pbx_down.Location = new System.Drawing.Point(0, 460);
            this.pbx_down.Name = "pbx_down";
            this.pbx_down.Size = new System.Drawing.Size(330, 10);
            this.pbx_down.TabIndex = 1;
            this.pbx_down.TabStop = false;
            this.pbx_down.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // pbx_left
            // 
            this.pbx_left.Location = new System.Drawing.Point(-11, -1);
            this.pbx_left.Name = "pbx_left";
            this.pbx_left.Size = new System.Drawing.Size(10, 453);
            this.pbx_left.TabIndex = 2;
            this.pbx_left.TabStop = false;
            // 
            // tmr_spawnplatform
            // 
            this.tmr_spawnplatform.Enabled = true;
            this.tmr_spawnplatform.Interval = 500;
            this.tmr_spawnplatform.Tick += new System.EventHandler(this.tmr_spawnplatform_Tick);
            // 
            // frm_doodlejump
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 460);
            this.Controls.Add(this.pbx_left);
            this.Controls.Add(this.pbx_down);
            this.Controls.Add(this.pbx_character);
            this.Name = "frm_doodlejump";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doodle Jump";
            this.Load += new System.EventHandler(this.frm_doodlejump_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_doodlejump_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_left)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_character;
        private System.Windows.Forms.Timer tmr_gravity;
        private System.Windows.Forms.Timer tmr_falldown;
        private System.Windows.Forms.Timer tmr_checkbounds;
        private System.Windows.Forms.PictureBox pbx_down;
        private System.Windows.Forms.PictureBox pbx_left;
        private System.Windows.Forms.Timer tmr_spawnplatform;
    }
}