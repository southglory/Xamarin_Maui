using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy2
{
    class Ch_26 : FirstStudy.Interface_Ch_26
    {
        int level;
        string name;

        public Ch_26() { level = 0; name = "주인공1"; }

        public string InterFaceStr()
        {
            name = "주인공2";
            return name + " 입니다.";
        }
        public int InterFaceInt(int x)
        {
            level += x;
            return level;

        }
        public void InterFaceVoid()
        {
            Console.WriteLine("이름:{0} 레벨:{1}",name,level);
        }

        public void msg(string str, int x)
        {
            Console.WriteLine("이름:{0} 레벨:{1}", str, x);
        }
    }
}
