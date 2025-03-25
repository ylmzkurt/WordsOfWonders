namespace WordsOfWonders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            baslat = new Button();
            gizle = new Button();
            kapat = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("MV Boli", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkRed;
            label1.Location = new Point(48, 30);
            label1.Name = "label1";
            label1.Size = new Size(769, 63);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Words of Wonders!";
            // 
            // baslat
            // 
            baslat.BackColor = Color.Lime;
            baslat.Cursor = Cursors.Hand;
            baslat.FlatAppearance.BorderSize = 0;
            baslat.FlatAppearance.MouseDownBackColor = Color.Green;
            baslat.FlatAppearance.MouseOverBackColor = Color.Green;
            baslat.FlatStyle = FlatStyle.Flat;
            baslat.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            baslat.ForeColor = Color.White;
            baslat.Location = new Point(48, 190);
            baslat.Name = "baslat";
            baslat.Size = new Size(237, 57);
            baslat.TabIndex = 1;
            baslat.Text = "Easy Mode";
            baslat.UseVisualStyleBackColor = false;
            baslat.Click += baslat_Click;
            // 
            // gizle
            // 
            gizle.BackColor = Color.Transparent;
            gizle.FlatAppearance.BorderSize = 0;
            gizle.FlatAppearance.MouseDownBackColor = Color.Teal;
            gizle.FlatAppearance.MouseOverBackColor = Color.Teal;
            gizle.FlatStyle = FlatStyle.Flat;
            gizle.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            gizle.Location = new Point(740, -8);
            gizle.Name = "gizle";
            gizle.Size = new Size(64, 43);
            gizle.TabIndex = 2;
            gizle.Text = "__";
            gizle.TextAlign = ContentAlignment.TopCenter;
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
            kapat.Location = new Point(805, 0);
            kapat.Name = "kapat";
            kapat.Size = new Size(65, 35);
            kapat.TabIndex = 3;
            kapat.Text = "x";
            kapat.UseVisualStyleBackColor = false;
            kapat.Click += button1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.ForeColor = Color.White;
            button1.Location = new Point(312, 190);
            button1.Name = "button1";
            button1.Size = new Size(237, 57);
            button1.TabIndex = 4;
            button1.Text = "Normal Mode";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Green;
            button2.FlatAppearance.MouseOverBackColor = Color.Green;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("MS Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.ForeColor = Color.White;
            button2.Location = new Point(580, 190);
            button2.Name = "button2";
            button2.Size = new Size(237, 57);
            button2.TabIndex = 5;
            button2.Text = "Hard Mode";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(870, 470);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(kapat);
            Controls.Add(gizle);
            Controls.Add(baslat);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button baslat;
        private Button gizle;
        private Button kapat;
        private Button button1;
        private Button button2;
    }
}
