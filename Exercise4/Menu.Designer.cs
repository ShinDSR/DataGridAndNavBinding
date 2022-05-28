
namespace Exercise4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.btnMBack = new System.Windows.Forms.Button();
            this.tvMenu = new System.Windows.Forms.Label();
            this.tvMGrid = new System.Windows.Forms.Label();
            this.tvMNav = new System.Windows.Forms.Label();
            this.pictGrid = new System.Windows.Forms.PictureBox();
            this.pictNav = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictNav)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMBack
            // 
            this.btnMBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnMBack.ForeColor = System.Drawing.Color.White;
            this.btnMBack.Location = new System.Drawing.Point(38, 265);
            this.btnMBack.Name = "btnMBack";
            this.btnMBack.Size = new System.Drawing.Size(75, 23);
            this.btnMBack.TabIndex = 0;
            this.btnMBack.Text = "Back";
            this.btnMBack.UseVisualStyleBackColor = false;
            this.btnMBack.Click += new System.EventHandler(this.btnMBack_Click);
            // 
            // tvMenu
            // 
            this.tvMenu.AutoSize = true;
            this.tvMenu.BackColor = System.Drawing.Color.Transparent;
            this.tvMenu.Font = new System.Drawing.Font("MV Boli", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tvMenu.Location = new System.Drawing.Point(153, 9);
            this.tvMenu.Name = "tvMenu";
            this.tvMenu.Size = new System.Drawing.Size(111, 46);
            this.tvMenu.TabIndex = 1;
            this.tvMenu.Text = "Menu";
            // 
            // tvMGrid
            // 
            this.tvMGrid.AutoSize = true;
            this.tvMGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvMGrid.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMGrid.ForeColor = System.Drawing.Color.Navy;
            this.tvMGrid.Location = new System.Drawing.Point(69, 197);
            this.tvMGrid.Name = "tvMGrid";
            this.tvMGrid.Size = new System.Drawing.Size(99, 25);
            this.tvMGrid.TabIndex = 2;
            this.tvMGrid.Text = "Data Grid";
            // 
            // tvMNav
            // 
            this.tvMNav.AutoSize = true;
            this.tvMNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.tvMNav.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvMNav.ForeColor = System.Drawing.Color.Navy;
            this.tvMNav.Location = new System.Drawing.Point(210, 197);
            this.tvMNav.Name = "tvMNav";
            this.tvMNav.Size = new System.Drawing.Size(170, 25);
            this.tvMNav.TabIndex = 3;
            this.tvMNav.Text = "Navigator Binding";
            // 
            // pictGrid
            // 
            this.pictGrid.BackColor = System.Drawing.Color.Transparent;
            this.pictGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictGrid.Image = ((System.Drawing.Image)(resources.GetObject("pictGrid.Image")));
            this.pictGrid.Location = new System.Drawing.Point(59, 103);
            this.pictGrid.Name = "pictGrid";
            this.pictGrid.Size = new System.Drawing.Size(109, 91);
            this.pictGrid.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictGrid.TabIndex = 4;
            this.pictGrid.TabStop = false;
            this.pictGrid.Click += new System.EventHandler(this.pictGrid_Click);
            // 
            // pictNav
            // 
            this.pictNav.BackColor = System.Drawing.Color.Gainsboro;
            this.pictNav.Image = ((System.Drawing.Image)(resources.GetObject("pictNav.Image")));
            this.pictNav.Location = new System.Drawing.Point(238, 103);
            this.pictNav.Name = "pictNav";
            this.pictNav.Size = new System.Drawing.Size(108, 91);
            this.pictNav.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictNav.TabIndex = 5;
            this.pictNav.TabStop = false;
            this.pictNav.Click += new System.EventHandler(this.pictNav_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(413, 372);
            this.Controls.Add(this.pictNav);
            this.Controls.Add(this.pictGrid);
            this.Controls.Add(this.tvMNav);
            this.Controls.Add(this.tvMGrid);
            this.Controls.Add(this.tvMenu);
            this.Controls.Add(this.btnMBack);
            this.Name = "Menu";
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.pictGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictNav)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMBack;
        private System.Windows.Forms.Label tvMenu;
        private System.Windows.Forms.Label tvMGrid;
        private System.Windows.Forms.Label tvMNav;
        private System.Windows.Forms.PictureBox pictGrid;
        private System.Windows.Forms.PictureBox pictNav;
    }
}