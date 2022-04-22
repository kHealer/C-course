// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
int month = DateTime.Now.Month;
//expression
switch (month)
{
    case 1:
        Console.WriteLine("Ocak ayındasınız!");
        break;
    case 2:
        Console.WriteLine("Şubat ayındasınız!");
        break;
    case 3:
        Console.WriteLine("mart ayındasınız!");
        break;
    case 4:
        Console.WriteLine("nisan ayındasınız!");
        break;    
    default:
        Console.WriteLine("yanlış veri girdiniz!");
        
    break;
}

switch (month)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Kış ayındasınız");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("ilk bahar ayındaısnız!");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("yaz bahar ayındaısnız!");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("yaz ayındaısnız!");
        break;
    default:
    break;
}