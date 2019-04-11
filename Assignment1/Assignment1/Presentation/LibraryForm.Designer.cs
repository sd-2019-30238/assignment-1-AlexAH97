namespace Assignment1
{
    partial class LibraryForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.booksDataSet1 = new Assignment1.DB.BooksDataSet1();
            this.libraryBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryTableAdapter = new Assignment1.DB.BooksDataSet1TableAdapters.LibraryTableAdapter();
            this.libraryBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookTitleDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.libraryBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(265, 426);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // booksDataSet1
            // 
            this.booksDataSet1.DataSetName = "BooksDataSet1";
            this.booksDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // libraryBindingSource3
            // 
            this.libraryBindingSource3.DataMember = "Library";
            this.libraryBindingSource3.DataSource = this.booksDataSet1;
            // 
            // libraryTableAdapter
            // 
            this.libraryTableAdapter.ClearBeforeFill = true;
            // 
            // libraryBindingSource4
            // 
            this.libraryBindingSource4.DataSource = typeof(Assignment1.Library);
            // 
            // libraryBindingSource
            // 
            this.libraryBindingSource.DataSource = typeof(Assignment1.Library);
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(Assignment1.Books);
            // 
            // libraryBindingSource1
            // 
            this.libraryBindingSource1.DataSource = typeof(Assignment1.Library);
            // 
            // libraryBindingSource2
            // 
            this.libraryBindingSource2.DataSource = typeof(Assignment1.Library);
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "BookTitle";
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // LibraryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LibraryForm";
            this.Text = "LibraryForm";
            this.Load += new System.EventHandler(this.LibraryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.BindingSource libraryBindingSource;
        private System.Windows.Forms.BindingSource libraryBindingSource2;
        private System.Windows.Forms.BindingSource libraryBindingSource1;
        private DB.BooksDataSet1 booksDataSet1;
        private System.Windows.Forms.BindingSource libraryBindingSource3;
        private DB.BooksDataSet1TableAdapters.LibraryTableAdapter libraryTableAdapter;
        private System.Windows.Forms.BindingSource libraryBindingSource4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
    }
}