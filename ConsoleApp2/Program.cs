namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String isim,hayvan,kedi;
            Console.Write("Lütfen isminizi giriniz : ");
            isim = Console.ReadLine();
            Console.WriteLine("Lütfen sevdiğiniz hayvanı yazınız : (Ben kedileri sevdiğim için şuan sadece kedilerle ilgili kod yazdım :) )");
            hayvan = Console.ReadLine().ToLower();

           

            Console.WriteLine(isim+","+" "+hayvan+"leri"+" sever.");
            if (hayvan == "kedi")
            {
                Console.WriteLine("Ooo kedilerden hoşlanıyoruz demek ki... Tekir mi,Sarman mı, Kaliko mu,Smokin mi?");
            }
            while (true) { 
            Console.Write("Hangisi peki: ");
            kedi = Console.ReadLine().ToLower();
            switch (kedi)
            {
                case "tekir":
                    Console.WriteLine("Bende tekirlere bayılırım. Çok tatlılar");
                    break;
              
                case "sarman":
                    Console.WriteLine("Bende sarmanlara bayılırım. Çok tatlılar ve biraz deli");
                    break;

                case "kaliko":
                    Console.WriteLine("Bende kalikolara bayılırım. Aşırı tatlılar...");
                    break;

                case "smokin":
                        Console.WriteLine("Onlar harika...");
                        break;

            }
            Console.WriteLine("Daha var mı sevdiğin kedi : (evet, hayır)");
            string devamDurumu = Console.ReadLine().ToLower();
            if(devamDurumu == "evet")
            {
                    continue;
            }
                else
                {
                    Console.WriteLine("Kedi üstadı : Teşekkürler!");
                    break;
                }

            }
            Console.ReadLine();
        }
    }
}
