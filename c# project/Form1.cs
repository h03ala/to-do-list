using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace to_do_list_app
{
    public partial class todolist : Form
    {
        public todolist()
        {
            InitializeComponent();
        }
        DataTable todoList= new DataTable();
        bool isEditing = false;

        private void Form1_Load(object sender, EventArgs e)
        {
         todoList.Columns.Add("Title");
         todoList.Columns.Add("Description");


        todolistView.DataSource =todoList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            titletextBox.Text = "";
            descriptionTextBox.Text = "";

        }


        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            titletextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
            todoList.Rows[todolistView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex) {

                Console.WriteLine("Error: " + ex);
            
            
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Title"] = titletextBox.Text;
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;
            }
            else
            {

            todoList.Rows.Add(titletextBox.Text, descriptionTextBox.Text);
            }
            titletextBox.Text = "";
            descriptionTextBox.Text = "";
            isEditing = false;
        }
    }
}
