namespace WinFormsApp8
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ımageList2 = new ImageList(components);
            button7 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageKey = "mervelist.jpg";
            button1.ImageList = ımageList1;
            button1.Location = new Point(105, 24);
            button1.Name = "button1";
            button1.Size = new Size(162, 191);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "extraction.jpg");
            ımageList1.Images.SetKeyName(1, "kar kardeşliği.jpg");
            ımageList1.Images.SetKeyName(2, "recep ivedik.jpg");
            ımageList1.Images.SetKeyName(3, "topgun.jpg");
            ımageList1.Images.SetKeyName(4, "ölümlü dünya.jpg");
            ımageList1.Images.SetKeyName(5, "mervelist.jpg");
            // 
            // button2
            // 
            button2.ImageKey = "ölümlü dünya.jpg";
            button2.ImageList = ımageList1;
            button2.Location = new Point(321, 24);
            button2.Name = "button2";
            button2.Size = new Size(162, 191);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.ImageKey = "recep ivedik.jpg";
            button3.ImageList = ımageList1;
            button3.Location = new Point(539, 24);
            button3.Name = "button3";
            button3.Size = new Size(162, 191);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.ImageKey = "topgun.jpg";
            button4.ImageList = ımageList1;
            button4.Location = new Point(105, 261);
            button4.Name = "button4";
            button4.Size = new Size(162, 191);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ImageKey = "kar kardeşliği.jpg";
            button5.ImageList = ımageList1;
            button5.Location = new Point(321, 261);
            button5.Name = "button5";
            button5.Size = new Size(162, 191);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.ImageKey = "extraction.jpg";
            button6.ImageList = ımageList1;
            button6.Location = new Point(539, 261);
            button6.Name = "button6";
            button6.Size = new Size(162, 191);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(153, 224);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 6;
            label1.Text = "Listem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(347, 224);
            label2.Name = "label2";
            label2.Size = new Size(122, 25);
            label2.TabIndex = 7;
            label2.Text = "Yerli Filmler";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ScrollBar;
            label3.Location = new Point(548, 224);
            label3.Name = "label3";
            label3.Size = new Size(154, 25);
            label3.TabIndex = 8;
            label3.Text = "Komedi Filmleri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(96, 460);
            label4.Name = "label4";
            label4.Size = new Size(182, 25);
            label4.TabIndex = 9;
            label4.Text = "Hollywood Filmleri";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(338, 460);
            label5.Name = "label5";
            label5.Size = new Size(140, 25);
            label5.TabIndex = 10;
            label5.Text = "Ödüllü Filmler";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ScrollBar;
            label6.Location = new Point(506, 460);
            label6.Name = "label6";
            label6.Size = new Size(254, 25);
            label6.TabIndex = 11;
            label6.Text = "Aksiyon ve Macera Filmleri";
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "geri dönüş.png");
            // 
            // button7
            // 
            button7.ImageKey = "geri dönüş.png";
            button7.ImageList = ımageList2;
            button7.Location = new Point(31, 24);
            button7.Name = "button7";
            button7.Size = new Size(56, 57);
            button7.TabIndex = 12;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(802, 518);
            Controls.Add(button7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            FormClosed += Form3_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private ImageList ımageList1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ImageList ımageList2;
        private Button button7;
    }
}