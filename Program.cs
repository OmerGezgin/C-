namespace Yıldızlarla_Kare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("İÇİ BOŞ KARE YAPIMI");
            Console.Write("Karenin Bir Kenarını Giriniz = ");

            int içiboşkareoluşturma;
            içiboşkareoluşturma = Convert.ToInt16(Console.ReadLine());
            //Üst kenarı oluşturdum.
            for (int i = 0; i < içiboşkareoluşturma; i++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            //Sol kenarı oluşturdum.    
            for (int j = 0; j < içiboşkareoluşturma - 2; j++)
            {
                Console.Write("*");
                //Aradaki boşluk satırı ekledim.
                for (int k = 0; k < içiboşkareoluşturma - 2; k++)
                {
                    Console.Write("  ");
                }
                //Sağ kenarı oluşturdum.
                Console.Write(" *");
                Console.WriteLine();
            }
            //Alt kenarı oluşturdum.
            for (int n = 0; n < içiboşkareoluşturma; n++)
                Console.Write("* ");
            Console.Read();
        }
        
    }
}