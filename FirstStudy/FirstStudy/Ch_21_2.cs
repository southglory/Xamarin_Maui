using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    class Ch_21_2 : Ch_21_1
    {
        public void methd()
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            name = "뽀로로";
            age = 10;
            Console.WriteLine(name);
            Console.WriteLine(age);
        }
    }
}
