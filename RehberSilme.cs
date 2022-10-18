public class RehberSilme
{
    public static void Sil()
     {
        tekrar:
        bool sonuc = false;
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string silinecekKisi = Console.ReadLine();

        for (int i = 0; i < Liste.isimler.Count; i++)
        {
            if (Liste.isimler[i] == silinecekKisi || Liste.soyisimler[i] == silinecekKisi)
            {
                sonuc = true;
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",Liste.isimler[i]);
                string cevap = Console.ReadLine();
                if (cevap == "y")
                {
                    Liste.isimler.RemoveAt(i);
                    Liste.soyisimler.RemoveAt(i);
                    Liste.numaralar.RemoveAt(i);
                    Console.WriteLine("Silme işlemi gerçekleştirildi.");
                }
                break;
            }
        }  
        if (sonuc == false)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                string secim = Console.ReadLine();
                if(secim == "2")
                    goto tekrar;
            }    
     }
}