namespace stokKontrol
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
            label2 = new Label();
            kullanıcı_giris = new TextBox();
            sifre_giris = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonFace;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label1.Location = new Point(194, 171);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Giriş";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonFace;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.Location = new Point(194, 241);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 1;
            label2.Text = "Şifre Girişi";
            // 
            // kullanıcı_giris
            // 
            kullanıcı_giris.Location = new Point(380, 171);
            kullanıcı_giris.Name = "kullanıcı_giris";
            kullanıcı_giris.Size = new Size(190, 27);
            kullanıcı_giris.TabIndex = 2;
            // 
            // sifre_giris
            // 
            sifre_giris.BorderStyle = BorderStyle.FixedSingle;
            sifre_giris.Location = new Point(380, 241);
            sifre_giris.Name = "sifre_giris";
            sifre_giris.Size = new Size(190, 27);
            sifre_giris.TabIndex = 3;
            sifre_giris.TextChanged += sifre_giris_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(261, 354);
            button1.Name = "button1";
            button1.Size = new Size(176, 35);
            button1.TabIndex = 4;
            button1.Text = "Giriş";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button2.Location = new Point(535, 356);
            button2.Name = "button2";
            button2.Size = new Size(162, 35);
            button2.TabIndex = 5;
            button2.Text = "Uygulamayı Kapat";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(993, 673);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sifre_giris);
            Controls.Add(kullanıcı_giris);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox kullanıcı_giris;
        private TextBox sifre_giris;
        private Button button1;
        private Button button2;
    }
}
