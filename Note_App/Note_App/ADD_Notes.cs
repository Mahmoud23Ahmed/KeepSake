

using Note_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Note_App
{
    public partial class ADD_Notes : Form
    {
        
        NotesContext context = new NotesContext();
        public ADD_Notes()
        {
            InitializeComponent();
            comboBox1.DataSource = context.Categories.ToList();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "CategName";
            this.dateTimePicker1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Note n = new Note()
            {
                Title = textBox1.Text,
                Date = dateTimePicker1.Value.ToLocalTime(),
                CategId = int.Parse(comboBox1.SelectedValue.ToString()),
                Body = richTextBox1.Text
            };
            context.Notes.Add(n);
            context.SaveChanges();
            MessageBox.Show("Successfully Added", " Notes Record", MessageBoxButtons.OK, MessageBoxIcon.Information);
  
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
