﻿using System.Web;
using System.Web.Mvc;

namespace Prova_WebSistema_Ex4
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
