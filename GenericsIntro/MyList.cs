using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //T tipinde bir array dizi oluuşturduk arka planda bunun içinde tutacak. ve Array ı kullanmak için new lemek gerek bu yüzden program çalışınca hemen çalışması gerekiyor

        public MyList() //constructor , class new lendiği an çalışır
        {
            items = new T[0]; //items i 0(sıfır) elamanlı verdin. T yi 0 elemanlı olarak new leyip items e atadı 
        }

        //newlerken kullandığım tip ne olursa bana geri vereceğin veya ekleyeceğin tip te o dur diyorum.
        public void Add(T item)
        {
            T[] tempArray = items; // referans değer old için 101 e bakıyor çünkü biraz sonra alttaki yeni eleman eklediği için eskiler silincekti ki bunun ile korudum onları
            items = new T[items.Length + 1];//ekle metodu çalıştığında items en yukarıda var o kaç ise ona 1 ekle ve yeni items bu olsun diyor bu sayede array da artış sağlayabiliyoruz 

            for (int i = 0; i < tempArray.Length; i++) 
            {
                items[i] = tempArray[i];
            
            }
            items[items.Length - 1] = item; //item olarak geleni [son elememan sayısı] na ekliyoruz
            Console.WriteLine("Add "+item); //item i ekrana yazdırıyoruz
        }



        public void Delete(T a)
        {
            T[] tempArray = items; // referans değer old için 101 e bakıyor çünkü biraz sonra alttaki yeni eleman eklediği için eskiler silincekti ki bunun ile korudum onları
            items = new T[items.Length -1];//ekle metodu çalıştığında items en yukarıda var o kaç ise ona 1 ekle ve yeni items bu olsun diyor bu sayede array da artış sağlayabiliyoruz 

            int i = 0; //eski dizi
            int j = 0; //yeni dizi
            
            while ( i < tempArray.Length)
            {
                if (a.Equals(tempArray[i])) //Equals içerisinde gezmemi sağlayan metot. 
                {
                    i++; //sadece i yi arttırırım çünkü burası i deki silmek istediğim sayının index numarası bu sayede osayının geçmesini sağlarım
                }
                else
                {
                    items[j] = tempArray[i]; //yeni dizi ye eski dizinin elemanlarını eklerim
                    i++; //eski dizinin index sayısını 1 arttırırım
                    j++; //yeni dizinin index sayısını 1 arttırırım
                }               

            }
         
            Console.WriteLine("Delete"+a); //item i ekrana yazdırıyoruz

        }
        public void GetAll()
        {
            Console.WriteLine("Start GelAll()");
            foreach (T item in items)
                Console.WriteLine(item);
            Console.WriteLine("End GelAll()");
        }
            
        
    }
}
