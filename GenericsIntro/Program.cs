// See https://aka.ms/new-console-template for more information
using GenericsIntro;

Console.WriteLine("Hello, World!");

//List<string> list = new List<string>(); //bak aynısı sadece aşağıda new lerken istediğimi verebiliyorum yani int,string,bool
//Console.WriteLine(list.Count);
MyList<string> isimler=new MyList<string> ();
isimler.Add("Gamze");
isimler.Add("Yaprak");
isimler.Add("Erol");
isimler.Add("Permin");
isimler.Add("Duran");
isimler.GetAll();
isimler.Delete("Yaprak");

isimler.GetAll();

