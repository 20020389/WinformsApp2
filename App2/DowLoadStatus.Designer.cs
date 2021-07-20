
namespace App2
{
    partial class DowLoadStatus
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DownloadBar = new CircularProgressBar.CircularProgressBar();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.NameFile = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DownloadBar
            // 
            this.DownloadBar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.DownloadBar.AnimationSpeed = 500;
            this.DownloadBar.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.DownloadBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DownloadBar.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DownloadBar.InnerMargin = 0;
            this.DownloadBar.InnerWidth = -1;
            this.DownloadBar.Location = new System.Drawing.Point(23, 12);
            this.DownloadBar.MarqueeAnimationSpeed = 2000;
            this.DownloadBar.Name = "DownloadBar";
            this.DownloadBar.OuterColor = System.Drawing.Color.White;
            this.DownloadBar.OuterMargin = -26;
            this.DownloadBar.OuterWidth = 26;
            this.DownloadBar.ProgressColor = System.Drawing.Color.Aqua;
            this.DownloadBar.ProgressWidth = 3;
            this.DownloadBar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.DownloadBar.Size = new System.Drawing.Size(54, 54);
            this.DownloadBar.StartAngle = 270;
            this.DownloadBar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.DownloadBar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.DownloadBar.SubscriptText = ".23";
            this.DownloadBar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.DownloadBar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.DownloadBar.SuperscriptText = "°C";
            this.DownloadBar.TabIndex = 0;
            this.DownloadBar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.DownloadBar.Value = 100;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Download;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 25;
            this.iconPictureBox1.Location = new System.Drawing.Point(38, 28);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(25, 25);
            this.iconPictureBox1.TabIndex = 1;
            this.iconPictureBox1.TabStop = false;
            // 
            // NameFile
            // 
            this.NameFile.AutoSize = true;
            this.NameFile.Location = new System.Drawing.Point(102, 33);
            this.NameFile.Name = "NameFile";
            this.NameFile.Size = new System.Drawing.Size(46, 17);
            this.NameFile.TabIndex = 2;
            this.NameFile.Text = "label1";
            // 
            // DowLoadStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.NameFile);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.DownloadBar);
            this.Name = "DowLoadStatus";
            this.Size = new System.Drawing.Size(214, 76);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public CircularProgressBar.CircularProgressBar DownloadBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        public System.Windows.Forms.Label NameFile;
    }
}
