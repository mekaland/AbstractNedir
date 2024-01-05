using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    public class Musteri: temelS
    {
        public int musteriID { get; set; }
        public Musteri()
        {
            musteriID = 1;
        }

        public override void testAbstract()
        {
            Console.WriteLine("müşteri sınıfının içerisindeki testabstract metodudur");
        }
    }
}
