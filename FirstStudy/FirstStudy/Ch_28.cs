using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstStudy
{
    delegate void EventHandler(string msg);
    class Ch_28
    {
        public event EventHandler EV;
        public void eventTest(string eventMsg)
        {
            EV("이벤트 메세지: " + eventMsg);
        }
    }
}
