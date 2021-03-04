using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labwork_3_1
{
    class Model
    {
        int h, m, s;

        public string Time()
        {
            s++;
            if (s == 60)
            {
                s = 0;
                m += 1;
            }
            if (m ==60)
            {
                m = 0;
                h += 1;
            }
            string time = string.Format("{0}:{1}:{2}", h.ToString().PadLeft(2,'0'),m.ToString().PadLeft(2, '0'), s.ToString().PadLeft(2, '0'));
            return time;
        }

        public void ValuesEqualZero()
        {
            h = 0;
            m = 0;
            s = 0;
        }
    }
}
