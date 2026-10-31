namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Form2 form2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Hide();
                form2.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("reCAPTCHA Nedir?: reCAPTCHA, bir hizmet olarak web sitelerinin botlara karþý korunmasýný saðlar. Kullanýcýlarýn insan olduðunu doðrulamak için çeþitli testler içerir.");
        }
    }
}
