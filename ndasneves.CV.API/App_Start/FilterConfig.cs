﻿using System.Web;
using System.Web.Mvc;

namespace ndasneves.CV.API
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}