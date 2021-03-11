using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //c# dictionary
            var kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(1, "Yeşim");
            kullanicilar.Add(2, "Gülsün");


            foreach (var kullanici in kullanicilar)
            {
                Console.WriteLine("Key :" + kullanici.Key + "   " + "Value : " + kullanici.Value);
            }
            Console.WriteLine("Count: " + kullanicilar.Count);
            Console.WriteLine("\n");


            //My Dictionary
            MyDictionary<int,string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(134, "Tolga Demirer");
            myDictionary.Add(158, "Ümit Özkan");
            myDictionary.Add(115, "Kadir Aydemir");
            myDictionary.Add(174, "Cemal Çiftçi");

            Console.WriteLine("MyDictionary Count: "+myDictionary.Count());
            myDictionary.List();

        }
    }
}
