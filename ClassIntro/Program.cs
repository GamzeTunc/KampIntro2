// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




Kurs kurs1 = new Kurs();
kurs1.kursAdi = "C#";
kurs1.Egitmen="Engin Demiroğ";
kurs1.IzlenmeOrani = 68;


Kurs kurs2 = new Kurs();
kurs2.kursAdi = "Java";
kurs2.Egitmen = "Kerem Varış";
kurs2.IzlenmeOrani = 64;

Kurs kurs3 = new Kurs();
kurs3.kursAdi = "Python";
kurs3.Egitmen = "Berkay Bilgin";
kurs3.IzlenmeOrani = 80;

Console.WriteLine(kurs1.kursAdi+" : "+kurs1.Egitmen);

Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};
foreach (var kurs in kurslar)
{
    Console.WriteLine(kurs.kursAdi);
}

class Kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }
}


