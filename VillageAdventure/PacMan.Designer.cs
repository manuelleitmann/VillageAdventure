
namespace VillageAdventure
{
    partial class PacMan
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
            this.pbx_pacMan = new System.Windows.Forms.PictureBox();
            this.pbx_prison1 = new System.Windows.Forms.PictureBox();
            this.pbx_prison3 = new System.Windows.Forms.PictureBox();
            this.pbx_prison2 = new System.Windows.Forms.PictureBox();
            this.pbx_door = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_door)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_pacMan
            // 
            this.pbx_pacMan.BackColor = System.Drawing.Color.Yellow;
            this.pbx_pacMan.Location = new System.Drawing.Point(397, 397);
            this.pbx_pacMan.Name = "pbx_pacMan";
            this.pbx_pacMan.Size = new System.Drawing.Size(55, 53);
            this.pbx_pacMan.TabIndex = 0;
            this.pbx_pacMan.TabStop = false;
            // 
            // pbx_prison1
            // 
            this.pbx_prison1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison1.Location = new System.Drawing.Point(299, 326);
            this.pbx_prison1.Name = "pbx_prison1";
            this.pbx_prison1.Size = new System.Drawing.Size(260, 13);
            this.pbx_prison1.TabIndex = 1;
            this.pbx_prison1.TabStop = false;
            // 
            // pbx_prison3
            // 
            this.pbx_prison3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison3.Location = new System.Drawing.Point(299, 209);
            this.pbx_prison3.Name = "pbx_prison3";
            this.pbx_prison3.Size = new System.Drawing.Size(15, 130);
            this.pbx_prison3.TabIndex = 2;
            this.pbx_prison3.TabStop = false;
            // 
            // pbx_prison2
            // 
            this.pbx_prison2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison2.Location = new System.Drawing.Point(544, 209);
            this.pbx_prison2.Name = "pbx_prison2";
            this.pbx_prison2.Size = new System.Drawing.Size(15, 130);
            this.pbx_prison2.TabIndex = 3;
            this.pbx_prison2.TabStop = false;
            // 
            // pbx_door
            // 
            this.pbx_door.BackColor = System.Drawing.Color.Bisque;
            this.pbx_door.Location = new System.Drawing.Point(299, 209);
            this.pbx_door.Name = "pbx_door";
            this.pbx_door.Size = new System.Drawing.Size(260, 13);
            this.pbx_door.TabIndex = 4;
            this.pbx_door.TabStop = false;
            // 
            // PacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(870, 658);
            this.Controls.Add(this.pbx_door);
            this.Controls.Add(this.pbx_prison2);
            this.Controls.Add(this.pbx_prison3);
            this.Controls.Add(this.pbx_prison1);
            this.Controls.Add(this.pbx_pacMan);
            this.Name = "PacMan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PacMan";
            this.Load += new System.EventHandler(this.PacMan_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PacMan_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_door)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_pacMan;
        private System.Windows.Forms.PictureBox pbx_prison1;
        private System.Windows.Forms.PictureBox pbx_prison3;
        private System.Windows.Forms.PictureBox pbx_prison2;
        private System.Windows.Forms.PictureBox pbx_door;
    }
}