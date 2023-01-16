using System.ComponentModel;

namespace ProgTut14;


public class Auto
{
    private Motor _motor;

    public double PS
    {
        get => _motor.Ps;
    }

    public Autotyp GetAutotyp()
    {
        if (_motor is ElektroMotor)
        {
            return Autotyp.Elektro;
        }else if (_motor is BenzinMotor)
        {
            return Autotyp.Benzin;
        }
        else
        {
            throw new InvalidEnumArgumentException("Autotyp ist nicht vorhanden!!");
        }
    }

    public void Tanken(Kraftstoff kraftstoff)
    {
        if (kraftstoff == Kraftstoff.Benzin)
        {
            if (GetAutotyp() == Autotyp.Benzin)
            {
                Console.WriteLine("Auto wird getankt!");
            }
            else
            {
                throw new WrongKraftstoffException();
            }
        }
        else if (kraftstoff == Kraftstoff.Strom)
        {
            if (GetAutotyp() == Autotyp.Elektro)
            {
                Console.WriteLine("Auto wird getankt!");
            }
            else
            {
                throw new WrongKraftstoffException();
            }
        }
    }

    public Auto(Motor motor)
    {
        _motor = motor;
    }

    public override string ToString()
    {
        return $"Das Auto hat: {nameof(_motor)}: {_motor}, {nameof(PS)}: {PS}";
    }
}

public class WrongKraftstoffException: InvalidOperationException{}

public abstract class Motor
{
    public double Ps { get; }

    protected Motor(double ps)
    {
        if (ps <= 0)
        {
            throw new ArgumentException("PS muss größer als 0 sein");
        }
        Ps = ps;
    }
}

public class ElektroMotor : Motor
{
    public ElektroMotor(double ps) : base(ps)
    {
    }
}

public class BenzinMotor : Motor
{
    public BenzinMotor(double ps) : base(ps)
    {
    }
}

public enum Kraftstoff
{
    Benzin, Strom
}

public enum Autotyp
{
    Elektro, Benzin
}
