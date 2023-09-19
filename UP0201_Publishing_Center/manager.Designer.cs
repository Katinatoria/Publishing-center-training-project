namespace UP0201_Publishing_Center
{
    partial class manager
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
            this.button_fee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_Name_writer = new System.Windows.Forms.ComboBox();
            this.писателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet3 = new UP0201_Publishing_Center.Издательский_центрDataSet3();
            this.писателиTableAdapter = new UP0201_Publishing_Center.Издательский_центрDataSet3TableAdapters.ПисателиTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_fee = new System.Windows.Forms.Label();
            this.comboBox_book = new System.Windows.Forms.ComboBox();
            this.книгиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.издательский_центрDataSet4 = new UP0201_Publishing_Center.Издательский_центрDataSet4();
            this.книгиTableAdapter = new UP0201_Publishing_Center.Издательский_центрDataSet4TableAdapters.КнигиTableAdapter();
            this.label4 = new System.Windows.Forms.Label();
            this.button_contract_term = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label_contract = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_terminated = new System.Windows.Forms.Label();
            this.button_count = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_count_ended_books = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.писателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // button_fee
            // 
            this.button_fee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_fee.Location = new System.Drawing.Point(16, 142);
            this.button_fee.Name = "button_fee";
            this.button_fee.Size = new System.Drawing.Size(772, 42);
            this.button_fee.TabIndex = 0;
            this.button_fee.Text = "Определить гонорар";
            this.button_fee.UseVisualStyleBackColor = true;
            this.button_fee.Click += new System.EventHandler(this.button_fee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя писателя:";
            // 
            // comboBox_Name_writer
            // 
            this.comboBox_Name_writer.DataSource = this.писателиBindingSource;
            this.comboBox_Name_writer.DisplayMember = "ФИО";
            this.comboBox_Name_writer.FormattingEnabled = true;
            this.comboBox_Name_writer.Location = new System.Drawing.Point(149, 68);
            this.comboBox_Name_writer.Name = "comboBox_Name_writer";
            this.comboBox_Name_writer.Size = new System.Drawing.Size(639, 24);
            this.comboBox_Name_writer.TabIndex = 2;
            this.comboBox_Name_writer.ValueMember = "ФИО";
            // 
            // писателиBindingSource
            // 
            this.писателиBindingSource.DataMember = "Писатели";
            this.писателиBindingSource.DataSource = this.издательский_центрDataSet3;
            // 
            // издательский_центрDataSet3
            // 
            this.издательский_центрDataSet3.DataSetName = "Издательский_центрDataSet3";
            this.издательский_центрDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // писателиTableAdapter
            // 
            this.писателиTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(333, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Менеджер";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(11, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Гонорар:";
            // 
            // label_fee
            // 
            this.label_fee.AutoSize = true;
            this.label_fee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_fee.Location = new System.Drawing.Point(101, 211);
            this.label_fee.Name = "label_fee";
            this.label_fee.Size = new System.Drawing.Size(9, 20);
            this.label_fee.TabIndex = 5;
            this.label_fee.Text = "\r\n";
            // 
            // comboBox_book
            // 
            this.comboBox_book.DataSource = this.книгиBindingSource;
            this.comboBox_book.DisplayMember = "название";
            this.comboBox_book.FormattingEnabled = true;
            this.comboBox_book.Location = new System.Drawing.Point(149, 101);
            this.comboBox_book.Name = "comboBox_book";
            this.comboBox_book.Size = new System.Drawing.Size(639, 24);
            this.comboBox_book.TabIndex = 7;
            this.comboBox_book.ValueMember = "название";
            // 
            // книгиBindingSource
            // 
            this.книгиBindingSource.DataMember = "Книги";
            this.книгиBindingSource.DataSource = this.издательский_центрDataSet4;
            // 
            // издательский_центрDataSet4
            // 
            this.издательский_центрDataSet4.DataSetName = "Издательский_центрDataSet4";
            this.издательский_центрDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // книгиTableAdapter
            // 
            this.книгиTableAdapter.ClearBeforeFill = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Книга:";
            // 
            // button_contract_term
            // 
            this.button_contract_term.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_contract_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_contract_term.Location = new System.Drawing.Point(16, 248);
            this.button_contract_term.Name = "button_contract_term";
            this.button_contract_term.Size = new System.Drawing.Size(772, 43);
            this.button_contract_term.TabIndex = 9;
            this.button_contract_term.Text = "Определить срок контракта";
            this.button_contract_term.UseVisualStyleBackColor = true;
            this.button_contract_term.Click += new System.EventHandler(this.button_contract_term_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Срок контракта:";
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_contract.Location = new System.Drawing.Point(181, 320);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(0, 20);
            this.label_contract.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(12, 348);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Расторгнут:";
            // 
            // label_terminated
            // 
            this.label_terminated.AutoSize = true;
            this.label_terminated.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_terminated.Location = new System.Drawing.Point(131, 344);
            this.label_terminated.Name = "label_terminated";
            this.label_terminated.Size = new System.Drawing.Size(0, 32);
            this.label_terminated.TabIndex = 13;
            // 
            // button_count
            // 
            this.button_count.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_count.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_count.Location = new System.Drawing.Point(16, 390);
            this.button_count.Name = "button_count";
            this.button_count.Size = new System.Drawing.Size(772, 43);
            this.button_count.TabIndex = 14;
            this.button_count.Text = "Количество написанных книг";
            this.button_count.UseVisualStyleBackColor = true;
            this.button_count.Click += new System.EventHandler(this.button_count_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(13, 450);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Завершённых:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 481);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "В процессе:";
            // 
            // label_count_ended_books
            // 
            this.label_count_ended_books.AutoSize = true;
            this.label_count_ended_books.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_count_ended_books.Location = new System.Drawing.Point(149, 450);
            this.label_count_ended_books.Name = "label_count_ended_books";
            this.label_count_ended_books.Size = new System.Drawing.Size(0, 20);
            this.label_count_ended_books.TabIndex = 17;
            // 
            // manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 519);
            this.Controls.Add(this.label_count_ended_books);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_count);
            this.Controls.Add(this.label_terminated);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label_contract);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_contract_term);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_book);
            this.Controls.Add(this.label_fee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Name_writer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fee);
            this.Name = "manager";
            this.Text = "Издательский центр";
            this.Load += new System.EventHandler(this.manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.писателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.книгиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.издательский_центрDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_Name_writer;
        private Издательский_центрDataSet3 издательский_центрDataSet3;
        private System.Windows.Forms.BindingSource писателиBindingSource;
        private Издательский_центрDataSet3TableAdapters.ПисателиTableAdapter писателиTableAdapter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_fee;
        private System.Windows.Forms.ComboBox comboBox_book;
        private Издательский_центрDataSet4 издательский_центрDataSet4;
        private System.Windows.Forms.BindingSource книгиBindingSource;
        private Издательский_центрDataSet4TableAdapters.КнигиTableAdapter книгиTableAdapter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_contract_term;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_terminated;
        private System.Windows.Forms.Button button_count;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_count_ended_books;
    }
}