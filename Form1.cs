namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vize=Convert.ToInt32(txtvize.Text); // V�ze notunu istedim.

            int final= Convert.ToInt32(txtfinal.Text); // Final notunu istedim.

            double ortalama = (vize * 0.4) + (final * 0.6) ; // Ortalama i�lemini yapt�rd�m.

            label3.Text="Ortalama :"+ ortalama; // Ortalaman�n ��kt�s�n� ald�rd�m.
        }
    }
}