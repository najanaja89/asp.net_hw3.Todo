﻿using System.Web;
using System.Web.Mvc;

namespace asp.net_hw3.Todo
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
