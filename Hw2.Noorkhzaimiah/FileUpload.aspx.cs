using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace Hw2.Noorkhzaimiah
{
    public partial class FileUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string folderPath = Server.MapPath("~/Files/");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            FileUpload1.SaveAs(folderPath + Path.GetFileName(FileUpload1.FileName));
            Image1.ImageUrl = "~/Files/" + Path.GetFileName(FileUpload1.FileName);


       

    }
    }
}