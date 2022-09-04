namespace MediaPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbInfor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.processTimer = new System.Windows.Forms.ProgressBar();
            this.lbStart = new System.Windows.Forms.Label();
            this.lbEnd = new System.Windows.Forms.Label();
            this.trackVolume = new System.Windows.Forms.TrackBar();
            this.btOpen = new System.Windows.Forms.Button();
            this.listTrack = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timerText = new System.Windows.Forms.Timer(this.components);
            this.picMute = new System.Windows.Forms.PictureBox();
            this.picThum = new System.Windows.Forms.PictureBox();
            this.picNext = new System.Windows.Forms.PictureBox();
            this.picForward = new System.Windows.Forms.PictureBox();
            this.picPlay = new System.Windows.Forms.PictureBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // lbInfor
            // 
            this.lbInfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbInfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbInfor.Font = new System.Drawing.Font("Poppins Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInfor.ForeColor = System.Drawing.Color.White;
            this.lbInfor.Location = new System.Drawing.Point(-3, 0);
            this.lbInfor.Name = "lbInfor";
            this.lbInfor.Size = new System.Drawing.Size(935, 45);
            this.lbInfor.TabIndex = 1;
            this.lbInfor.Text = "label1";
            this.lbInfor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(932, 98);
            this.label2.TabIndex = 2;
            // 
            // processTimer
            // 
            this.processTimer.ForeColor = System.Drawing.Color.Black;
            this.processTimer.Location = new System.Drawing.Point(81, 397);
            this.processTimer.Name = "processTimer";
            this.processTimer.Size = new System.Drawing.Size(770, 10);
            this.processTimer.TabIndex = 3;
            this.processTimer.Click += new System.EventHandler(this.processTimer_Click);
            this.processTimer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.processTimer_MouseDown);
            // 
            // lbStart
            // 
            this.lbStart.AutoSize = true;
            this.lbStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbStart.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStart.ForeColor = System.Drawing.Color.White;
            this.lbStart.Location = new System.Drawing.Point(33, 390);
            this.lbStart.Name = "lbStart";
            this.lbStart.Size = new System.Drawing.Size(42, 26);
            this.lbStart.TabIndex = 4;
            this.lbStart.Text = "0:00";
            // 
            // lbEnd
            // 
            this.lbEnd.AutoSize = true;
            this.lbEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.lbEnd.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEnd.ForeColor = System.Drawing.Color.White;
            this.lbEnd.Location = new System.Drawing.Point(857, 390);
            this.lbEnd.Name = "lbEnd";
            this.lbEnd.Size = new System.Drawing.Size(42, 26);
            this.lbEnd.TabIndex = 5;
            this.lbEnd.Text = "0:00";
            this.lbEnd.Click += new System.EventHandler(this.lbEnd_Click);
            // 
            // trackVolume
            // 
            this.trackVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.trackVolume.Location = new System.Drawing.Point(770, 426);
            this.trackVolume.Name = "trackVolume";
            this.trackVolume.Size = new System.Drawing.Size(130, 45);
            this.trackVolume.TabIndex = 10;
            this.trackVolume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.toolTip1.SetToolTip(this.trackVolume, "Volume");
            this.trackVolume.Scroll += new System.EventHandler(this.trackVolume_Scroll);
            // 
            // btOpen
            // 
            this.btOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.btOpen.FlatAppearance.BorderSize = 0;
            this.btOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btOpen.Font = new System.Drawing.Font("Poppins SemiBold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOpen.ForeColor = System.Drawing.Color.White;
            this.btOpen.Location = new System.Drawing.Point(38, 417);
            this.btOpen.Name = "btOpen";
            this.btOpen.Size = new System.Drawing.Size(151, 50);
            this.btOpen.TabIndex = 10;
            this.btOpen.Text = "OPEN";
            this.toolTip1.SetToolTip(this.btOpen, "Open the songs");
            this.btOpen.UseVisualStyleBackColor = false;
            this.btOpen.Click += new System.EventHandler(this.btOpen_Click);
            // 
            // listTrack
            // 
            this.listTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.listTrack.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTrack.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTrack.ForeColor = System.Drawing.Color.White;
            this.listTrack.FormattingEnabled = true;
            this.listTrack.ItemHeight = 26;
            this.listTrack.Location = new System.Drawing.Point(297, 58);
            this.listTrack.Name = "listTrack";
            this.listTrack.Size = new System.Drawing.Size(623, 312);
            this.listTrack.TabIndex = 12;
            this.listTrack.SelectedIndexChanged += new System.EventHandler(this.listTrack_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timerText
            // 
            this.timerText.Enabled = true;
            this.timerText.Interval = 200;
            this.timerText.Tick += new System.EventHandler(this.timerText_Tick);
            // 
            // picMute
            // 
            this.picMute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picMute.Image = global::MediaPlayer.Properties.Resources.mute;
            this.picMute.Location = new System.Drawing.Point(731, 415);
            this.picMute.Name = "picMute";
            this.picMute.Size = new System.Drawing.Size(45, 39);
            this.picMute.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMute.TabIndex = 13;
            this.picMute.TabStop = false;
            this.toolTip1.SetToolTip(this.picMute, "Mute");
            this.picMute.Click += new System.EventHandler(this.picMute_Click);
            // 
            // picThum
            // 
            this.picThum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.picThum.Location = new System.Drawing.Point(12, 57);
            this.picThum.Name = "picThum";
            this.picThum.Size = new System.Drawing.Size(279, 313);
            this.picThum.TabIndex = 11;
            this.picThum.TabStop = false;
            this.toolTip1.SetToolTip(this.picThum, "Thumnail");
            // 
            // picNext
            // 
            this.picNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picNext.Image = global::MediaPlayer.Properties.Resources.next;
            this.picNext.Location = new System.Drawing.Point(508, 413);
            this.picNext.Name = "picNext";
            this.picNext.Size = new System.Drawing.Size(71, 58);
            this.picNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNext.TabIndex = 8;
            this.picNext.TabStop = false;
            this.toolTip1.SetToolTip(this.picNext, "Next");
            this.picNext.Click += new System.EventHandler(this.picNext_Click);
            // 
            // picForward
            // 
            this.picForward.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picForward.Image = global::MediaPlayer.Properties.Resources.forward;
            this.picForward.Location = new System.Drawing.Point(354, 413);
            this.picForward.Name = "picForward";
            this.picForward.Size = new System.Drawing.Size(71, 58);
            this.picForward.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picForward.TabIndex = 7;
            this.picForward.TabStop = false;
            this.toolTip1.SetToolTip(this.picForward, "Forward");
            this.picForward.Click += new System.EventHandler(this.picForward_Click);
            // 
            // picPlay
            // 
            this.picPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPlay.Image = global::MediaPlayer.Properties.Resources.play_music;
            this.picPlay.Location = new System.Drawing.Point(431, 413);
            this.picPlay.Name = "picPlay";
            this.picPlay.Size = new System.Drawing.Size(71, 58);
            this.picPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlay.TabIndex = 6;
            this.picPlay.TabStop = false;
            this.toolTip1.SetToolTip(this.picPlay, "Play / Pause");
            this.picPlay.Click += new System.EventHandler(this.picPlay_Click);
            // 
            // player
            // 
            this.player.Dock = System.Windows.Forms.DockStyle.Top;
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(932, 45);
            this.player.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(77)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(932, 481);
            this.Controls.Add(this.picMute);
            this.Controls.Add(this.listTrack);
            this.Controls.Add(this.picThum);
            this.Controls.Add(this.btOpen);
            this.Controls.Add(this.trackVolume);
            this.Controls.Add(this.picNext);
            this.Controls.Add(this.picForward);
            this.Controls.Add(this.picPlay);
            this.Controls.Add(this.lbEnd);
            this.Controls.Add(this.lbStart);
            this.Controls.Add(this.processTimer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbInfor);
            this.Controls.Add(this.player);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picThum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picForward)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer player;
        private System.Windows.Forms.Label lbInfor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar processTimer;
        private System.Windows.Forms.Label lbStart;
        private System.Windows.Forms.Label lbEnd;
        private System.Windows.Forms.PictureBox picPlay;
        private System.Windows.Forms.PictureBox picForward;
        private System.Windows.Forms.PictureBox picNext;
        private System.Windows.Forms.TrackBar trackVolume;
        private System.Windows.Forms.Button btOpen;
        private System.Windows.Forms.PictureBox picThum;
        private System.Windows.Forms.ListBox listTrack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timerText;
        private System.Windows.Forms.PictureBox picMute;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

