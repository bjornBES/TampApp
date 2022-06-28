using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TampApp
{
    public class Temp
    {
        /// <summary>
        /// gets the tenp form the arduino
        /// </summary>
        /// <returns>form the arduinos temp form a file or stuff</returns>
        public float GetTemp()
        {
            return 20f;
        }
        /// <summary>
        /// sets the temp form the arduino
        /// </summary>
        /// <param name="temp">the temp that the arduino can set to the pump</param>
        public void SetTemp(object temp)
        {
            Form1 form1 = clock.Form;
            form1.TempText.Text = temp.ToString();
        }
    }
}
