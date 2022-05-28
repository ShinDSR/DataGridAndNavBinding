
namespace Exercise4
{
    partial class View
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
            this.nimVL = new System.Windows.Forms.Label();
            this.namaVL = new System.Windows.Forms.Label();
            this.AlmtVL = new System.Windows.Forms.Label();
            this.kelVL = new System.Windows.Forms.Label();
            this.telpVL = new System.Windows.Forms.Label();
            this.nimVR = new System.Windows.Forms.Label();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.prodiTIDataSet = new Exercise4.ProdiTIDataSet();
            this.namaVR = new System.Windows.Forms.Label();
            this.almtVR = new System.Windows.Forms.Label();
            this.kelVR = new System.Windows.Forms.Label();
            this.telpVR = new System.Windows.Forms.Label();
            this.btnVBack = new System.Windows.Forms.Button();
            this.mahasiswaTableAdapter = new Exercise4.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // nimVL
            // 
            this.nimVL.AutoSize = true;
            this.nimVL.Location = new System.Drawing.Point(61, 80);
            this.nimVL.Name = "nimVL";
            this.nimVL.Size = new System.Drawing.Size(155, 13);
            this.nimVL.TabIndex = 0;
            this.nimVL.Text = "No Mahasiswa                         :";
            // 
            // namaVL
            // 
            this.namaVL.AutoSize = true;
            this.namaVL.Location = new System.Drawing.Point(61, 131);
            this.namaVL.Name = "namaVL";
            this.namaVL.Size = new System.Drawing.Size(154, 13);
            this.namaVL.TabIndex = 1;
            this.namaVL.Text = "Nama Mahsiswa                      :";
            // 
            // AlmtVL
            // 
            this.AlmtVL.AutoSize = true;
            this.AlmtVL.Location = new System.Drawing.Point(61, 187);
            this.AlmtVL.Name = "AlmtVL";
            this.AlmtVL.Size = new System.Drawing.Size(155, 13);
            this.AlmtVL.TabIndex = 2;
            this.AlmtVL.Text = "Alamat Mahasiswa                   :";
            // 
            // kelVL
            // 
            this.kelVL.AutoSize = true;
            this.kelVL.Location = new System.Drawing.Point(61, 246);
            this.kelVL.Name = "kelVL";
            this.kelVL.Size = new System.Drawing.Size(155, 13);
            this.kelVL.TabIndex = 3;
            this.kelVL.Text = "Jenis Kelamin                           :";
            // 
            // telpVL
            // 
            this.telpVL.AutoSize = true;
            this.telpVL.Location = new System.Drawing.Point(61, 305);
            this.telpVL.Name = "telpVL";
            this.telpVL.Size = new System.Drawing.Size(156, 13);
            this.telpVL.TabIndex = 4;
            this.telpVL.Text = "No Telpon                                :";
            // 
            // nimVR
            // 
            this.nimVR.AutoSize = true;
            this.nimVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.nimVR.Location = new System.Drawing.Point(222, 80);
            this.nimVR.Name = "nimVR";
            this.nimVR.Size = new System.Drawing.Size(0, 13);
            this.nimVR.TabIndex = 5;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // namaVR
            // 
            this.namaVR.AutoSize = true;
            this.namaVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.namaVR.Location = new System.Drawing.Point(222, 131);
            this.namaVR.Name = "namaVR";
            this.namaVR.Size = new System.Drawing.Size(0, 13);
            this.namaVR.TabIndex = 6;
            // 
            // almtVR
            // 
            this.almtVR.AutoSize = true;
            this.almtVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.almtVR.Location = new System.Drawing.Point(222, 187);
            this.almtVR.Name = "almtVR";
            this.almtVR.Size = new System.Drawing.Size(0, 13);
            this.almtVR.TabIndex = 7;
            // 
            // kelVR
            // 
            this.kelVR.AutoSize = true;
            this.kelVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.kelVR.Location = new System.Drawing.Point(222, 246);
            this.kelVR.Name = "kelVR";
            this.kelVR.Size = new System.Drawing.Size(0, 13);
            this.kelVR.TabIndex = 8;
            // 
            // telpVR
            // 
            this.telpVR.AutoSize = true;
            this.telpVR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.telpVR.Location = new System.Drawing.Point(222, 305);
            this.telpVR.Name = "telpVR";
            this.telpVR.Size = new System.Drawing.Size(0, 13);
            this.telpVR.TabIndex = 9;
            // 
            // btnVBack
            // 
            this.btnVBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVBack.ForeColor = System.Drawing.Color.White;
            this.btnVBack.Location = new System.Drawing.Point(21, 375);
            this.btnVBack.Name = "btnVBack";
            this.btnVBack.Size = new System.Drawing.Size(75, 23);
            this.btnVBack.TabIndex = 10;
            this.btnVBack.Text = "Back";
            this.btnVBack.UseVisualStyleBackColor = false;
            this.btnVBack.Click += new System.EventHandler(this.btnVBack_Click);
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 410);
            this.Controls.Add(this.btnVBack);
            this.Controls.Add(this.telpVR);
            this.Controls.Add(this.kelVR);
            this.Controls.Add(this.almtVR);
            this.Controls.Add(this.namaVR);
            this.Controls.Add(this.nimVR);
            this.Controls.Add(this.telpVL);
            this.Controls.Add(this.kelVL);
            this.Controls.Add(this.AlmtVL);
            this.Controls.Add(this.namaVL);
            this.Controls.Add(this.nimVL);
            this.Name = "View";
            this.Text = "View";
            this.Load += new System.EventHandler(this.View_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nimVL;
        private System.Windows.Forms.Label namaVL;
        private System.Windows.Forms.Label AlmtVL;
        private System.Windows.Forms.Label kelVL;
        private System.Windows.Forms.Label telpVL;
        public System.Windows.Forms.Label nimVR;
        public System.Windows.Forms.Label namaVR;
        public System.Windows.Forms.Label almtVR;
        public System.Windows.Forms.Label kelVR;
        public System.Windows.Forms.Label telpVR;
        private System.Windows.Forms.Button btnVBack;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}