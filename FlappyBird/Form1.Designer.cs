namespace FlappyBird
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
            this.components = new System.ComponentModel.Container();
            this.pic_bird = new System.Windows.Forms.PictureBox();
            this.pic_pipedown = new System.Windows.Forms.PictureBox();
            this.pic_pipeup = new System.Windows.Forms.PictureBox();
            this.pic_ground = new System.Windows.Forms.PictureBox();
            this.game_timer = new System.Windows.Forms.Timer(this.components);
            this.lbl_score = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pipedown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pipeup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ground)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_bird
            // 
            this.pic_bird.Image = global::FlappyBird.Properties.Resources.bird;
            this.pic_bird.Location = new System.Drawing.Point(104, 322);
            this.pic_bird.Name = "pic_bird";
            this.pic_bird.Size = new System.Drawing.Size(100, 90);
            this.pic_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_bird.TabIndex = 0;
            this.pic_bird.TabStop = false;
            this.pic_bird.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pic_pipedown
            // 
            this.pic_pipedown.Image = global::FlappyBird.Properties.Resources.pipedown;
            this.pic_pipedown.Location = new System.Drawing.Point(882, -3);
            this.pic_pipedown.Name = "pic_pipedown";
            this.pic_pipedown.Size = new System.Drawing.Size(156, 238);
            this.pic_pipedown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pipedown.TabIndex = 1;
            this.pic_pipedown.TabStop = false;
            this.pic_pipedown.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pic_pipeup
            // 
            this.pic_pipeup.Image = global::FlappyBird.Properties.Resources.pipe1;
            this.pic_pipeup.Location = new System.Drawing.Point(680, 463);
            this.pic_pipeup.Name = "pic_pipeup";
            this.pic_pipeup.Size = new System.Drawing.Size(164, 278);
            this.pic_pipeup.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_pipeup.TabIndex = 2;
            this.pic_pipeup.TabStop = false;
            this.pic_pipeup.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pic_ground
            // 
            this.pic_ground.Image = global::FlappyBird.Properties.Resources.ground;
            this.pic_ground.Location = new System.Drawing.Point(3, 732);
            this.pic_ground.Name = "pic_ground";
            this.pic_ground.Size = new System.Drawing.Size(1215, 93);
            this.pic_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_ground.TabIndex = 3;
            this.pic_ground.TabStop = false;
            // 
            // game_timer
            // 
            this.game_timer.Enabled = true;
            this.game_timer.Interval = 20;
            this.game_timer.Tick += new System.EventHandler(this.game_timer_Tick);
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Transparent;
            this.lbl_score.Font = new System.Drawing.Font("Georgia", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_score.Location = new System.Drawing.Point(-5, -3);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(150, 46);
            this.lbl_score.TabIndex = 4;
            this.lbl_score.Text = "Score : ";
            this.lbl_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1216, 827);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.pic_ground);
            this.Controls.Add(this.pic_pipeup);
            this.Controls.Add(this.pic_pipedown);
            this.Controls.Add(this.pic_bird);
            this.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "FlappyBird";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bird_down);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bird_up);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pipedown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pipeup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_bird;
        private System.Windows.Forms.PictureBox pic_pipedown;
        private System.Windows.Forms.PictureBox pic_pipeup;
        private System.Windows.Forms.PictureBox pic_ground;
        private System.Windows.Forms.Timer game_timer;
        private System.Windows.Forms.Label lbl_score;
    }
}

