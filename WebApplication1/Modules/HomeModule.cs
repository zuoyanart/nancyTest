using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;

namespace WebApplication1.Modules
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = p =>
            {
                return View["Home"];
            };
        
            Get["/2"] = p1 =>
            {
                return View["2"];
            };
        }
    }
}
