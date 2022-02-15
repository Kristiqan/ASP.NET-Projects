
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AppFlowSkeleton.Middlewares
{
    public class EvenMinuteCheckerMiddleware
    {
        private readonly RequestDelegate _next;

        public EvenMinuteCheckerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
                var minute =DateTime.Now.Minute;
                if(minute % 2 == 0)
               {
                await context.Response.WriteAsync("Hello, World!");
                return;
               }
                await _next(context);
        }
    }
}
