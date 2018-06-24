﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Routing;
using System.Web.Security;
using System.Web.SessionState;

namespace _01_Routing
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            // конфигурация маршрута для WebAPI 
            GlobalConfiguration.Configuration.Routes.MapHttpRoute("MyRoute", "{controller}");
        }
    }
}