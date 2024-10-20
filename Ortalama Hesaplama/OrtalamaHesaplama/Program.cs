#region Not1
Not1:
Console.Write("Birinci ders notunu giriniz: "); // Birinci ders notu girişini iste
string girdi1 = Console.ReadLine(); // Kullanıcıdan giriş oku
if (!double.TryParse(girdi1, out double not1)) // Girişin geçerli bir double olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto Not1; // Hatalı giriş yapıldığında döngünün başına dön
}
if (not1 < 0 || not1 > 100) // Girişin 0 ile 100 arasında olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen 0 ile 100 arasında bir not giriniz!\r\n");
    goto Not1; // Geçersiz not girildiğinde döngünün başına dön
}
#endregion
#region Not2
Not2:
Console.Write("\r\nİkinci ders notunu giriniz: "); // İkinci ders notu girişini iste
string girdi2 = Console.ReadLine(); // Kullanıcıdan giriş oku
if (!double.TryParse(girdi2, out double not2)) // Girişin geçerli bir double olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto Not2; // Hatalı giriş yapıldığında döngünün başına dön
}
if (not2 < 0 || not2 > 100) // Girişin 0 ile 100 arasında olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen 0 ile 100 arasında bir not giriniz!\r\n");
    goto Not2; // Geçersiz not girildiğinde döngünün başına dön
}
#endregion
#region Not3
Not3:
Console.Write("\r\nÜçüncü ders notunu giriniz: "); // Üçüncü ders notu girişini iste
string girdi3 = Console.ReadLine(); // Kullanıcıdan giriş oku
if (!double.TryParse(girdi3, out double not3)) // Girişin geçerli bir double olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen geçerli bir sayı giriniz!\r\n");
    goto Not3; // Hatalı giriş yapıldığında döngünün başına dön
}
if (not3 < 0 || not3 > 100) // Girişin 0 ile 100 arasında olup olmadığını kontrol et
{
    Console.WriteLine("\r\nLütfen 0 ile 100 arasında bir not giriniz!\r\n");
    goto Not3; // Geçersiz not girildiğinde döngünün başına dön
}
#endregion
#region OrtalamaHesap
double ortalama = (not1 + not2 + not3) / 3; // Üç notun ortalamasını hesapla
#endregion
#region HarfNotuHesap
string harfNotu; // Ortalamaya göre harf notunu belirle
if (ortalama >= 90 )
{
    harfNotu = "AA";
}
else if (ortalama >=85)
{
    harfNotu = "BA";
}
else if (ortalama >= 80)
{
    harfNotu = "BB";
}
else if (ortalama >= 75)
{
    harfNotu = "CB";
}
else if (ortalama >= 70)
{
    harfNotu = "CC";
}
else if (ortalama >= 65)
{
    harfNotu = "DC";
}
else if (ortalama >= 60)
{
    harfNotu = "DD";
}
else if (ortalama >= 55)
{
    harfNotu = "FD";
}
else
{
    harfNotu = "FF";
}


#endregion
#region SonuçVeÇıkış 
Console.WriteLine($"\r\nOrtamalamanız : {ortalama}"); // Ortalamayı yazdır
Console.WriteLine($"\r\nOrtalamanıza denk gelen harf notu : {harfNotu}"); // Harf notunu yazdır
Console.WriteLine($"\r\nYeni bir hesap yapmak  için 'Y' tuşuna, çıkmak için başka bir tuşa basınız.\r\n"); // Yeni hesap için seçenek sun
char cikis = Console.ReadKey().KeyChar; // Kullanıcının hangi tuşa bastığını oku
switch (cikis)
{
    case 'y':
        Console.Clear(); // Ekranı temizle
        goto Not1; // 'Y' tuşuna basılırsa programı başa döndür
    default:
        return; // Farklı bir tuş basılırsa program sona ersin
}
#endregion