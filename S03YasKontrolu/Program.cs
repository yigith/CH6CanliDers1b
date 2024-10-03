Console.Write("Yaşınız: ");
int yas = Convert.ToInt32(Console.ReadLine());

#region Yöntem 1
bool buyukMu = yas >= 18;

if (buyukMu)
{
    Console.WriteLine("Yetişkinsiniz.");
}
else
{
    Console.WriteLine("Çocuksunuz.");
}
#endregion

#region Yöntem 2
if (yas >= 18)
    Console.WriteLine("Yetişkinsiniz.");
else
    Console.WriteLine("Çocuksunuz");
#endregion

#region Yöntem 3
Console.WriteLine(yas < 18 ? "Çocuksunuz." : "Yetişkinsiniz.");

// ternary conditional operator
// şart ? doğruysa :
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/conditional-operator
#endregion

Console.ReadKey();