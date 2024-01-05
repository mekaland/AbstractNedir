using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractNedir
{
    public class Program
    {
        static void Main(string[] args)
        {
            // abstract classların ilk çağrımda örneklenemediğini ama kalıtımsal açıdan baktığımızda
            // kalıtan nesnenin abstract classı örnekleyebildiğini gördük
            // implement etmek : classın içerisinde o metot imzasını kullanmak demek
            // ne zaman kullanırız?
            // interface ve abstract şablonu oluştur insanlara dağıt ve bunu kullanmak zorunda kalsınlar
            // diğer developerım metot imzasıyla uğraşmaz classı alır implemente eder içinin doludurur geçer
            // kurumsal projelerde kulllanılır. 
            // sealed kalıtılamasın demek
            // virtual özelliği bodysinin olması ve override edilip kullanılabilmesi
            Musteri M1 = new Musteri();
            M1.test();
            M1.testAbstract();
            Console.ReadLine();
        }
    }
}
