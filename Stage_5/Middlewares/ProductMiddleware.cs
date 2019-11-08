using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using System.Globalization;
using Microsoft.AspNetCore.Builder;

namespace Middlewares
{
    public class ProductMiddleware
    {
        private readonly RequestDelegate _next;

        public ProductMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            List<string> t = context.Request.Path.Value.Split('/').Skip(1).ToList();
            await context.Response.WriteAsync((Convert.ToInt32(t[0]) * Convert.ToInt32(t[1])).ToString());
            await _next(context);
        }
    }
    public static class ProductMiddlewareExtensions
    {
        public static IApplicationBuilder UseProductMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ProductMiddleware>();
        }
    }
}
