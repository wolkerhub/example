using example.methods;
Evvele:
Console.WriteLine("1. Yola cix ");
Console.WriteLine("2. Benzin doldur");
Console.WriteLine("3. Yanacaq miqdari");
Console.WriteLine("4. Yurus");
Console.WriteLine("4. Cixis");


string daxilEdilenReqem = Console.ReadLine();

Go start = new Go();
decimal benzin = 100m;


switch (Convert.ToInt32(daxilEdilenReqem))
{
    case 1:
        start.HereketeBasla(benzin);
        goto Evvele;
        break;
      
    case 2:
        start.Benzindoldur(benzin);
            goto Evvele;
        break;
    case 3:

        break;
    case 4:

        break;
    case 5:

        break;

    default:

        break;
}