// See https://aka.ms/new-console-template for more information
using Metotlar;

Console.WriteLine("Hello, World!");


Urun urun1 = new Urun(); //classı kullanmak için yapman gerekiyor class ın örneği denir

urun1.Adi = "Elma";
urun1.Fiyatı = 15;
urun1.Aciklama = "Amasya Elması";

Urun urun2 = new Urun();
urun2.Adi = "Karpuz";
urun2.Fiyatı = 80;
urun2.Aciklama = "Diyarbakır Karpuzu";

Urun[] urunler = new Urun[] { urun1, urun2 };

         //type-safe -- tip güvenliği c# ta verdiğimiz değişkenin önüne veri tipini yazmamız gerekiyor.
foreach (Urun urun in urunler)
{
    Console.WriteLine(urun.Adi);
    Console.WriteLine(urun.Fiyatı);
    Console.WriteLine(urun.Aciklama);
    Console.WriteLine("-----------------------------");
}
Console.WriteLine("------------METOTLAR----------");


//instance - örnek class örneği oluşturuyoruz classı tanımlıyoruz
SepetManager sepetManager = new SepetManager();
sepetManager.Ekle(urun1); //bu classta da özelliği değil metodu çağırdım


sepetManager.Ekle2("Peynir", "Ezine peyniri", 15,10);
sepetManager.Ekle2("Elma","Yeşil Elma", 12,9);
sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 12,8);
