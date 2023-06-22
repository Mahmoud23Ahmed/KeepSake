namespace Note_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(259, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(264, 65);
            this.button1.TabIndex = 0;
            this.button1.Text = "ADD Notes";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button2.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(189, 265);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(10);
            this.button2.Size = new System.Drawing.Size(389, 68);
            this.button2.TabIndex = 1;
            this.button2.Text = "Search and Delete and View Notes";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Demi", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.button4.Location = new System.Drawing.Point(161, 158);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(10);
            this.button4.Size = new System.Drawing.Size(461, 65);
            this.button4.TabIndex = 3;
            this.button4.Text = "View and Edite and Delete Categories";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Desktop;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(211, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Note Application";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.BackgroundImage = global::Note_App.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button4;
        private Label label1;
    }
}