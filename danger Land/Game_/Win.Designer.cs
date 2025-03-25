
namespace Game_
{
    partial class Win
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
            this.Level2Btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.closeBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // Level2Btn
            // 
            this.Level2Btn.BackColor = System.Drawing.Color.Transparent;
            this.Level2Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Level2Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Level2Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Level2Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Level2Btn.FillColor = System.Drawing.Color.Transparent;
            this.Level2Btn.Font = new System.Drawing.Font("Goudy Stout", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Level2Btn.ForeColor = System.Drawing.Color.White;
            this.Level2Btn.Location = new System.Drawing.Point(439, 358);
            this.Level2Btn.Name = "Level2Btn";
            this.Level2Btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Level2Btn.Size = new System.Drawing.Size(369, 68);
            this.Level2Btn.TabIndex = 3;
            this.Level2Btn.Text = "Level 2";
            this.Level2Btn.Click += new System.EventHandler(this.Level2Btn_Click);
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
            this.closeBtn.Location = new System.Drawing.Point(50, 358);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.closeBtn.Size = new System.Drawing.Size(273, 68);
            this.closeBtn.TabIndex = 2;
            this.closeBtn.Text = "Close";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_.Properties.Resources.istockphoto_1184395227_640x640;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(857, 500);
            this.Controls.Add(this.Level2Btn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CircleButton Level2Btn;
        private Guna.UI2.WinForms.Guna2CircleButton closeBtn;
    }
}