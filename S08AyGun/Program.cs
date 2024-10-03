Console.Write("Ay No: ");
int ay = Convert.ToInt32(Console.ReadLine());

int adet;

switch (ay)
{
    case 2:
        adet = 28;
        break;
    case 1:
    case 3:
    case 5:
    case 7:
    case 8:
    case 10:
    case 12:
        adet = 31;
        break;
    case 4:
    case 6:
    case 9:
    case 11:
        adet = 30;
        break;
    default:
        Console.WriteLine("Geçersiz bir ay numarası girdiniz!");
        Console.ReadKey();
        return;
}

Console.WriteLine("Gün adedi: " + adet);
Console.ReadKey();