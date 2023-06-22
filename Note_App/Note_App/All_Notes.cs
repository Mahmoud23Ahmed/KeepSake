using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Note_App
{
    public partial class All_Notes : Form
    {
        NotesContext context = new NotesContext();
        Note n = new Note();
        public All_Notes()
        {
            InitializeComponent();
            var data = context.Notes.Select(data => new { Title = data.Title, Date = data.Date, Body = data.Body , Category = data.Categ.CategName}).ToList();          
            dataGridView1.DataSource = data;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        

        private void All_Notes_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {  
            var searchword = textBox1.Text;
            var data = context.Notes.Where(data =>  data.Title.ToLower().Contains(searchword.ToLower()))
                                             .Select(data => new { title = data.Title, date = data.Date , body = data.Body , Category = data.Categ.CategName})
                                             .ToList();
            dataGridView1.DataSource=data;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            var searchdate = dateTimePicker1.Value.ToLocalTime();
            var data = context.Notes.Where(data => data.Date == searchdate)
                                             .Select(data => new { title = data.Title, date = data.Date, body = data.Body, Category = data.Categ.CategName })
                                             .ToList();
            dataGridView1.DataSource = data;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var searchword = textBox1.Text;
            var data = context.Notes.Where(data => data.Title.ToLower().Contains(searchword.ToLower()))
                                             .Select(data => new { title = data.Title, date = data.Date, body = data.Body, Category = data.Categ.CategName })
                                             .ToList();
            dataGridView1.DataSource = data;
            var searchdate = dateTimePicker1.Value.ToLocalTime();
            var data2 = context.Notes.Where(data => data.Date == searchdate)
                                             .Select(data => new { title = data.Title, date = data.Date, body = data.Body, Category = data.Categ.CategName })
                                             .ToList();
            dataGridView1.DataSource = data2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Note n = new Note()
            {
                Title = textBox1.Text,
            };

            var itemToRemove = context.Notes.SingleOrDefault(x => x.Title.Contains(textBox1.Text));
            DialogResult dialogResult = MessageBox.Show("sure", "Are you sure to delete this category", MessageBoxButtons.YesNo);

            if (itemToRemove != null && dialogResult == DialogResult.Yes)
            {
                context.Notes.Remove(itemToRemove);
                context.SaveChanges();
                var s = context.Notes
               .Select(s => new { Title = s.Title, Date = s.Date, Body = s.Body, Category = s.Categ.CategName })
             .ToList();
                dataGridView1.DataSource = s;
                textBox1.Text = "";
            }
        }
    }
}
