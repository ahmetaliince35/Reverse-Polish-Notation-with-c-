using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class Topla : Operator
    {

        public override void hesapla(Mystack<Operand> stack)
        {
            if (stack.Count < 2)
            {
                throw new InvalidOperationException("Toplama yapmak için yeterli sayı yok");
            }
            Operand sayi1 = stack.Pop();
            Operand sayi2 = stack.Pop();
            double sonuc = (sayi1.sayi + sayi2.sayi);
            stack.Push(new Operand(sonuc));
        }
    }
}
