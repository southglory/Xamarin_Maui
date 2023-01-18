using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    class Ch_19
    {
        string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        int age1;
        public int Age1
        {
            get
            {
                return age1;
            }
            set
            {
                age1 = value + 10;
            }
        }

        int age2;
        public int Age2
        {
            get
            {
                return age2 + 10;
            }
            set
            {
                age2 = value;
            }
        }
        public string Address { get; set; }
    }
}
