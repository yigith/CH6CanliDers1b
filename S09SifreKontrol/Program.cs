string sifre = "12345";
Console.Write("Şifreyi giriniz: ");
string girilen = Console.ReadLine();

#region Yöntem 1
if (sifre == girilen)
    Console.WriteLine("Giriş Başarılı");
else
    Console.WriteLine("Giriş Başarısız");
#endregion

#region Yöntem 2
Console.WriteLine(sifre == girilen ? "Giriş Başarılı" : "Giriş Başarısız");
#endregion

#region Yöntem 3
switch(girilen)
{
    case "12345":
        Console.WriteLine("Giriş Başarılı");
        break;
    default:
        Console.WriteLine("Giriş Başarısız");
        break;
}
#endregion

Console.ReadKey();