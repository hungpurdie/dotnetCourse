namespace DotNetCourse
{
    partial class frmCountDown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCountDown));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbldesc = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbldays = new System.Windows.Forms.Label();
            this.lblhours = new System.Windows.Forms.Label();
            this.lblminutes = new System.Windows.Forms.Label();
            this.lblseconds = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.player = new AxWMPLib.AxWindowsMediaPlayer();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Rosewood Std Regular", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Salmon;
            this.lblTitle.Location = new System.Drawing.Point(341, 16);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(215, 43);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "CountDown";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbldesc
            // 
            this.lbldesc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbldesc.AutoSize = true;
            this.lbldesc.BackColor = System.Drawing.Color.Transparent;
            this.lbldesc.Font = new System.Drawing.Font("Tahoma", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbldesc.Location = new System.Drawing.Point(25, 196);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(851, 35);
            this.lbldesc.TabIndex = 0;
            this.lbldesc.Text = "Days                 Hours                 Minutes               Seconds";
            this.lbldesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbldesc.Click += new System.EventHandler(this.lblTimer_Click);
            // 
            // btnStart
            // 
            this.btnStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Font = new System.Drawing.Font("SF Mono", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnStart.ForeColor = System.Drawing.Color.IndianRed;
            this.btnStart.Location = new System.Drawing.Point(377, 336);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(112, 39);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbldays
            // 
            this.lbldays.AutoSize = true;
            this.lbldays.BackColor = System.Drawing.Color.Transparent;
            this.lbldays.Font = new System.Drawing.Font("SF Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbldays.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbldays.Location = new System.Drawing.Point(35, 132);
            this.lbldays.Name = "lbldays";
            this.lbldays.Size = new System.Drawing.Size(97, 38);
            this.lbldays.TabIndex = 4;
            this.lbldays.Text = "yeah";
            // 
            // lblhours
            // 
            this.lblhours.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblhours.AutoSize = true;
            this.lblhours.BackColor = System.Drawing.Color.Transparent;
            this.lblhours.Font = new System.Drawing.Font("SF Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblhours.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblhours.Location = new System.Drawing.Point(268, 132);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(97, 38);
            this.lblhours.TabIndex = 4;
            this.lblhours.Text = "yeah";
            this.lblhours.Click += new System.EventHandler(this.hours_Click);
            // 
            // lblminutes
            // 
            this.lblminutes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblminutes.AutoSize = true;
            this.lblminutes.BackColor = System.Drawing.Color.Transparent;
            this.lblminutes.Font = new System.Drawing.Font("SF Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblminutes.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblminutes.Location = new System.Drawing.Point(520, 132);
            this.lblminutes.Name = "lblminutes";
            this.lblminutes.Size = new System.Drawing.Size(97, 38);
            this.lblminutes.TabIndex = 4;
            this.lblminutes.Text = "yeah";
            // 
            // lblseconds
            // 
            this.lblseconds.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblseconds.AutoSize = true;
            this.lblseconds.BackColor = System.Drawing.Color.Transparent;
            this.lblseconds.Font = new System.Drawing.Font("SF Mono", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblseconds.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lblseconds.Location = new System.Drawing.Point(767, 132);
            this.lblseconds.Name = "lblseconds";
            this.lblseconds.Size = new System.Drawing.Size(97, 38);
            this.lblseconds.TabIndex = 4;
            this.lblseconds.Text = "yeah";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblseconds);
            this.groupBox1.Controls.Add(this.lblminutes);
            this.groupBox1.Controls.Add(this.lblhours);
            this.groupBox1.Controls.Add(this.lbldays);
            this.groupBox1.Controls.Add(this.btnStart);
            this.groupBox1.Controls.Add(this.lbldesc);
            this.groupBox1.Controls.Add(this.lblTitle);
            this.groupBox1.Controls.Add(this.player);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(912, 388);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.Enabled = true;
            this.player.Location = new System.Drawing.Point(0, 0);
            this.player.Name = "player";
            this.player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("player.OcxState")));
            this.player.Size = new System.Drawing.Size(898, 394);
            this.player.TabIndex = 5;
            this.player.UseWaitCursor = true;
            this.player.Visible = false;
            this.player.Enter += new System.EventHandler(this.player_Enter);
            // 
            // frmCountDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DotNetCourse.Properties.Resources._abstract;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCountDown";
            this.Text = "frmCountDown";
            this.Load += new System.EventHandler(this.frmCountDown_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lbldesc;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbldays;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.Label lblminutes;
        private System.Windows.Forms.Label lblseconds;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer player;
    }
}