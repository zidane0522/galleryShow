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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Common.f = this;
        }

        private void signOutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SignInBtn_Click(object sender, EventArgs e)
        {

                this.Hide();
                GalleryList gl = new GalleryShow.GalleryList();
                gl.Show();
                
        }
    }
}
