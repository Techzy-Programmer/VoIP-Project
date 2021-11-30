
namespace BoltCall.Interactives
{
    partial class AuthBoard
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
            this.TbCtrl = new System.Windows.Forms.TabControl();
            this.TPLogin = new System.Windows.Forms.TabPage();
            this.BtnForgot = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.LLogTitle = new System.Windows.Forms.Label();
            this.LLToken = new System.Windows.Forms.Label();
            this.TBLToken = new System.Windows.Forms.TextBox();
            this.LLPwd = new System.Windows.Forms.Label();
            this.LLEmail = new System.Windows.Forms.Label();
            this.TBLPwd = new System.Windows.Forms.TextBox();
            this.TBLEmail = new System.Windows.Forms.TextBox();
            this.TPRegister = new System.Windows.Forms.TabPage();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.LRAccess = new System.Windows.Forms.Label();
            this.TBRAccess = new System.Windows.Forms.TextBox();
            this.LRegTitle = new System.Windows.Forms.Label();
            this.LRPwd = new System.Windows.Forms.Label();
            this.TBRPwd = new System.Windows.Forms.TextBox();
            this.LREmail = new System.Windows.Forms.Label();
            this.LRName = new System.Windows.Forms.Label();
            this.TBREmail = new System.Windows.Forms.TextBox();
            this.TBRName = new System.Windows.Forms.TextBox();
            this.TbCtrl.SuspendLayout();
            this.TPLogin.SuspendLayout();
            this.TPRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbCtrl
            // 
            this.TbCtrl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TbCtrl.Controls.Add(this.TPLogin);
            this.TbCtrl.Controls.Add(this.TPRegister);
            this.TbCtrl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TbCtrl.HotTrack = true;
            this.TbCtrl.Location = new System.Drawing.Point(0, 0);
            this.TbCtrl.Name = "TbCtrl";
            this.TbCtrl.SelectedIndex = 0;
            this.TbCtrl.Size = new System.Drawing.Size(384, 321);
            this.TbCtrl.TabIndex = 0;
            // 
            // TPLogin
            // 
            this.TPLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(30)))), ((int)(((byte)(25)))));
            this.TPLogin.Controls.Add(this.BtnForgot);
            this.TPLogin.Controls.Add(this.BtnLogin);
            this.TPLogin.Controls.Add(this.LLogTitle);
            this.TPLogin.Controls.Add(this.LLToken);
            this.TPLogin.Controls.Add(this.TBLToken);
            this.TPLogin.Controls.Add(this.LLPwd);
            this.TPLogin.Controls.Add(this.LLEmail);
            this.TPLogin.Controls.Add(this.TBLPwd);
            this.TPLogin.Controls.Add(this.TBLEmail);
            this.TPLogin.Location = new System.Drawing.Point(4, 25);
            this.TPLogin.Name = "TPLogin";
            this.TPLogin.Padding = new System.Windows.Forms.Padding(3);
            this.TPLogin.Size = new System.Drawing.Size(376, 292);
            this.TPLogin.TabIndex = 0;
            this.TPLogin.Text = "Login";
            // 
            // BtnForgot
            // 
            this.BtnForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnForgot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnForgot.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnForgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnForgot.Location = new System.Drawing.Point(20, 248);
            this.BtnForgot.Name = "BtnForgot";
            this.BtnForgot.Size = new System.Drawing.Size(109, 33);
            this.BtnForgot.TabIndex = 12;
            this.BtnForgot.Text = "Forgot?";
            this.BtnForgot.UseVisualStyleBackColor = true;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLogin.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnLogin.Location = new System.Drawing.Point(252, 248);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(104, 33);
            this.BtnLogin.TabIndex = 11;
            this.BtnLogin.Text = "Login";
            this.BtnLogin.UseVisualStyleBackColor = true;
            // 
            // LLogTitle
            // 
            this.LLogTitle.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLogTitle.ForeColor = System.Drawing.Color.Orange;
            this.LLogTitle.Location = new System.Drawing.Point(20, 10);
            this.LLogTitle.Name = "LLogTitle";
            this.LLogTitle.Size = new System.Drawing.Size(336, 24);
            this.LLogTitle.TabIndex = 10;
            this.LLogTitle.Text = "User Login";
            this.LLogTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LLToken
            // 
            this.LLToken.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLToken.ForeColor = System.Drawing.Color.Yellow;
            this.LLToken.Location = new System.Drawing.Point(20, 209);
            this.LLToken.Name = "LLToken";
            this.LLToken.Size = new System.Drawing.Size(336, 19);
            this.LLToken.TabIndex = 9;
            this.LLToken.Text = "Enter Secure Access Token";
            this.LLToken.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBLToken
            // 
            this.TBLToken.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.TBLToken.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLToken.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLToken.ForeColor = System.Drawing.Color.GreenYellow;
            this.TBLToken.Location = new System.Drawing.Point(20, 177);
            this.TBLToken.Name = "TBLToken";
            this.TBLToken.Size = new System.Drawing.Size(336, 29);
            this.TBLToken.TabIndex = 8;
            this.TBLToken.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBLToken.TextChanged += new System.EventHandler(this.TBLToken_TextChanged);
            // 
            // LLPwd
            // 
            this.LLPwd.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLPwd.ForeColor = System.Drawing.Color.Yellow;
            this.LLPwd.Location = new System.Drawing.Point(20, 148);
            this.LLPwd.Name = "LLPwd";
            this.LLPwd.Size = new System.Drawing.Size(336, 19);
            this.LLPwd.TabIndex = 7;
            this.LLPwd.Text = "Please Enter Your Login Password";
            this.LLPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LLEmail
            // 
            this.LLEmail.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LLEmail.ForeColor = System.Drawing.Color.Yellow;
            this.LLEmail.Location = new System.Drawing.Point(20, 87);
            this.LLEmail.Name = "LLEmail";
            this.LLEmail.Size = new System.Drawing.Size(336, 19);
            this.LLEmail.TabIndex = 6;
            this.LLEmail.Text = "Please Enter Your Login Email Address";
            this.LLEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBLPwd
            // 
            this.TBLPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.TBLPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLPwd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLPwd.ForeColor = System.Drawing.Color.GreenYellow;
            this.TBLPwd.Location = new System.Drawing.Point(20, 116);
            this.TBLPwd.Name = "TBLPwd";
            this.TBLPwd.PasswordChar = '*';
            this.TBLPwd.Size = new System.Drawing.Size(336, 29);
            this.TBLPwd.TabIndex = 5;
            this.TBLPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBLPwd.TextChanged += new System.EventHandler(this.TBLPwd_TextChanged);
            // 
            // TBLEmail
            // 
            this.TBLEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.TBLEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBLEmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBLEmail.ForeColor = System.Drawing.Color.GreenYellow;
            this.TBLEmail.Location = new System.Drawing.Point(20, 55);
            this.TBLEmail.Name = "TBLEmail";
            this.TBLEmail.Size = new System.Drawing.Size(336, 29);
            this.TBLEmail.TabIndex = 4;
            this.TBLEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBLEmail.TextChanged += new System.EventHandler(this.TBLEmail_TextChanged);
            // 
            // TPRegister
            // 
            this.TPRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(30)))));
            this.TPRegister.Controls.Add(this.BtnRegister);
            this.TPRegister.Controls.Add(this.LRAccess);
            this.TPRegister.Controls.Add(this.TBRAccess);
            this.TPRegister.Controls.Add(this.LRegTitle);
            this.TPRegister.Controls.Add(this.LRPwd);
            this.TPRegister.Controls.Add(this.TBRPwd);
            this.TPRegister.Controls.Add(this.LREmail);
            this.TPRegister.Controls.Add(this.LRName);
            this.TPRegister.Controls.Add(this.TBREmail);
            this.TPRegister.Controls.Add(this.TBRName);
            this.TPRegister.Location = new System.Drawing.Point(4, 25);
            this.TPRegister.Name = "TPRegister";
            this.TPRegister.Padding = new System.Windows.Forms.Padding(3);
            this.TPRegister.Size = new System.Drawing.Size(376, 292);
            this.TPRegister.TabIndex = 1;
            this.TPRegister.Text = "Register";
            // 
            // BtnRegister
            // 
            this.BtnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegister.Font = new System.Drawing.Font("Courier New", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegister.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.BtnRegister.Location = new System.Drawing.Point(232, 248);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(124, 33);
            this.BtnRegister.TabIndex = 24;
            this.BtnRegister.Text = "Register";
            this.BtnRegister.UseVisualStyleBackColor = true;
            // 
            // LRAccess
            // 
            this.LRAccess.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRAccess.ForeColor = System.Drawing.Color.Yellow;
            this.LRAccess.Location = new System.Drawing.Point(214, 88);
            this.LRAccess.Name = "LRAccess";
            this.LRAccess.Size = new System.Drawing.Size(142, 19);
            this.LRAccess.TabIndex = 23;
            this.LRAccess.Text = "Access Code";
            this.LRAccess.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBRAccess
            // 
            this.TBRAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TBRAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBRAccess.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRAccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBRAccess.Location = new System.Drawing.Point(214, 56);
            this.TBRAccess.Name = "TBRAccess";
            this.TBRAccess.Size = new System.Drawing.Size(142, 29);
            this.TBRAccess.TabIndex = 22;
            this.TBRAccess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LRegTitle
            // 
            this.LRegTitle.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRegTitle.ForeColor = System.Drawing.Color.Orange;
            this.LRegTitle.Location = new System.Drawing.Point(20, 11);
            this.LRegTitle.Name = "LRegTitle";
            this.LRegTitle.Size = new System.Drawing.Size(336, 24);
            this.LRegTitle.TabIndex = 19;
            this.LRegTitle.Text = "User Registration";
            this.LRegTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LRPwd
            // 
            this.LRPwd.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRPwd.ForeColor = System.Drawing.Color.Yellow;
            this.LRPwd.Location = new System.Drawing.Point(20, 210);
            this.LRPwd.Name = "LRPwd";
            this.LRPwd.Size = new System.Drawing.Size(336, 19);
            this.LRPwd.TabIndex = 18;
            this.LRPwd.Text = "Create A Strong Password";
            this.LRPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBRPwd
            // 
            this.TBRPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TBRPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBRPwd.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBRPwd.Location = new System.Drawing.Point(20, 178);
            this.TBRPwd.Name = "TBRPwd";
            this.TBRPwd.PasswordChar = '*';
            this.TBRPwd.Size = new System.Drawing.Size(336, 29);
            this.TBRPwd.TabIndex = 17;
            this.TBRPwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBRPwd.TextChanged += new System.EventHandler(this.TBRPwd_TextChanged);
            // 
            // LREmail
            // 
            this.LREmail.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LREmail.ForeColor = System.Drawing.Color.Yellow;
            this.LREmail.Location = new System.Drawing.Point(20, 149);
            this.LREmail.Name = "LREmail";
            this.LREmail.Size = new System.Drawing.Size(336, 19);
            this.LREmail.TabIndex = 16;
            this.LREmail.Text = "Please Enter Your Email";
            this.LREmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LRName
            // 
            this.LRName.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRName.ForeColor = System.Drawing.Color.Yellow;
            this.LRName.Location = new System.Drawing.Point(20, 88);
            this.LRName.Name = "LRName";
            this.LRName.Size = new System.Drawing.Size(188, 19);
            this.LRName.TabIndex = 15;
            this.LRName.Text = "Please Enter Your Name";
            this.LRName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TBREmail
            // 
            this.TBREmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TBREmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBREmail.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBREmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBREmail.Location = new System.Drawing.Point(20, 117);
            this.TBREmail.Name = "TBREmail";
            this.TBREmail.Size = new System.Drawing.Size(336, 29);
            this.TBREmail.TabIndex = 14;
            this.TBREmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBREmail.TextChanged += new System.EventHandler(this.TBREmail_TextChanged);
            // 
            // TBRName
            // 
            this.TBRName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.TBRName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TBRName.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TBRName.Location = new System.Drawing.Point(20, 56);
            this.TBRName.Name = "TBRName";
            this.TBRName.Size = new System.Drawing.Size(188, 29);
            this.TBRName.TabIndex = 13;
            this.TBRName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TBRName.TextChanged += new System.EventHandler(this.TBRName_TextChanged);
            // 
            // AuthBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(60)))), ((int)(((byte)(80)))));
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.TbCtrl);
            this.Name = "AuthBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Authentication : Bolt-Call";
            this.TbCtrl.ResumeLayout(false);
            this.TPLogin.ResumeLayout(false);
            this.TPLogin.PerformLayout();
            this.TPRegister.ResumeLayout(false);
            this.TPRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TbCtrl;
        private System.Windows.Forms.TabPage TPLogin;
        private System.Windows.Forms.TabPage TPRegister;
        private System.Windows.Forms.Label LLToken;
        private System.Windows.Forms.TextBox TBLToken;
        private System.Windows.Forms.Label LLPwd;
        private System.Windows.Forms.Label LLEmail;
        private System.Windows.Forms.TextBox TBLPwd;
        private System.Windows.Forms.TextBox TBLEmail;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Label LLogTitle;
        private System.Windows.Forms.Label LRegTitle;
        private System.Windows.Forms.Label LRPwd;
        private System.Windows.Forms.TextBox TBRPwd;
        private System.Windows.Forms.Label LREmail;
        private System.Windows.Forms.Label LRName;
        private System.Windows.Forms.TextBox TBREmail;
        private System.Windows.Forms.TextBox TBRName;
        private System.Windows.Forms.Label LRAccess;
        private System.Windows.Forms.TextBox TBRAccess;
        private System.Windows.Forms.Button BtnForgot;
        private System.Windows.Forms.Button BtnRegister;
    }
}