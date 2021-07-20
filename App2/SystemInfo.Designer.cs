
namespace App2
{
    partial class SystemInfo
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
            this.Bar1 = new CircularProgressBar.CircularProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // Bar1
            // 
            this.Bar1.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Bar1.AnimationSpeed = 500;
            this.Bar1.BackColor = System.Drawing.Color.Transparent;
            this.Bar1.Font = new System.Drawing.Font("Magneto", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bar1.ForeColor = System.Drawing.Color.White;
            this.Bar1.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(75)))));
            this.Bar1.InnerMargin = 0;
            this.Bar1.InnerWidth = -1;
            this.Bar1.Location = new System.Drawing.Point(13, 18);
            this.Bar1.MarqueeAnimationSpeed = 2000;
            this.Bar1.Name = "Bar1";
            this.Bar1.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Bar1.OuterMargin = -40;
            this.Bar1.OuterWidth = 40;
            this.Bar1.ProgressColor = System.Drawing.Color.MediumSlateBlue;
            this.Bar1.ProgressWidth = 39;
            this.Bar1.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Bar1.Size = new System.Drawing.Size(212, 212);
            this.Bar1.StartAngle = 180;
            this.Bar1.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar1.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Bar1.SubscriptText = "";
            this.Bar1.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Bar1.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Bar1.SuperscriptText = "";
            this.Bar1.TabIndex = 0;
            this.Bar1.Text = "32%";
            this.Bar1.TextMargin = new System.Windows.Forms.Padding(0, -20, 0, 0);
            this.Bar1.Value = 16;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(-28, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(299, 105);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "0                                       100";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(100, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ram Usage";
            // 
            // SystemInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Bar1);
            this.Name = "SystemInfo";
            this.Size = new System.Drawing.Size(332, 311);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public CircularProgressBar.CircularProgressBar Bar1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label label2;
    }
}
