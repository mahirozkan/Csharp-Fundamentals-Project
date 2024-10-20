#region Karşılama
Karşılama: // Oyunun başlangıcında kullanıcıya hoş geldiniz mesajı ver ve kuralları anlat
Console.WriteLine("Merhaba! Oyunumuza hoşgeldiniz.\r\n" +
    "Bu oyunda 1 ile 100 arasında rastgele bir sayı belirleyeceğiz.\r\n" +
    "Sizin bu sayıyı tahmin etmek için 5 hakkınız bulunacak.\r\n" +
    "Eğer bu 5 hak içinde sayıyı doğru bilirseniz kazanırsınız, yoksa kaybedeceksiniz.\r\n" +
    "Merak etmeyin sizin için ipuçlarımız olacak.\r\n" +
    "Başlamak için bir tuşa basınız.\r\n");
Console.ReadKey(); // Kullanıcıdan bir tuşa basmasını bekle
Console.Clear(); // Ekranı temizle
Console.WriteLine("\r\nSayınız oluşturuldu.\r\n"); // Sayının oluşturulduğunu bildir
#endregion
#region Random Sayı 
Random rnd = new Random();
int rastgele = rnd.Next(1, 101); // 1 ile 100 arasında rastgele bir sayı oluştur
#endregion
#region Can
int can = 5; // Kullanıcının tahmin hakkını belirle
#endregion
#region Tahmin
int i = 1; // Kaçıncı hak olduğunu belirtmek için değişken tanımla
while (can > 0) // Kullanıcının tahminlerini almak için döngü başlat
{
    Console.WriteLine($"Kalan canınız: {can}"); // Kalan canı göster
    Console.Write($"{i}. Tahminizi giriniz: "); // Kullanıcıdan tahmin al
    string girdi = Console.ReadLine();
    if (!int.TryParse(girdi, out int tahmin)) // Kullanıcının girdiği değerin geçerli bir sayı olup olmadığını kontrol et
    {
        Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
        continue; // Hatalı giriş yapıldığında döngünün başına dön
    }
    // Tahminin rastgele sayıyla karşılaştırmasını yap
    if (tahmin < rastgele)
    {
        Console.WriteLine("\r\nTahmininiz sayımızdan küçük!\r\n"); // Tahmin küçükse uyarı ver
    }
    else if (tahmin > rastgele)
    {
        Console.WriteLine("\r\nTahmininiz sayımızdan büyük!\r\n"); // Tahmin büyükse uyarı ver
    }
    else 
    {
        Console.WriteLine("\r\nTebrikler Kazandınız!\r\n" +
           "Yeni bir oyuna başlamak için 'Y' tuşuna, çıkmak için başka bir tuşa basınız.\r\n"); // Tahmin doğruysa kullanıcıyı tebrik et, oyuna devam edip etmemek istediğini sor
        char secim1 = Console.ReadKey().KeyChar; // Kullanıcının seçimini al
        switch (secim1)
        {
            case 'y':
                Console.Clear(); // 'Y' tuşuna basılırsa ekranı temizle
                goto Karşılama; // Programı başa döndür
            default:
                Console.WriteLine("\r\nOyunumuzu oynadığınız için teşekkür ederiz.");
                return; // Farklı bir tuş basılırsa programı sona erdir
        }
    }
    can--; // Her tahminde canı bir azalt
    i++; // Tahmin sayısını bir artır
    if (can == 1)
    {
        break;  // Son hak kalınca döngüden çık
    }
}
#endregion
#region Son Tahmin
SonTahmin:
Console.WriteLine("Son canınız!"); // Kullanıcıya son canı olduğunu bildir
Console.Write("\r\nSon tahmininizi giriniz: "); // Kullanıcının son tahminini al
string sonGirdi = Console.ReadLine();

if (!int.TryParse(sonGirdi, out int sonTahmin)) // Kullanıcının son tahmininin geçerli bir sayı olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto SonTahmin; // Hatalı giriş yapıldığında döngünün başına dön
}

if (sonTahmin == rastgele)
{
    Console.WriteLine("\r\nTebrikler Kazandınız!\r\n" +
        "Yeni bir oyuna başlamak için 'Y' tuşuna, çıkmak için başka bir tuşa basınız.\r\n"); // Tahmin doğruysa kullanıcıyı tebrik et, oyuna devam edip etmemek istediğini sor
}
else
{
    Console.WriteLine($"\r\nMaalesef canınız kalmadı!" +
        $"\r\nSizin için belirlediğimiz rastgele sayımız:  {rastgele} " +
        $"\r\nYeni bir oyuna başlamak için 'Y' tuşuna, çıkmak için başka bir tuşa basınız.\r\n"); // Tahmin yanlışsa kaybettiğini bildir, doğru cevabı göster, oyuna devam edip etmemek istediğini sor
}
char secim2 = Console.ReadKey().KeyChar; // Kullanıcının seçimini al
 switch (secim2)
 {
    case 'y':
            Console.Clear(); // 'Y' tuşuna basılırsa ekranı temizle
            goto Karşılama; // Programı başa döndür
    default:
            Console.WriteLine("\r\nOyunumuzu oynadığınız için teşekkür ederiz.");
            return; // Farklı bir tuş basılırsa programı sona erdir
 }
#endregion