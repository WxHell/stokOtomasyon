    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    namespace stokKontrol
    {
    public partial class Form2 : Form
    {
        private object[] row;

        public Form2()
        {
            InitializeComponent();
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            string ekle = textBox1.Text;
            uint urun_adet = Convert.ToUInt32(textBox2.Text);
            textBox1.Text = "";
            textBox2.Text = "";


            bool urunBulundu = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)//satırları geziyor
            {
                if (row.Cells[0].Value?.ToString() == ekle)//eğer satırlarda aynı isme değer 
                {

                    uint mevcutAdet = Convert.ToUInt32(row.Cells[1].Value);
                    row.Cells[1].Value = mevcutAdet + urun_adet;
                    urunBulundu = true;
                    break;
                }
            }

            if (!urunBulundu)
            {
                //eğer bulunmadıysa yeni bir ürün olarak eklenir
                dataGridView1.Rows.Add(new object[] { ekle, urun_adet });
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string toUpper = textBox4.Text;
            string urunAdi = toUpper;
            int azaltmakIstenenMiktar = Convert.ToInt32(textBox3.Text);

            if (string.IsNullOrEmpty(urunAdi))
            {
                MessageBox.Show("Lütfen ürün adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text, out azaltmakIstenenMiktar))
            //out metot tarafından dışarıya bir değer döndürmesi gerektiğini belirtmek için kullanılır
            {
                MessageBox.Show("Geçerli bir miktar girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool urunBulundu = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == urunAdi)
                {
                    int currentQuantity = Convert.ToInt32(row.Cells[1].Value);

                    if (currentQuantity >= azaltmakIstenenMiktar)
                    {
                        row.Cells[1].Value = currentQuantity - azaltmakIstenenMiktar;
                        urunBulundu = true;
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz miktar. Mevcut miktardan daha fazlasını eksiltemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string urunAdı = textBox5.Text;
            if (string.IsNullOrEmpty(urunAdı))
            {
                MessageBox.Show("Lütfen ürün adını girin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            bool urunBulundu = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[0].Value.ToString() == urunAdı)
                {
                    int currentQuantity = Convert.ToInt32(row.Cells[1].Value);

                    if (currentQuantity != null)
                    {
                        row.Cells[1].Value = currentQuantity;
                        MessageBox.Show($"Ürün: {urunAdı} Adet: {currentQuantity}");
                        textBox4.Text = "";
                        urunBulundu = true;
                    }
                    else
                    {
                        MessageBox.Show("Yetersiz miktar. Mevcut miktardan daha fazlasını eksiltemezsiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    break;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}


    


