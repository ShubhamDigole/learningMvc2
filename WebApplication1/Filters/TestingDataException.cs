using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Filters
{
    public class TestingDataException :ExceptionFilterAttribute,IExceptionFilter
    {
       
    public void OnException(ExceptionContext context)
        {
            context.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            context.ExceptionHandled = true;
        }
    }
}
