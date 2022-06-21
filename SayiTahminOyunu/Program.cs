namespace SayiTahminOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int tutulansayi = rnd.Next(100);
            Console.WriteLine("Bu oyunda bilgisayarın 1 ile 100 arasında tuttuğu bir sayıyı tahmin etmeye çalışacaksınız");
            Console.WriteLine("BOL ŞANS! :)");
            Console.WriteLine("");
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("İlk tahmininizi girin");

            string tahminyazi;
            int tahmin;
            bool keepgoing = true;
            string tekrar;
            int tekrar1;
            tahminyazi = Console.ReadLine();
            tahmin = Convert.ToInt32(tahminyazi);
            while (keepgoing)
            {
                while (tahmin != tutulansayi)
                {
                    if (tahmin < tutulansayi)
                    {
                        Console.WriteLine("Tahminin tutulan sayıdan daha küçük. Haydi tekrar dene");
                        tahminyazi = Console.ReadLine();
                        tahmin = Convert.ToInt32(tahminyazi);
                    }
                    else if (tahmin > tutulansayi)
                    {
                        Console.WriteLine("Tahmininiz tutulan sayıdan daha büyük. Haydi tekrar dene");
                        tahminyazi = Console.ReadLine();
                        tahmin = Convert.ToInt32(tahminyazi);
                    }
                }

                if (tahmin == tutulansayi)
                {
                    Console.WriteLine("TEBRİKLER!!! DOĞRU TAHMİN");
                    Console.WriteLine("Tekrar oynamak ister misiniz? Tekrar oynamak için 1, kapatmak için 0 girin.");
                    tekrar = Console.ReadLine();
                    tekrar1 = Convert.ToInt32(tekrar);
                    if (tekrar1 == 0)
                    {
                        Console.WriteLine("Oynadığınız için teşekkürler");
                        keepgoing = false;
                    }
                    else
                    {
                        Console.WriteLine("Haydi tekrar başlayalım");
                    }
                }
            }
        }
    }
}