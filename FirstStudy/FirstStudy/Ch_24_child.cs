using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    class Ch_24_child : Ch_24_Parent
    {
        public override void message()
        {
            string str1 = "Ch_24_Child";
            string str2 = " 추상클래스를 상속 받았습니다";
            Console.WriteLine(str1 + str2);
        }
        public override void message(string name)
        {
    
            Console.WriteLine(name);
        }
    }
}
