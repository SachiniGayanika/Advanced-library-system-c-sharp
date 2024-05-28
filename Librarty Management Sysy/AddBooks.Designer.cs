
namespace Librarty_Management_Sysy
{
    partial class AddBooks
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_exit = new Guna.UI2.WinForms.Guna2Button();
            this.btn_books = new Guna.UI2.WinForms.Guna2Button();
            this.btn_members = new Guna.UI2.WinForms.Guna2Button();
            this.btn_returnBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_issueBook = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addBook = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl2 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2DragControl3 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txt_isbn = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_bookName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_author = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_publication = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_qty = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbx_cat = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_description = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_clear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_delete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_invlidInput = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GrayText;
            this.guna2Panel1.Controls.Add(this.btn_exit);
            this.guna2Panel1.Controls.Add(this.btn_books);
            this.guna2Panel1.Controls.Add(this.btn_members);
            this.guna2Panel1.Controls.Add(this.btn_returnBook);
            this.guna2Panel1.Controls.Add(this.btn_issueBook);
            this.guna2Panel1.Controls.Add(this.btn_addBook);
            this.guna2Panel1.Location = new System.Drawing.Point(-2, -1);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(407, 813);
            this.guna2Panel1.TabIndex = 2;
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
            this.btn_exit.Location = new System.Drawing.Point(78, 694);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(312, 64);
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
            this.btn_books.Location = new System.Drawing.Point(78, 439);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(367, 64);
            this.btn_books.TabIndex = 4;
            this.btn_books.Text = "BOOKS";
            this.btn_books.Click += new System.EventHandler(this.btn_books_Click);
            // 
            // btn_members
            // 
            this.btn_members.AutoRoundedCorners = true;
            this.btn_members.BorderRadius = 31;
            this.btn_members.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_members.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_members.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_members.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_members.FillColor = System.Drawing.Color.DimGray;
            this.btn_members.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.btn_members.ForeColor = System.Drawing.Color.White;
            this.btn_members.Location = new System.Drawing.Point(78, 356);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(367, 64);
            this.btn_members.TabIndex = 3;
            this.btn_members.Text = "MEMBERS";
            this.btn_members.Click += new System.EventHandler(this.btn_members_Click);
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
            this.btn_returnBook.Location = new System.Drawing.Point(78, 267);
            this.btn_returnBook.Name = "btn_returnBook";
            this.btn_returnBook.Size = new System.Drawing.Size(367, 64);
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
            this.btn_issueBook.Location = new System.Drawing.Point(78, 178);
            this.btn_issueBook.Name = "btn_issueBook";
            this.btn_issueBook.Size = new System.Drawing.Size(367, 64);
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
            this.btn_addBook.FillColor = System.Drawing.Color.White;
            this.btn_addBook.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBook.ForeColor = System.Drawing.Color.Black;
            this.btn_addBook.Location = new System.Drawing.Point(78, 90);
            this.btn_addBook.Name = "btn_addBook";
            this.btn_addBook.Size = new System.Drawing.Size(367, 64);
            this.btn_addBook.TabIndex = 0;
            this.btn_addBook.Text = "ADD BOOKS";
            this.btn_addBook.Click += new System.EventHandler(this.btn_addBook_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2DragControl2
            // 
            this.guna2DragControl2.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl2.TargetControl = this.guna2Panel1;
            this.guna2DragControl2.UseTransparentDrag = true;
            // 
            // guna2DragControl3
            // 
            this.guna2DragControl3.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl3.TargetControl = this;
            this.guna2DragControl3.UseTransparentDrag = true;
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
            this.txt_isbn.Location = new System.Drawing.Point(774, 125);
            this.txt_isbn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.PasswordChar = '\0';
            this.txt_isbn.PlaceholderText = "";
            this.txt_isbn.SelectedText = "";
            this.txt_isbn.Size = new System.Drawing.Size(431, 39);
            this.txt_isbn.TabIndex = 10;
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
            this.txt_bookName.Location = new System.Drawing.Point(774, 180);
            this.txt_bookName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_bookName.Name = "txt_bookName";
            this.txt_bookName.PasswordChar = '\0';
            this.txt_bookName.PlaceholderText = "";
            this.txt_bookName.SelectedText = "";
            this.txt_bookName.Size = new System.Drawing.Size(431, 39);
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
            this.txt_author.Location = new System.Drawing.Point(774, 233);
            this.txt_author.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_author.Name = "txt_author";
            this.txt_author.PasswordChar = '\0';
            this.txt_author.PlaceholderText = "";
            this.txt_author.SelectedText = "";
            this.txt_author.Size = new System.Drawing.Size(431, 39);
            this.txt_author.TabIndex = 12;
            // 
            // txt_publication
            // 
            this.txt_publication.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_publication.DefaultText = "";
            this.txt_publication.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_publication.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_publication.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_publication.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_publication.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_publication.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_publication.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_publication.Location = new System.Drawing.Point(774, 337);
            this.txt_publication.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_publication.Name = "txt_publication";
            this.txt_publication.PasswordChar = '\0';
            this.txt_publication.PlaceholderText = "";
            this.txt_publication.SelectedText = "";
            this.txt_publication.Size = new System.Drawing.Size(431, 39);
            this.txt_publication.TabIndex = 14;
            // 
            // txt_qty
            // 
            this.txt_qty.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qty.DefaultText = "";
            this.txt_qty.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_qty.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_qty.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_qty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_qty.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_qty.Location = new System.Drawing.Point(774, 396);
            this.txt_qty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.PasswordChar = '\0';
            this.txt_qty.PlaceholderText = "";
            this.txt_qty.SelectedText = "";
            this.txt_qty.Size = new System.Drawing.Size(431, 39);
            this.txt_qty.TabIndex = 15;
            // 
            // cmbx_cat
            // 
            this.cmbx_cat.BackColor = System.Drawing.Color.Transparent;
            this.cmbx_cat.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbx_cat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbx_cat.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_cat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbx_cat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbx_cat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbx_cat.ItemHeight = 30;
            this.cmbx_cat.Items.AddRange(new object[] {
            "Novels",
            "Children\'s Story",
            "Adventure",
            "Education",
            "Religious",
            "Historical",
            "Magazine"});
            this.cmbx_cat.Location = new System.Drawing.Point(774, 288);
            this.cmbx_cat.Name = "cmbx_cat";
            this.cmbx_cat.Size = new System.Drawing.Size(431, 36);
            this.cmbx_cat.TabIndex = 16;
            // 
            // txt_description
            // 
            this.txt_description.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_description.DefaultText = "";
            this.txt_description.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_description.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_description.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_description.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_description.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_description.Location = new System.Drawing.Point(774, 448);
            this.txt_description.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_description.Name = "txt_description";
            this.txt_description.PasswordChar = '\0';
            this.txt_description.PlaceholderText = "";
            this.txt_description.SelectedText = "";
            this.txt_description.Size = new System.Drawing.Size(431, 207);
            this.txt_description.TabIndex = 17;
            // 
            // btn_add
            // 
            this.btn_add.AutoRoundedCorners = true;
            this.btn_add.BorderRadius = 21;
            this.btn_add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_add.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_add.FillColor2 = System.Drawing.Color.Silver;
            this.btn_add.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(774, 678);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(245, 45);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "ADD";
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
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
            this.btn_clear.Location = new System.Drawing.Point(1025, 678);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(180, 45);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "CLEAR";
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(529, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 32);
            this.label1.TabIndex = 23;
            this.label1.Text = "ADD BOOKS";
            // 
            // btn_search
            // 
            this.btn_search.AutoRoundedCorners = true;
            this.btn_search.BorderRadius = 18;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_search.FillColor2 = System.Drawing.Color.LightGray;
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1221, 125);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(124, 39);
            this.btn_search.TabIndex = 24;
            this.btn_search.Text = "SEARCH";
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.AutoRoundedCorners = true;
            this.btn_delete.BorderRadius = 18;
            this.btn_delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_delete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_delete.FillColor2 = System.Drawing.Color.LightGray;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(1221, 180);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(124, 39);
            this.btn_delete.TabIndex = 25;
            this.btn_delete.Text = "DELETE";
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(539, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "BOOK ISBN NUMBER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(539, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "BOOK NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(539, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "BOOK AUTHOR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(539, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "CATEGORY";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(190, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "BOOK PUBLICATION";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(539, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "QUANTITY";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(539, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "DESCRIPTION";
            // 
            // lbl_invlidInput
            // 
            this.lbl_invlidInput.AutoSize = true;
            this.lbl_invlidInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 4.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_invlidInput.ForeColor = System.Drawing.Color.Red;
            this.lbl_invlidInput.Location = new System.Drawing.Point(772, 380);
            this.lbl_invlidInput.Name = "lbl_invlidInput";
            this.lbl_invlidInput.Size = new System.Drawing.Size(197, 12);
            this.lbl_invlidInput.TabIndex = 33;
            this.lbl_invlidInput.Text = "Invalid input please enter number only";
            this.lbl_invlidInput.Click += new System.EventHandler(this.label9_Click);
            // 
            // AddBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 810);
            this.Controls.Add(this.lbl_invlidInput);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_description);
            this.Controls.Add(this.cmbx_cat);
            this.Controls.Add(this.txt_qty);
            this.Controls.Add(this.txt_publication);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.txt_bookName);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddBooks";
            this.Text = "AdminDashboard";
            this.Load += new System.EventHandler(this.AddBooks_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btn_exit;
        private Guna.UI2.WinForms.Guna2Button btn_books;
        private Guna.UI2.WinForms.Guna2Button btn_members;
        private Guna.UI2.WinForms.Guna2Button btn_returnBook;
        private Guna.UI2.WinForms.Guna2Button btn_issueBook;
        private Guna.UI2.WinForms.Guna2Button btn_addBook;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl2;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl3;
        private Guna.UI2.WinForms.Guna2GradientButton btn_clear;
        private Guna.UI2.WinForms.Guna2GradientButton btn_add;
        private Guna.UI2.WinForms.Guna2TextBox txt_description;
        private Guna.UI2.WinForms.Guna2ComboBox cmbx_cat;
        private Guna.UI2.WinForms.Guna2TextBox txt_qty;
        private Guna.UI2.WinForms.Guna2TextBox txt_publication;
        private Guna.UI2.WinForms.Guna2TextBox txt_author;
        private Guna.UI2.WinForms.Guna2TextBox txt_bookName;
        private Guna.UI2.WinForms.Guna2TextBox txt_isbn;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_search;
        private Guna.UI2.WinForms.Guna2GradientButton btn_delete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_invlidInput;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}