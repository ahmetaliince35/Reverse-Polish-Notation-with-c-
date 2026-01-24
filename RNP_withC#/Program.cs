using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool devamkarari = true; // while döngüsü için belirlenir. 
            CalculatorGui log = new CalculatorGui(); // CalculatorGui sınıfına ait nesne belirlenir.
            while (devamkarari)
            {
                try
                {
                    Calculator calculator = new Calculator();
                    calculator.Calculator_Main(); //  Calculator sınıfına ait nesne oluşturulur, o sınıfa ait Calculator_Main() methodu çalıştırılır.
                    Console.WriteLine("Lütfen devam etmek istiyorsanız 1' i, programı kapatmak istiyorsanız 0' ı tuşlayınız. ");
                    string giris = Console.ReadLine(); // programın devam edip sonlanacağı zaman kullanıcıya bırakılır
                    if (!int.TryParse(giris, out int secim))
                    {
                        throw new FormatException("Sayı girilmedi."); // Kullanıcı ayı girmezse throw fırlatır
                    }
                    if (secim == 0) devamkarari = false; // 0 durumunda program sonlanır
                    else if (secim != 1) Console.WriteLine("Geçersiz bir değer girildi. Program devam ediyor.");
                }
                catch (FormatException fe)
                {
                    log.hatayazdir(fe.Message);
                    log.logla(fe.Message);
                    // hatalar önce ekrana sonra dosyaya yazdırılır.
                }
                catch (Exception ex)
                {
                    log.hatayazdir(ex.Message);
                    log.logla(ex.Message);
                    // hatalar önce ekrana sonra dosyaya yazdırılır.
                }

            }
            
        }
    }
}
