using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{

    public class Cikar : Operator
    {

        public override void hesapla(Mystack<Operand> stack)
        {
            if (stack.Count < 2) // stack boyutu ikiden küçükse throw fırlatıldı
            {
                throw new InvalidOperationException("Çıkarma yapmak için yeterli sayı yok");
            }
            Operand sayi1 = stack.Pop();
            Operand sayi2 = stack.Pop(); // operand nesnesine ait sayi1 , sayi2 belirlendi; bunların içlerindeki değerlere işlem yapıldı
            double sonuc = (sayi2.sayi - sayi1.sayi);
            stack.Push(new Operand(sonuc));
        }
    }
}
