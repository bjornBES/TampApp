using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TampApp
{
    public class clock
    {
        public float F_timer;
        public static Form1 Form;
        public static void start()
        {
            Form = new Form1();
        }
        public static float GetTimer_F()
        {
            return Form.UpdateTimer.Interval;
        }
        public static void Set(int time)
        {
            Form.UpdateTimer.Stop();
            Form.UpdateTimer.Interval = time;
            Form.UpdateTimer.Start();
        }
    }
}
