using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneBook
{
    public partial class Form1 : Form
    {
        private SortedList<string, Phone> book;

        public Form1()
        {
            InitializeComponent();
            book = new SortedList<string, Phone>();
            InitializeGrid();
            // Explicit validation
            AutoValidate = AutoValidate.Disable;
        }

        private void options_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (options.SelectedIndex)
            {
                case 0: // New Phone Book tab page
                    grid.Columns["number"].ReadOnly = true;
                    grid.Columns["address"].ReadOnly = true;
                    break;
                case 1: // Add New Phone tab page
                    grid.Columns["number"].ReadOnly = true;
                    grid.Columns["address"].ReadOnly = true;
                    // Restriction on controls that support validation
                    number.Visible = true;
                    address.Visible = true;
                    name.Visible = true;
                    searchField.Visible = false;
                    break;
                case 2: // Edit Phone tab page
                    grid.Columns["number"].ReadOnly = false;
                    grid.Columns["address"].ReadOnly = false;
                    break;
                case 3: // Delete Phone tab page
                    grid.Columns["number"].ReadOnly = true;
                    grid.Columns["address"].ReadOnly = true;
                    break;
                case 4: // Search Phone tab page
                    grid.Columns["number"].ReadOnly = true;
                    grid.Columns["address"].ReadOnly = true;
                    // Restriction on controls that support validation
                    name.Visible = false;
                    address.Visible = false;
                    number.Visible = false;
                    searchField.Visible = true;
                    break;
            }
        }

        private void grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            grid.Rows[e.RowIndex].ErrorText = "";
            long newInteger;
            if (grid.Columns[e.ColumnIndex].Name == "number")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    grid.Rows[e.RowIndex].ErrorText = "Required field";
                    e.Cancel = true;
                }
                else if (!long.TryParse(e.FormattedValue.ToString(),
                out newInteger))
                {
                    grid.Rows[e.RowIndex].ErrorText = "Invalid number";
                    e.Cancel = true;
                }
            }
            else if (grid.Columns[e.ColumnIndex].Name == "address")
            {
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    grid.Rows[e.RowIndex].ErrorText = "Required field";
                    e.Cancel = true;
                }
            }
        }

        private void grid_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            // Clear error messages that may have been set in cell
            // validation.
            grid.Rows[e.RowIndex].ErrorText = null;
        }

        private void InitializeGrid()
        {
            // Adds columns with column name and column header text
            grid.Columns.Add("name", "Name");
            grid.Columns.Add("number", "Number");
            grid.Columns.Add("address", "Address");
            // Sets columns read only
            grid.Columns["name"].ReadOnly = true;
            grid.Columns["number"].ReadOnly = true;
            grid.Columns["address"].ReadOnly = true;
            // Option to add rows is not displayed to the user
            grid.AllowUserToAddRows = false;
            // Clears all rows in the grid
            grid.Rows.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void create_Click(object sender, EventArgs e)
        {
            book = new SortedList<string, Phone>();
            grid.Rows.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            // Creates a new phone
            Phone p = new Phone();
            // Validates all child controls within a form
            // that support validation with restriction Visible
            if (ValidateChildren(ValidationConstraints.Visible))
            {
                p.Name = name.Text;
                p.Number = long.Parse(number.Text);
                p.Address = address.Text;
                // Adds the phone to the phone book and checks
                // if the phone book contains entry with the same name
                try
                {
                    book.Add(p.Name, p);
                }
                catch (ArgumentException)
                {
                    error.SetError(l1, "Duplicate name");
                    return;
                }
                // Adds the phone to the grid
                AddToGrid(p);
                // Clears the content of the text boxes and errors
                clear_Click(sender, e);
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            // Clears the content of all text boxes
            number.Text = "";
            address.Text = "";
            name.Text = "";
            // Clears all errors
            error.SetError(number, "");
            error.SetError(address, "");
            error.SetError(name, "");
        }

        private void textbox_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;
            error.SetError(tb, "");
            if (tb.Name == "name")
            {
                if (!IsEmpty(tb))
                    e.Cancel = true;
            }
            else if (tb.Name == "number")
            {
                long newInteger;
                if (!IsEmpty(tb))
                    e.Cancel = true;
                else if (!IsLongNumber(tb, out newInteger))
                    e.Cancel = true;
            }
            else if (tb.Name == "address")
            {
                if (!IsEmpty(tb))
                    e.Cancel = true;
            }
        }

        private void textbox_Validated(object sender, EventArgs e)
        {
            // If all conditions have been met,
            // clear the ErrorProvider of errors.
            error.SetError((TextBox)sender, "");
        }
        private bool IsEmpty(TextBox tb)
        {
            bool flag = true;
            if (string.IsNullOrEmpty(tb.Text))
            {
                // Set the ErrorProvider error with the text to display
                error.SetError(tb, "Required field");
                flag = false;
            }
            else
                error.SetError(tb, "");
            return flag;
        }

        private bool IsLongNumber(TextBox tb, out long n)
        {
            bool flag = true;
            n = 0;
            try
            {
                n = long.Parse(tb.Text);
                error.SetError(tb, "");
            }
            catch (Exception)
            {
                error.SetError(tb, "Invalid number");
                flag = false;
            }
            return flag;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x10) 
                 AutoValidate = AutoValidate.Disable;
            base.WndProc(ref m);
        }

        private void AddToGrid(Phone p)
        {
            // Adds a new row to the grid and returns the index
            int index = grid.Rows.Add();
            // Gets the row with index
            DataGridViewRow row = grid.Rows[index];
            // Sets the cell value in each column
            row.Cells["name"].Value = p.Name;
            row.Cells["number"].Value = p.Number;
            row.Cells["address"].Value = p.Address;
            // Sorts the contents of the grid in ascending order
            // based on the contents of the first column
            DataGridViewColumn column = grid.Columns[0];
            grid.Sort(column, ListSortDirection.Ascending);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (book.Count == 0)
            {
                MessageBox.Show("Empty phone book");
                return;
            }
            // Crete a new phone
            Phone p = new Phone();
            // Finds the row index of the current cell
            int rowIndex = grid.CurrentCell.RowIndex;
            // Finds the row with this index
            DataGridViewRow row = grid.Rows[rowIndex];
            // Gets the value associated with the cell
            p.Name = row.Cells["name"].Value.ToString();
            p.Number = long.Parse(row.Cells["number"].Value.ToString());
            p.Address = row.Cells["address"].Value.ToString();
            // Update the phone in the phone book
            book[p.Name] = p;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (book.Count == 0)
            {
                MessageBox.Show("Empty phone book");
                return;
            }
            // If there are selected rows
            if (grid.SelectedRows.Count > 0)
            {
                // Finds the position of the first selected row
                int position =
                grid.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                // Removes the row at this position
                if (position > -1)
                    grid.Rows.RemoveAt(position);
                // Removes the phone from the phone book at this position
                book.RemoveAt(position);
            }
        }

        private void searchTextBox_Validating(object sender, CancelEventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {
            int countPhones = book.Count;

            if(countPhones==0)
            {
                MessageBox.Show("Empty phone book");
                return;
            }
            

            var searchedName = searchField.Text;

            var hasFounded = book.ContainsKey(searchedName);
            
            

            if (hasFounded)
            {
               var indexOfRow = book.Keys.IndexOf(searchedName);
                DataGridViewRow foundedRow = grid.Rows[indexOfRow];

                for (int i = 0; i < grid.Rows.Count; i++)
                {
                    grid.Rows[i].Selected = false;
                }

                grid.Rows[indexOfRow].Selected = true;
            } else
            {
                MessageBox.Show("The phone book does not contain this name");
                return;
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {

        }

        private void address_Click(object sender, EventArgs e)
        {

        }
    }
}
