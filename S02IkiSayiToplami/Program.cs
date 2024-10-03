Console.Write("Sayı 1: ");
string cevap1 = Console.ReadLine();
int sayi1 = Convert.ToInt32(cevap1);

Console.Write("Sayı 2: ");
string cevap2 = Console.ReadLine();
int sayi2 = Convert.ToInt32(cevap2);

int toplam = sayi1 + sayi2;
Console.Write("Toplam: " + toplam);

Console.ReadKey();