﻿using SUS.HTTP;
using SUS.MVCFramework;
using System;

namespace MyFirstMvcApp.Controllers
{
    public class StaticFilesController: Controller
    {
        public HttpResponse Favicon(HttpRequest request)
        {
            return this.File("wwwroot/favicon_monitor.ico", "image/vnd.microsoft.icon");            
        }

        internal HttpResponse BootstrapCss(HttpRequest request)
        {
            return this.File("wwwroot/css/bootstrap.min.css", "text/css");            
        }

        internal HttpResponse CustomCss(HttpRequest request)
        {
            return this.File("wwwroot/css/custom.css", "text/css");
        }

        internal HttpResponse CustomJs(HttpRequest request)
        {
            return this.File("wwwroot/js/bootstrap.bundle.min.js", "text/javascript");
        }

        internal HttpResponse BootstrapJs(HttpRequest request)
        {
            return this.File("wwwroot/js/custom.js", "text/javascript");
            throw new NotImplementedException();
        }
    }
}
