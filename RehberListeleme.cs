public class RehberListele
{
    public static void Listele()
    {
        Console.WriteLine(" Telefon Rehberi");
        Console.WriteLine("**********************************************");
        for (int i = 0; i < Liste.isimler.Count; i++)
        {
            Console.WriteLine("İsim: {0}",Liste.isimler[i]);
            Console.WriteLine("Soyisim: {0}",Liste.soyisimler[i]);
            Console.WriteLine("Numara: {0}",Liste.numaralar[i]);
            if (i + 1 != Liste.isimler.Count)
                Console.WriteLine("-");
        }
    }
}