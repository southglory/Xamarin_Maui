using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    abstract class Ch_24_Parent
    {
        public void parentMessage()
        {
            Console.WriteLine("부모클래스 메소드 입니다.");
        }
        abstract public void message();
        abstract public void message(string name);

    }
}
