namespace WordsOfWonders
{
    partial class soru13
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soru13));
            button1 = new Button();
            groupBox1 = new GroupBox();
            label4 = new Label();
            progressBar1 = new ProgressBar();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            onayla = new Button();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            button2 = new Button();
            label1 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Teal;
            button1.FlatAppearance.MouseOverBackColor = Color.Teal;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(717, -7);
            button1.Name = "button1";
            button1.Size = new Size(67, 41);
            button1.TabIndex = 44;
            button1.Text = "__";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(progressBar1);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(onayla);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(9, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(364, 389);
            groupBox1.TabIndex = 42;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question-3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label4.Location = new Point(34, 256);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 12;
            label4.Text = "Time :";
            // 
            // progressBar1
            // 
            progressBar1.BackColor = Color.Black;
            progressBar1.ForeColor = Color.Yellow;
            progressBar1.Location = new Point(91, 258);
            progressBar1.Maximum = 300;
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(218, 21);
            progressBar1.Step = 100;
            progressBar1.TabIndex = 11;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = (Image)resources.GetObject("button3.BackgroundImage");
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Silver;
            button3.FlatAppearance.MouseOverBackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(314, 8);
            button3.Name = "button3";
            button3.Size = new Size(44, 44);
            button3.TabIndex = 10;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(108, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(184, 185);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // onayla
            // 
            onayla.BackColor = Color.Lime;
            onayla.Cursor = Cursors.Hand;
            onayla.FlatAppearance.BorderSize = 0;
            onayla.FlatStyle = FlatStyle.Flat;
            onayla.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            onayla.ForeColor = Color.White;
            onayla.Location = new Point(133, 331);
            onayla.Name = "onayla";
            onayla.Size = new Size(129, 39);
            onayla.TabIndex = 7;
            onayla.Text = "Continue";
            onayla.UseVisualStyleBackColor = false;
            onayla.Click += onayla_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(6, 36);
            label3.Name = "label3";
            label3.Size = new Size(241, 21);
            label3.TabIndex = 5;
            label3.Text = "Write what the picture below is.";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(91, 293);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(218, 32);
            textBox1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(16, 297);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 3;
            label2.Text = "Answer :";
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button2.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(786, -2);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 43;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(9, 9);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 41;
            label1.Text = "Level : 3";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // soru13
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 470);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "soru13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "soru13";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private GroupBox groupBox1;
        private Label label4;
        private ProgressBar progressBar1;
        private Button button3;
        private PictureBox pictureBox1;
        private Button onayla;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}