using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Foreach Döngüsü

            //Foreach(1;2;3;4)
            //1:Değişken türü
            //2:Değişken adı
            //3:in
            //4:Liste, koleksiyon,dizi

            //string[] cities = { "milano", "roma", "budapeşte", "ankara", "istanbul", "varşova" };
            //foreach (string x in cities)
            //{
            //    Console.WriteLine(x);
            //}

            //int[] number = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in number)
            //{
            //    Console.WriteLine(i);
            //}

            //int[] number = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //foreach (int i in number)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //int[] number = { 45, 78, 985, 74, 11, 22, 33, 41, 205, 6578, 10394 };
            //int total = 0;
            //foreach (int i in number)
            //{
            //    total += i;
            //}
            //Console.WriteLine(total);   

            //List<int> numbers = new List<int>()
            //{
            //    1, 2, 3, 4, 5, 6,
            //};

            //foreach (int i in numbers)
            //{
            //    Console.WriteLine(i);
            //};

            //string word = "merhaba";
            //foreach (char c in word)
            //{
            //    Console.WriteLine(c);
            //}



            #endregion

            #region Örnek Sınav Sistemi Uygulaması

            Console.Write("***** C# Eğitim Kampı Sınav Uygulaması");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //Öğrenci sayısını kullanıcıdan alma
            Console.WriteLine("------------------------------");
            Console.WriteLine("Sınıfınızda kaç öğrenci var: ");
            int studentCount = int.Parse(Console.ReadLine());
            Console.WriteLine("------------------------------");

            //öğrenci isim ve not ortalamalarını saklayacak diziler
            string[] studentName =new string[studentCount];
            double[] studentExamAvg = new double[studentCount];

            for (int i = 0; i < studentCount; i++)
            {
                Console.Write($"{i + 1}. öğrencinin ismini griniz: ");
                studentName[i] = Console.ReadLine();

                double totalExamResults = 0;

                //Her öğrenci için 3 sınav notu girişi
                for (int j = 0; j < 3; j++) {
                    Console.Write($"{studentName[i]} isimli öğrencinin {j + 1}. sınav notunu giriniz: ");
                    double value = double.Parse(Console.ReadLine());
                    totalExamResults += value; //notları topluyoruz
                }
                Console.WriteLine();
                studentExamAvg[i] = totalExamResults / 3;

            }

            //Sınav Ortalamaları
            for (int i = 0; i < studentCount; i++)
            {
                Console.WriteLine("------------------------------");
                Console.Write($"{studentName[i]} adlı öğrencinin ortalaması: {studentExamAvg[i]}");

                //Öğrencilerin ortalaması ve geçme kalma durumları
                if (studentExamAvg[i] >= 50)
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersi geçti");
                }
                else
                {
                    Console.WriteLine($"{studentName[i]} adlı öğrenci dersten kaldı");
                }
                Console.WriteLine("------------------------------");
            }






            #endregion

            Console.Read();
        }
    }
}
