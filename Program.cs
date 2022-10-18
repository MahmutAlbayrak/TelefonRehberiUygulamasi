internal class Program
{
    private static void Main(string[] args)
    {
        int secimNo = 0 ;
        Liste.isimler.Add("Mehmet");
        Liste.soyisimler.Add("Arslan");
        Liste.numaralar.Add("5468568989");

        Liste.isimler.Add("Ayşe");
        Liste.soyisimler.Add("Gün");
        Liste.numaralar.Add("5468562289");

        Liste.isimler.Add("Ali");
        Liste.soyisimler.Add("Baykar");
        Liste.numaralar.Add("5464448989");

        Liste.isimler.Add("Çiğdem");
        Liste.soyisimler.Add("Mert");
        Liste.numaralar.Add("546555989");

        Liste.isimler.Add("Gürkan");
        Liste.soyisimler.Add("Güçlü");
        Liste.numaralar.Add("5468511189");


        dongu:
        Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :");
        Console.WriteLine("******************************************");
        Console.WriteLine("(1) Yeni Numara Kaydetmek");
        Console.WriteLine("(2) Varolan Numarayı Silmek");
        Console.WriteLine("(3) Varolan Numarayı Güncelleme");
        Console.WriteLine("(4) Rehberi Listelemek");
        Console.WriteLine("(5) Rehberde Arama Yapmak");

        try
        {
            giris:
            secimNo = Int32.Parse(Console.ReadLine());
            if (secimNo<1 || secimNo>5)
            {
                Console.WriteLine("Lütfen 1 ile 5 arasında bir değer giriniz");
                goto giris;
            }
        }
        catch 
        {
            Console.WriteLine("*************************************************");
            Console.WriteLine("Lütfen sadece 1 ile 5 arasında bir değer giriniz!");
            goto dongu;
        }

        switch (secimNo)
        {
            case 1:
                NumaraKaydet.Kaydet();
                break;
            case 2:
                RehberSilme.Sil();
                break;
            case 3:
                RehberGuncelleme.Guncelle();
                break;
            case 4:
                RehberListele.Listele();
                break;
            case 5:
                RehberArama.Ara();
                break;
        }

        Console.WriteLine("*********************************");
        Console.WriteLine("Başka bir işlem yapmak ister misiniz?(y/n)");
        string c = Console.ReadLine();
        if (c == "y")
        {
            goto dongu;
        }
        Console.Clear();
    }
}