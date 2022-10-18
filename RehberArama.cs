public class RehberArama
{
    public static void Ara()
     {
        tekrar:
        bool sonuc = false;
        Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
        Console.WriteLine("**************************************");
        Console.WriteLine("");
        Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
        Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
        string secim1 = Console.ReadLine();
        string aranacakKisi = "";

        if (secim1 == "1")
        {
            Console.WriteLine(" Lütfen aramak istediğiniz kişinin adını ya da soyadını giriniz:");
            aranacakKisi = Console.ReadLine();
            Console.WriteLine("Arama sonuçlarınız:");
            Console.WriteLine("**********************************");

            for (int i = 0; i < Liste.isimler.Count; i++)
            {
                if (Liste.isimler[i] == aranacakKisi || Liste.soyisimler[i] == aranacakKisi)
                {
                    sonuc = true;
                    Console.WriteLine("İsim         : {0}",Liste.isimler[i]);
                    Console.WriteLine("Soysisim     : {0}",Liste.soyisimler[i]);
                    Console.WriteLine("Numara       : {0}",Liste.numaralar[i]);
                    Console.WriteLine("-");
                }
            }
        }
        else if (secim1 == "2")
        {
            Console.WriteLine(" Lütfen aramak istediğiniz kişinin numarasını giriniz:");
            aranacakKisi = Console.ReadLine();
            for (int i = 0; i < Liste.isimler.Count; i++)
            {
                Console.WriteLine("Arama sonuçlarınız:");
                Console.WriteLine("**********************************");
                if (Liste.numaralar[i] == aranacakKisi)
                {
                    sonuc = true;
                    Console.WriteLine("İsim         : {0}",Liste.isimler[i]);
                    Console.WriteLine("Soysisim     : {0}",Liste.soyisimler[i]);
                    Console.WriteLine("Numara       : {0}",Liste.numaralar[i]);
                    Console.WriteLine("-");
                }
            }
        }
        else
        {
            Console.WriteLine("Hatalı giriş yaptınız!");
            goto tekrar;
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
