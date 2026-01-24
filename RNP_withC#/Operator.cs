using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public abstract class Operator
    {
        public abstract void hesapla(Mystack<Operand> stack); // abstract class ve method içi boş olarak yazılır.
    }
}
