// See https://aka.ms/new-console-template for more information

using ProgTut14;


var mercedes = new Auto(new BenzinMotor(100));
var tesla = new Auto(new ElektroMotor(200));
Console.WriteLine(mercedes);
Console.WriteLine(tesla);

mercedes.Tanken(Kraftstoff.Benzin);
try
{
    mercedes.Tanken(Kraftstoff.Strom);
}
catch (WrongKraftstoffException _)
{
    Console.WriteLine("Der Mercedes kann nicht mit Strom getankt werden");
}

tesla.Tanken(Kraftstoff.Strom);
try
{
    tesla.Tanken(Kraftstoff.Benzin);
}
catch (WrongKraftstoffException _)
{
    Console.WriteLine("Der Tesla kann nicht mit Strom getankt werden");
}

Console.WriteLine($"Mercedes ist ein {mercedes.GetAutotyp()}");
Console.WriteLine($"Tesla ist ein {tesla.GetAutotyp()}");
