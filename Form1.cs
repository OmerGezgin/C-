namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Rastgele bir 5 haneli kod olu�turmak i�in randomu kulland�m.
            Random random = new Random();
            string kod = random.Next(10000, 99999).ToString();

            // Kodu MessageBox i�inde g�sterdim.
            MessageBox.Show("Yeni Kodunuz: " + kod);
        }
    }
}

//C# FORM: Bir BUTON olacak ve buttonun �zerinde "KOD �RET" yazacak. Butona her bas�ld��� zaman MESAJBOX i�erisinde rastgele �retilmi� 5 haneli olan kod yazacak.