using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms.Architecture.Demo.Forms.Extensions
{
    public static class ControlsExtensions
    {
        public static double ToDouble(this TextBox textBox) 
            => Convert.ToDouble(textBox.Text);
    }
}
