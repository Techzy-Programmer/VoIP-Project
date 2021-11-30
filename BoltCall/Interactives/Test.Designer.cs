
namespace BoltCall.Interactives
{
    partial class Test
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
            this.PBDisplay = new System.Windows.Forms.PictureBox();
            this.GBx1 = new System.Windows.Forms.GroupBox();
            this.BtnMicrophone = new System.Windows.Forms.Button();
            this.BtnSystem = new System.Windows.Forms.Button();
            this.BtnAudio = new System.Windows.Forms.Button();
            this.GBx2 = new System.Windows.Forms.GroupBox();
            this.LIndicator = new System.Windows.Forms.Label();
            this.TBFileName = new System.Windows.Forms.TextBox();
            this.BtnRecToggle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBDisplay)).BeginInit();
            this.GBx1.SuspendLayout();
            this.GBx2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBDisplay
            // 
            this.PBDisplay.Location = new System.Drawing.Point(12, 25);
            this.PBDisplay.Name = "PBDisplay";
            this.PBDisplay.Size = new System.Drawing.Size(200, 60);
            this.PBDisplay.TabIndex = 0;
            this.PBDisplay.TabStop = false;
            // 
            // GBx1
            // 
            this.GBx1.Controls.Add(this.BtnMicrophone);
            this.GBx1.Controls.Add(this.BtnSystem);
            this.GBx1.Controls.Add(this.BtnAudio);
            this.GBx1.Controls.Add(this.PBDisplay);
            this.GBx1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx1.ForeColor = System.Drawing.Color.Orange;
            this.GBx1.Location = new System.Drawing.Point(12, 12);
            this.GBx1.Name = "GBx1";
            this.GBx1.Size = new System.Drawing.Size(346, 97);
            this.GBx1.TabIndex = 1;
            this.GBx1.TabStop = false;
            this.GBx1.Text = "FFT Graph Test";
            // 
            // BtnMicrophone
            // 
            this.BtnMicrophone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnMicrophone.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMicrophone.ForeColor = System.Drawing.Color.HotPink;
            this.BtnMicrophone.Location = new System.Drawing.Point(223, 67);
            this.BtnMicrophone.Name = "BtnMicrophone";
            this.BtnMicrophone.Size = new System.Drawing.Size(112, 23);
            this.BtnMicrophone.TabIndex = 3;
            this.BtnMicrophone.Text = "From Microphone";
            this.BtnMicrophone.UseVisualStyleBackColor = true;
            this.BtnMicrophone.Click += new System.EventHandler(this.BtnMicrophone_Click);
            // 
            // BtnSystem
            // 
            this.BtnSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnSystem.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSystem.ForeColor = System.Drawing.Color.HotPink;
            this.BtnSystem.Location = new System.Drawing.Point(223, 39);
            this.BtnSystem.Name = "BtnSystem";
            this.BtnSystem.Size = new System.Drawing.Size(112, 23);
            this.BtnSystem.TabIndex = 2;
            this.BtnSystem.Text = "From System Audio";
            this.BtnSystem.UseVisualStyleBackColor = true;
            this.BtnSystem.Click += new System.EventHandler(this.BtnSystem_Click);
            // 
            // BtnAudio
            // 
            this.BtnAudio.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAudio.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAudio.ForeColor = System.Drawing.Color.HotPink;
            this.BtnAudio.Location = new System.Drawing.Point(223, 10);
            this.BtnAudio.Name = "BtnAudio";
            this.BtnAudio.Size = new System.Drawing.Size(112, 23);
            this.BtnAudio.TabIndex = 1;
            this.BtnAudio.Text = "From Audio File";
            this.BtnAudio.UseVisualStyleBackColor = true;
            this.BtnAudio.Click += new System.EventHandler(this.BtnAudio_Click);
            // 
            // GBx2
            // 
            this.GBx2.Controls.Add(this.LIndicator);
            this.GBx2.Controls.Add(this.TBFileName);
            this.GBx2.Controls.Add(this.BtnRecToggle);
            this.GBx2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GBx2.ForeColor = System.Drawing.Color.Orange;
            this.GBx2.Location = new System.Drawing.Point(12, 115);
            this.GBx2.Name = "GBx2";
            this.GBx2.Size = new System.Drawing.Size(346, 56);
            this.GBx2.TabIndex = 2;
            this.GBx2.TabStop = false;
            this.GBx2.Text = "OPUS Audio Codec Test";
            // 
            // LIndicator
            // 
            this.LIndicator.AutoSize = true;
            this.LIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIndicator.ForeColor = System.Drawing.Color.Yellow;
            this.LIndicator.Location = new System.Drawing.Point(9, 25);
            this.LIndicator.Name = "LIndicator";
            this.LIndicator.Size = new System.Drawing.Size(74, 13);
            this.LIndicator.TabIndex = 4;
            this.LIndicator.Text = "File Name >";
            // 
            // TBFileName
            // 
            this.TBFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(22)))), ((int)(((byte)(44)))));
            this.TBFileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBFileName.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBFileName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.TBFileName.Location = new System.Drawing.Point(99, 20);
            this.TBFileName.Name = "TBFileName";
            this.TBFileName.Size = new System.Drawing.Size(113, 25);
            this.TBFileName.TabIndex = 3;
            this.TBFileName.Text = "Test-Audio.wav";
            this.TBFileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnRecToggle
            // 
            this.BtnRecToggle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnRecToggle.Font = new System.Drawing.Font("Palatino Linotype", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecToggle.ForeColor = System.Drawing.Color.HotPink;
            this.BtnRecToggle.Location = new System.Drawing.Point(223, 22);
            this.BtnRecToggle.Name = "BtnRecToggle";
            this.BtnRecToggle.Size = new System.Drawing.Size(112, 23);
            this.BtnRecToggle.TabIndex = 2;
            this.BtnRecToggle.Tag = "";
            this.BtnRecToggle.Text = "Start Recording";
            this.BtnRecToggle.UseVisualStyleBackColor = true;
            this.BtnRecToggle.Click += new System.EventHandler(this.BtnRecToggle_Click);
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(20)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(370, 183);
            this.Controls.Add(this.GBx2);
            this.Controls.Add(this.GBx1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Test";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoltCall : TestUI";
            ((System.ComponentModel.ISupportInitialize)(this.PBDisplay)).EndInit();
            this.GBx1.ResumeLayout(false);
            this.GBx2.ResumeLayout(false);
            this.GBx2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PBDisplay;
        private System.Windows.Forms.GroupBox GBx1;
        private System.Windows.Forms.Button BtnMicrophone;
        private System.Windows.Forms.Button BtnSystem;
        private System.Windows.Forms.Button BtnAudio;
        private System.Windows.Forms.GroupBox GBx2;
        private System.Windows.Forms.Label LIndicator;
        private System.Windows.Forms.TextBox TBFileName;
        private System.Windows.Forms.Button BtnRecToggle;
    }
}