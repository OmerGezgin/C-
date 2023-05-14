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
            // Rastgele bir 5 haneli kod oluşturmak için randomu kullandım.
            Random random = new Random();
            string kod = random.Next(10000, 99999).ToString();

            // Kodu MessageBox içinde gösterdim.
            MessageBox.Show("Yeni Kodunuz: " + kod);
        }
    }
}

//C# FORM: Bir BUTON olacak ve buttonun üzerinde "KOD ÜRET" yazacak. Butona her basıldığı zaman MESAJBOX içerisinde rastgele üretilmiş 5 haneli olan kod yazacak.
