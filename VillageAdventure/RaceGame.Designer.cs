
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
            this.tmr_raceGame = new System.Windows.Forms.Timer(this.components);
            this.tmr_left = new System.Windows.Forms.Timer(this.components);
            this.tmr_down = new System.Windows.Forms.Timer(this.components);
            this.pbx_enemy = new System.Windows.Forms.PictureBox();
            this.pbx_car = new System.Windows.Forms.PictureBox();
            this.pbx_street = new System.Windows.Forms.PictureBox();
            this.pbx_changeDirectionLeft = new System.Windows.Forms.PictureBox();
            this.pbx_changeDirection = new System.Windows.Forms.PictureBox();
            this.pbx_finishLine = new System.Windows.Forms.PictureBox();
            this.pbx_backgroundCarGame = new System.Windows.Forms.PictureBox();
            this.pbx_house = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_car)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_street)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirectionLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_finishLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_backgroundCarGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_house)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_raceGame
            // 
            this.tmr_raceGame.Enabled = true;
            this.tmr_raceGame.Tick += new System.EventHandler(this.tmr_raceGame_Tick);
            // 
            // tmr_left
            // 
            this.tmr_left.Tick += new System.EventHandler(this.tmr_left_Tick);
            // 
            // tmr_down
            // 
            this.tmr_down.Tick += new System.EventHandler(this.tmr_down_Tick);
            // 
            // pbx_enemy
            // 
            this.pbx_enemy.BackColor = System.Drawing.Color.Red;
            this.pbx_enemy.Location = new System.Drawing.Point(34, 87);
            this.pbx_enemy.Name = "pbx_enemy";
            this.pbx_enemy.Size = new System.Drawing.Size(72, 44);
            this.pbx_enemy.TabIndex = 6;
            this.pbx_enemy.TabStop = false;
            // 
            // pbx_car
            // 
            this.pbx_car.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_car.Location = new System.Drawing.Point(34, 12);
            this.pbx_car.Name = "pbx_car";
            this.pbx_car.Size = new System.Drawing.Size(72, 44);
            this.pbx_car.TabIndex = 4;
            this.pbx_car.TabStop = false;
            // 
            // pbx_street
            // 
            this.pbx_street.Image = global::VillageAdventure.Properties.Resources.Street;
            this.pbx_street.Location = new System.Drawing.Point(-7, -1);
            this.pbx_street.Name = "pbx_street";
            this.pbx_street.Size = new System.Drawing.Size(638, 628);
            this.pbx_street.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_street.TabIndex = 8;
            this.pbx_street.TabStop = false;
            // 
            // pbx_changeDirectionLeft
            // 
            this.pbx_changeDirectionLeft.BackColor = System.Drawing.Color.Transparent;
            this.pbx_changeDirectionLeft.Location = new System.Drawing.Point(477, 610);
            this.pbx_changeDirectionLeft.Name = "pbx_changeDirectionLeft";
            this.pbx_changeDirectionLeft.Size = new System.Drawing.Size(142, 30);
            this.pbx_changeDirectionLeft.TabIndex = 7;
            this.pbx_changeDirectionLeft.TabStop = false;
            // 
            // pbx_changeDirection
            // 
            this.pbx_changeDirection.BackColor = System.Drawing.Color.Transparent;
            this.pbx_changeDirection.Location = new System.Drawing.Point(607, 12);
            this.pbx_changeDirection.Name = "pbx_changeDirection";
            this.pbx_changeDirection.Size = new System.Drawing.Size(53, 124);
            this.pbx_changeDirection.TabIndex = 5;
            this.pbx_changeDirection.TabStop = false;
            // 
            // pbx_finishLine
            // 
            this.pbx_finishLine.BackColor = System.Drawing.Color.Transparent;
            this.pbx_finishLine.Location = new System.Drawing.Point(-7, 497);
            this.pbx_finishLine.Name = "pbx_finishLine";
            this.pbx_finishLine.Size = new System.Drawing.Size(63, 125);
            this.pbx_finishLine.TabIndex = 3;
            this.pbx_finishLine.TabStop = false;
            // 
            // pbx_backgroundCarGame
            // 
            this.pbx_backgroundCarGame.Image = global::VillageAdventure.Properties.Resources.BackgroundCarGame;
            this.pbx_backgroundCarGame.Location = new System.Drawing.Point(-10, -6);
            this.pbx_backgroundCarGame.Name = "pbx_backgroundCarGame";
            this.pbx_backgroundCarGame.Size = new System.Drawing.Size(638, 628);
            this.pbx_backgroundCarGame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbx_backgroundCarGame.TabIndex = 9;
            this.pbx_backgroundCarGame.TabStop = false;
            // 
            // pbx_house
            // 
            this.pbx_house.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbx_house.Location = new System.Drawing.Point(2, 141);
            this.pbx_house.Name = "pbx_house";
            this.pbx_house.Size = new System.Drawing.Size(466, 335);
            this.pbx_house.TabIndex = 10;
            this.pbx_house.TabStop = false;
            // 
            // RaceGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 620);
            this.Controls.Add(this.pbx_house);
            this.Controls.Add(this.pbx_enemy);
            this.Controls.Add(this.pbx_car);
            this.Controls.Add(this.pbx_street);
            this.Controls.Add(this.pbx_changeDirectionLeft);
            this.Controls.Add(this.pbx_changeDirection);
            this.Controls.Add(this.pbx_finishLine);
            this.Controls.Add(this.pbx_backgroundCarGame);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(634, 659);
            this.MinimumSize = new System.Drawing.Size(634, 659);
            this.Name = "RaceGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RaceGame";
            this.Load += new System.EventHandler(this.RaceGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RaceGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_car)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_street)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirectionLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_changeDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_finishLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_backgroundCarGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_house)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pbx_finishLine;
        private System.Windows.Forms.PictureBox pbx_car;
        private System.Windows.Forms.PictureBox pbx_changeDirection;
        private System.Windows.Forms.PictureBox pbx_enemy;
        private System.Windows.Forms.PictureBox pbx_changeDirectionLeft;
        private System.Windows.Forms.Timer tmr_raceGame;
        private System.Windows.Forms.Timer tmr_left;
        private System.Windows.Forms.Timer tmr_down;
        private System.Windows.Forms.PictureBox pbx_street;
        private System.Windows.Forms.PictureBox pbx_backgroundCarGame;
        private System.Windows.Forms.PictureBox pbx_house;
    }
}