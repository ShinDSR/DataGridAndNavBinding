
namespace Exercise4
{
    partial class NavBinding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavBinding));
            this.btnNBack = new System.Windows.Forms.Button();
            this.nimNL = new System.Windows.Forms.Label();
            this.namaNL = new System.Windows.Forms.Label();
            this.almtNL = new System.Windows.Forms.Label();
            this.kelNL = new System.Windows.Forms.Label();
            this.telpNL = new System.Windows.Forms.Label();
            this.nimNR = new System.Windows.Forms.Label();
            this.namaNR = new System.Windows.Forms.Label();
            this.almtNR = new System.Windows.Forms.Label();
            this.kelNR = new System.Windows.Forms.Label();
            this.telpNR = new System.Windows.Forms.Label();
            this.TextView = new System.Windows.Forms.Label();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.prodiTIDataSet = new Exercise4.ProdiTIDataSet();
            this.mahasiswaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mahasiswaTableAdapter = new Exercise4.ProdiTIDataSetTableAdapters.MahasiswaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNBack
            // 
            this.btnNBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNBack.ForeColor = System.Drawing.Color.White;
            this.btnNBack.Location = new System.Drawing.Point(29, 341);
            this.btnNBack.Name = "btnNBack";
            this.btnNBack.Size = new System.Drawing.Size(75, 23);
            this.btnNBack.TabIndex = 0;
            this.btnNBack.Text = "Back";
            this.btnNBack.UseVisualStyleBackColor = false;
            this.btnNBack.Click += new System.EventHandler(this.btnNBack_Click);
            // 
            // nimNL
            // 
            this.nimNL.AutoSize = true;
            this.nimNL.BackColor = System.Drawing.Color.Transparent;
            this.nimNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimNL.ForeColor = System.Drawing.Color.Yellow;
            this.nimNL.Location = new System.Drawing.Point(78, 150);
            this.nimNL.Name = "nimNL";
            this.nimNL.Size = new System.Drawing.Size(165, 15);
            this.nimNL.TabIndex = 3;
            this.nimNL.Text = "No Mahasiswa               :";
            // 
            // namaNL
            // 
            this.namaNL.AutoSize = true;
            this.namaNL.BackColor = System.Drawing.Color.Transparent;
            this.namaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaNL.ForeColor = System.Drawing.Color.Yellow;
            this.namaNL.Location = new System.Drawing.Point(78, 183);
            this.namaNL.Name = "namaNL";
            this.namaNL.Size = new System.Drawing.Size(165, 15);
            this.namaNL.TabIndex = 4;
            this.namaNL.Text = "Nama Mahasiswa          :";
            // 
            // almtNL
            // 
            this.almtNL.AutoSize = true;
            this.almtNL.BackColor = System.Drawing.Color.Transparent;
            this.almtNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almtNL.ForeColor = System.Drawing.Color.Yellow;
            this.almtNL.Location = new System.Drawing.Point(78, 218);
            this.almtNL.Name = "almtNL";
            this.almtNL.Size = new System.Drawing.Size(163, 15);
            this.almtNL.TabIndex = 5;
            this.almtNL.Text = "Alamat Mahasiswa        :";
            // 
            // kelNL
            // 
            this.kelNL.AutoSize = true;
            this.kelNL.BackColor = System.Drawing.Color.Transparent;
            this.kelNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelNL.ForeColor = System.Drawing.Color.Yellow;
            this.kelNL.Location = new System.Drawing.Point(78, 253);
            this.kelNL.Name = "kelNL";
            this.kelNL.Size = new System.Drawing.Size(162, 15);
            this.kelNL.TabIndex = 6;
            this.kelNL.Text = "Jenis Kelamin               :";
            // 
            // telpNL
            // 
            this.telpNL.AutoSize = true;
            this.telpNL.BackColor = System.Drawing.Color.Transparent;
            this.telpNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpNL.ForeColor = System.Drawing.Color.Yellow;
            this.telpNL.Location = new System.Drawing.Point(78, 291);
            this.telpNL.Name = "telpNL";
            this.telpNL.Size = new System.Drawing.Size(161, 15);
            this.telpNL.TabIndex = 7;
            this.telpNL.Text = "No Telpon                     :";
            // 
            // nimNR
            // 
            this.nimNR.AutoSize = true;
            this.nimNR.BackColor = System.Drawing.Color.Transparent;
            this.nimNR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NIM", true));
            this.nimNR.Enabled = false;
            this.nimNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nimNR.ForeColor = System.Drawing.Color.Aqua;
            this.nimNR.Location = new System.Drawing.Point(249, 150);
            this.nimNR.Name = "nimNR";
            this.nimNR.Size = new System.Drawing.Size(0, 15);
            this.nimNR.TabIndex = 8;
            // 
            // namaNR
            // 
            this.namaNR.AutoSize = true;
            this.namaNR.BackColor = System.Drawing.Color.Transparent;
            this.namaNR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "NamaMhs", true));
            this.namaNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namaNR.ForeColor = System.Drawing.Color.Aqua;
            this.namaNR.Location = new System.Drawing.Point(249, 183);
            this.namaNR.Name = "namaNR";
            this.namaNR.Size = new System.Drawing.Size(0, 15);
            this.namaNR.TabIndex = 9;
            // 
            // almtNR
            // 
            this.almtNR.AutoSize = true;
            this.almtNR.BackColor = System.Drawing.Color.Transparent;
            this.almtNR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "AlamatMhs", true));
            this.almtNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.almtNR.ForeColor = System.Drawing.Color.Aqua;
            this.almtNR.Location = new System.Drawing.Point(248, 218);
            this.almtNR.Name = "almtNR";
            this.almtNR.Size = new System.Drawing.Size(0, 15);
            this.almtNR.TabIndex = 10;
            // 
            // kelNR
            // 
            this.kelNR.AutoSize = true;
            this.kelNR.BackColor = System.Drawing.Color.Transparent;
            this.kelNR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "Sex", true));
            this.kelNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelNR.ForeColor = System.Drawing.Color.Aqua;
            this.kelNR.Location = new System.Drawing.Point(248, 253);
            this.kelNR.Name = "kelNR";
            this.kelNR.Size = new System.Drawing.Size(0, 15);
            this.kelNR.TabIndex = 11;
            // 
            // telpNR
            // 
            this.telpNR.AutoSize = true;
            this.telpNR.BackColor = System.Drawing.Color.Transparent;
            this.telpNR.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.mahasiswaBindingSource, "PhoneMhs", true));
            this.telpNR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telpNR.ForeColor = System.Drawing.Color.Aqua;
            this.telpNR.Location = new System.Drawing.Point(248, 291);
            this.telpNR.Name = "telpNR";
            this.telpNR.Size = new System.Drawing.Size(0, 15);
            this.telpNR.TabIndex = 12;
            // 
            // TextView
            // 
            this.TextView.BackColor = System.Drawing.Color.Blue;
            this.TextView.Font = new System.Drawing.Font("Niagara Solid", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextView.ForeColor = System.Drawing.Color.Red;
            this.TextView.Location = new System.Drawing.Point(117, 69);
            this.TextView.Name = "TextView";
            this.TextView.Size = new System.Drawing.Size(219, 37);
            this.TextView.TabIndex = 13;
            this.TextView.Text = "Data Binding";
            this.TextView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TextView.Click += new System.EventHandler(this.label1_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = null;
            this.bindingNavigator1.BindingSource = this.mahasiswaBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(467, 25);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // prodiTIDataSet
            // 
            this.prodiTIDataSet.DataSetName = "ProdiTIDataSet";
            this.prodiTIDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mahasiswaBindingSource
            // 
            this.mahasiswaBindingSource.DataMember = "Mahasiswa";
            this.mahasiswaBindingSource.DataSource = this.prodiTIDataSet;
            // 
            // mahasiswaTableAdapter
            // 
            this.mahasiswaTableAdapter.ClearBeforeFill = true;
            // 
            // NavBinding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(467, 376);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.TextView);
            this.Controls.Add(this.telpNR);
            this.Controls.Add(this.kelNR);
            this.Controls.Add(this.almtNR);
            this.Controls.Add(this.namaNR);
            this.Controls.Add(this.nimNR);
            this.Controls.Add(this.telpNL);
            this.Controls.Add(this.kelNL);
            this.Controls.Add(this.almtNL);
            this.Controls.Add(this.namaNL);
            this.Controls.Add(this.nimNL);
            this.Controls.Add(this.btnNBack);
            this.Name = "NavBinding";
            this.Text = "Navigator Binding";
            this.Load += new System.EventHandler(this.NavBinding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodiTIDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mahasiswaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNBack;
        private System.Windows.Forms.Label nimNL;
        private System.Windows.Forms.Label namaNL;
        private System.Windows.Forms.Label almtNL;
        private System.Windows.Forms.Label kelNL;
        private System.Windows.Forms.Label telpNL;
        private System.Windows.Forms.Label nimNR;
        private System.Windows.Forms.Label namaNR;
        private System.Windows.Forms.Label almtNR;
        private System.Windows.Forms.Label kelNR;
        private System.Windows.Forms.Label telpNR;
        private System.Windows.Forms.Label TextView;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private ProdiTIDataSet prodiTIDataSet;
        private System.Windows.Forms.BindingSource mahasiswaBindingSource;
        private ProdiTIDataSetTableAdapters.MahasiswaTableAdapter mahasiswaTableAdapter;
    }
}