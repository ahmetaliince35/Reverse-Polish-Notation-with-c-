using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class Bol : Operator
    {

        public override void hesapla(Mystack<Operand> stack)
        {
            if (stack.Count < 2)
            {
                throw new InvalidOperationException("Bölme yapmak için yeterli sayı yok");
            }
            Operand sayi1 = stack.Pop();
            Operand sayi2 = stack.Pop();
            if (sayi1.sayi == 0)
            {
                throw new DivideByZeroException("Sıfıra bölme işlemi yapılamaz.");
            }
            double sonuc = (sayi2.sayi / sayi1.sayi);
            stack.Push(new Operand(sonuc));
        }
    }
}
