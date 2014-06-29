using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTable.HelperClasses
{
    static public class clsFormPreperation
    {
        /*
         * Set up the form to suit our needs
         * Sets up the MDI Parent and changes the borders, etc in case they have been set by accident
        */
        public static void SetUpForm(Form theForm)
        {
            theForm.ControlBox = false;
            theForm.AutoSize = true;
            theForm.AutoScroll = true;
            theForm.AutoSize = true;
            theForm.FormBorderStyle = FormBorderStyle.None;
            theForm.MaximizeBox = false;
            theForm.WindowState = FormWindowState.Maximized;
            //theForm.BackColor = System.Drawing.Color.SkyBlue;
        }
    }
}
