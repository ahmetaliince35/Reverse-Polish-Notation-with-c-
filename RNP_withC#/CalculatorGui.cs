using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class CalculatorGui
    {
        private string yol = "hata-log.txt"; // Hataların yazıldığı dosya belirlenir.
        public string Inputal()
        {
            Console.WriteLine("Lütfen işlem operatörlerini, ve sayıları; işlem operatörleri sayılardan 1 eksik olacak şekilde giriniz");
            return Console.ReadLine(); // Kullanıcı hesaplanacak sayılar için string girer.
        }
        public void sonucyaz(double sonuc)
        {
            Console.WriteLine("Yaptığımız bir dizi işlemlerin sonucu: " + sonuc); // Son sonucu yazdırır.
        }

        public void hatayazdir(string hata)
        {
            Console.WriteLine("SİSTEMDE HATA OLUŞTU :" + hata); // Hataları yazdırır
        }
        public void logla(string mesaj)
        {
            File.AppendAllText(yol, $"[{DateTime.Now}]{mesaj}\n"); // Hatalar dosyaya yazılır.
        }
    }
}
