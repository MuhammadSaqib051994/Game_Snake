namespace snake_Game
{
    partial class Game_Form
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
            this.pbcanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelscore = new System.Windows.Forms.Label();
            this.Gametimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcanvas
            // 
            this.pbcanvas.BackColor = System.Drawing.Color.SteelBlue;
            this.pbcanvas.BackgroundImage = global::snake_Game.Properties.Resources.green_background_1371059839NnE;
            this.pbcanvas.InitialImage = null;
            this.pbcanvas.Location = new System.Drawing.Point(4, 49);
            this.pbcanvas.Name = "pbcanvas";
            this.pbcanvas.Size = new System.Drawing.Size(442, 376);
            this.pbcanvas.TabIndex = 0;
            this.pbcanvas.TabStop = false;
            this.pbcanvas.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbcanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbcanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelscore
            // 
            this.labelscore.AutoSize = true;
            this.labelscore.Font = new System.Drawing.Font("Script MT Bold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscore.Location = new System.Drawing.Point(88, 9);
            this.labelscore.Name = "labelscore";
            this.labelscore.Size = new System.Drawing.Size(63, 25);
            this.labelscore.TabIndex = 2;
            this.labelscore.Text = "points";
            this.labelscore.Click += new System.EventHandler(this.labelscore_Click);
            // 
            // Gametimer
            // 
            this.Gametimer.Tick += new System.EventHandler(this.Gametimer_Tick);
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoEllipsis = true;
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGameOver.Font = new System.Drawing.Font("Script MT Bold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblGameOver.Location = new System.Drawing.Point(102, 104);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(140, 31);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "lblGameOver";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGameOver.Visible = false;
            // 
            // Game_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 432);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.labelscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcanvas);
            this.MaximizeBox = false;
            this.Name = "Game_Form";
            this.Text = "Game_Form";
            this.Load += new System.EventHandler(this.Game_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelscore;
        private System.Windows.Forms.Timer Gametimer;
        private System.Windows.Forms.Label lblGameOver;
    }
}

