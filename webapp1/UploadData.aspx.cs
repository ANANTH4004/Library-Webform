using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace webapp1
{
    public partial class UploadData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           string path = @"D:\c#\webapp1\webapp1\Files\";
            FileUpload1.SaveAs(path + FileUpload1.PostedFile.FileName);
            //if (!string.IsNullOrEmpty(FileUpload1.FileName))
            //{
            //    if (FileUpload1.HasFiles)
            //    {

            //        foreach (HttpPostedFile item in FileUpload1.PostedFiles)
            //        {
            //            //string fname = item.FileName;
            //            //FileInfo finfo = new FileInfo(fname);
            //            //string ext = finfo.Extension;

            //            //if (ext == ".pdf")
            //            //{
            //                string s = item.FileName;
            //                //string path = @"D:\Sulakshana\MphasisAugust\WebAppServerControlsDemo\WebAppServerControlsDemo\UploadedFiles\";

            //                FileUpload1.SaveAs(Server.MapPath("Files") + "\\" + s);
            //            //}
            //            //else
            //            //{
            //            //    Response.Write("U can only upload pdf");
            //            //}
            //        }
            //    }
            // }
        }
    }
}