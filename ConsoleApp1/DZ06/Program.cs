//Na osnovu primera sa vežbi napraviti interfejs, apstraktnu klasu, nekoliko konkretnih klasa i
//prikazati overriding i polimorfizam na primeru po želji, po uzoru na vežbe
//Demonstrirati funkcionalnosti programa i dati kratki tekstualni opis
//Kreirati domaći, zipovati i poslati predmetnom asistentu.

//Napraviti program za upravljanje informacijama o različitim tipovima vozila u autoparku. 
//Program treba da ima interfejs koji definiše osnovne funkcionalnosti vozila,
//apstraktnu klasu koja sadrži zajedničke karakteristike svih vozila, kao i konkretne klase za 
//različite tipove vozila (npr. automobil, kamion, motocikl).

//Prikazati upotrebu overriding i polimorfizma kroz primere metoda specifičnih za svaku klasu vozila, i
//omogućiti da program poziva metode za pokretanje, zaustavljanje i prikaz 
//informacija o svakom vozilu u autoparku.

internal interface IRide
{
    public void Info();
}

internal abstract class Vehicle : IRide
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public Vehicle(string model, string brand)
    {
        this.Model = model;
        this.Brand = brand;
    }
    public virtual void Info() => Console.WriteLine($"Model: {Model}\nBrand: {Brand}");
}

internal class Car : Vehicle
{
    public float Power { get; set; }

    public Car(string m, string b, float power) : base(m, b) => this.Power = power;

    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Power: {Power}\n");
    }
}

internal class Motorcycle : Vehicle
{
    public string Type { get; set; }

    public Motorcycle(string m, string b, string type) : base(m, b) => this.Type = type;

    public override void Info()
    {
        base.Info();
        Console.WriteLine($"Type: {Type}\n");
    }
}

class Program
{
    [STAThread]
    static void Main(string[] args)
    {
        Vehicle[] vehicles = new Vehicle[4];

        vehicles[0] = new Car("Ford", "Focus", 80.0F);
        vehicles[1] = new Car("Opel", "Astra", 144F);
        vehicles[2] = new Motorcycle("TS1", "Suzuki", "Motorcycle");
        vehicles[3] = new Motorcycle("NT315", "Yamaha", "Quad");

        foreach (var vehicle in vehicles)
            vehicle.Info();

        Console.WriteLine("\n Motorcycle: \n");

        Motorcycle motorcycle = (Motorcycle)vehicles[2];
        motorcycle.Brand = "Ninja";
        motorcycle.Info();
    }
}