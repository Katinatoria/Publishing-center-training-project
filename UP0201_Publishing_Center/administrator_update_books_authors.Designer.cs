namespace UP0201_Publishing_Center
{
    partial class administrator_update_books_authors
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
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.адресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.телефонDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDконтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.писателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet1 = new UP0201_Publishing_Center.Издательский_центрDataSet1();
            this.писателиTableAdapter = new UP0201_Publishing_Center.Издательский_центрDataSet1TableAdapters.ПисателиTableAdapter();
            this.button_writers = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.номерконтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датазаключенияконтрактаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.срокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.расторгнутDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.датарасторженияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контрактыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet2 = new UP0201_Publishing_Center.Издательский_центрDataSet2();
            this.контрактыTableAdapter = new UP0201_Publishing_Center.Издательский_центрDataSet2TableAdapters.КонтрактыTableAdapter();
            this.button_update_contract = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idкнигиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idавтораDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.книгаавторыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet5 = new UP0201_Publishing_Center.Издательский_центрDataSet5();
            this.книга_авторыTableAdapter = new UP0201_Publishing_Center.Издательский_центрDataSet5TableAdapters.Книга_авторыTableAdapter();
            this.button_update_book_authors = new System.Windows.Forms.Button();
            this.button_out = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.писателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаавторыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.адресDataGridViewTextBoxColumn,
            this.телефонDataGridViewTextBoxColumn,
            this.iDконтрактаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.писателиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1142, 127);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.Width = 125;
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            this.фИОDataGridViewTextBoxColumn.Width = 125;
            // 
            // адресDataGridViewTextBoxColumn
            // 
            this.адресDataGridViewTextBoxColumn.DataPropertyName = "Адрес";
            this.адресDataGridViewTextBoxColumn.HeaderText = "Адрес";
            this.адресDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.адресDataGridViewTextBoxColumn.Name = "адресDataGridViewTextBoxColumn";
            this.адресDataGridViewTextBoxColumn.Width = 125;
            // 
            // телефонDataGridViewTextBoxColumn
            // 
            this.телефонDataGridViewTextBoxColumn.DataPropertyName = "Телефон";
            this.телефонDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.телефонDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.телефонDataGridViewTextBoxColumn.Name = "телефонDataGridViewTextBoxColumn";
            this.телефонDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDконтрактаDataGridViewTextBoxColumn
            // 
            this.iDконтрактаDataGridViewTextBoxColumn.DataPropertyName = "ID_контракта";
            this.iDконтрактаDataGridViewTextBoxColumn.HeaderText = "ID_контракта";
            this.iDконтрактаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDконтрактаDataGridViewTextBoxColumn.Name = "iDконтрактаDataGridViewTextBoxColumn";
            this.iDконтрактаDataGridViewTextBoxColumn.Width = 125;
            // 
            // писателиBindingSource
            // 
            this.писателиBindingSource.DataMember = "Писатели";
            this.писателиBindingSource.DataSource = this.издательский_центрDataSet1;
            // 
            // издательский_центрDataSet1
            // 
            this.издательский_центрDataSet1.DataSetName = "Издательский_центрDataSet1";
            this.издательский_центрDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // писателиTableAdapter
            // 
            this.писателиTableAdapter.ClearBeforeFill = true;
            // 
            // button_writers
            // 
            this.button_writers.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_writers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_writers.Location = new System.Drawing.Point(12, 192);
            this.button_writers.Name = "button_writers";
            this.button_writers.Size = new System.Drawing.Size(288, 30);
            this.button_writers.TabIndex = 1;
            this.button_writers.Text = "Обновить таблицу \"писатели\"";
            this.button_writers.UseVisualStyleBackColor = true;
            this.button_writers.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Писатели";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "Контракты";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.номерконтрактаDataGridViewTextBoxColumn,
            this.датазаключенияконтрактаDataGridViewTextBoxColumn,
            this.срокDataGridViewTextBoxColumn,
            this.расторгнутDataGridViewCheckBoxColumn,
            this.датарасторженияDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.контрактыBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 309);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(1136, 123);
            this.dataGridView2.TabIndex = 6;
            // 
            // номерконтрактаDataGridViewTextBoxColumn
            // 
            this.номерконтрактаDataGridViewTextBoxColumn.DataPropertyName = "номер_контракта";
            this.номерконтрактаDataGridViewTextBoxColumn.HeaderText = "номер_контракта";
            this.номерконтрактаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.номерконтрактаDataGridViewTextBoxColumn.Name = "номерконтрактаDataGridViewTextBoxColumn";
            this.номерконтрактаDataGridViewTextBoxColumn.ReadOnly = true;
            this.номерконтрактаDataGridViewTextBoxColumn.Width = 125;
            // 
            // датазаключенияконтрактаDataGridViewTextBoxColumn
            // 
            this.датазаключенияконтрактаDataGridViewTextBoxColumn.DataPropertyName = "дата_заключения_контракта";
            this.датазаключенияконтрактаDataGridViewTextBoxColumn.HeaderText = "дата_заключения_контракта";
            this.датазаключенияконтрактаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датазаключенияконтрактаDataGridViewTextBoxColumn.Name = "датазаключенияконтрактаDataGridViewTextBoxColumn";
            this.датазаключенияконтрактаDataGridViewTextBoxColumn.Width = 125;
            // 
            // срокDataGridViewTextBoxColumn
            // 
            this.срокDataGridViewTextBoxColumn.DataPropertyName = "срок";
            this.срокDataGridViewTextBoxColumn.HeaderText = "срок";
            this.срокDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.срокDataGridViewTextBoxColumn.Name = "срокDataGridViewTextBoxColumn";
            this.срокDataGridViewTextBoxColumn.Width = 125;
            // 
            // расторгнутDataGridViewCheckBoxColumn
            // 
            this.расторгнутDataGridViewCheckBoxColumn.DataPropertyName = "расторгнут";
            this.расторгнутDataGridViewCheckBoxColumn.HeaderText = "расторгнут";
            this.расторгнутDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.расторгнутDataGridViewCheckBoxColumn.Name = "расторгнутDataGridViewCheckBoxColumn";
            this.расторгнутDataGridViewCheckBoxColumn.Width = 125;
            // 
            // датарасторженияDataGridViewTextBoxColumn
            // 
            this.датарасторженияDataGridViewTextBoxColumn.DataPropertyName = "дата_расторжения";
            this.датарасторженияDataGridViewTextBoxColumn.HeaderText = "дата_расторжения";
            this.датарасторженияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датарасторженияDataGridViewTextBoxColumn.Name = "датарасторженияDataGridViewTextBoxColumn";
            this.датарасторженияDataGridViewTextBoxColumn.Width = 125;
            // 
            // контрактыBindingSource
            // 
            this.контрактыBindingSource.DataMember = "Контракты";
            this.контрактыBindingSource.DataSource = this.издательский_центрDataSet2;
            // 
            // издательский_центрDataSet2
            // 
            this.издательский_центрDataSet2.DataSetName = "Издательский_центрDataSet2";
            this.издательский_центрDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // контрактыTableAdapter
            // 
            this.контрактыTableAdapter.ClearBeforeFill = true;
            // 
            // button_update_contract
            // 
            this.button_update_contract.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update_contract.Location = new System.Drawing.Point(12, 448);
            this.button_update_contract.Name = "button_update_contract";
            this.button_update_contract.Size = new System.Drawing.Size(288, 30);
            this.button_update_contract.TabIndex = 7;
            this.button_update_contract.Text = "Обновить таблицу \"контракты\"";
            this.button_update_contract.UseVisualStyleBackColor = true;
            this.button_update_contract.Click += new System.EventHandler(this.button_update_contract_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 13.8F);
            this.label3.Location = new System.Drawing.Point(12, 520);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Книга-авторы";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.idкнигиDataGridViewTextBoxColumn,
            this.idавтораDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.книгаавторыBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(12, 565);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1142, 150);
            this.dataGridView3.TabIndex = 9;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // idкнигиDataGridViewTextBoxColumn
            // 
            this.idкнигиDataGridViewTextBoxColumn.DataPropertyName = "id_книги";
            this.idкнигиDataGridViewTextBoxColumn.HeaderText = "id_книги";
            this.idкнигиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idкнигиDataGridViewTextBoxColumn.Name = "idкнигиDataGridViewTextBoxColumn";
            this.idкнигиDataGridViewTextBoxColumn.Width = 125;
            // 
            // idавтораDataGridViewTextBoxColumn
            // 
            this.idавтораDataGridViewTextBoxColumn.DataPropertyName = "id_автора";
            this.idавтораDataGridViewTextBoxColumn.HeaderText = "id_автора";
            this.idавтораDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idавтораDataGridViewTextBoxColumn.Name = "idавтораDataGridViewTextBoxColumn";
            this.idавтораDataGridViewTextBoxColumn.Width = 125;
            // 
            // книгаавторыBindingSource
            // 
            this.книгаавторыBindingSource.DataMember = "Книга_авторы";
            this.книгаавторыBindingSource.DataSource = this.издательский_центрDataSet5;
            // 
            // издательский_центрDataSet5
            // 
            this.издательский_центрDataSet5.DataSetName = "Издательский_центрDataSet5";
            this.издательский_центрDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книга_авторыTableAdapter
            // 
            this.книга_авторыTableAdapter.ClearBeforeFill = true;
            // 
            // button_update_book_authors
            // 
            this.button_update_book_authors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update_book_authors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_update_book_authors.Location = new System.Drawing.Point(12, 732);
            this.button_update_book_authors.Name = "button_update_book_authors";
            this.button_update_book_authors.Size = new System.Drawing.Size(288, 30);
            this.button_update_book_authors.TabIndex = 10;
            this.button_update_book_authors.Text = "Обновить таблицу \"книга-авторы\"";
            this.button_update_book_authors.UseVisualStyleBackColor = true;
            // 
            // button_out
            // 
            this.button_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_out.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_out.Location = new System.Drawing.Point(1005, 8);
            this.button_out.Name = "button_out";
            this.button_out.Size = new System.Drawing.Size(152, 32);
            this.button_out.TabIndex = 11;
            this.button_out.Text = "Назад";
            this.button_out.UseVisualStyleBackColor = true;
            this.button_out.Click += new System.EventHandler(this.button_out_Click);
            // 
            // administrator_update_books_authors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 818);
            this.Controls.Add(this.button_out);
            this.Controls.Add(this.button_update_book_authors);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_update_contract);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_writers);
            this.Controls.Add(this.dataGridView1);
            this.Name = "administrator_update_books_authors";
            this.Text = "Издательский центр";
            this.Load += new System.EventHandler(this.manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.писателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.контрактыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгаавторыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Издательский_центрDataSet1 издательский_центрDataSet1;
        private System.Windows.Forms.BindingSource писателиBindingSource;
        private Издательский_центрDataSet1TableAdapters.ПисателиTableAdapter писателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn адресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn телефонDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDконтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_writers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Издательский_центрDataSet2 издательский_центрDataSet2;
        private System.Windows.Forms.BindingSource контрактыBindingSource;
        private Издательский_центрDataSet2TableAdapters.КонтрактыTableAdapter контрактыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерконтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датазаключенияконтрактаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn срокDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn расторгнутDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарасторженияDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_update_contract;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView3;
        private Издательский_центрDataSet5 издательский_центрDataSet5;
        private System.Windows.Forms.BindingSource книгаавторыBindingSource;
        private Издательский_центрDataSet5TableAdapters.Книга_авторыTableAdapter книга_авторыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idкнигиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idавтораDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_update_book_authors;
        private System.Windows.Forms.Button button_out;
    }
}