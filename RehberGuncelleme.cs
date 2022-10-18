public class RehberGuncelleme
{
    public static void Guncelle()
     {
        tekrar:
        bool sonuc = false;
        Console.WriteLine("Lütfen güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
        string guncellenecekKisi = Console.ReadLine();

        for (int i = 0; i < Liste.isimler.Count; i++)
        {
            if (Liste.isimler[i] == guncellenecekKisi || Liste.soyisimler[i] == guncellenecekKisi)
            {
                sonuc = true;
                Console.WriteLine("{0} isimli kişi güncellenmek üzere, onaylıyor musunuz ?(y/n)",Liste.isimler[i]);
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    Console.Write("İsim     :");
                    Liste.isimler[i] = Console.ReadLine();
                    Console.Write("Soyisim  :");
                    Liste.soyisimler[i] = Console.ReadLine();
                    Console.Write("Numara   :");
                    Liste.numaralar[i] = Console.ReadLine();
                    Console.WriteLine("Güncelleme işlemi gerçekleştirildi.");
                }
                break;
            }
        }  
        if (sonuc = false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için           : (2)");
                string secim = Console.ReadLine();
                if(secim == "2")
                    goto tekrar;
            }    
     }
}