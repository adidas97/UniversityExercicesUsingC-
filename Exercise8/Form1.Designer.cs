namespace PhoneBook
{
    partial class Form1
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
            this.options = new System.Windows.Forms.TabControl();
            this.newPhoneBook = new System.Windows.Forms.TabPage();
            this.addNewPhone = new System.Windows.Forms.TabPage();
            this.editPhone = new System.Windows.Forms.TabPage();
            this.deletePhone = new System.Windows.Forms.TabPage();
            this.searchPhone = new System.Windows.Forms.TabPage();
            this.grid = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.create = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.delete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchField = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.options.SuspendLayout();
            this.newPhoneBook.SuspendLayout();
            this.addNewPhone.SuspendLayout();
            this.editPhone.SuspendLayout();
            this.deletePhone.SuspendLayout();
            this.searchPhone.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // options
            // 
            this.options.Controls.Add(this.newPhoneBook);
            this.options.Controls.Add(this.addNewPhone);
            this.options.Controls.Add(this.editPhone);
            this.options.Controls.Add(this.deletePhone);
            this.options.Controls.Add(this.searchPhone);
            this.options.Location = new System.Drawing.Point(1, 0);
            this.options.Name = "options";
            this.options.SelectedIndex = 0;
            this.options.Size = new System.Drawing.Size(570, 150);
            this.options.TabIndex = 0;
            this.options.SelectedIndexChanged += new System.EventHandler(this.options_SelectedIndexChanged);
            // 
            // newPhoneBook
            // 
            this.newPhoneBook.Controls.Add(this.create);
            this.newPhoneBook.Controls.Add(this.label1);
            this.newPhoneBook.Location = new System.Drawing.Point(4, 25);
            this.newPhoneBook.Name = "newPhoneBook";
            this.newPhoneBook.Padding = new System.Windows.Forms.Padding(3);
            this.newPhoneBook.Size = new System.Drawing.Size(562, 121);
            this.newPhoneBook.TabIndex = 0;
            this.newPhoneBook.Text = "New Phone Book";
            this.newPhoneBook.UseVisualStyleBackColor = true;
            // 
            // addNewPhone
            // 
            this.addNewPhone.Controls.Add(this.clear);
            this.addNewPhone.Controls.Add(this.add);
            this.addNewPhone.Controls.Add(this.number);
            this.addNewPhone.Controls.Add(this.address);
            this.addNewPhone.Controls.Add(this.name);
            this.addNewPhone.Controls.Add(this.l3);
            this.addNewPhone.Controls.Add(this.l2);
            this.addNewPhone.Controls.Add(this.l1);
            this.addNewPhone.Location = new System.Drawing.Point(4, 25);
            this.addNewPhone.Name = "addNewPhone";
            this.addNewPhone.Padding = new System.Windows.Forms.Padding(3);
            this.addNewPhone.Size = new System.Drawing.Size(562, 121);
            this.addNewPhone.TabIndex = 1;
            this.addNewPhone.Text = "Add New Phone";
            this.addNewPhone.UseVisualStyleBackColor = true;
            // 
            // editPhone
            // 
            this.editPhone.Controls.Add(this.save);
            this.editPhone.Controls.Add(this.label2);
            this.editPhone.Location = new System.Drawing.Point(4, 25);
            this.editPhone.Name = "editPhone";
            this.editPhone.Size = new System.Drawing.Size(562, 121);
            this.editPhone.TabIndex = 2;
            this.editPhone.Text = "Edit Phone";
            this.editPhone.UseVisualStyleBackColor = true;
            // 
            // deletePhone
            // 
            this.deletePhone.Controls.Add(this.delete);
            this.deletePhone.Controls.Add(this.label3);
            this.deletePhone.Location = new System.Drawing.Point(4, 25);
            this.deletePhone.Name = "deletePhone";
            this.deletePhone.Size = new System.Drawing.Size(402, 121);
            this.deletePhone.TabIndex = 3;
            this.deletePhone.Text = "Delete Phone";
            this.deletePhone.UseVisualStyleBackColor = true;
            // 
            // searchPhone
            // 
            this.searchPhone.Controls.Add(this.cancel);
            this.searchPhone.Controls.Add(this.search);
            this.searchPhone.Controls.Add(this.searchField);
            this.searchPhone.Controls.Add(this.label4);
            this.searchPhone.Location = new System.Drawing.Point(4, 25);
            this.searchPhone.Name = "searchPhone";
            this.searchPhone.Size = new System.Drawing.Size(481, 121);
            this.searchPhone.TabIndex = 4;
            this.searchPhone.Text = "Search Phone";
            this.searchPhone.UseVisualStyleBackColor = true;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(40, 165);
            this.grid.Name = "grid";
            this.grid.RowTemplate.Height = 24;
            this.grid.Size = new System.Drawing.Size(508, 210);
            this.grid.TabIndex = 1;
            this.grid.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_CellValidated);
            this.grid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.grid_CellValidating);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "To create a new phone book press Create.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // create
            // 
            this.create.Location = new System.Drawing.Point(179, 73);
            this.create.Name = "create";
            this.create.Size = new System.Drawing.Size(75, 23);
            this.create.TabIndex = 1;
            this.create.Text = "Create";
            this.create.UseVisualStyleBackColor = true;
            this.create.Click += new System.EventHandler(this.create_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(32, 17);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(45, 17);
            this.l1.TabIndex = 0;
            this.l1.Text = "Name";
            this.l1.Click += new System.EventHandler(this.label2_Click);
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(32, 45);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(62, 17);
            this.l2.TabIndex = 1;
            this.l2.Text = " Number";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(32, 77);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(60, 17);
            this.l3.TabIndex = 2;
            this.l3.Text = "Address";
            this.l3.Click += new System.EventHandler(this.address_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(150, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(100, 22);
            this.name.TabIndex = 3;
            this.name.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.name.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(150, 77);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(100, 22);
            this.address.TabIndex = 4;
            this.address.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.address.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(150, 45);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 22);
            this.number.TabIndex = 5;
            this.number.Validating += new System.ComponentModel.CancelEventHandler(this.textbox_Validating);
            this.number.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(291, 17);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 6;
            this.add.Text = "Add";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(291, 74);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 7;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(296, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Select a cell from the grid, edit number or/and";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(158, 81);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(285, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select a row from the grid and press Delete.";
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(152, 68);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 1;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Search by name";
            // 
            // searchField
            // 
            this.searchField.Location = new System.Drawing.Point(147, 62);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(100, 22);
            this.searchField.TabIndex = 1;
            this.searchField.Validating += new System.ComponentModel.CancelEventHandler(this.searchTextBox_Validating);
            this.searchField.Validated += new System.EventHandler(this.textbox_Validated);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(283, 32);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 2;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(283, 79);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 407);
            this.Controls.Add(this.options);
            this.Controls.Add(this.grid);
            this.Name = "Form1";
            this.Text = "Phone Book";
            this.options.ResumeLayout(false);
            this.newPhoneBook.ResumeLayout(false);
            this.newPhoneBook.PerformLayout();
            this.addNewPhone.ResumeLayout(false);
            this.addNewPhone.PerformLayout();
            this.editPhone.ResumeLayout(false);
            this.editPhone.PerformLayout();
            this.deletePhone.ResumeLayout(false);
            this.deletePhone.PerformLayout();
            this.searchPhone.ResumeLayout(false);
            this.searchPhone.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl options;
        private System.Windows.Forms.TabPage newPhoneBook;
        private System.Windows.Forms.TabPage addNewPhone;
        private System.Windows.Forms.TabPage editPhone;
        private System.Windows.Forms.TabPage deletePhone;
        private System.Windows.Forms.TabPage searchPhone;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Button cancel;
    }
}

