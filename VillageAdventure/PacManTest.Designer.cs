
namespace VillageAdventure
{
    partial class PacManTest
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
            this.tmr_moveTest = new System.Windows.Forms.Timer(this.components);
            this.pbx_testPacMan = new System.Windows.Forms.PictureBox();
            this.pbx_testWall = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_testPacMan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_testWall)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_moveTest
            // 
            this.tmr_moveTest.Enabled = true;
            this.tmr_moveTest.Tick += new System.EventHandler(this.tmr_moveTest_Tick);
            // 
            // pbx_testPacMan
            // 
            this.pbx_testPacMan.BackColor = System.Drawing.Color.Yellow;
            this.pbx_testPacMan.Location = new System.Drawing.Point(353, 217);
            this.pbx_testPacMan.Name = "pbx_testPacMan";
            this.pbx_testPacMan.Size = new System.Drawing.Size(58, 57);
            this.pbx_testPacMan.TabIndex = 3;
            this.pbx_testPacMan.TabStop = false;
            // 
            // pbx_testWall
            // 
            this.pbx_testWall.BackColor = System.Drawing.Color.Blue;
            this.pbx_testWall.Location = new System.Drawing.Point(145, 177);
            this.pbx_testWall.Name = "pbx_testWall";
            this.pbx_testWall.Size = new System.Drawing.Size(511, 34);
            this.pbx_testWall.TabIndex = 2;
            this.pbx_testWall.TabStop = false;
            this.pbx_testWall.Tag = "walls";
            // 
            // PacManTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbx_testPacMan);
            this.Controls.Add(this.pbx_testWall);
            this.Name = "PacManTest";
            this.Text = "PacManTest";
            this.Load += new System.EventHandler(this.PacManTest_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PacManTest_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_testPacMan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_testWall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_moveTest;
        private System.Windows.Forms.PictureBox pbx_testPacMan;
        private System.Windows.Forms.PictureBox pbx_testWall;
    }
}