namespace WinFormsApp8
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            button1 = new Button();
            ımageList1 = new ImageList(components);
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            button7 = new Button();
            ımageList2 = new ImageList(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.ImageKey = "cocuklistt.jpg";
            button1.ImageList = ımageList1;
            button1.Location = new Point(107, 40);
            button1.Name = "button1";
            button1.Size = new Size(188, 139);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "sihirbazın fili-hayvanlar.jpg");
            ımageList1.Images.SetKeyName(1, "bizim köyün şarkısı- iyi hissettiren.jpg");
            ımageList1.Images.SetKeyName(2, "evde tek başına-sıradaki önerimiz.jpg");
            ımageList1.Images.SetKeyName(3, "minyonlar-animasyon.jpg");
            ımageList1.Images.SetKeyName(4, "bir tuhaf futbol filmi-spor.jpg");
            ımageList1.Images.SetKeyName(5, "cocuklistt.jpg");
            // 
            // button2
            // 
            button2.ImageKey = "minyonlar-animasyon.jpg";
            button2.ImageList = ımageList1;
            button2.Location = new Point(379, 40);
            button2.Name = "button2";
            button2.Size = new Size(188, 139);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.ImageKey = "evde tek başına-sıradaki önerimiz.jpg";
            button4.ImageList = ımageList1;
            button4.Location = new Point(107, 264);
            button4.Name = "button4";
            button4.Size = new Size(188, 139);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.ImageKey = "sihirbazın fili-hayvanlar.jpg";
            button5.ImageList = ımageList1;
            button5.Location = new Point(379, 264);
            button5.Name = "button5";
            button5.Size = new Size(188, 139);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ControlText;
            label1.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ScrollBar;
            label1.Location = new Point(168, 196);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 6;
            label1.Text = "Listem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ControlText;
            label2.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ScrollBar;
            label2.Location = new Point(422, 196);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 7;
            label2.Text = "Animasyon";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ControlText;
            label4.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ScrollBar;
            label4.Location = new Point(121, 415);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 9;
            label4.Text = "Sıradaki Önerimiz";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ControlText;
            label5.Font = new Font("Segoe UI Black", 10.8F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ScrollBar;
            label5.Location = new Point(422, 415);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 10;
            label5.Text = "Hayvanlar";
            // 
            // button7
            // 
            button7.ImageKey = "geri dönüş.png";
            button7.ImageList = ımageList2;
            button7.Location = new Point(29, 40);
            button7.Name = "button7";
            button7.Size = new Size(56, 57);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // ımageList2
            // 
            ımageList2.ColorDepth = ColorDepth.Depth32Bit;
            ımageList2.ImageStream = (ImageListStreamer)resources.GetObject("ımageList2.ImageStream");
            ımageList2.TransparentColor = Color.Transparent;
            ımageList2.Images.SetKeyName(0, "geri dönüş.png");
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(682, 475);
            Controls.Add(button7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            FormClosed += Form4_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private ImageList ımageList1;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Button button7;
        private ImageList ımageList2;
    }
}