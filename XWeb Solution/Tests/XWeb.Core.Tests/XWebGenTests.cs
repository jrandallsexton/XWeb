using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using XWeb.Core.Enumerations;

namespace XWeb.Core.Tests
{

    [TestFixture]
    public class XWebGenTests
    {

        [Test]
        public void Foo()
        {
            // take the XWeb definition
            var web = new XWeb {
                Name = "Brandi",
                Title = "My Awesome Company",
                Subtitle = "Finally Here",
                OwnerType = EOwnerType.Corporation,
                BizType = EBizType.Bar,
                Type = EWebType.Bootstrap_Jumbotron,
                Path = @"C:\Projects\XWeb\Output\Awesome",
                PathCss = @"C:\Projects\XWeb\Output\Awesome\css\",
                PathJs = @"C:\Projects\XWeb\Output\Awesome\scripts\",
                FilesCss = new List<string> { "bootstrap.min.css", "jumbotron.css" },
                FilesJs = new List<string> { "bootstrap.min.js" }
            };

            // create an IIS location for it
            Assert.That(new XWebDeployer().CreateSite(web));

            // generate it
            var html = new XWebGen().Generate(web);

            // deploy it
            Assert.That(new XWebDeployer().Deploy(web, html));

            // launch it
            Process.Start(web.Path + "\\Index.html");
        }

        /// <summary>
        /// http://startbootstrap.com/template-overviews/creative/
        /// </summary>
        [Test]
        public void Bootstrap_Creative()
        {
            // take the XWeb definition
            var web = new XWeb
            {
                Name = "Brandi",
                Title = "My Awesome Company",
                Subtitle = "Finally Here",
                OwnerType = EOwnerType.Corporation,
                BizType = EBizType.Bar,
                Type = EWebType.Botstrap_Creative,
                Path = @"C:\Projects\XWeb\Output\Awesome",
                PathCss = @"C:\Projects\XWeb\Output\Awesome\css\",
                PathJs = @"C:\Projects\XWeb\Output\Awesome\scripts\",
                FilesCss = new List<string> { "bootstrap.min.css", "jumbotron.css" },
                FilesJs = new List<string> { "bootstrap.min.js" }
            };

            // create an IIS location for it
            Assert.That(new XWebDeployer().CreateSite(web));

            // generate it
            var html = new XWebGen().Generate(web);

            // deploy it
            Assert.That(new XWebDeployer().Deploy(web, html));

            // launch it
            Process.Start(web.Path + "\\Index.html");
        }

    }

}