Console.Write("Gün No: ");
int no = Convert.ToInt32(Console.ReadLine());

#region İsterseniz hata kontrolünü baştan da yapabilirsiniz..
//if (no < 1 || no > 7)
//{
//    Console.WriteLine("Geçersiz gün!");
//    Console.WriteLine("Çıkmak için bir tuşa bas..");
//    Console.ReadKey();
//    Environment.Exit(0);
//    // return;
//} 
#endregion

#region Yöntem 1
if (no == 1)
    Console.WriteLine("Pazartesi");
else if (no == 2)
    Console.WriteLine("Salı");
else if (no == 3)
    Console.WriteLine("Çarşamba");
else if (no == 4)
    Console.WriteLine("Perşembe");
else if (no == 5)
    Console.WriteLine("Cuma");
else if (no == 6)
    Console.WriteLine("Cumartesi");
else if (no == 7)
    Console.WriteLine("Pazar");
else
    Console.WriteLine("Geçersiz gün!");
#endregion

#region Yöntem 2
switch(no)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Geçersiz gün!");
        break;
}
#endregion

Console.ReadKey();