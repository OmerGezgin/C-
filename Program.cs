namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int vize,final; // Vize ve finali değişken olarak tanımladım
            double ortalama; // Ortalamayı değişken olarak tanımladım.

            Console.WriteLine("Vize notunu giriniz :");

            vize=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Final notunu giriniz :");

            final=Convert.ToInt32(Console.ReadLine());

            ortalama = (vize * 0.4) + (final * 0.6); // Vize ve finalin hesaplamasını yaptırdım.

            Console.WriteLine("Ortalama :"+ ortalama); // Ortalamayı çıktı olarak verdim.

            Console.ReadLine(); // BİTİR.


        }
    }
}