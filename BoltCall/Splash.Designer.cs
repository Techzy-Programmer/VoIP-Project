
namespace BoltCall
{
    partial class Splash
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
            this.LTitle = new System.Windows.Forms.Label();
            this.LAnims = new System.Windows.Forms.Label();
            this.LStatus = new System.Windows.Forms.Label();
            this.LSubTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LTitle
            // 
            this.LTitle.Font = new System.Drawing.Font("Consolas", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(160)))));
            this.LTitle.Location = new System.Drawing.Point(12, 6);
            this.LTitle.Name = "LTitle";
            this.LTitle.Size = new System.Drawing.Size(336, 36);
            this.LTitle.TabIndex = 0;
            this.LTitle.Text = "B O L T - C A L L";
            this.LTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LAnims
            // 
            this.LAnims.Font = new System.Drawing.Font("Impact", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAnims.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.LAnims.Location = new System.Drawing.Point(0, 142);
            this.LAnims.Margin = new System.Windows.Forms.Padding(3, 0, 3, 5);
            this.LAnims.Name = "LAnims";
            this.LAnims.Size = new System.Drawing.Size(360, 20);
            this.LAnims.TabIndex = 3;
            this.LAnims.Text = ".";
            this.LAnims.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LAnims.UseCompatibleTextRendering = true;
            // 
            // LStatus
            // 
            this.LStatus.Font = new System.Drawing.Font("Ink Free", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LStatus.Location = new System.Drawing.Point(12, 132);
            this.LStatus.Name = "LStatus";
            this.LStatus.Size = new System.Drawing.Size(336, 22);
            this.LStatus.TabIndex = 4;
            this.LStatus.Text = "Initializing The Program......";
            this.LStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LSubTitle
            // 
            this.LSubTitle.Font = new System.Drawing.Font("Lucida Console", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LSubTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.LSubTitle.Location = new System.Drawing.Point(12, 35);
            this.LSubTitle.Name = "LSubTitle";
            this.LSubTitle.Size = new System.Drawing.Size(336, 16);
            this.LSubTitle.TabIndex = 5;
            this.LSubTitle.Text = "Lightning Fast Calling Application";
            this.LSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(360, 160);
            this.Controls.Add(this.LSubTitle);
            this.Controls.Add(this.LStatus);
            this.Controls.Add(this.LAnims);
            this.Controls.Add(this.LTitle);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Splash";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BoltCall : Splash (Loading)";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LTitle;
        private System.Windows.Forms.Label LAnims;
        private System.Windows.Forms.Label LStatus;
        private System.Windows.Forms.Label LSubTitle;
    }
}

