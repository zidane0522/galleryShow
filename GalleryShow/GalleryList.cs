using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GalleryShow
{
    public partial class GalleryList : Form
    {
        public GalleryList()
        {
            InitializeComponent();
            this.FormClosed += GalleryList_FormClosed;
        }

        private void GalleryList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.f.Close();
        }
    }
}
