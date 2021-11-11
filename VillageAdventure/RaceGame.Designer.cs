
namespace VillageAdventure
{
    partial class RaceGame
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
            this.pbx_car = new System.Windows.Forms.PictureBox();
            this.pbx_finishLine = new System.Windows.Forms.PictureBox();
            this.pbx_barrierThree = new System.Windows.Forms.PictureBox();
            this.pbx_barrierTwo = new System.Windows.Forms.PictureBox();
            this.pbx_barrierOne = new System.Windows.Forms.PictureBox();
            this.pbx_changeDirection = new System.Windows.Forms.PictureBox();
            this.pbx_enemy = new System.Windows.Forms.PictureBox();
            this.pbx_changeDirection2 = new System.Windows.Forms.PictureBox();
            this.tmr_raceGame = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_finishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_car
            // 
            this.pbx_car.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_car.Location = new System.Drawing.Point(34, 12);
            this.pbx_car.Name = "pbx_car";
            this.pbx_car.Size = new System.Drawing.Size(72, 44);
            this.pbx_car.TabIndex = 4;
            this.pbx_car.TabStop = false;
            // 
            // pbx_finishLine
            // 
            this.pbx_finishLine.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pbx_finishLine.Location = new System.Drawing.Point(-1, 311);
            this.pbx_finishLine.Name = "pbx_finishLine";
            this.pbx_finishLine.Size = new System.Drawing.Size(72, 191);
            this.pbx_finishLine.TabIndex = 3;
            this.pbx_finishLine.TabStop = false;
            // 
            // pbx_barrierThree
            // 
            this.pbx_barrierThree.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_barrierThree.Location = new System.Drawing.Point(-1, 185);
            this.pbx_barrierThree.Name = "pbx_barrierThree";
            this.pbx_barrierThree.Size = new System.Drawing.Size(425, 132);
            this.pbx_barrierThree.TabIndex = 2;
            this.pbx_barrierThree.TabStop = false;
            // 
            // pbx_barrierTwo
            // 
            this.pbx_barrierTwo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_barrierTwo.Location = new System.Drawing.Point(417, 185);
            this.pbx_barrierTwo.Name = "pbx_barrierTwo";
            this.pbx_barrierTwo.Size = new System.Drawing.Size(425, 194);
            this.pbx_barrierTwo.TabIndex = 1;
            this.pbx_barrierTwo.TabStop = false;
            // 
            // pbx_barrierOne
            // 
            this.pbx_barrierOne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_barrierOne.Location = new System.Drawing.Point(-1, 156);
            this.pbx_barrierOne.Name = "pbx_barrierOne";
            this.pbx_barrierOne.Size = new System.Drawing.Size(843, 39);
            this.pbx_barrierOne.TabIndex = 0;
            this.pbx_barrierOne.TabStop = false;
            // 
            // pbx_changeDirection
            // 
            this.pbx_changeDirection.BackColor = System.Drawing.Color.Transparent;
            this.pbx_changeDirection.Location = new System.Drawing.Point(1000, 12);
            this.pbx_changeDirection.Name = "pbx_changeDirection";
            this.pbx_changeDirection.Size = new System.Drawing.Size(53, 471);
            this.pbx_changeDirection.TabIndex = 5;
            this.pbx_changeDirection.TabStop = false;
            // 
            // pbx_enemy
            // 
            this.pbx_enemy.BackColor = System.Drawing.Color.Red;
            this.pbx_enemy.Location = new System.Drawing.Point(34, 88);
            this.pbx_enemy.Name = "pbx_enemy";
            this.pbx_enemy.Size = new System.Drawing.Size(72, 44);
            this.pbx_enemy.TabIndex = 6;
            this.pbx_enemy.TabStop = false;
            // 
            // pbx_changeDirection2
            // 
            this.pbx_changeDirection2.BackColor = System.Drawing.Color.Transparent;
            this.pbx_changeDirection2.Location = new System.Drawing.Point(51, 465);
            this.pbx_changeDirection2.Name = "pbx_changeDirection2";
            this.pbx_changeDirection2.Size = new System.Drawing.Size(967, 37);
            this.pbx_changeDirection2.TabIndex = 7;
            this.pbx_changeDirection2.TabStop = false;
            // 
            // tmr_raceGame
            // 
            this.tmr_raceGame.Enabled = true;
            this.tmr_raceGame.Tick += new System.EventHandler(this.tmr_raceGame_Tick);
            // 
            // RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 495);
            this.Controls.Add(this.pbx_changeDirection2);
            this.Controls.Add(this.pbx_enemy);
            this.Controls.Add(this.pbx_changeDirection);
            this.Controls.Add(this.pbx_car);
            this.Controls.Add(this.pbx_finishLine);
            this.Controls.Add(this.pbx_barrierThree);
            this.Controls.Add(this.pbx_barrierTwo);
            this.Controls.Add(this.pbx_barrierOne);
            this.Name = "RaceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaceGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaceGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_finishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_barrierOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_barrierOne;
        private System.Windows.Forms.PictureBox pbx_barrierTwo;
        private System.Windows.Forms.PictureBox pbx_barrierThree;
        private System.Windows.Forms.PictureBox pbx_finishLine;
        private System.Windows.Forms.PictureBox pbx_car;
        private System.Windows.Forms.PictureBox pbx_changeDirection;
        private System.Windows.Forms.PictureBox pbx_enemy;
        private System.Windows.Forms.PictureBox pbx_changeDirection2;
        private System.Windows.Forms.Timer tmr_raceGame;
    }
}