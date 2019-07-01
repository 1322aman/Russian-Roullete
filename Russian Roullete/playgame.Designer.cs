namespace Russian_Roullete
{
    partial class playgame
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
            this.label1 = new System.Windows.Forms.Label();
            this.imagegifplayer = new System.Windows.Forms.PictureBox();
            this.button_load = new System.Windows.Forms.Button();
            this.button_spin = new System.Windows.Forms.Button();
            this.button_shoot = new System.Windows.Forms.Button();
            this.button_shootaway = new System.Windows.Forms.Button();
            this.button_playagain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagegifplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lime;
            this.label1.Font = new System.Drawing.Font("Museo Sans For Dell", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Play Now";
            // 
            // pictureBox1
            // 
            this.imagegifplayer.Location = new System.Drawing.Point(24, 86);
            this.imagegifplayer.Name = "pictureBox1";
            this.imagegifplayer.Size = new System.Drawing.Size(548, 319);
            this.imagegifplayer.TabIndex = 1;
            this.imagegifplayer.TabStop = false;
            // 
            // button_load
            // 
            this.button_load.BackColor = System.Drawing.Color.Lime;
            this.button_load.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_load.Location = new System.Drawing.Point(634, 86);
            this.button_load.Name = "button_load";
            this.button_load.Size = new System.Drawing.Size(104, 40);
            this.button_load.TabIndex = 2;
            this.button_load.Text = "Load";
            this.button_load.UseVisualStyleBackColor = false;
            this.button_load.Click += new System.EventHandler(this.button_load_Click);
            // 
            // button_spin
            // 
            this.button_spin.BackColor = System.Drawing.Color.Lime;
            this.button_spin.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_spin.Location = new System.Drawing.Point(634, 151);
            this.button_spin.Name = "button_spin";
            this.button_spin.Size = new System.Drawing.Size(104, 40);
            this.button_spin.TabIndex = 3;
            this.button_spin.Text = "Spin";
            this.button_spin.UseVisualStyleBackColor = false;
            this.button_spin.Click += new System.EventHandler(this.button_spin_Click);
            // 
            // button_shoot
            // 
            this.button_shoot.BackColor = System.Drawing.Color.Lime;
            this.button_shoot.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shoot.Location = new System.Drawing.Point(634, 221);
            this.button_shoot.Name = "button_shoot";
            this.button_shoot.Size = new System.Drawing.Size(104, 40);
            this.button_shoot.TabIndex = 4;
            this.button_shoot.Text = "Shoot";
            this.button_shoot.UseVisualStyleBackColor = false;
            this.button_shoot.Click += new System.EventHandler(this.button_shoot_Click);
            // 
            // button_shootaway
            // 
            this.button_shootaway.BackColor = System.Drawing.Color.Lime;
            this.button_shootaway.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_shootaway.Location = new System.Drawing.Point(617, 293);
            this.button_shootaway.Name = "button_shootaway";
            this.button_shootaway.Size = new System.Drawing.Size(140, 40);
            this.button_shootaway.TabIndex = 5;
            this.button_shootaway.Text = "Shoot Away";
            this.button_shootaway.UseVisualStyleBackColor = false;
            this.button_shootaway.Click += new System.EventHandler(this.button_shootaway_Click);
            // 
            // button_playagain
            // 
            this.button_playagain.BackColor = System.Drawing.Color.Lime;
            this.button_playagain.Font = new System.Drawing.Font("Museo Sans For Dell", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_playagain.Location = new System.Drawing.Point(617, 365);
            this.button_playagain.Name = "button_playagain";
            this.button_playagain.Size = new System.Drawing.Size(140, 40);
            this.button_playagain.TabIndex = 6;
            this.button_playagain.Text = "Play Again";
            this.button_playagain.UseVisualStyleBackColor = false;
            this.button_playagain.Click += new System.EventHandler(this.button_playagain_Click);
            // 
            // playgame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Russian_Roullete.Properties.Resources.welcome;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_playagain);
            this.Controls.Add(this.button_shootaway);
            this.Controls.Add(this.button_shoot);
            this.Controls.Add(this.button_spin);
            this.Controls.Add(this.button_load);
            this.Controls.Add(this.imagegifplayer);
            this.Controls.Add(this.label1);
            this.Name = "playgame";
            this.Text = "playgame";
            ((System.ComponentModel.ISupportInitialize)(this.imagegifplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagegifplayer;
        private System.Windows.Forms.Button button_load;
        private System.Windows.Forms.Button button_spin;
        private System.Windows.Forms.Button button_shoot;
        private System.Windows.Forms.Button button_shootaway;
        private System.Windows.Forms.Button button_playagain;
    }
}