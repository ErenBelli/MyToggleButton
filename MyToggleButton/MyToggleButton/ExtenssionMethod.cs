using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MyToggleButton
{
    /// <summary>
    /// İnternal Static class biçiminde bir uzantı metodu oluşturarak html'den renk kodu çekebilmeyi sağladık.
    /// </summary>
    internal static class ExtenssionMethod
    {

        public static Color FromHex(this string hex) =>
            ColorTranslator.FromHtml(hex);
    }
}
