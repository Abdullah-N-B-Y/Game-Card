namespace Game1
{
    partial class Form1
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
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.Start_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Game1.Properties.Resources.Welcome_PNG_HD_Image;
            this.pictureBox3.Location = new System.Drawing.Point(271, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(858, 221);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 115;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Game1.Properties.Resources.Smurf3;
            this.pictureBox2.Location = new System.Drawing.Point(144, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(89, 131);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 114;
            this.pictureBox2.TabStop = false;
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.Transparent;
            this.Cancel_Button.BackgroundImage = global::Game1.Properties.Resources.rsz_1rsz_1rsz_x_sign;
            this.Cancel_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cancel_Button.FlatAppearance.BorderSize = 0;
            this.Cancel_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Cancel_Button.Location = new System.Drawing.Point(1301, 41);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(28, 28);
            this.Cancel_Button.TabIndex = 111;
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // Start_Button
            // 
            this.Start_Button.BackColor = System.Drawing.Color.Transparent;
            this.Start_Button.BackgroundImage = global::Game1.Properties.Resources.Start2;
            this.Start_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Start_Button.FlatAppearance.BorderSize = 0;
            this.Start_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Button.ForeColor = System.Drawing.SystemColors.Info;
            this.Start_Button.Location = new System.Drawing.Point(584, 554);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(235, 108);
            this.Start_Button.TabIndex = 116;
            this.Start_Button.UseVisualStyleBackColor = false;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Game1.Properties.Resources.nature_back3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Start_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button Start_Button;
    }
}

