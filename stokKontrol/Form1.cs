namespace stokKontrol
{
    public partial class Form1 : Form
    {
        private string user = "root";
        private string sifre = "123";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            Form1 form1 = new Form1();
            string giris = kullanýcý_giris.Text;
            string sifre_giris = this.sifre_giris.Text;
            if (giris == user && sifre_giris == sifre)
            {
                MessageBox.Show("Baþarýlý");
                form2.Show();
                form1.Close();
            }
            else
            {
                MessageBox.Show("hatalý");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sifre_giris_TextChanged(object sender, EventArgs e)
        {
           sifre_giris.PasswordChar = '*';
  

        }
    }
}
