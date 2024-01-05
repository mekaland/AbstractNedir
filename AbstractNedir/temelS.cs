using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    public abstract class temelS
    {
        // abstract eklediğmizde temelS sınıf aslında benim şablon olarak kullanıcağım bir sınıf
        // ben bu sınıfı bir kural kütüphanesi gibi görmek istiyorum bundan kalıtılan sınıflar burda yazan
        // kuralla uysun istiyorum. abstract ve interface olduğu zaman örneklenemez
        public DateTime kayitTarih { get; set; }
        public DateTime guncellemeTarih { get; set; }

        public temelS()
        {
            kayitTarih = DateTime.Now;
            guncellemeTarih = DateTime.Now;
        }
        public void test()
        {
            Console.WriteLine(" temel sınıf => test");
        }
        public abstract void testAbstract(); 
    }
}
