
namespace Librarty_Management_Sysy
{
    partial class ViewMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_books = new Guna.UI2.WinForms.Guna2Button();
            this.btn_meembers = new Guna.UI2.WinForms.Guna2Button();
            this.btn_returnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_issueBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addBook = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nicNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telephoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet2 = new Librarty_Management_Sysy.LibraryManagementDataSet2();
            this.membersTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSet2TableAdapters.membersTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // btn_exit
            // 
            this.btn_exit.AutoRoundedCorners = true;
            this.btn_exit.BorderRadius = 31;
            this.btn_exit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_exit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_exit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_exit.FillColor = System.Drawing.Color.Firebrick;
            this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(74, 688);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(285, 64);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_books
            // 
            this.btn_books.AutoRoundedCorners = true;
            this.btn_books.BorderRadius = 31;
            this.btn_books.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_books.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_books.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_books.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_books.FillColor = System.Drawing.Color.DimGray;
            this.btn_books.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_books.ForeColor = System.Drawing.Color.White;
            this.btn_books.Location = new System.Drawing.Point(74, 427);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(362, 64);
            this.btn_books.TabIndex = 4;
            this.btn_books.Text = "BOOKS";
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_meembers
            // 
            this.btn_meembers.AutoRoundedCorners = true;
            this.btn_meembers.BorderRadius = 31;
            this.btn_meembers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_meembers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_meembers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_meembers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_meembers.FillColor = System.Drawing.Color.White;
            this.btn_meembers.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_meembers.ForeColor = System.Drawing.Color.Black;
            this.btn_meembers.Location = new System.Drawing.Point(74, 344);
            this.btn_meembers.Name = "btn_meembers";
            this.btn_meembers.Size = new System.Drawing.Size(362, 64);
            this.btn_meembers.TabIndex = 3;
            this.btn_meembers.Text = "MEMBERS";
            this.btn_meembers.Click += new System.EventHandler(this.btn_meembers_Click);
            // 
            // btn_returnBook
            // 
            this.btn_returnBook.AutoRoundedCorners = true;
            this.btn_returnBook.BorderRadius = 31;
            this.btn_returnBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_returnBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_returnBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_returnBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_returnBook.FillColor = System.Drawing.Color.DimGray;
            this.btn_returnBook.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_returnBook.ForeColor = System.Drawing.Color.White;
            this.btn_returnBook.Location = new System.Drawing.Point(74, 255);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(362, 64);
            this.btn_returnBook.TabIndex = 2;
            this.btn_returnBook.Text = "RETURN BOOK";
            this.btn_returnBook.Click += new System.EventHandler(this.btn_returnBook_Click);
            // 
            // btn_issueBook
            // 
            this.btn_issueBook.AutoRoundedCorners = true;
            this.btn_issueBook.BorderRadius = 31;
            this.btn_issueBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_issueBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_issueBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_issueBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_issueBook.FillColor = System.Drawing.Color.DimGray;
            this.btn_issueBook.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_issueBook.ForeColor = System.Drawing.Color.White;
            this.btn_issueBook.Location = new System.Drawing.Point(74, 166);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(362, 64);
            this.btn_issueBook.TabIndex = 1;
            this.btn_issueBook.Text = "ISSUE BOOK";
            this.btn_issueBook.Click += new System.EventHandler(this.btn_issueBook_Click);
            // 
            // btn_addBook
            // 
            this.btn_addBook.AutoRoundedCorners = true;
            this.btn_addBook.BorderRadius = 31;
            this.btn_addBook.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBook.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addBook.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addBook.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addBook.FillColor = System.Drawing.Color.DimGray;
            this.btn_addBook.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_addBook.ForeColor = System.Drawing.Color.White;
            this.btn_addBook.Location = new System.Drawing.Point(74, 78);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(362, 64);
            this.btn_addBook.TabIndex = 0;
            this.btn_addBook.Text = "ADD BOOKS";
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.guna2Panel1.Controls.Add(this.btn_exit);
            this.guna2Panel1.Controls.Add(this.btn_books);
            this.guna2Panel1.Controls.Add(this.btn_meembers);
            this.guna2Panel1.Controls.Add(this.btn_returnBook);
            this.guna2Panel1.Controls.Add(this.btn_issueBook);
            this.guna2Panel1.Controls.Add(this.btn_addBook);
            this.guna2Panel1.Location = new System.Drawing.Point(-1, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(401, 813);
            this.guna2Panel1.TabIndex = 81;
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView1.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 36;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.nicNumberDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.emailAddressDataGridViewTextBoxColumn,
            this.telephoneNumberDataGridViewTextBoxColumn,
            this.dobDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.mAddressDataGridViewTextBoxColumn});
            this.guna2DataGridView1.DataSource = this.membersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(465, 145);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowHeadersWidth = 51;
            this.guna2DataGridView1.RowTemplate.Height = 24;
            this.guna2DataGridView1.Size = new System.Drawing.Size(810, 607);
            this.guna2DataGridView1.TabIndex = 83;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 36;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "memberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "Member ID";
            this.memberIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            this.memberIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nicNumberDataGridViewTextBoxColumn
            // 
            this.nicNumberDataGridViewTextBoxColumn.DataPropertyName = "nicNumber";
            this.nicNumberDataGridViewTextBoxColumn.HeaderText = "NIC";
            this.nicNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nicNumberDataGridViewTextBoxColumn.Name = "nicNumberDataGridViewTextBoxColumn";
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "memberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.memberNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            // 
            // emailAddressDataGridViewTextBoxColumn
            // 
            this.emailAddressDataGridViewTextBoxColumn.DataPropertyName = "emailAddress";
            this.emailAddressDataGridViewTextBoxColumn.HeaderText = "E-Mail";
            this.emailAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailAddressDataGridViewTextBoxColumn.Name = "emailAddressDataGridViewTextBoxColumn";
            // 
            // telephoneNumberDataGridViewTextBoxColumn
            // 
            this.telephoneNumberDataGridViewTextBoxColumn.DataPropertyName = "telephoneNumber";
            this.telephoneNumberDataGridViewTextBoxColumn.HeaderText = "Telephone";
            this.telephoneNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telephoneNumberDataGridViewTextBoxColumn.Name = "telephoneNumberDataGridViewTextBoxColumn";
            // 
            // dobDataGridViewTextBoxColumn
            // 
            this.dobDataGridViewTextBoxColumn.DataPropertyName = "dob";
            this.dobDataGridViewTextBoxColumn.HeaderText = "Date of Birth";
            this.dobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dobDataGridViewTextBoxColumn.Name = "dobDataGridViewTextBoxColumn";
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            // 
            // mAddressDataGridViewTextBoxColumn
            // 
            this.mAddressDataGridViewTextBoxColumn.DataPropertyName = "mAddress";
            this.mAddressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.mAddressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mAddressDataGridViewTextBoxColumn.Name = "mAddressDataGridViewTextBoxColumn";
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "members";
            this.membersBindingSource.DataSource = this.libraryManagementDataSet2;
            // 
            // libraryManagementDataSet2
            // 
            this.libraryManagementDataSet2.DataSetName = "LibraryManagementDataSet2";
            this.libraryManagementDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(460, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "VIEW MEMBER";
            // 
            // ViewMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1349, 797);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewMember";
            this.Text = "ViewMember";
            this.Load += new System.EventHandler(this.ViewMember_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_books;
        private Guna.UI2.WinForms.Guna2Button btn_meembers;
        private Guna.UI2.WinForms.Guna2Button btn_returnBook;
        private Guna.UI2.WinForms.Guna2Button btn_issueBook;
        private Guna.UI2.WinForms.Guna2Button btn_addBook;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private LibraryManagementDataSet2 libraryManagementDataSet2;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private LibraryManagementDataSet2TableAdapters.membersTableAdapter membersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nicNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telephoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mAddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}