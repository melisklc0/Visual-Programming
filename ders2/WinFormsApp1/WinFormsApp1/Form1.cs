namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted == false)
            {
                MessageBox.Show("Telefon numarasi icin gerekli alani doldurunuz!");
                label3.Text = " "; //alaný temizledik
                maskedTextBox1.Focus();
            }
            else
            {
                label3.Text = maskedTextBox1.Text;
            }

            if (maskedTextBox2.MaskCompleted == false)
            {
                MessageBox.Show("Tarih icin gerekli alani doldurunuz!");
                label4.Text = " ";
                maskedTextBox2.Focus();
            }
            else
            {
                label4.Text = maskedTextBox2.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(richTextBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string adSoyad1, adSoyad2;
            adSoyad1 = "Bilal KASAP";
            adSoyad2 = "Bilal \nKASAP";

            label5.Text = adSoyad1;
            label6.Text = adSoyad2;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("KÝÞÝSEL BÝLGÝLER");
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(maskedTextBox3.Text);
            listBox1.Items.Add(maskedTextBox4.Text);
            listBox1.Items.Add(textBox2.Text);

            if (radioButton1.Checked)
            {
                listBox1.Items.Add(radioButton1.Text);
            }
            else if (radioButton2.Checked)
            {
                listBox1.Items.Add(radioButton2.Text);
            }

            listBox1.Items.Add(" ");
            listBox1.Items.Add("KÝÞÝSEL BÝLGÝLER 2");
            listBox1.Items.Add(comboBox1.Text);
            listBox1.Items.Add(textBox3.Text);

            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i) == true)
                {
                    listBox1.Items.Add(checkedListBox1.Items[i].ToString());
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double r, cevre, alan;
            const double pi = 3.14;

            r = Convert.ToDouble(textBox4.Text);
            cevre = 2 * pi * r;
            alan = pi * r * r;

            cevre = Math.Round(cevre, 3);
            alan = Math.Round(alan, 3);

            textBox5.Text = cevre.ToString();
            textBox6.Text = alan.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, sonuc;
            sayi1 = Convert.ToInt16(textBox7.Text);
            sayi2 = Convert.ToInt16(textBox8.Text);

            sonuc = sayi1 + sayi2;
            textBox9.Text = sonuc.ToString();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int kisaKenar, uzunKenar, cevre, alan;
            kisaKenar = Convert.ToInt16(textBox11.Text);
            uzunKenar = Convert.ToInt16(textBox10.Text);

            cevre = 2 * (kisaKenar + uzunKenar);
            alan = kisaKenar * uzunKenar;

            textBox12.Text = cevre.ToString();
            textBox13.Text = alan.ToString();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            bool durum;
            durum = true;
            if(durum == true)
            {
                textBox14.Text = "Dogru";
            }
            else
            {
                textBox14.Text = "Yanlis";
            }
        }
    }
}
