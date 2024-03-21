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
            Console.WriteLine(item); //item i ekrana yazdırıyoruz
        }



        public void Delete(T a)
        {
            T[] tempArray = items; // referans değer old için 101 e bakıyor çünkü biraz sonra alttaki yeni eleman eklediği için eskiler silincekti ki bunun ile korudum onları
            items = new T[items.Length -1];//ekle metodu çalıştığında items en yukarıda var o kaç ise ona 1 ekle ve yeni items bu olsun diyor bu sayede array da artış sağlayabiliyoruz 
            for (int i = 0; i < tempArray.Length-1; i++)
            {
                items[i] = tempArray[i];

            }
            foreach (var item in items)
            {
                item[]
            }
            Console.WriteLine(a); //item i ekrana yazdırıyoruz

        }
    }
}
