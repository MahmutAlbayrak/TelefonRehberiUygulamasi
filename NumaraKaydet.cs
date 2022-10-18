public class NumaraKaydet
{
    public static void Kaydet()
    {
        tekrar:
        Console.WriteLine("Kayıt İşleme");
        Console.Write("Lütfen isim giriniz             : ");
        Liste.isimler.Add(Console.ReadLine()); 
        Console.Write("Lütfen soyisim giriniz          : ");
        Liste.soyisimler.Add(Console.ReadLine());
        Console.Write("Lütfen telefon numarası giriniz : ");
        Liste.numaralar.Add(Console.ReadLine());
        Console.WriteLine("Kaydetme işlemi gerçekleşti.");

        Console.WriteLine("*********************************************");
        Console.WriteLine("* Ekleme işlemini sonlandırmak için  : (1)");
        Console.WriteLine("* Yeniden kayıt yapmak için          : (2)");
        string secim = Console.ReadLine();
        if(secim == "2")
            goto tekrar;
    }

}