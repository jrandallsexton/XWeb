using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XWeb.Core.Enumerations;

namespace XWeb.Core
{
    public class XWebGen
    {

        public string Generate(XWeb xWeb)
        {
            switch (xWeb.Type)
            {
                case EWebType.Bootstrap:
                case EWebType.Bootstrap_Jumbotron:
                    return this.HtmlJumbotron(xWeb).ToString();
                default:
                    return this.Html(xWeb).ToString();
            }
        }

        private StringBuilder Html(XWeb web)
        {
            var sb = new StringBuilder();
            return sb;
        }

        private StringBuilder HtmlJumbotron(XWeb web)
        {
            var sb = new StringBuilder();
            sb.AppendLine("<html lang='en'>");
            sb.AppendLine("<head>");
            sb.AppendLine("<meta charset='utf-8'>");
            sb.AppendLine("<meta http-equiv='X-UA-Compatibl' content='IE=edge'>");
            sb.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1'>");
            sb.AppendLine("<title>" + web.Title + "</title>");
            sb.AppendLine("<link href='css/bootstrap.min.css' rel='stylesheet'>");
            sb.AppendLine("<link href='css/jumbotron.css' rel='stylesheet'>");
            sb.AppendLine("</head>");
            sb.AppendLine("<body>");
            sb.AppendLine("<nav class=\"navbar navbar-inverse navbar-fixed-top\">");
            sb.AppendLine("<div class=\"container\">");
            sb.AppendLine("<div class=\"navbar-header\">");
            sb.AppendLine("<button type=\"button\" class=\"navbar-toggle collapsed\" data-toggle=\"collapse\" data-target=\"#navbar\" aria-expanded=\"false\" aria-controls=\"navbar\">");
            sb.AppendLine("<span class=\"sr-only\">Toggle navigation</span>");
            sb.AppendLine("<span class=\"icon-bar\"></span>");
            sb.AppendLine("<span class=\"icon-bar\"></span>");
            sb.AppendLine("<span class=\"icon-bar\"></span>");
            sb.AppendLine("</button>");
            sb.AppendLine("<a class=\"navbar-brand\" href=\"#\">" + web.Name + "</a>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div id=\"navbar\" class=\"navbar-collapse collapse\">");
            sb.AppendLine("<form class=\"navbar-form navbar-right\">");
            sb.AppendLine("<div class=\"form-group\">");
            sb.AppendLine("<input type=\"text\" placeholder=\"Email\" class=\"form-control\">");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"form-group\">");
            sb.AppendLine("<input type=\"password\" placeholder=\"Password\" class=\"form-control\">");
            sb.AppendLine("</div>");
            sb.AppendLine("<button type=\"submit\" class=\"btn btn-success\">Sign in</button>");
            sb.AppendLine("</form>");
            sb.AppendLine("</div><!--/.navbar-collapse -->");
            sb.AppendLine("</div>");
            sb.AppendLine("</nav>");
            sb.AppendLine("<!-- Main jumbotron for a primary marketing message or call to action -->");
            sb.AppendLine("<div class=\"jumbotron\">");
            sb.AppendLine("<div class=\"container\">");
            sb.AppendLine("<h1>Hello, " + web.Name + "</h1>");
            sb.AppendLine("<p>This is a template for a simple marketing or informational website. It includes a large callout called a jumbotron and three supporting pieces of content. Use it as a starting point to create something more unique.</p>");
            sb.AppendLine("<p><a class=\"btn btn-primary btn-lg\" href=\"#\" role=\"button\">Learn more »</a></p>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"container\">");
            sb.AppendLine("<!-- Example row of columns -->");
            sb.AppendLine("<div class=\"row\">");
            sb.AppendLine("<div class=\"col-md-4\">");
            sb.AppendLine("<h2>About 2</h2>");
            sb.AppendLine("<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>");
            sb.AppendLine("<p><a class=\"btn btn-default\" href=\"#\" role=\"button\">View details »</a></p>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-md-4\">");
            sb.AppendLine("<h2>Clients 2</h2>");
            sb.AppendLine("<p>Donec id elit non mi porta gravida at eget metus. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus. Etiam porta sem malesuada magna mollis euismod. Donec sed odio dui. </p>");
            sb.AppendLine("<p><a class=\"btn btn-default\" href=\"#\" role=\"button\">View details »</a></p>");
            sb.AppendLine("</div>");
            sb.AppendLine("<div class=\"col-md-4\">");
            sb.AppendLine("<h2>Contact 2</h2>");
            sb.AppendLine("<p>Donec sed odio dui. Cras justo odio, dapibus ac facilisis in, egestas eget quam. Vestibulum id ligula porta felis euismod semper. Fusce dapibus, tellus ac cursus commodo, tortor mauris condimentum nibh, ut fermentum massa justo sit amet risus.</p>");
            sb.AppendLine("<p><a class=\"btn btn-default\" href=\"#\" role=\"button\">View details »</a></p>");
            sb.AppendLine("</div>");
            sb.AppendLine("</div>");
            sb.AppendLine("<hr>");
            sb.AppendLine("<footer>");
            sb.AppendLine("<p>© Company 2014</p>");
            sb.AppendLine("</footer>");
            sb.AppendLine("</div>");
            sb.AppendLine("</body>");
            sb.AppendLine("</html>");
            return sb;
        }

    }
}