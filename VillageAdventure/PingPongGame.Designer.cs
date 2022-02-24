
namespace VillageAdventure
{
    partial class PingPongGame
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
            this.pbx_platformLeft = new System.Windows.Forms.PictureBox();
            this.pbx_platformRight = new System.Windows.Forms.PictureBox();
            this.tmr_moveBall = new System.Windows.Forms.Timer(this.components);
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_close = new System.Windows.Forms.Label();
            this.lbl_restart = new System.Windows.Forms.Label();
            this.tmr_time = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformRight)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_platformLeft
            // 
            this.pbx_platformLeft.BackColor = System.Drawing.Color.Black;
            this.pbx_platformLeft.Location = new System.Drawing.Point(12, 134);
            this.pbx_platformLeft.Name = "pbx_platformLeft";
            this.pbx_platformLeft.Size = new System.Drawing.Size(28, 174);
            this.pbx_platformLeft.TabIndex = 0;
            this.pbx_platformLeft.TabStop = false;
            // 
            // pbx_platformRight
            // 
            this.pbx_platformRight.BackColor = System.Drawing.Color.Black;
            this.pbx_platformRight.Location = new System.Drawing.Point(995, 248);
            this.pbx_platformRight.Name = "pbx_platformRight";
            this.pbx_platformRight.Size = new System.Drawing.Size(28, 174);
            this.pbx_platformRight.TabIndex = 1;
            this.pbx_platformRight.TabStop = false;
            // 
            // tmr_moveBall
            // 
            this.tmr_moveBall.Enabled = true;
            this.tmr_moveBall.Interval = 10;
            this.tmr_moveBall.Tick += new System.EventHandler(this.tmr_moveBall_Tick);
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Location = new System.Drawing.Point(1010, 9);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(13, 13);
            this.lbl_time.TabIndex = 3;
            this.lbl_time.Text = "0";
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(9, 33);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(71, 18);
            this.lbl_close.TabIndex = 7;
            this.lbl_close.Text = "C - Close";
            // 
            // lbl_restart
            // 
            this.lbl_restart.AutoSize = true;
            this.lbl_restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_restart.Location = new System.Drawing.Point(9, 15);
            this.lbl_restart.Name = "lbl_restart";
            this.lbl_restart.Size = new System.Drawing.Size(80, 18);
            this.lbl_restart.TabIndex = 6;
            this.lbl_restart.Text = "R - Restart";
            // 
            // tmr_time
            // 
            this.tmr_time.Enabled = true;
            this.tmr_time.Interval = 360;
            this.tmr_time.Tick += new System.EventHandler(this.tmr_time_Tick);
            // 
            // PingPongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 615);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.lbl_restart);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.pbx_platformRight);
            this.Controls.Add(this.pbx_platformLeft);
            this.Name = "PingPongGame";
            this.Text = "PingPongGame";
            this.Load += new System.EventHandler(this.PingPongGame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.PingPongGame_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.PingPongGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_platformRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_platformLeft;
        private System.Windows.Forms.PictureBox pbx_platformRight;
        private System.Windows.Forms.Timer tmr_moveBall;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Label lbl_restart;
        private System.Windows.Forms.Timer tmr_time;
    }
}