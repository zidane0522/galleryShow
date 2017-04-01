using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryShow
{
    public class listviewItemNew: ListViewItem
    {
        public listviewItemNew() : base()
        {

        }
        public listviewItemNew(string str) : base(str)
        {

        }
        public event EventHandler Click;
    }
}
