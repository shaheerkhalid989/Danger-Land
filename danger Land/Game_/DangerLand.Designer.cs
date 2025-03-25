
namespace Game_
{
    partial class DangerLand
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
            this.play = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2CircleButton2 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoadingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.PBar = new CircularProgressBar.CircularProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dlLOOP = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.LoadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.play.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.play.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.play.FillColor = System.Drawing.Color.Transparent;
            this.play.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.Black;
            this.play.Location = new System.Drawing.Point(535, 416);
            this.play.Name = "play";
            this.play.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.play.Size = new System.Drawing.Size(228, 84);
            this.play.TabIndex = 0;
            this.play.Text = "Play";
            this.play.Tile = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // guna2CircleButton2
            // 
            this.guna2CircleButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton2.Font = new System.Drawing.Font("Matura MT Script Capitals", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2CircleButton2.ForeColor = System.Drawing.Color.Black;
            this.guna2CircleButton2.Location = new System.Drawing.Point(123, 416);
            this.guna2CircleButton2.Name = "guna2CircleButton2";
            this.guna2CircleButton2.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton2.Size = new System.Drawing.Size(239, 84);
            this.guna2CircleButton2.TabIndex = 1;
            this.guna2CircleButton2.Text = "Close";
            this.guna2CircleButton2.Tile = false;
            this.guna2CircleButton2.Click += new System.EventHandler(this.guna2CircleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(567, 98);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danger Land";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Game_.Properties.Resources.Ship5_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = global::Game_.Properties.Resources.Ship5_1;
            this.pictureBox1.Location = new System.Drawing.Point(329, 204);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 151);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoadingPanel
            // 
            this.LoadingPanel.BackgroundImage = global::Game_.Properties.Resources.War3;
            this.LoadingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LoadingPanel.Controls.Add(this.PBar);
            this.LoadingPanel.Controls.Add(this.pictureBox2);
            this.LoadingPanel.Controls.Add(this.label2);
            this.LoadingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoadingPanel.Location = new System.Drawing.Point(0, 0);
            this.LoadingPanel.Name = "LoadingPanel";
            this.LoadingPanel.Size = new System.Drawing.Size(893, 594);
            this.LoadingPanel.TabIndex = 4;
            // 
            // PBar
            // 
            this.PBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.PBar.AnimationSpeed = 500;
            this.PBar.BackColor = System.Drawing.Color.Transparent;
            this.PBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PBar.InnerColor = System.Drawing.Color.Navy;
            this.PBar.InnerMargin = 2;
            this.PBar.InnerWidth = -1;
            this.PBar.Location = new System.Drawing.Point(343, 380);
            this.PBar.MarqueeAnimationSpeed = 2000;
            this.PBar.Name = "PBar";
            this.PBar.OuterColor = System.Drawing.Color.Gray;
            this.PBar.OuterMargin = -25;
            this.PBar.OuterWidth = 26;
            this.PBar.ProgressColor = System.Drawing.Color.Blue;
            this.PBar.ProgressWidth = 20;
            this.PBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PBar.Size = new System.Drawing.Size(186, 180);
            this.PBar.StartAngle = 270;
            this.PBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.PBar.SubscriptColor = System.Drawing.Color.WhiteSmoke;
            this.PBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.PBar.SubscriptText = "";
            this.PBar.SuperscriptColor = System.Drawing.Color.WhiteSmoke;
            this.PBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.PBar.SuperscriptText = "";
            this.PBar.TabIndex = 6;
            this.PBar.TextMargin = new System.Windows.Forms.Padding(8);
            this.PBar.Value = 68;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Game_.Properties.Resources.Ship5_1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.InitialImage = global::Game_.Properties.Resources.Ship5_1;
            this.pictureBox2.Location = new System.Drawing.Point(329, 204);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(210, 151);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(567, 98);
            this.label2.TabIndex = 4;
            this.label2.Text = "Danger Land";
            // 
            // dlLOOP
            // 
            this.dlLOOP.Enabled = true;
            this.dlLOOP.Tick += new System.EventHandler(this.dlLOOP_Tick);
            // 
            // DangerLand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_.Properties.Resources.War3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(893, 594);
            this.Controls.Add(this.LoadingPanel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2CircleButton2);
            this.Controls.Add(this.play);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DangerLand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danger Land";
            this.Load += new System.EventHandler(this.DangerLand_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.LoadingPanel.ResumeLayout(false);
            this.LoadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton play;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Panel LoadingPanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer dlLOOP;
        private CircularProgressBar.CircularProgressBar PBar;
    }
}