using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class Calculator

    {
        private Mystack<Operand> stack;
        private CalculatorGui calistir;

        public Calculator()
        {
            stack = new Mystack<Operand>();
            calistir = new CalculatorGui();
        }
        public void Calculator_Main()
        {
            string input = calistir.Inputal(); // kullanıcı hesaplamak istediği değerleri girdi.
            {
                foreach (string gezici in input.Split(' ')) // her boşluk arasını bir string e çevirdi
                {
                    if (double.TryParse(gezici, out double number))
                    {
                        stack.Push(new Operand(number)); // string ler içinden double a dönüştürülenler stack e eklendi.
                    }
                    else if (gezici == "+")
                    {
                        Operator toplayici = new Topla();
                        toplayici.hesapla(stack);// + operatörü girildiyse topla sınıfında gönderildi.
                    }
                    else if (gezici == "-")
                    {
                        Operator cikarici = new Cikar();
                        cikarici.hesapla(stack); // - operatörü girildiyse topla sınıfında gönderildi.
                    }
                    else if (gezici == "*")
                    {
                        Operator carpici = new Carp();
                        carpici.hesapla(stack); // * operatörü girildiyse topla sınıfında gönderildi.
                    }
                    else if (gezici == "/")
                    {
                        Operator bolucu = new Bol();
                        bolucu.hesapla(stack); // / operatörü girildiyse topla sınıfında gönderildi.
                    }
                    else
                        throw new Exception("Tanımsız Operatör"); // hesaplanacak operatörler dışında bir şey girildiyse throw fırlatır.
                }
                if (stack.Count == 1)
                {
                    calistir.sonucyaz(stack.Peek().sayi); // stack te  1 eleman kaldığında sonucu yazdırır.
                }
                else if (stack.Count > 1)
                {
                    throw new Exception("Sayıyı fazla girdiniz."); // stack te 1 den fazla eleman kaldıyssa throw fırlatır.
                }
                else
                {
                    throw new Exception("Sonuç elde edilemedi");
                }
            }

        }
    }
}
