
namespace Librarty_Management_Sysy
{
    partial class Reserve_Book
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txt_search = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_isbn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_author = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_memberID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_memberName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reserve = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2DataGridView2 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.isbnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolkNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publicationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryManagementDataSet = new Librarty_Management_Sysy.LibraryManagementDataSet();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel8 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btn_clear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.bookTableAdapter = new Librarty_Management_Sysy.LibraryManagementDataSetTableAdapters.bookTableAdapter();
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_dateCollect = new System.Windows.Forms.MaskedTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_qty = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_email = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(152)))), ((int)(((byte)(166)))));
            this.guna2ControlBox1.IconColor = System.Drawing.Color.White;
            this.guna2ControlBox1.Location = new System.Drawing.Point(1388, 15);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.guna2ControlBox1.TabIndex = 1;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.DefaultText = "";
            this.txt_search.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_search.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_search.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_search.Location = new System.Drawing.Point(51, 52);
            this.txt_search.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.PasswordChar = '\0';
            this.txt_search.PlaceholderText = "Enter ISBN or Book Name";
            this.txt_search.SelectedText = "";
            this.txt_search.Size = new System.Drawing.Size(446, 35);
            this.txt_search.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BorderRadius = 16;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(51, 94);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(446, 35);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // txt_isbn
            // 
            this.txt_isbn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_isbn.DefaultText = "";
            this.txt_isbn.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_isbn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_isbn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_isbn.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_isbn.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_isbn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_isbn.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_isbn.Location = new System.Drawing.Point(236, 200);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.PasswordChar = '\0';
            this.txt_isbn.PlaceholderText = "22-32-23234-4";
            this.txt_isbn.SelectedText = "";
            this.txt_isbn.Size = new System.Drawing.Size(303, 32);
            this.txt_isbn.TabIndex = 10;
            this.txt_isbn.TextChanged += new System.EventHandler(this.txt_isbn_TextChanged);
            // 
            // txt_bookName
            // 
            this.txt_bookName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_bookName.DefaultText = "";
            this.txt_bookName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_bookName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_bookName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bookName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_bookName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bookName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_bookName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_bookName.Location = new System.Drawing.Point(236, 94);
            this.txt_bookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.PasswordChar = '\0';
            this.txt_bookName.PlaceholderText = "Eclips with MySQL";
            this.txt_bookName.SelectedText = "";
            this.txt_bookName.Size = new System.Drawing.Size(303, 32);
            this.txt_bookName.TabIndex = 11;
            // 
            // txt_author
            // 
            this.txt_author.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_author.DefaultText = "";
            this.txt_author.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_author.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_author.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_author.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_author.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_author.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_author.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_author.Location = new System.Drawing.Point(236, 252);
            this.txt_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_author.Name = "txt_author";
            this.txt_author.PasswordChar = '\0';
            this.txt_author.PlaceholderText = "Ashen Wishwageeth";
            this.txt_author.SelectedText = "";
            this.txt_author.Size = new System.Drawing.Size(303, 32);
            this.txt_author.TabIndex = 12;
            this.txt_author.TextChanged += new System.EventHandler(this.txt_author_TextChanged);
            // 
            // txt_memberID
            // 
            this.txt_memberID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_memberID.DefaultText = "";
            this.txt_memberID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_memberID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_memberID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_memberID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_memberID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_memberID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_memberID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_memberID.Location = new System.Drawing.Point(236, 353);
            this.txt_memberID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_memberID.Name = "txt_memberID";
            this.txt_memberID.PasswordChar = '\0';
            this.txt_memberID.PlaceholderText = "1112";
            this.txt_memberID.SelectedText = "";
            this.txt_memberID.Size = new System.Drawing.Size(303, 32);
            this.txt_memberID.TabIndex = 13;
            // 
            // txt_memberName
            // 
            this.txt_memberName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_memberName.DefaultText = "";
            this.txt_memberName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_memberName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_memberName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_memberName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_memberName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_memberName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_memberName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_memberName.Location = new System.Drawing.Point(236, 393);
            this.txt_memberName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_memberName.Name = "txt_memberName";
            this.txt_memberName.PasswordChar = '\0';
            this.txt_memberName.PlaceholderText = "John Doe";
            this.txt_memberName.SelectedText = "";
            this.txt_memberName.Size = new System.Drawing.Size(303, 32);
            this.txt_memberName.TabIndex = 14;
            // 
            // btn_reserve
            // 
            this.btn_reserve.AutoRoundedCorners = true;
            this.btn_reserve.BorderRadius = 21;
            this.btn_reserve.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reserve.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reserve.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reserve.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reserve.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reserve.FillColor = System.Drawing.Color.Silver;
            this.btn_reserve.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_reserve.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_reserve.ForeColor = System.Drawing.Color.White;
            this.btn_reserve.Location = new System.Drawing.Point(98, 616);
            this.btn_reserve.Name = "btn_reserve";
            this.btn_reserve.Size = new System.Drawing.Size(248, 45);
            this.btn_reserve.TabIndex = 15;
            this.btn_reserve.Text = "Reserve";
            this.btn_reserve.Click += new System.EventHandler(this.btn_reserve_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.guna2Panel1.Controls.Add(this.guna2DataGridView2);
            this.guna2Panel1.Controls.Add(this.txt_search);
            this.guna2Panel1.Controls.Add(this.btn_search);
            this.guna2Panel1.Location = new System.Drawing.Point(602, 27);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(537, 715);
            this.guna2Panel1.TabIndex = 27;
            // 
            // guna2DataGridView2
            // 
            this.guna2DataGridView2.AllowUserToAddRows = false;
            this.guna2DataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.guna2DataGridView2.AutoGenerateColumns = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView2.ColumnHeadersHeight = 19;
            this.guna2DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.isbnDataGridViewTextBoxColumn,
            this.boolkNameDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.publicationDataGridViewTextBoxColumn});
            this.guna2DataGridView2.DataSource = this.bookBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView2.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.Location = new System.Drawing.Point(53, 154);
            this.guna2DataGridView2.Name = "guna2DataGridView2";
            this.guna2DataGridView2.ReadOnly = true;
            this.guna2DataGridView2.RowHeadersVisible = false;
            this.guna2DataGridView2.RowHeadersWidth = 51;
            this.guna2DataGridView2.RowTemplate.Height = 24;
            this.guna2DataGridView2.Size = new System.Drawing.Size(445, 526);
            this.guna2DataGridView2.TabIndex = 28;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView2.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView2.ThemeStyle.HeaderStyle.Height = 19;
            this.guna2DataGridView2.ThemeStyle.ReadOnly = true;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.Height = 24;
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView2.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // isbnDataGridViewTextBoxColumn
            // 
            this.isbnDataGridViewTextBoxColumn.DataPropertyName = "isbn";
            this.isbnDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.isbnDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isbnDataGridViewTextBoxColumn.Name = "isbnDataGridViewTextBoxColumn";
            this.isbnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // boolkNameDataGridViewTextBoxColumn
            // 
            this.boolkNameDataGridViewTextBoxColumn.DataPropertyName = "boolkName";
            this.boolkNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.boolkNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.boolkNameDataGridViewTextBoxColumn.Name = "boolkNameDataGridViewTextBoxColumn";
            this.boolkNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            this.categoryDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // publicationDataGridViewTextBoxColumn
            // 
            this.publicationDataGridViewTextBoxColumn.DataPropertyName = "publication";
            this.publicationDataGridViewTextBoxColumn.HeaderText = "Publication";
            this.publicationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publicationDataGridViewTextBoxColumn.Name = "publicationDataGridViewTextBoxColumn";
            this.publicationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bookBindingSource
            // 
            this.bookBindingSource.DataMember = "book";
            this.bookBindingSource.DataSource = this.libraryManagementDataSet;
            // 
            // libraryManagementDataSet
            // 
            this.libraryManagementDataSet.DataSetName = "LibraryManagementDataSet";
            this.libraryManagementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(236, 306);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(141, 24);
            this.guna2HtmlLabel7.TabIndex = 29;
            this.guna2HtmlLabel7.Text = "Member Details";
            // 
            // guna2HtmlLabel8
            // 
            this.guna2HtmlLabel8.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel8.Location = new System.Drawing.Point(230, 502);
            this.guna2HtmlLabel8.Name = "guna2HtmlLabel8";
            this.guna2HtmlLabel8.Size = new System.Drawing.Size(161, 24);
            this.guna2HtmlLabel8.TabIndex = 34;
            this.guna2HtmlLabel8.Text = "Burrowing Details";
            // 
            // btn_clear
            // 
            this.btn_clear.AutoRoundedCorners = true;
            this.btn_clear.BorderRadius = 21;
            this.btn_clear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_clear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_clear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_clear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clear.FillColor2 = System.Drawing.Color.LightGray;
            this.btn_clear.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(352, 616);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(187, 45);
            this.btn_clear.TabIndex = 43;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
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
            this.btn_exit.Location = new System.Drawing.Point(98, 678);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(441, 64);
            this.btn_exit.TabIndex = 44;
            this.btn_exit.Text = "EXIT";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // bookTableAdapter
            // 
            this.bookTableAdapter.ClearBeforeFill = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 47;
            this.label1.Text = "BOOK DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "ISBN";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "BOOK NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "BOOK AUTHOR";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 51;
            this.label5.Text = "MEMBER ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 405);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "MEMBER NAME";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "DATE COLLECTION";
            // 
            // txt_dateCollect
            // 
            this.txt_dateCollect.Location = new System.Drawing.Point(230, 544);
            this.txt_dateCollect.Mask = "00/00/0000";
            this.txt_dateCollect.Name = "txt_dateCollect";
            this.txt_dateCollect.Size = new System.Drawing.Size(303, 22);
            this.txt_dateCollect.TabIndex = 54;
            this.txt_dateCollect.ValidatingType = typeof(System.DateTime);
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BorderRadius = 16;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(236, 136);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(303, 35);
            this.guna2Button1.TabIndex = 29;
            this.guna2Button1.Text = "Search";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click_1);
            // 
            // lbl_qty
            // 
            this.lbl_qty.AutoSize = true;
            this.lbl_qty.Location = new System.Drawing.Point(233, 181);
            this.lbl_qty.Name = "lbl_qty";
            this.lbl_qty.Size = new System.Drawing.Size(46, 17);
            this.lbl_qty.TabIndex = 55;
            this.lbl_qty.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 17);
            this.label8.TabIndex = 57;
            this.label8.Text = "MEMBER EMAIL";
            // 
            // txt_email
            // 
            this.txt_email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_email.DefaultText = "";
            this.txt_email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_email.Location = new System.Drawing.Point(236, 433);
            this.txt_email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_email.Name = "txt_email";
            this.txt_email.PasswordChar = '\0';
            this.txt_email.PlaceholderText = "john@example.com";
            this.txt_email.SelectedText = "";
            this.txt_email.Size = new System.Drawing.Size(303, 32);
            this.txt_email.TabIndex = 56;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this;
            this.guna2DragControl3.UseTransparentDrag = true;
            // 
            // Reserve_Book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 799);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.lbl_qty);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.txt_dateCollect);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.guna2HtmlLabel8);
            this.Controls.Add(this.guna2HtmlLabel7);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btn_reserve);
            this.Controls.Add(this.txt_memberName);
            this.Controls.Add(this.txt_memberID);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.guna2ControlBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reserve_Book";
            this.Text = "Reserve_Book";
            this.Load += new System.EventHandler(this.Reserve_Book_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryManagementDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2TextBox txt_search;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_isbn;
        private Guna.UI2.WinForms.Guna2TextBox txt_bookName;
        private Guna.UI2.WinForms.Guna2TextBox txt_author;
        private Guna.UI2.WinForms.Guna2TextBox txt_memberID;
        private Guna.UI2.WinForms.Guna2TextBox txt_memberName;
        private Guna.UI2.WinForms.Guna2GradientButton btn_reserve;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel8;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2GradientButton btn_clear;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private LibraryManagementDataSet libraryManagementDataSet;
        private System.Windows.Forms.BindingSource bookBindingSource;
        private LibraryManagementDataSetTableAdapters.bookTableAdapter bookTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn boolkNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publicationDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txt_dateCollect;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Label lbl_qty;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox txt_email;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
    }
}