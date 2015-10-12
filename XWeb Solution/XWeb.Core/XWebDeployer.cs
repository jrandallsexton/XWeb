using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.Administration;

namespace XWeb.Core
{
    public class XWebDeployer
    {
        public bool CreateSite(XWeb web)
        {
            if (IsWebsiteExists(web.Name))
                return true;

            var iisManager = new ServerManager();
            iisManager.Sites.Add(web.Name, "http", "*:8080:", web.Path);
            iisManager.CommitChanges();
            return true;
        }

        public bool Deploy(XWeb web, string html)
        {
            // does the output dir exist?
            if (Directory.Exists(web.Path))
                // yes?  delete all content
                Directory.Delete(web.Path, true);

            // does the CSS dir exist?
            if (Directory.Exists(web.PathCss))
                // yes?  delete all content
                Directory.Delete(web.PathCss, true);

            // does the JS dir exist?
            if (Directory.Exists(web.PathCss))
                // yes?  delete all content
                Directory.Delete(web.PathJs, true);

            Directory.CreateDirectory(web.Path);
            Directory.CreateDirectory(web.PathCss);
            Directory.CreateDirectory(web.PathJs);

            // write the HTML content
            using (var file = new StreamWriter(web.Path + "\\Index.html"))
            {
                file.WriteLine(html);
            }

            // copy all CSS to target
            web.FilesCss.ForEach(x => File.Copy(@"C:\Projects\XWeb\XWeb Solution\XWeb.Core\Frameworks\Bootstrap\3.3.5\css\" + x, web.PathCss + x, true));

            // copy all JS to target
            web.FilesJs.ForEach(x => File.Copy(@"C:\Projects\XWeb\XWeb Solution\XWeb.Core\Frameworks\Bootstrap\3.3.5\js\" + x, web.PathJs + x, true));

            return true;
        }

        public bool IsWebsiteExists(string strWebsitename)
        {
            Boolean flagset = false;
            SiteCollection sitecollection = new ServerManager().Sites;
            foreach (Site site in sitecollection)
            {
                if (site.Name == strWebsitename.ToString())
                {
                    flagset = true;
                    break;
                }
                else
                {
                    flagset = false;
                }
            }
            return flagset;
        }

    }
 
}