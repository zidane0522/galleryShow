using Dapper;
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
            this.FormClosing += GalleryList_FormClosing;
            GetGallery(); 
        }

        private void GalleryList_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.listView1.Items.Clear();
            this.listView1.Dispose();
            this.imageList3.Dispose();
        }

        List<string> imgList = new List<string>();

        private void GetGallery()
        {
            try
            {
                int picId = 0;
                using (var db = DbEntry.GetSqlCon("galleryant"))
                {
                    var res = db.Query("select picId from viewhistory order by id desc limit 0,1");
                    if (res.Count() > 0)
                    {
                        picId = res.First();
                    }
                    var imglist = db.Query("select glrypath, picName,pic.id from pic join glry on pic.glryId = glry.glryId where pic.id > @id limit 0, @limit", new
                    {
                        id = picId,
                        limit = Common.c
                    });
                    if (imglist.Count() == 0)
                    {
                        MessageBox.Show("已经到最后一张图片");
                    }
                    else
                    {
                        this.imageList3.ImageSize = new Size { Height = 150, Width = 150 };
                        foreach (var item in imglist)
                        {
                            imgList.Add(item.glrypath +"\\"+ item.picName);
                            this.imageList3.Images.Add(Image.FromFile(item.glrypath +"\\"+ item.picName));
                        }
                        //this.listView1.LargeImageList = imageList3;
                        listView1.Items.Clear();
                        for (int i=0; i<Common.c; i++)
                        {
                            listView1.Items.Add(new ListViewItem((picId+i+1).ToString(),i));
                        }

                    }
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            

        }

        private void GalleryList_FormClosed(object sender, FormClosedEventArgs e)
        {
            Common.f.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_ItemCheck(object sender, ItemCheckEventArgs e)
        {

        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {

        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {

        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
