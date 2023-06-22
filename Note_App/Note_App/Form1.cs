namespace Note_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_Notes add = new ADD_Notes();
            add.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            All_Notes all = new All_Notes();
            all.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Categories categories = new Categories();
            categories.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }
    }
}