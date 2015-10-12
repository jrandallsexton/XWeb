using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XWeb.Core.Enumerations;

namespace XWeb.Core
{
    public class XWeb
    {
        /// <summary>
        /// Must be unique; no spaces.  Will be in the URL
        /// </summary>
        public string Name { get; set; }
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public EWebType Type { get; set; }
        public string Path { get; set; }
        public string PathCss { get; set; }
        public string PathJs { get; set; }
        public List<string> FilesCss { get; set; }
        public List<string> FilesJs { get; set; }
        public EOwnerType OwnerType { get; set; }
        public EBizType BizType { get; set; }

        public XWeb()
        {
            this.FilesCss = new List<string>();
            this.FilesJs = new List<string>();
        }
    }
}