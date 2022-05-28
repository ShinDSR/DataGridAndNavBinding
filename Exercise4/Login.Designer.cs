
namespace Exercise4
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.btnExit = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.tvLogin = new System.Windows.Forms.Label();
            this.tvUsername = new System.Windows.Forms.Label();
            this.tvPass = new System.Windows.Forms.Label();
            this.txUsername = new System.Windows.Forms.TextBox();
            this.txPass = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.loginPict = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginPict)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(67, 294);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.checkBox.Location = new System.Drawing.Point(116, 235);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(116, 17);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Tern and Condition";
            this.checkBox.UseVisualStyleBackColor = false;
            // 
            // tvLogin
            // 
            this.tvLogin.AutoSize = true;
            this.tvLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tvLogin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tvLogin.Font = new System.Drawing.Font("Algerian", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvLogin.ForeColor = System.Drawing.Color.Navy;
            this.tvLogin.Location = new System.Drawing.Point(148, 87);
            this.tvLogin.Name = "tvLogin";
            this.tvLogin.Size = new System.Drawing.Size(94, 32);
            this.tvLogin.TabIndex = 2;
            this.tvLogin.Text = "Login";
            // 
            // tvUsername
            // 
            this.tvUsername.AutoSize = true;
            this.tvUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tvUsername.Location = new System.Drawing.Point(113, 130);
            this.tvUsername.Name = "tvUsername";
            this.tvUsername.Size = new System.Drawing.Size(55, 13);
            this.tvUsername.TabIndex = 3;
            this.tvUsername.Text = "Username";
            // 
            // tvPass
            // 
            this.tvPass.AutoSize = true;
            this.tvPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tvPass.Location = new System.Drawing.Point(113, 193);
            this.tvPass.Name = "tvPass";
            this.tvPass.Size = new System.Drawing.Size(53, 13);
            this.tvPass.TabIndex = 4;
            this.tvPass.Text = "Password";
            // 
            // txUsername
            // 
            this.txUsername.BackColor = System.Drawing.Color.Navy;
            this.txUsername.ForeColor = System.Drawing.Color.White;
            this.txUsername.Location = new System.Drawing.Point(116, 146);
            this.txUsername.Name = "txUsername";
            this.txUsername.Size = new System.Drawing.Size(152, 20);
            this.txUsername.TabIndex = 5;
            // 
            // txPass
            // 
            this.txPass.BackColor = System.Drawing.Color.Navy;
            this.txPass.ForeColor = System.Drawing.Color.White;
            this.txPass.Location = new System.Drawing.Point(116, 209);
            this.txPass.Name = "txPass";
            this.txPass.Size = new System.Drawing.Size(152, 20);
            this.txPass.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Green;
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(246, 294);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginPict
            // 
            this.loginPict.BackColor = System.Drawing.Color.Transparent;
            this.loginPict.Image = ((System.Drawing.Image)(resources.GetObject("loginPict.Image")));
            this.loginPict.Location = new System.Drawing.Point(148, 3);
            this.loginPict.Name = "loginPict";
            this.loginPict.Size = new System.Drawing.Size(94, 81);
            this.loginPict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginPict.TabIndex = 9;
            this.loginPict.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(382, 371);
            this.Controls.Add(this.loginPict);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txPass);
            this.Controls.Add(this.txUsername);
            this.Controls.Add(this.tvPass);
            this.Controls.Add(this.tvUsername);
            this.Controls.Add(this.tvLogin);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.btnExit);
            this.Name = "Login";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginPict)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label tvLogin;
        private System.Windows.Forms.Label tvUsername;
        private System.Windows.Forms.Label tvPass;
        private System.Windows.Forms.TextBox txUsername;
        private System.Windows.Forms.TextBox txPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox loginPict;
    }
}