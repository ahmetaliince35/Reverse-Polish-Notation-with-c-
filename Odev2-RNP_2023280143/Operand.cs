using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2_RNP_2023280143
{
    public class Operand // stack lerin işlem yapıldığı class belirlenir, stack lere buradaki nesneler eklenir.
    {
        public double sayi { get; }
        public Operand(double sayi)
        {
            this.sayi = sayi;
        }
    }
}
