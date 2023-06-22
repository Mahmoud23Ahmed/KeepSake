using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Note_App.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Note_App
{
    public partial class Categories : Form
    {

        NotesContext context = new NotesContext();
         Category n = new Category();

        public Categories()
        {
            InitializeComponent();

            var data = context.Categories.Select(data => new { category = data.CategName })
                                            .ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Categories_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             Category c = new Category() {

              CategName  = textBox1.Text,

            };
            context.Categories.Add(c);
            context.SaveChanges();
            var s = context.Categories.Select(s => new { Category = s.CategName }).ToList();
            dataGridView1.DataSource = s;
            textBox1.Text = "";

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var note = context.Categories.Where(note => note.CategName == textBox1.Text)
               .Select(note => note)
               .First();

            note.CategName = textBox2.Text;
            context.Entry(note).State = EntityState.Modified;
            context.SaveChanges();

            var s = context.Categories
            .Select(s => new {Category = s.CategName })
            .ToList();
            dataGridView1.DataSource = s;
            textBox1.Text = "";
            textBox2.Text = "";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Category n = new Category()
            {
                CategName = textBox1.Text,
            };

            var itemToRemove = context.Categories.SingleOrDefault(x => x.CategName.Contains(textBox1.Text));
            DialogResult dialogResult = MessageBox.Show("sure", "Are you sure to delete this category", MessageBoxButtons.YesNo);

            if (itemToRemove != null && dialogResult == DialogResult.Yes)
            {

                context.Categories.Remove(itemToRemove);
                context.SaveChanges();
                var s = context.Categories
            .Select(s => new { Category = s.CategName })
            .ToList();
                dataGridView1.DataSource = s;
                textBox1.Text = "";

            }
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            Categories c = new Categories();
           
            if(dataGridView1.CurrentRow.Index != -1)
            {              
               n.CategName  = (dataGridView1.CurrentRow.Cells["category"].Value).ToString();
                textBox1.Text = n.CategName;

            }
        }
            
        }
    }




