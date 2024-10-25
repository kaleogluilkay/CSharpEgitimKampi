using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri 
            // sarı,kırmızı,mavi
            //adana,ankara,istanbul,bursa
            // DeğişkenTürü [] DiziAdı = new DeğişkenTürü (ElemanSayısı)
            //string[] colors = new string[4];
            //colors[0] = "kırımızı";
            //colors[1] = "sarı";
            //colors[2] = "beyaz";
            //colors[3] = "mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "milano";
            //cities[1] = "budapeşte";
            //cities[2] = "lyon";
            //cities[3] = "kahire";
            //cities[4] = "üsküp";

            //Console.WriteLine(cities[3]);

            //int[] numbers=new int[10];
            //numbers[0] = 2;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]); //tanımlama yapmazsak default değeri sıfırdır.

            //string[] cities = { "prag", "roma", "atina", "ankara", "bursa" };
            //Console.WriteLine(cities[4]);


            #endregion

            #region Dizideki Tüm Elemanları Listeleme 
            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 4, 6, 12, 345, 67, 75, 533, 96, 120 };
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] %3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '/', '-', '*' };
            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}


            //int[] myarray = { 47, 86, 123, 654, 100, 748 };
            //int maxnumber=myarray[0];
            //for (int i = 0; i < myarray.Length; i++)
            //{
            //    if (myarray[i] > maxnumber)
            //    {
            //        maxnumber = myarray[i];
            //    }
            //} 
            //Console.WriteLine(maxnumber);

            //string[] persons = { "ali", "ahmet", "ayşe", "buse", "can", "deniz" };
            //Console.WriteLine(persons.Length);

            //int[] numbers = { 1, 2, 82, 22, 35 };
            //Array.Sort(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            //int[] numbers = { 1, 2, 82, 22, 35 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion
            #region Dizi Metotları
            //string[] customers = { "ali", "buse", "ayşegül", "merve", "çınar", "kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            //int[] numbers = { 45, 85, 96, 63, 74, 22, 36 };
            //Console.WriteLine("dizinin en büyük elemanı: " + numbers.Max() + " dizinin en küçük elemanı: " + numbers.Min());


            #endregion
            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for (int i = 0; i < cities.Length; i++)
            //{
            //    Console.Write($"Lütfen {i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //for (int i = 0; i < cities.Length;i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = { 10, 20, 30, 40, 50 };
            //int sum = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 42, 33, 54, 55, 66, 897, 748, 39, 220 };

            //Console.WriteLine("Çift sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine("-----------------");
            //Console.WriteLine("Tek sayılar");
            //Console.WriteLine();
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}
