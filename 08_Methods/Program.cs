using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Void Metotlar (Geriye değer Döndürmeyen Metotlar)

            //void CustomerList()
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Çakır");
            //    Console.WriteLine("Hakan Öztürk");
            //}

            //CustomerList();


            //void Sum()
            //{
            //    int x = 1;
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //Sum();

            #endregion

            #region Geriye Değer Döndürmeyen Parametreli Metotlar

            //void WriteMethod(string name)
            //{
            //    Console.WriteLine(name);
            //}
            //WriteMethod("Selin Sarılar");

            //void CustomerCard(string name, string surname)
            //{
            //    Console.WriteLine("Müşteri: " + name + " " + surname);
            //}

            //CustomerCard("Selin", "Sarılar");

            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void Sum(int num1, int num2, int num3)
            //{
            //    int result = num1 + num2 + num3;
            //    Console.WriteLine(result);
            //}

            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Selin Sarılar";
            //}

            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Selin";
            //    string surname = "Sarılar";
            //    return name+ " " + surname;
            //}

            //Console.WriteLine(StudentCard());
            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            // string CountryCard(string countryName, string capital, string flagColor)
            // {
            //     string cardInfo = "Ülke: " + countryName + " - Başkent: " + capital + " - Bayrak Rengi: " + flagColor;
            //     return cardInfo;
            // }

            // string x, y, z;

            // Console.WriteLine("Ülke adı giriniz: ");
            // x = Console.ReadLine();
            // Console.WriteLine("Başkent giriniz: ");
            // y = Console.ReadLine();
            // Console.WriteLine("Bayrak rengi giriniz: ");
            // z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            //Console.WriteLine(CountryCard("Türkiye", "Ankara", "Kırmızı"));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar 

            //int Sum(int num1, int num2)
            //{
            //    int result = num1 + num2;
            //    return result;
            //}

            //Console.WriteLine(Sum(45, 98));
            //Console.WriteLine(Sum(589, 20));
            //Console.WriteLine(Sum(99, 10));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
                int result = (exam1 + exam2 + exam3) / 3;
                if (result >= 50)
                {
                    return student + " isimli öğrenci sınavı geçti. Ortalama: " + result;
                }
                else
                {
                    return student + " isimli öğrenci sınavdan kaldı. Ortalama: " + result;

                }
            }

            Console.WriteLine(ExamResult("Ali", 25, 41, 85));
            Console.WriteLine(ExamResult("Ayşe", 36, 50, 33));
            #endregion

            Console.Read();
        }
    }
}
