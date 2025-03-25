namespace WordsOfWonders
{
    partial class soru1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(soru1));
            gizle = new Button();
            kapat = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            button1 = new Button();
            onayla = new Button();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gizle
            // 
            gizle.BackColor = Color.Transparent;
            gizle.FlatAppearance.BorderSize = 0;
            gizle.FlatAppearance.MouseDownBackColor = Color.Teal;
            gizle.FlatAppearance.MouseOverBackColor = Color.Teal;
            gizle.FlatStyle = FlatStyle.Flat;
            gizle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gizle.Location = new Point(719, -8);
            gizle.Name = "gizle";
            gizle.Size = new Size(75, 43);
            gizle.TabIndex = 0;
            gizle.Text = "__";
            gizle.UseVisualStyleBackColor = false;
            gizle.Click += gizle_Click;
            // 
            // kapat
            // 
            kapat.BackColor = Color.Transparent;
            kapat.FlatAppearance.BorderSize = 0;
            kapat.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            kapat.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            kapat.FlatStyle = FlatStyle.Flat;
            kapat.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            kapat.Location = new Point(794, -1);
            kapat.Name = "kapat";
            kapat.Size = new Size(77, 38);
            kapat.TabIndex = 1;
            kapat.Text = "x";
            kapat.UseVisualStyleBackColor = false;
            kapat.Click += kapat_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(111, 55);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(174, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(241, 21);
            label1.TabIndex = 3;
            label1.Text = "Write what the picture below is.";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(onayla);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Font = new Font("Segoe UI Black", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(13, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(363, 335);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Question-1";
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Silver;
            button1.FlatAppearance.MouseOverBackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(313, 8);
            button1.Name = "button1";
            button1.Size = new Size(44, 44);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // onayla
            // 
            onayla.BackColor = Color.Lime;
            onayla.Cursor = Cursors.Hand;
            onayla.FlatAppearance.BorderSize = 0;
            onayla.FlatAppearance.MouseDownBackColor = Color.Green;
            onayla.FlatAppearance.MouseOverBackColor = Color.Green;
            onayla.FlatStyle = FlatStyle.Flat;
            onayla.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            onayla.ForeColor = Color.White;
            onayla.Location = new Point(132, 279);
            onayla.Name = "onayla";
            onayla.Size = new Size(129, 39);
            onayla.TabIndex = 6;
            onayla.Text = "Continue";
            onayla.UseVisualStyleBackColor = false;
            onayla.Click += onayla_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            textBox1.Location = new Point(87, 241);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 29);
            textBox1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(15, 243);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 4;
            label2.Text = "Answer :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Sylfaen", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label3.ForeColor = Color.DarkRed;
            label3.Location = new Point(13, 15);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Level : 1";
            // 
            // soru1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 471);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(kapat);
            Controls.Add(gizle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "soru1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "soru1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button gizle;
        private Button kapat;
        private PictureBox pictureBox1;
        private Label label1;
        private GroupBox groupBox1;
        private Button onayla;
        private TextBox textBox1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}