#region Sayı1
Sayı1:
Console.Write("Birinci sayıyı giriniz: "); // Birinci sayıyı kullanıcıdan al
string girdi1 = Console.ReadLine(); 
if (!double.TryParse(girdi1, out double sayi1)) // Kullanıcının girdiği değerin geçerli bir sayı olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto Sayı1; // Hatalı giriş yapıldığında döngünün başına dön
}
#endregion
#region Sayı2
Sayı2:
Console.Write("\r\nİkinci sayıyı giriniz: "); // İkinci sayıyı kullanıcıdan al
string girdi2 = Console.ReadLine();
if (!double.TryParse(girdi2, out double sayi2)) // Kullanıcının girdiği değerin geçerli bir sayı olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto Sayı2; // Hatalı giriş yapıldığında döngünün başına dön
}
#endregion
#region İşlemSeçimi
OperatorSec:
Console.Write("\r\nLütfen yapmak istediğiniz işlemi seçiniz(Topla / Çıkar / Çarp / Böl ): "); // Kullanıcıdan hangi matematiksel işlemi yapmak istediğini al
string secim= Console.ReadLine().Trim().ToLower();
#endregion
#region İşlem
double sonuc;// İşlemi gerçekleştirmek değişken tanımla
switch (secim) // Kullanıcının seçimine göre işlemi yap
{
    case "topla":
        sonuc = sayi1 + sayi2; // Toplama işlemi
        break;
    case "çıkar":
        sonuc = sayi1 - sayi2; // Çıkarma işlemi
        break;
    case "çarp":
        sonuc = sayi1 * sayi2; // Çarpma işlemi
        break;
    case "böl":
        {
            if (sayi2 != 0) // Bölme işlemi için sıfıra bölme kontrolü yap sayi2 0 değilse işlemi yap
            {
                sonuc = sayi1 / sayi2; // Bölme işlemi
            }
            else
            {
                Console.WriteLine("\r\nSayı sıfıra bölünemez! Lütfen farklı bir işlem girin!");
                Console.ReadKey();
                Console.Clear();
                goto Sayı1; // sayi2 0 ise hatalı giriş yapıldığından döngünün başına dön
            }
        }
        break;
    default:
        Console.WriteLine("\r\nHatalı bir giriş yaptınız!"); // Geçersiz işlem durumu
        goto OperatorSec; // Operatör seçme işlemine geri dön
}
#endregion
#region SonuçVeÇıkış
Console.WriteLine($"\r\nSonuç: {sonuc} \r\nYeni bir hesap yapmak  için 'Y' tuşuna, çıkmak için başka bir tuşa basınız.\r\n"); // Sonucu ekrana yazdır, kullanıcıya yeni bir işlem yapmak isteyip istemediğini sor
char cikis = Console.ReadKey().KeyChar;
    switch (cikis)
    {
        case 'y':
            Console.Clear();
            goto Sayı1; // Eğer 'Y' tuşuna basılırsa ekranı temizleyip başa dön
    default:
            return; // Farklı bir tuş basılırsa program sona ersin
    }
#endregion