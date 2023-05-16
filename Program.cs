namespace PROJE7
{
    // Öğrenci bilgilerini içeren struct yapısı
    struct Student
    {
        public string ad;
        public string soyad;
        public string tc;
        public string okulnumarasi;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Öğrenci bilgilerini tutmak için bu kodu kullandım.
            Student ogrenci = new Student();

            // Kullanıcıdan öğrenci bilgilerini aldım.
            Console.WriteLine("Öğrenci Adı: ");
            ogrenci.ad = Console.ReadLine();

            Console.WriteLine("Öğrenci Soyadı: ");
            ogrenci.soyad = Console.ReadLine();

            Console.WriteLine("TC Kimlik Numarası: ");
            ogrenci.tc = Console.ReadLine();

            Console.WriteLine("Okul Numarası: ");
            ogrenci.okulnumarasi = Console.ReadLine();

            // Öğrenci bilgileri ekrana yazdırdım.
            Console.WriteLine("Öğrenci Bilgileri:");
            Console.WriteLine("Adı: " + ogrenci.ad);
            Console.WriteLine("Soyadı: " + ogrenci.soyad);
            Console.WriteLine("TC Kimlik Numarası: " + ogrenci.tc);
            Console.WriteLine("Okul Numarası: " + ogrenci.okulnumarasi);

            Console.ReadLine();
        }
    }
}