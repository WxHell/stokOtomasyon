
namespace stokKontrol
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            ekle = new Button();
            satınAl = new Button();
            textBox1 = new TextBox();
            form2BindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            product = new DataGridViewTextBoxColumn();
            adet = new DataGridViewTextBoxColumn();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            textBox5 = new TextBox();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)form2BindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ekle
            // 
            ekle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            ekle.Location = new Point(98, 176);
            ekle.Name = "ekle";
            ekle.Size = new Size(94, 31);
            ekle.TabIndex = 2;
            ekle.Text = "ekle";
            ekle.UseVisualStyleBackColor = true;
            ekle.UseWaitCursor = true;
            ekle.Click += ekle_Click;
            // 
            // satınAl
            // 
            satınAl.Location = new Point(559, 177);
            satınAl.Name = "satınAl";
            satınAl.Size = new Size(94, 30);
            satınAl.TabIndex = 5;
            satınAl.Text = "satın al";
            satınAl.UseVisualStyleBackColor = true;
            satınAl.UseWaitCursor = true;
            satınAl.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(137, 27);
            textBox1.TabIndex = 7;
            textBox1.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { product, adet });
            dataGridView1.Location = new Point(440, 324);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(302, 223);
            dataGridView1.TabIndex = 8;
            dataGridView1.UseWaitCursor = true;
            dataGridView1.Visible = false;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // product
            // 
            product.HeaderText = "product";
            product.MinimumWidth = 6;
            product.Name = "product";
            product.Width = 125;
            // 
            // adet
            // 
            adet.HeaderText = "adet";
            adet.MinimumWidth = 6;
            adet.Name = "adet";
            adet.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 31);
            label1.Name = "label1";
            label1.Size = new Size(90, 28);
            label1.TabIndex = 9;
            label1.Text = "Ürün Adı";
            label1.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(61, 28);
            label2.TabIndex = 10;
            label2.Text = "Sayısı";
            label2.UseWaitCursor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(167, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(136, 27);
            textBox2.TabIndex = 11;
            textBox2.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ButtonFace;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.Location = new Point(456, 109);
            label3.Name = "label3";
            label3.Size = new Size(76, 28);
            label3.TabIndex = 12;
            label3.Text = "Satın al";
            label3.UseWaitCursor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(655, 109);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            textBox3.UseWaitCursor = true;
            // 
            // button2
            // 
            button2.Location = new Point(28, 443);
            button2.Name = "button2";
            button2.Size = new Size(164, 29);
            button2.TabIndex = 14;
            button2.Text = "Ürünleri göster";
            button2.UseVisualStyleBackColor = true;
            button2.UseWaitCursor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonFace;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label4.Location = new Point(456, 31);
            label4.Name = "label4";
            label4.Size = new Size(112, 28);
            label4.TabIndex = 15;
            label4.Text = "Ürünün Adı";
            label4.UseWaitCursor = true;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(655, 35);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 27);
            textBox4.TabIndex = 16;
            textBox4.UseWaitCursor = true;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonFace;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label5.Location = new Point(850, 35);
            label5.Name = "label5";
            label5.Size = new Size(112, 28);
            label5.TabIndex = 17;
            label5.Text = "Ürünün Adı";
            label5.UseWaitCursor = true;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(1034, 36);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(148, 27);
            textBox5.TabIndex = 18;
            textBox5.UseWaitCursor = true;
            // 
            // button1
            // 
            button1.Location = new Point(957, 130);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Sorgula";
            button1.UseVisualStyleBackColor = true;
            button1.UseWaitCursor = true;
            button1.Click += button1_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(28, 506);
            button3.Name = "button3";
            button3.Size = new Size(164, 29);
            button3.TabIndex = 20;
            button3.Text = "kapat";
            button3.UseVisualStyleBackColor = true;
            button3.UseWaitCursor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(878, 506);
            button4.Name = "button4";
            button4.Size = new Size(152, 29);
            button4.TabIndex = 21;
            button4.Text = "uygulamayı kapat";
            button4.UseVisualStyleBackColor = true;
            button4.UseWaitCursor = true;
            button4.Click += button4_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1194, 607);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(satınAl);
            Controls.Add(ekle);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            Text = "Form2";
            UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)form2BindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Button ekle;
        private Button satınAl;
        private TextBox textBox1;
        private BindingSource form2BindingSource;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn product;
        private DataGridViewTextBoxColumn adet;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button button2;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private TextBox textBox5;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}