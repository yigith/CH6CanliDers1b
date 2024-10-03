soru:
Console.Write("Bir sayı giriniz: ");
string cevap = Console.ReadLine();
int sayi;
bool basariliMi = int.TryParse(cevap, out sayi);

if (!basariliMi)
{
    Console.WriteLine("Geçersiz bir sayı girdiniz!");
    Console.WriteLine("Lütfen tekrar giriniz.");
    goto soru;
}

#region Yöntem 1
if (sayi % 2 == 0)
    Console.WriteLine("Çift sayıdır.");
else
    Console.WriteLine("Tek sayıdır.");
#endregion

#region Yöntem 2
string sonuc = sayi % 2 == 0 ? "Çift" : "Tek";
Console.WriteLine(sonuc + " sayıdır.");
#endregion

Console.ReadKey();