
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
            this.components = new System.ComponentModel.Container();
            this.pbx_pacMan = new System.Windows.Forms.PictureBox();
            this.pbx_prison1 = new System.Windows.Forms.PictureBox();
            this.pbx_prison3 = new System.Windows.Forms.PictureBox();
            this.pbx_prison2 = new System.Windows.Forms.PictureBox();
            this.pbx_door = new System.Windows.Forms.PictureBox();
            this.pbx_ghost1 = new System.Windows.Forms.PictureBox();
            this.pbx_ghost2 = new System.Windows.Forms.PictureBox();
            this.pbx_ghost3 = new System.Windows.Forms.PictureBox();
            this.pbx_wall1 = new System.Windows.Forms.PictureBox();
            this.pbx_wall2 = new System.Windows.Forms.PictureBox();
            this.pbx_wall3 = new System.Windows.Forms.PictureBox();
            this.pbx_wall4 = new System.Windows.Forms.PictureBox();
            this.tmr_PacManLeft = new System.Windows.Forms.Timer(this.components);
            this.tmr_PacManUp = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_pacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_prison2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_door)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall4)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_pacMan
            // 
            this.pbx_pacMan.BackColor = System.Drawing.Color.Yellow;
            this.pbx_pacMan.Location = new System.Drawing.Point(602, 345);
            this.pbx_pacMan.Name = "pbx_pacMan";
            this.pbx_pacMan.Size = new System.Drawing.Size(55, 53);
            this.pbx_pacMan.TabIndex = 0;
            this.pbx_pacMan.TabStop = false;
            // 
            // pbx_prison1
            // 
            this.pbx_prison1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison1.Location = new System.Drawing.Point(343, 326);
            this.pbx_prison1.Name = "pbx_prison1";
            this.pbx_prison1.Size = new System.Drawing.Size(175, 13);
            this.pbx_prison1.TabIndex = 1;
            this.pbx_prison1.TabStop = false;
            // 
            // pbx_prison3
            // 
            this.pbx_prison3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison3.Location = new System.Drawing.Point(343, 209);
            this.pbx_prison3.Name = "pbx_prison3";
            this.pbx_prison3.Size = new System.Drawing.Size(15, 130);
            this.pbx_prison3.TabIndex = 2;
            this.pbx_prison3.TabStop = false;
            // 
            // pbx_prison2
            // 
            this.pbx_prison2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_prison2.Location = new System.Drawing.Point(503, 209);
            this.pbx_prison2.Name = "pbx_prison2";
            this.pbx_prison2.Size = new System.Drawing.Size(15, 130);
            this.pbx_prison2.TabIndex = 3;
            this.pbx_prison2.TabStop = false;
            // 
            // pbx_door
            // 
            this.pbx_door.BackColor = System.Drawing.Color.Bisque;
            this.pbx_door.Location = new System.Drawing.Point(343, 209);
            this.pbx_door.Name = "pbx_door";
            this.pbx_door.Size = new System.Drawing.Size(175, 13);
            this.pbx_door.TabIndex = 4;
            this.pbx_door.TabStop = false;
            // 
            // pbx_ghost1
            // 
            this.pbx_ghost1.BackColor = System.Drawing.Color.Chartreuse;
            this.pbx_ghost1.Location = new System.Drawing.Point(375, 244);
            this.pbx_ghost1.Name = "pbx_ghost1";
            this.pbx_ghost1.Size = new System.Drawing.Size(33, 38);
            this.pbx_ghost1.TabIndex = 5;
            this.pbx_ghost1.TabStop = false;
            // 
            // pbx_ghost2
            // 
            this.pbx_ghost2.BackColor = System.Drawing.Color.Fuchsia;
            this.pbx_ghost2.Location = new System.Drawing.Point(419, 282);
            this.pbx_ghost2.Name = "pbx_ghost2";
            this.pbx_ghost2.Size = new System.Drawing.Size(33, 38);
            this.pbx_ghost2.TabIndex = 6;
            this.pbx_ghost2.TabStop = false;
            // 
            // pbx_ghost3
            // 
            this.pbx_ghost3.BackColor = System.Drawing.Color.Aqua;
            this.pbx_ghost3.Location = new System.Drawing.Point(445, 228);
            this.pbx_ghost3.Name = "pbx_ghost3";
            this.pbx_ghost3.Size = new System.Drawing.Size(33, 38);
            this.pbx_ghost3.TabIndex = 7;
            this.pbx_ghost3.TabStop = false;
            // 
            // pbx_wall1
            // 
            this.pbx_wall1.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_wall1.Location = new System.Drawing.Point(503, 326);
            this.pbx_wall1.Name = "pbx_wall1";
            this.pbx_wall1.Size = new System.Drawing.Size(175, 13);
            this.pbx_wall1.TabIndex = 8;
            this.pbx_wall1.TabStop = false;
            // 
            // pbx_wall2
            // 
            this.pbx_wall2.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_wall2.Location = new System.Drawing.Point(274, 404);
            this.pbx_wall2.Name = "pbx_wall2";
            this.pbx_wall2.Size = new System.Drawing.Size(404, 10);
            this.pbx_wall2.TabIndex = 9;
            this.pbx_wall2.TabStop = false;
            // 
            // pbx_wall3
            // 
            this.pbx_wall3.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_wall3.Location = new System.Drawing.Point(663, 326);
            this.pbx_wall3.Name = "pbx_wall3";
            this.pbx_wall3.Size = new System.Drawing.Size(15, 88);
            this.pbx_wall3.TabIndex = 10;
            this.pbx_wall3.TabStop = false;
            // 
            // pbx_wall4
            // 
            this.pbx_wall4.BackColor = System.Drawing.Color.MidnightBlue;
            this.pbx_wall4.Location = new System.Drawing.Point(261, 117);
            this.pbx_wall4.Name = "pbx_wall4";
            this.pbx_wall4.Size = new System.Drawing.Size(15, 297);
            this.pbx_wall4.TabIndex = 11;
            this.pbx_wall4.TabStop = false;
            // 
            // tmr_PacManLeft
            // 
            this.tmr_PacManLeft.Tick += new System.EventHandler(this.tmr_PacManLeft_Tick);
            // 
            // tmr_PacManUp
            // 
            this.tmr_PacManUp.Tick += new System.EventHandler(this.tmr_PacManUp_Tick);
            // 
            // PacMan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(870, 658);
            this.Controls.Add(this.pbx_wall4);
            this.Controls.Add(this.pbx_wall3);
            this.Controls.Add(this.pbx_wall2);
            this.Controls.Add(this.pbx_wall1);
            this.Controls.Add(this.pbx_ghost3);
            this.Controls.Add(this.pbx_ghost2);
            this.Controls.Add(this.pbx_ghost1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_ghost3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_wall4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_pacMan;
        private System.Windows.Forms.PictureBox pbx_prison1;
        private System.Windows.Forms.PictureBox pbx_prison3;
        private System.Windows.Forms.PictureBox pbx_prison2;
        private System.Windows.Forms.PictureBox pbx_door;
        private System.Windows.Forms.PictureBox pbx_ghost1;
        private System.Windows.Forms.PictureBox pbx_ghost2;
        private System.Windows.Forms.PictureBox pbx_ghost3;
        private System.Windows.Forms.PictureBox pbx_wall1;
        private System.Windows.Forms.PictureBox pbx_wall2;
        private System.Windows.Forms.PictureBox pbx_wall3;
        private System.Windows.Forms.PictureBox pbx_wall4;
        private System.Windows.Forms.Timer tmr_PacManLeft;
        private System.Windows.Forms.Timer tmr_PacManUp;
    }
}