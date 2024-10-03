baslangic:
Console.Write("Notunuz (1-100): ");
int not = Convert.ToInt32(Console.ReadLine());

if (not < 0 || not > 100)
    goto baslangic;

#region Yöntem 1
string sonuc;

if (not > 80)
    sonuc = "Başarılı";
else if (not > 60)
    sonuc = "Orta";
else
    sonuc = "Başarısız";

Console.WriteLine("Sonuç: " + sonuc);
#endregion

#region Yöntem 2
Console.WriteLine("Sonuç: "
+ (not > 80 ? "Başarılı" : not > 60 ? "Orta" : "Başarısız")); 
#endregion

Console.ReadKey();