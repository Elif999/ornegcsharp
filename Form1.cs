namespace WinFormsApp29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int başlangıç = Convert.ToInt32(textBox1.Text);
            int Bitiş = Convert.ToInt32(textBox2.Text);
            int artış = Convert.ToInt32(textBox3.Text);
            for(int sayac=başlangıç;sayac<=Bitiş;sayac+=artış)
            {
                listBox1.Items.Add(sayac.ToString());
            }
          //***artış miktarı değeri texbox3 ten alınacak
        }
    }
}
/*
