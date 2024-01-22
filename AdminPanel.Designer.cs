namespace MovieLibrary
{
    partial class AdminPanel
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
            System.Windows.Forms.Label lANSARELabel;
            System.Windows.Forms.Label dURATALabel;
            System.Windows.Forms.Label aCTORILabel;
            System.Windows.Forms.Label rEGIZORLabel;
            System.Windows.Forms.Label gENLabel;
            System.Windows.Forms.Label dESCRIERELabel;
            System.Windows.Forms.Label tITLULabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.DateBox = new System.Windows.Forms.TextBox();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.MainBox = new System.Windows.Forms.TextBox();
            this.DirBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.DescBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataBaseDataSet = new MovieLibrary.DataBaseDataSet();
            this.movieTableAdapter = new MovieLibrary.DataBaseDataSetTableAdapters.MovieTableAdapter();
            this.tableAdapterManager = new MovieLibrary.DataBaseDataSetTableAdapters.TableAdapterManager();
            this.dataBaseDataSet1 = new MovieLibrary.DataBaseDataSet1();
            this.movieBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.movieTableAdapter1 = new MovieLibrary.DataBaseDataSet1TableAdapters.MovieTableAdapter();
            this.tableAdapterManager1 = new MovieLibrary.DataBaseDataSet1TableAdapters.TableAdapterManager();
            this.movieDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            lANSARELabel = new System.Windows.Forms.Label();
            dURATALabel = new System.Windows.Forms.Label();
            aCTORILabel = new System.Windows.Forms.Label();
            rEGIZORLabel = new System.Windows.Forms.Label();
            gENLabel = new System.Windows.Forms.Label();
            dESCRIERELabel = new System.Windows.Forms.Label();
            tITLULabel = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lANSARELabel
            // 
            lANSARELabel.AutoSize = true;
            lANSARELabel.Location = new System.Drawing.Point(3, 200);
            lANSARELabel.Name = "lANSARELabel";
            lANSARELabel.Size = new System.Drawing.Size(88, 13);
            lANSARELabel.TabIndex = 15;
            lANSARELabel.Text = "RELEASE DATE";
            // 
            // dURATALabel
            // 
            dURATALabel.AutoSize = true;
            dURATALabel.Location = new System.Drawing.Point(9, 176);
            dURATALabel.Name = "dURATALabel";
            dURATALabel.Size = new System.Drawing.Size(60, 13);
            dURATALabel.TabIndex = 13;
            dURATALabel.Text = "RUNTIME:";
            // 
            // aCTORILabel
            // 
            aCTORILabel.AutoSize = true;
            aCTORILabel.Location = new System.Drawing.Point(9, 151);
            aCTORILabel.Name = "aCTORILabel";
            aCTORILabel.Size = new System.Drawing.Size(77, 13);
            aCTORILabel.TabIndex = 11;
            aCTORILabel.Text = "MAIN ACTOR:";
            // 
            // rEGIZORLabel
            // 
            rEGIZORLabel.AutoSize = true;
            rEGIZORLabel.Location = new System.Drawing.Point(11, 133);
            rEGIZORLabel.Name = "rEGIZORLabel";
            rEGIZORLabel.Size = new System.Drawing.Size(66, 13);
            rEGIZORLabel.TabIndex = 9;
            rEGIZORLabel.Text = "DIRECTOR:";
            // 
            // gENLabel
            // 
            gENLabel.AutoSize = true;
            gENLabel.Location = new System.Drawing.Point(11, 101);
            gENLabel.Name = "gENLabel";
            gENLabel.Size = new System.Drawing.Size(38, 13);
            gENLabel.TabIndex = 7;
            gENLabel.Text = "TYPE:";
            // 
            // dESCRIERELabel
            // 
            dESCRIERELabel.AutoSize = true;
            dESCRIERELabel.Location = new System.Drawing.Point(3, 36);
            dESCRIERELabel.Name = "dESCRIERELabel";
            dESCRIERELabel.Size = new System.Drawing.Size(83, 13);
            dESCRIERELabel.TabIndex = 5;
            dESCRIERELabel.Text = "DESCRIPTION:";
            // 
            // tITLULabel
            // 
            tITLULabel.AutoSize = true;
            tITLULabel.Location = new System.Drawing.Point(3, 12);
            tITLULabel.Name = "tITLULabel";
            tITLULabel.Size = new System.Drawing.Size(40, 13);
            tITLULabel.TabIndex = 3;
            tITLULabel.Text = "TITLE:";
            // 
            // DateBox
            // 
            this.DateBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "LANSARE", true));
            this.DateBox.Location = new System.Drawing.Point(100, 197);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(100, 20);
            this.DateBox.TabIndex = 16;
            // 
            // TimeBox
            // 
            this.TimeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "DURATA", true));
            this.TimeBox.Location = new System.Drawing.Point(100, 171);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(100, 20);
            this.TimeBox.TabIndex = 14;
            // 
            // MainBox
            // 
            this.MainBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "ACTORI", true));
            this.MainBox.Location = new System.Drawing.Point(100, 148);
            this.MainBox.Multiline = true;
            this.MainBox.Name = "MainBox";
            this.MainBox.Size = new System.Drawing.Size(100, 20);
            this.MainBox.TabIndex = 12;
            // 
            // DirBox
            // 
            this.DirBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "REGIZOR", true));
            this.DirBox.Location = new System.Drawing.Point(100, 126);
            this.DirBox.Multiline = true;
            this.DirBox.Name = "DirBox";
            this.DirBox.Size = new System.Drawing.Size(100, 20);
            this.DirBox.TabIndex = 10;
            // 
            // TypeBox
            // 
            this.TypeBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "GEN", true));
            this.TypeBox.Location = new System.Drawing.Point(100, 101);
            this.TypeBox.Multiline = true;
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(100, 20);
            this.TypeBox.TabIndex = 8;
            // 
            // DescBox
            // 
            this.DescBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "DESCRIERE", true));
            this.DescBox.Location = new System.Drawing.Point(100, 33);
            this.DescBox.Multiline = true;
            this.DescBox.Name = "DescBox";
            this.DescBox.Size = new System.Drawing.Size(294, 65);
            this.DescBox.TabIndex = 6;
            // 
            // TitleBox
            // 
            this.TitleBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.movieBindingSource, "TITLU", true));
            this.TitleBox.Location = new System.Drawing.Point(100, 9);
            this.TitleBox.Multiline = true;
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(100, 20);
            this.TitleBox.TabIndex = 4;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GradientPanel1.Controls.Add(this.AddButton);
            this.guna2GradientPanel1.Controls.Add(tITLULabel);
            this.guna2GradientPanel1.Controls.Add(this.DateBox);
            this.guna2GradientPanel1.Controls.Add(lANSARELabel);
            this.guna2GradientPanel1.Controls.Add(this.TimeBox);
            this.guna2GradientPanel1.Controls.Add(dURATALabel);
            this.guna2GradientPanel1.Controls.Add(this.MainBox);
            this.guna2GradientPanel1.Controls.Add(aCTORILabel);
            this.guna2GradientPanel1.Controls.Add(this.DirBox);
            this.guna2GradientPanel1.Controls.Add(rEGIZORLabel);
            this.guna2GradientPanel1.Controls.Add(this.TypeBox);
            this.guna2GradientPanel1.Controls.Add(gENLabel);
            this.guna2GradientPanel1.Controls.Add(this.DescBox);
            this.guna2GradientPanel1.Controls.Add(dESCRIERELabel);
            this.guna2GradientPanel1.Controls.Add(this.TitleBox);
            this.guna2GradientPanel1.Location = new System.Drawing.Point(27, 271);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(967, 236);
            this.guna2GradientPanel1.TabIndex = 17;
            // 
            // AddButton
            // 
            this.AddButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AddButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AddButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AddButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.Location = new System.Drawing.Point(863, 176);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(86, 48);
            this.AddButton.TabIndex = 17;
            this.AddButton.Text = "ADD MOVIE";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "DialogResult";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.dataBaseDataSet;
            // 
            // dataBaseDataSet
            // 
            this.dataBaseDataSet.DataSetName = "DataBaseDataSet";
            this.dataBaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieTableAdapter
            // 
            this.movieTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MovieTableAdapter = this.movieTableAdapter;
            this.tableAdapterManager.UpdateOrder = MovieLibrary.DataBaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataBaseDataSet1
            // 
            this.dataBaseDataSet1.DataSetName = "DataBaseDataSet1";
            this.dataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // movieBindingSource1
            // 
            this.movieBindingSource1.DataMember = "Movie";
            this.movieBindingSource1.DataSource = this.dataBaseDataSet1;
            // 
            // movieTableAdapter1
            // 
            this.movieTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.MovieTableAdapter = this.movieTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = MovieLibrary.DataBaseDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // movieDataGridView
            // 
            this.movieDataGridView.AutoGenerateColumns = false;
            this.movieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewImageColumn1});
            this.movieDataGridView.DataSource = this.movieBindingSource1;
            this.movieDataGridView.Location = new System.Drawing.Point(27, 12);
            this.movieDataGridView.Name = "movieDataGridView";
            this.movieDataGridView.Size = new System.Drawing.Size(944, 239);
            this.movieDataGridView.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TITLU";
            this.dataGridViewTextBoxColumn2.HeaderText = "TITLU";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DESCRIERE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DESCRIERE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "GEN";
            this.dataGridViewTextBoxColumn4.HeaderText = "GEN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "REGIZOR";
            this.dataGridViewTextBoxColumn5.HeaderText = "REGIZOR";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ACTORI";
            this.dataGridViewTextBoxColumn6.HeaderText = "ACTORI";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "DURATA";
            this.dataGridViewTextBoxColumn7.HeaderText = "DURATA";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "LANSARE";
            this.dataGridViewTextBoxColumn8.HeaderText = "LANSARE";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "STELUTE";
            this.dataGridViewTextBoxColumn9.HeaderText = "STELUTE";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "PHOTO";
            this.dataGridViewImageColumn1.HeaderText = "PHOTO";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1020, 557);
            this.Controls.Add(this.movieDataGridView);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataBaseDataSet dataBaseDataSet;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private DataBaseDataSetTableAdapters.MovieTableAdapter movieTableAdapter;
        private DataBaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox TimeBox;
        private System.Windows.Forms.TextBox MainBox;
        private System.Windows.Forms.TextBox DirBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox DescBox;
        private System.Windows.Forms.TextBox TitleBox;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataBaseDataSet1 dataBaseDataSet1;
        private System.Windows.Forms.BindingSource movieBindingSource1;
        private DataBaseDataSet1TableAdapters.MovieTableAdapter movieTableAdapter1;
        private DataBaseDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView movieDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}