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
            var route = context.GetRouteData();
            var res1 = route.Values.TryGetValue("id1", out var routeid1);
            var res2 = route.Values.TryGetValue("id2", out var routeid2);
            var res = Convert.ToInt32(res1) * Convert.ToInt32(res2);
            //var res = Convert.ToInt32(context.GetRouteValue("id1")) * Convert.ToInt32(context.GetRouteValue("id2"));
            await context.Response.WriteAsync(res1.ToString());
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
