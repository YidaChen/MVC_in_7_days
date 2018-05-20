﻿using System.Web;
using System.Web.Mvc;
using WebApplication1.Filters;

namespace WebApplication1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //filters.Add(new HandleErrorAttribute());//ExceptionFilter
            filters.Add(new EmployeeExceptionFilter());
            //filters.Add(new AuthorizeAttribute());//[AllowAnonymous]
        }
    }
}
