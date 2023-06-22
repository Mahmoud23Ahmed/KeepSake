namespace Note_App
{
    partial class All_Notes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(651, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(625, 360);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(272, 27);
            this.textBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(243, 169);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(272, 27);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(42, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 40);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search by Title";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(117, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Demi", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(117, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Date";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lavender;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(376, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(202, 40);
            this.button2.TabIndex = 5;
            this.button2.Text = "Search by Date";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Lavender;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(151, 332);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(351, 40);
            this.button4.TabIndex = 7;
            this.button4.Text = "Search by Title and Date";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Lavender;
            this.button3.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button3.Location = new System.Drawing.Point(214, 398);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(202, 40);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete by Title";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // All_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1304, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "All_Notes";
            this.Text = "All_Notes";
            this.Load += new System.EventHandler(this.All_Notes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Label label1;
        private Label label2;
        private Button button2;
        private Button button4;
        private Button button3;
    }
}