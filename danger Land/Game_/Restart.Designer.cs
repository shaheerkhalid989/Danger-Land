
namespace Game_
{
    partial class Restart
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
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.restartBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.closeBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.closeBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(59, 421);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.Size = new System.Drawing.Size(274, 68);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // restartBtn
            // 
            this.restartBtn.BackColor = System.Drawing.Color.Transparent;
            this.restartBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.restartBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.restartBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.restartBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.restartBtn.FillColor = System.Drawing.Color.Transparent;
            this.restartBtn.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.restartBtn.ForeColor = System.Drawing.Color.White;
            this.restartBtn.Location = new System.Drawing.Point(417, 421);
            this.restartBtn.Name = "restartBtn";
            this.restartBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.restartBtn.Size = new System.Drawing.Size(408, 68);
            this.restartBtn.TabIndex = 1;
            this.restartBtn.Text = "Restart";
            this.restartBtn.Click += new System.EventHandler(this.restartBtn_Click);
            // 
            // Restart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_.Properties.Resources.artworks_000100951712_0ue5ck_t500x500;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(875, 547);
            this.Controls.Add(this.restartBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Restart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restart";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
        private Guna.UI2.WinForms.Guna2CircleButton restartBtn;
    }
}