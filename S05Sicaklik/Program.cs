Console.Write("Hava Sıcaklığı: ");
int sicaklik = Convert.ToInt32(Console.ReadLine());

#region Uzun Hali
if (sicaklik < 0)
{
    Console.WriteLine("Donuyor");
}
else
{
    if (sicaklik <= 30)
    {
        Console.WriteLine("Normal");
    }
    else
    {
        Console.WriteLine("Sıcak");
    }
}
#endregion

#region Kısa Hali
if (sicaklik < 0)
{
    Console.WriteLine("Donuyor");
}
else if (sicaklik <= 30)
{
    Console.WriteLine("Normal");
}
else
{
    Console.WriteLine("Sıcak");
}
#endregion

#region Daha Kısa Hali
if (sicaklik < 0)
    Console.WriteLine("Donuyor");
else if (sicaklik <= 30)
    Console.WriteLine("Normal");
else
    Console.WriteLine("Sıcak");
#endregion

#region Daha da Kısa Hali
Console.WriteLine(sicaklik < 0 ? "Donuyor" : sicaklik > 30 ? "Sıcak" : "Normal");
#endregion

Console.ReadKey();