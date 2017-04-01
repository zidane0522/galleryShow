using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryShow
{
    public static class Common
    {
        public static Form f;

        public static void closeForm()
        {
            f.Close();
        }

        public const int c = 40;
    }
}
