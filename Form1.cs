using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ybsödev2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "123456" && textBox1.Text == "admin123")
            {
                Form2 git = new Form2();
                git.Show();
                this.Hide();
                MessageBox.Show("Başarılı Giriş yaptınız");
            }

            else
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı","HATA");
                textBox2.Clear();
                textBox1.Clear();
            }
        }
    }
}
