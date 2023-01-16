// See https://aka.ms/new-console-template for more information

using System.Collections;
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


Console.WriteLine($"Sind tesla und mercedes gleich? {Equals(mercedes, tesla)}");

Console.WriteLine("Hash of mercedes" + mercedes.GetHashCode());
Console.WriteLine("Hash of tesla " + tesla.GetHashCode());

Console.WriteLine("Zwei gleiche Autos " + new Auto(new BenzinMotor(20)).GetHashCode() +"  " + new Auto(new BenzinMotor(20)).GetHashCode());
