using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    class Ch_22_1
    {
        string name = "Ch_22_1";
        virtual public void message()
        {
            name = "aaaa" + "bbb";
            Console.WriteLine(name);
        }
    }
}
