using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    class Ch_18
    {

        public void time1()
        {
            Console.WriteLine("2021-01-01 오후 01:00:00");
            //DateTime.Now.ToString();
        }
        public static void time2()
        {
            Console.WriteLine("2022-01-01 오후 02:00:00");
            //DateTime.Now.ToString();
        }

        public static void time3(ref Ch_17 ch_17)
        {
            ch_17.name = "태권브이";
            
            Console.WriteLine(ch_17.name + " 고향: " + Ch_17.homeTown);
        }

        public static void time4(out Ch_17 ch_17)
        {
            ch_17 = new Ch_17();
            ch_17.name = "상어";
            ch_17.age = 5;
        }
    }
}
