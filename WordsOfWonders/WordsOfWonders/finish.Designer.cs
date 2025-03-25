namespace WordsOfWonders
{
    partial class finish
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finish));
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            baslat = new Button();
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
            button1.Location = new Point(720, -5);
            button1.Name = "button1";
            button1.Size = new Size(67, 41);
            button1.TabIndex = 18;
            button1.Text = "__";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Firebrick;
            button2.FlatAppearance.MouseOverBackColor = Color.Firebrick;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(789, 0);
            button2.Name = "button2";
            button2.Size = new Size(86, 36);
            button2.TabIndex = 17;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(236, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 156);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 162);
            label1.ForeColor = Color.Gold;
            label1.Location = new Point(111, 404);
            label1.Name = "label1";
            label1.Size = new Size(644, 41);
            label1.TabIndex = 20;
            label1.Text = "You have successfully completed the game.";
            // 
            // baslat
            // 
            baslat.BackColor = Color.LightSalmon;
            baslat.Cursor = Cursors.Hand;
            baslat.FlatAppearance.BorderSize = 0;
            baslat.FlatAppearance.MouseDownBackColor = Color.DarkSalmon;
            baslat.FlatAppearance.MouseOverBackColor = Color.DarkSalmon;
            baslat.FlatStyle = FlatStyle.Flat;
            baslat.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            baslat.ForeColor = Color.White;
            baslat.Location = new Point(322, 325);
            baslat.Name = "baslat";
            baslat.Size = new Size(237, 57);
            baslat.TabIndex = 21;
            baslat.Text = "Return to Menu";
            baslat.UseVisualStyleBackColor = false;
            baslat.Click += baslat_Click;
            // 
            // finish
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(870, 471);
            Controls.Add(baslat);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(button2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "finish";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "finish";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label1;
        private Button baslat;
    }
}