// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//array- dizi
//stringler yani içinde 1 den fazla string tutar
string[] kurslar = new string[] {"Yazılım Kampı","Programlamaya Başlangıç","Java" };
//string[] kurslar = kurslariGetir(); gerçekte böyle kullanılıyor db den getiriyor.

//for (string[] kurs = 0; kurs < kurslar.Length; i++)
//{
//    Console.WriteLine(kurs);
//}
Console.WriteLine("Sayfa Sonu - footer");
for (int i = 0; i < kurslar.Length; ++i)
{
    Console.WriteLine(kurslar[i]);
}

foreach (var item in kurslar)
{
    Console.WriteLine(item);
}
foreach (string kurs in kurslar)
{
    Console.WriteLine(kurs);
}