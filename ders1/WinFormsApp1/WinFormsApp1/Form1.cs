namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text); //veri aktardýk
            textBox1.Focus(); //çevresindeki mavi çerçeve
            textBox1.Text = " "; //sonraki isim için boþluk atadýk
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear(); //veri sildik
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "www.cumhuriyet.edu.tr");
            linkLabel1.LinkVisited = true;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
            linkLabel2.LinkVisited = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            linkLabel1.LinkVisited = false;
            linkLabel2.LinkVisited = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // comboBox1.Items.Add("Ýlkokul"); //Form çalýþtýðýnda ekler
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add($"{textBox2.Text} {textBox3.Text} {comboBox1.Text}");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox4.Text);
        }
    }
}
